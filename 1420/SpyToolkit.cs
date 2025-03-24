using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1420
{
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
            if(category != null)
            {
                List<SpyGadget> activeCategoryGadgets = SpyGadgets.Where(s => s.IsActive == true).Where(s => s.Category == category).ToList();
                return activeCategoryGadgets;
            }

            List<SpyGadget> activeGadgets = SpyGadgets.Where(s => s.IsActive == true).ToList();
            return activeGadgets;
        }

        public void DeactivateGadget(string name)
        {
            bool containsGadget = SpyGadgets.Any(s => s.Name == name);

            SpyGadget spyGadget = new SpyGadget();
            spyGadget.Name = name;
            spyGadget.IsActive = false;

            var deactivate = containsGadget ? $"{name} deactivated." : $"{name} not found.";

            Console.WriteLine(deactivate);

            //still need to fix this
        }
    }
}
