using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Media;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Managers;
using LlamaLibrary;

namespace SalesTracker;

public class SalesPlugin : TemplatePlugin
{
    private readonly Regex _mbRegex = new Regex(@"The (\d{0,3}).+sold for ([\d,]+) gil", RegexOptions.Compiled);
    private int _gil;
    private int _saleCount;

    public override string PluginName => "Market Board Sales Tracker";

    public override string Author => "Sinbeard";

    //protected override Color LogColor =>
    protected override Type SettingsForm => typeof(SettingsForm);
    protected override bool RequiresPulseThread => true;
    protected override PulseFlags PulseFlags => PulseFlags.Chat;
    public static Version CurrentVersion => new Version(2, 2, 0);
    public override Version Version => CurrentVersion;
    public override bool WantButton => true;
    public override string ButtonText => "Log Report";

    public override void OnEnabled()
    {
        base.OnEnabled();
        GamelogManager.MessageRecevied += GamelogManager_MessageRecevied;
    }

    public override void OnDisabled()
    {
        base.OnDisabled();
        GamelogManager.MessageRecevied -= GamelogManager_MessageRecevied;
    }

    private void GamelogManager_MessageRecevied(object sender, ChatEventArgs e)
    {
        switch (e.ChatLogEntry.MessageType)
        {
            case MessageType.RetainerSaleReports:
                //Log.Information("Retainer sale report.");
                var match = _mbRegex.Match(e.ChatLogEntry.Contents);
                if (match.Success)
                {
                    Log.Information("Market Board sale made.");
                    _saleCount++;
                    var sale = new Sale();
                    var groups = match.Groups;

                    sale.SalesDateTime = e.ChatLogEntry.TimeStamp.ToLocalTime();
                    sale.AmountSold = groups[1].ToString() != "" ? int.Parse(groups[1].ToString()) : 1;

                    var item = GetItemFromBytes(e.ChatLogEntry.Bytes);
                    if (item != null)
                    {
                        sale.ItemSold = item.CurrentLocaleName;
                        sale.ItemId = item.Id;
                        sale.SoldPrice = int.Parse(groups[2].ToString().Replace(",", ""));
                        _gil += sale.SoldPrice;
                        sale.ByteHashCode = ComputeHash(e.ChatLogEntry.Bytes);

                        if (SalesSettings.Instance.Sales.Contains(sale))
                        {
                            Log.Information($"Sale already in list for {sale.ItemSold}");
                            return;
                        }

                        Log.Information($"{sale.AmountSold} x {sale.ItemSold} (Item ID: {sale.ItemId}) sold for {sale.SoldPrice:n0}");
                        Log.Information($"You have made {_saleCount} sales, and {_gil:n0} since starting the bot.");

                        SalesSettings.Instance.Sales.Add(sale);
                        SalesSettings.Instance.Save();
                        SalesTracker.SettingsForm.Instance?.UpdateSalesDgv();
                    }
                    else
                    {
                        var chatbytes = string.Join(" ", e.ChatLogEntry.Bytes.Select(i => $"{i:X2}"));
                        Logger.Verbose($"Chat Log Bytes: {chatbytes}");
                    }
                }

                break;
            case MessageType.Tell_Receive:
                Log.Information($"Tell received from {e.ChatLogEntry.SenderDisplayName}.");
                Log.Information($"Tell text: {e.ChatLogEntry.Contents}");
                break;
        }
    }

    private Item GetItemFromBytes(IReadOnlyList<byte> itemBytes)
    {
        var newBytes = new List<byte>();
        var HQ = false;
        for (var x = 0; x < itemBytes.Count(); x++)
        {
            switch (itemBytes[x])
            {
                case 2:
                    // special in-game replacements/wrappers
                    // 2 46 5 7 242 2 210 3
                    // 2 29 1 3
                    // remove them
                    if (itemBytes[x + 1] == 0x27 && itemBytes[x + 3] == 0x03)
                    {
                        var length = itemBytes[x + 2];
                        newBytes.AddRange(itemBytes.Skip(x + 5).Take(length - 5));
                    }

                    break;
            }
        }

        var result = "";
        foreach (var b in newBytes)
        {
            result += $"{b:X2}";
        }

        uint itemId;
        if (!uint.TryParse(result, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out itemId))
        {
            Log.Error($"Failed to parse item from bytes: {result}");
            return null;
        }

        if (itemId > 1000000)
        {
            itemId -= 1000000;
            HQ = true;
        }

        return DataManager.GetItem(itemId, HQ);
    }

    public static int ComputeHash(params byte[] data)
    {
        unchecked
        {
            const int p = 16777619;
            var hash = (int)2166136261;

            for (var i = 0; i < data.Length; i++)
            {
                hash = (hash ^ data[i]) * p;
            }

            hash += hash << 13;
            hash ^= hash >> 7;
            hash += hash << 3;
            hash ^= hash >> 17;
            hash += hash << 5;
            return hash;
        }
    }
}