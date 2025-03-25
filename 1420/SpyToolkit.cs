using System;
using System.Collections.Generic;
using System.Linq;
using DemoSolution;

public class SpyToolkit
{
    private readonly List<SpyGadget> gadgets = new List<SpyGadget>();

    public SpyToolkit() { }

    public void AddGadget(string name, string category, int powerLevel = 50, bool isActive = true)
    {
        SpyGadget spyGadget = new SpyGadget();
        spyGadget.Name = name;
        spyGadget.Category = category;
        spyGadget.PowerLevel = powerLevel;
        spyGadget.IsActive = isActive;

        if (gadgets.Any(s => s.Name == name))
        {
            Console.WriteLine($"{name} already exists.");
            return;
        }

        gadgets.Add(spyGadget);
        Console.WriteLine($"{name} added to toolkit.");
    }

    public List<SpyGadget> GetActiveGadgets(string category = null)
    {
        if (category != null)
        {
            List<SpyGadget> activeCategoryGadgets = gadgets.Where(s => s.IsActive == true).Where(s => s.Category == category).ToList();
            return activeCategoryGadgets;
        }

        List<SpyGadget> activeGadgets = gadgets.Where(s => s.IsActive == true).ToList();
        return activeGadgets;
    }

    public void DeactivateGadget(string name)
    {
        SpyGadget containsGadget = gadgets.Where(s => s.Name == name).FirstOrDefault();

        if (containsGadget != null)
        {
            containsGadget.IsActive = false;
        }

        Console.WriteLine(containsGadget != null ? $"{name} deactivated." : $"{name} not found.");
    }

    public static bool PowerCheck(List<SpyGadget> gadgets, int minPower)
    {
        if (gadgets.All(s => s.PowerLevel >= minPower))
        {
            return true;
        }
        else if (gadgets == null)
        {
            return true;
        }

        return false;
    }


    public void DebugMission(string missionName, int requiredPower)
    {
        var activeGadgets = GetActiveGadgets();

        bool missionReady = activeGadgets.Any() && PowerCheck(activeGadgets, requiredPower);

        string determineIfReady = missionReady ? $"Mission {missionName}: Ready." : $"Mission {missionName}: Insufficient power.";

        Console.WriteLine(determineIfReady);
    }
}