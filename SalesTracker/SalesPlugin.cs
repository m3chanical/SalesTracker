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
    public override string Author { get; } = "Sinbeard";
    public static Version CurrentVersion => new Version(3, 0, 0);
    public override Version Version { get; } = CurrentVersion;
    public override string PluginName { get; } = "Market Board Sales Tracker";
    public override bool WantButton => true;
    public override string ButtonText => "Sales Report";
    protected override Type SettingsForm => typeof(SettingsForm);
    protected override bool RequiresPulseThread => true;
    protected override PulseFlags PulseFlags => PulseFlags.Chat;
    
    private readonly Regex _mbRegex = new Regex(@"The (\d{0,3}).+sold for ([\d,]+) gil", RegexOptions.Compiled);
    private int _gil;
    private int _saleCount;
    
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
                    _saleCount++;
                    var sale = new Sale();
                    var groups = match.Groups;

                    sale.SalesDateTime = e.ChatLogEntry.TimeStamp.ToLocalTime();
                    sale.AmountSold = groups[1].ToString() != "" ? int.Parse(groups[1].ToString()) : 1;
                    var chatBytes = string.Join(" ", e.ChatLogEntry.Bytes.Select(i => $"{i:X2}"));
                    //Log.Information($"Chat Log Bytes: {chatBytes}");

                    var item = GetItemFromBytes(e.ChatLogEntry.Bytes);  
                    sale.ItemSold = item.CurrentLocaleName ?? "Unknown";
                    sale.ItemId = item?.Id ?? 0;
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

                break;
            /*case MessageType.Tell_Receive:
                Log.Information($"Tell received from {e.ChatLogEntry.SenderDisplayName}.");
                Log.Information($"Tell text: {e.ChatLogEntry.Contents}");
                break;*/
        }
    }

    private Item GetItemFromBytes(IReadOnlyList<byte> itemBytes)
    {
        var newBytes = new List<byte>();
        var HQ = false;
        uint itemId = 0;
        for (var x = 0; x < itemBytes.Count(); x++)
        {
            switch (itemBytes[x])
            {
                case 2:
                    // 0x02 -> StartByte
                    // 0x27 -> Interactable
                    // 0xXX -> Chunk Length
                    // 0x03 -> ItemLink
                    if (itemBytes[x + 1] == 0x27 && itemBytes[x + 3] == 0x03)
                    {
                        // get length of chunk so we can pull it out
                        var chunkLength = GetInteger(itemBytes, x + 2);
                        
                        // grab only the chunk we need (mostly for debug purposes)
                        var chunk = itemBytes.Skip(x + 1).Take((int)chunkLength).ToList();
                        itemId = GetInteger(chunk, 3); // skip to marker byte, start from there
                    }
                    break;
            }
        }
        // Could Add collectable/event: https://github.com/goatcorp/Dalamud/blob/47cf3170fe0e58a305fab8a7ba5c429f0871bf45/Dalamud/Game/Text/SeStringHandling/Payloads/ItemPayload.cs#L273
        if (itemId > 1000000)
        {
            itemId -= 1000000;
            HQ = true;
        }
        return DataManager.GetItem(itemId, HQ);
    }

    private static uint GetInteger(IReadOnlyList<byte> itemBytes, int chunkPos)
    {
        // https://github.com/goatcorp/Dalamud/blob/47cf3170fe0e58a305fab8a7ba5c429f0871bf45/Dalamud/Game/Text/SeStringHandling/Payload.cs#L364
        uint marker = itemBytes[chunkPos];
        if (marker < 0xD0)
            return marker - 1;

        marker = (marker + 1) & 0b1111;
        var ret = new byte[4];
        var k = 1; // past marker byte to item bytes
        for (var i = 3; i >= 0; i--)
        {
            try
            {
                // can't duplicate dalamud exactly since i'm not using binaryreader
                if((marker & (1 << i)) == 0)
                {
                    ret[i] = 0;
                }
                else
                {
                    ret[i] = itemBytes[chunkPos + k];
                    k++;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                // just in case
            }
        }
        return BitConverter.ToUInt32(ret, 0);
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