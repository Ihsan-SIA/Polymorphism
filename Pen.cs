public class Pen : Tool
{
    public override void Enlarge()
    {
        Console.WriteLine("Enlarge the pen object");
        Tool actool = new();
        base.Enlarge();
    }
}
