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
