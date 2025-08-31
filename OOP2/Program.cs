internal class Program
{
    private static void Main(string[] args)
    {
        var v = new Vehicle();
        Vehicle c = new Car(); //Method Hiding

        v.Start(); // Vehicle started
        c.Start(); // Car started

        Console.WriteLine("------------------------------------");

        v.Stop(); // Vehicle stopped
        c.Stop(); // Car stopped

        //var a = new Animal(); // Error: Cannot create an instance of the abstract class 'Animal'

        Console.WriteLine("------------------------------------");

        var d = new Dog();

        Console.WriteLine(d.name);
        d.Speak(); // Woof! Woof!
        d.Eat(); // Dog is eating
        d.Sleep(); // Dog is sleeping

        Console.WriteLine("------------------------------------");

        Animal a = new Dog(); // Upcasting
        a.Speak(); // Woof! Woof!
        a.Eat(); // Animal is eating
        a.Sleep(); // Dog is sleeping
    }
}

public class Vehicle 
{
    public static int vehicleCount = 0;
    public string name = "";

    public virtual void Start() 
    {
        vehicleCount++;
        Console.WriteLine("Vehicle started");
    }

    public void Stop() 
    {
        vehicleCount--;
        Console.WriteLine("Vehicle stopped");
    }
}

public class Car : Vehicle
{
    public override void Start()
    {
        vehicleCount++;
        Console.WriteLine("Car started");
        base.Start(); // Call the base class Start method
    }

    public void Stop() // Method Hiding
    {
        vehicleCount--;
        Console.WriteLine("Car stopped");
        base.Stop(); // Call the base class Stop method
    }

}

public abstract class Animal
{
    public string name;
    //public abstract string type; // Abstract property error!!!
    public abstract void Speak(); // Abstract method
    public void Eat() // Concrete method
    {
        Console.WriteLine("Animal is eating");
    }

    public virtual void Sleep() // Virtual method
    {
        Console.WriteLine("Animal is sleeping");
    }
}

public class Dog : Animal
{
    public override void Speak() // Implementing abstract method
    {
        Console.WriteLine("Woof! Woof!");
    }

    public void Eat() // Method Hiding
    {
        Console.WriteLine("Dog is eating");
        //base.Eat(); // Call the base class Eat method
    }

    public override void Sleep() // Overriding virtual method
    {
        Console.WriteLine("Dog is sleeping");
        //base.Sleep(); // Call the base class Sleep method
    }
}

public sealed class Cat : Animal // Sealed class
{
    public override void Speak() // Implementing abstract method
    {
        Console.WriteLine("Meow! Meow!");
    }
}

//public class Tekir : Cat
//{
//    // Error: Cannot derive from sealed type 'Cat'
//}