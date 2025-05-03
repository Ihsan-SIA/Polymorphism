public class Tool
{
    public int width { get; set; }
    public int height { get; set; }
    public int XDim { get; set; }
    public int YDim { get; set; }
    public virtual void Enlarge()
    {
        Console.WriteLine("Enlarged tools class.... done\n");
    }
}
