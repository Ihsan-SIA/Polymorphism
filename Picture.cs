public class Picture : Tool
{
    public int Opacity { get; set; }
    public int Brightness { get; set; }
    public override void Enlarge()
    {
        Console.WriteLine("Enlarge the picture object");
        base.Enlarge();
    }
}
