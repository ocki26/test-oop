using System;

// Base class (parent class)
class Animal
{
  public string Name { get; set; }
  public int Age { get; set; }

  public Animal(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public virtual void MakeSound()
  {
    Console.WriteLine("Some generic animal sound");
  }
    
}

// Derived class (child class) that inherits from Animal
class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    // Override the MakeSound method with a specific implementation
    public override void MakeSound()
    {
        Console.WriteLine("Bark, bark!");
    }

    public void Fetch()
    {
        Console.WriteLine("The dog is fetching a ball.");
    }
}
