using DemoSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class SpyToolkit
{
    List<SpyGadget> SpyGadgets { get; set; } = new List<SpyGadget>();

    public SpyToolkit() { }

    public void AddGadget(string name, string category, int powerLevel = 50, bool isActive = true)
    {
        SpyGadget spyGadget = new SpyGadget();
        spyGadget.Name = name;
        spyGadget.Category = category;
        spyGadget.PowerLevel = powerLevel;
        spyGadget.IsActive = isActive;


        bool containsGadget = SpyGadgets.Any(s => s.Name == name);

        if (containsGadget)
        {
            Console.WriteLine($"{name} already exists.");
            return;
        }

        SpyGadgets.Add(spyGadget);
        Console.WriteLine($"{name} added to toolkit.");
    }

    public List<SpyGadget> GetActiveGadgets(string category = null)
    {
        if (category != null)
        {
            List<SpyGadget> activeCategoryGadgets = SpyGadgets.Where(s => s.IsActive == true).Where(s => s.Category == category).ToList();
            return activeCategoryGadgets;
        }

        List<SpyGadget> activeGadgets = SpyGadgets.Where(s => s.IsActive == true).ToList();
        return activeGadgets;
    }

    public void DeactivateGadget(string name)
    {
        SpyGadget containsGadget = SpyGadgets.Where(s => s.Name == name).FirstOrDefault();

        if (containsGadget != null)
        {
            containsGadget.IsActive = false;
        }

        Console.WriteLine(containsGadget != null ? $"{name} deactivated." : $"{name} not found.");
    }

    public static bool PowerCheck(List<SpyGadget> gadgets, int minPower)
    {
        if (gadgets.Where(s => s.PowerLevel >= minPower).Count() == gadgets.Count())
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
        List<SpyGadget> activeGadgets = GetActiveGadgets();
        if (activeGadgets.Count() == 0)
        {
            Console.WriteLine($"Mission {missionName}: No active gadgets available.");
            return;
        }

        if (activeGadgets.Where(s => s.PowerLevel >= requiredPower).Count() == 0)
        {
            Console.WriteLine($"Mission {missionName}: Insufficient power level.");
            return;
        }

        Console.WriteLine($"Mission {missionName}: Ready.");
    }
}
