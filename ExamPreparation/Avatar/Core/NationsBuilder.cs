﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> warHisoryRecord;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            {"Air", new Nation() },
            {"Fire", new Nation() },
            {"Earth", new Nation() },
            {"Water", new Nation() }
        };

        this.warHisoryRecord = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];

        Bender currentBender = this.GetBender(benderArgs);
        this.nations[benderType].AddBender(currentBender);
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];

        Monument currentMonument = this.GetMonument(monumentArgs);
        this.nations[monumentType].AddMonument(currentMonument);
    }
    public string GetStatus(string nationsType)
    {
        StringBuilder msg = new StringBuilder();
        msg.AppendLine($"{nationsType} Nation").Append(this.nations[nationsType]);

        return msg.ToString();
    }
    public void IssueWar(string nationsType)
    {
        var victoryPower = this.nations.Max(p => p.Value.GetTotalPower());
        foreach (var nation in nations.Values)
        {
            if (nation.GetTotalPower() != victoryPower)
            {
                nation.DeclareDefeat();
            }
        }

        this.warHisoryRecord.Add($"War {warHisoryRecord.Count() + 1} issued by {nationsType}");
    }
    public string GetWarsRecord()
    {
        return string.Join(Environment.NewLine, warHisoryRecord);
    }


    private Bender GetBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        var benderPower = int.Parse(benderArgs[2]);
        var benderSecondParam = double.Parse(benderArgs[3]);

        switch (benderType)
        {
            case "Air":
                return new AirBender(benderName, benderPower, benderSecondParam);
            case "Water":
                return new WaterBender(benderName, benderPower, benderSecondParam);
            case "Fire":
                return new FireBender(benderName, benderPower, benderSecondParam);
            case "Earth":
                return new EarthBender(benderName, benderPower, benderSecondParam);

            default:
                throw new ArgumentException();
        }
    }

    private Monument GetMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];
        var monumentName = monumentArgs[1];
        var monumentAffinity = int.Parse(monumentArgs[2]);

        switch (monumentType)
        {
            case "Air":
                return new AirMonument(monumentName, monumentAffinity);
            case "Water":
                return new WaterMonument(monumentName, monumentAffinity);
            case "Fire":
                return new FireMonument(monumentName, monumentAffinity);
            case "Earth":
                return new EarthMonument(monumentName, monumentAffinity);

            default:
                throw new ArgumentException();
        }
    }

    private void OutputWriter(string status)
    {
        Console.WriteLine(status);
    }
}
