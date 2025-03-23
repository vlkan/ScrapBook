internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        IAnimal animal = new Dog();
        animal.SitP();

        Human human = new Turkish();
        human.Sit();
        human.Test1();
    }

    public interface IAnimal
    {
        void Eat();
        void Breath();
        private void Sit() // Default Implementation, Helper Method
        {
            Console.WriteLine("Sit!: IAnimal");
        }

        public void SitP() // Default Implementation
        {
            Sit();
            StandUp();
        }

        private static void StandUp()
        {
            Console.WriteLine("Thats Static!: IAnimal");
        }
    }

    public abstract class Human
    {
        public void Test1()
        {

        }

        public abstract void Eat();
        public abstract void Breath();
        public virtual void Sit()
        {
            Console.WriteLine("Sit!: Human");
        }

        public void Walk()
        {
            Console.WriteLine("Walk!: Human");
        }

        public Human(string name)
        {
            Console.WriteLine("{0} CTOR: Human CTOR", name);
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
        public Turkish() : base("Turkish")
        {
            Console.WriteLine("Turkish CTOR");
        }
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