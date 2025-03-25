using _1420;


class Program
{
    static void Main()
    {
        SpyToolkit spyToolkit = new SpyToolkit();
        spyToolkit.AddGadget("Freeze Ray", "Weapon");
        spyToolkit.AddGadget("Fire Ray", "Weapon");
        spyToolkit.AddGadget("Freeze Camera", "Surveillance");


        spyToolkit.DeactivateGadget("Freeze Ray");

        spyToolkit.GetActiveGadgets();
    }
}

