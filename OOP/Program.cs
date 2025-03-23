internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public interface IAnimal
    {
        public void Eat();
        public abstract void Breath();
        public void Sit() // Default Implementation
        {
            Console.WriteLine("Sit!");
        }
    }

    public abstract class Human
    {
        public abstract void Eat();
        public abstract void Breath();
        public virtual void Sit()
        {
            Console.WriteLine("Sit!");
        }
    }

    public class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }
        public void Breath()
        {
            Console.WriteLine("Dog is breathing.");
        }

        public void Sit()
        {
            Console.WriteLine("Dog is sitting.");
        }
    }

    public class Turkish : Human
    {
        public override void Eat()
        {
            Console.WriteLine("Turkish is eating.");
        }
        public override void Breath()
        {
            Console.WriteLine("Turkish is breathing.");
        }
        public override void Sit()
        {
            Console.WriteLine("Turkish is sitting.");
        }
    }
}