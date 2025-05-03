public class AbstractClasses
{
    public abstract class Lagos
    {
        public void ChangeState()
        {
            Console.WriteLine("Now we're in another state in Nigeria....");
        }
        public abstract void East();
        public abstract void Central();
        public abstract void West();
    }
    public class Somolu : Lagos
    {
        public override void East()
        {
            Console.WriteLine("Somolu is in Lagos East");
        }

        public override void Central()
        {
            Console.WriteLine("This is not where to implement this method...\n");
        }

        public override void West()
        {
            Console.WriteLine("This is not where to implement this method...\n");
        }
    }
    public class LagIsland : Lagos
    {
        public override void East()
        {
            Console.WriteLine("This is not where to implement this method...\n");
        }

        public override void Central()
        {
            Console.WriteLine("Isale Eko is in Lagos Central");
        }

        public override void West()
        {
            Console.WriteLine("This is not where to implement this method...\n");
        }
    }
    public class Agege : Lagos
    {
        public override void East()
        {
            Console.WriteLine("This is not where to implement this method...\n");
        }

        public override void Central()
        {
            Console.WriteLine("This is not where to implement this method...\n");
        }

        public override void West()
        {
            Console.WriteLine("Agege is in Lagos West");
        }
    }
}