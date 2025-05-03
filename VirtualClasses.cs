public class VirtualClasses
{
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

    public class Canvas
    {
        public void DrawShapes(List<Tool> tools)
        {
            foreach (var tool in tools)
            {
                tool.Enlarge();
            }
        }
    }
    public class Pen : Tool
    {
        public override void Enlarge()
        {
            Console.WriteLine("Enlarge the pen object");
            Tool actool = new();
            base.Enlarge();
        }
    }
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



}