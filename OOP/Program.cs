internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        IAnimal animal = new Dog();
        animal.Sit();

        Human human = new Turkish();
        human.Sit();
    }

    public interface IAnimal
    {
        public void Eat();
        public void Breath();
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

        public void Walk()
        {
            Console.WriteLine("Walk!");
        }
    }

    public class Dog : IAnimal
    {
        public void Breath()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    public class Turkish : Human
    {
        public override void Breath()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Sit()
        {
            base.Sit();
        }
    }
}