using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoSolution
{
    public class SpyGadget
    {
        public string Name { get; set; }
        public string Category { get; set; }  // e.g., "Weapon", "Surveillance"
        public int PowerLevel { get; set; }   // Power level (0-100)
        public bool IsActive { get; set; }    // True if gadget is operational
    }
}
