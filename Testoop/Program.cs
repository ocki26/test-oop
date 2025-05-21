// // Create instances of the Circle and Rectangle classes
// Circle circle = new Circle(5);
// Rectangle rectangle = new Rectangle(4, 6);
// // Call the Area method on the instances
// Console.WriteLine($"Circle Area: {circle.Area()}");
// Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
//lab2
// Person person = new Person();

// // Access and set properties
// person.Name = "John";
// person.Age = 30;

// // Call a method to introduce the person
// person.Introduce();
//lab3
// Create an instance of the Dog class
// Dog myDog = new Dog("Buddy", 3, "Golden Retriever");

// // Access properties from the base class
// Console.WriteLine($"Name: {myDog.Name}");
// Console.WriteLine($"Age: {myDog.Age}");

// // Access properties specific to the Dog class
// Console.WriteLine($"Breed: {myDog.Breed}");

// // Call methods inherited from the base class
// myDog.MakeSound();

// // Call a method specific to the Dog class
// myDog.Fetch();

Book newbook = new Book("conca", "concua", "contom", true);
Console.WriteLine($"{newbook.Title}+{newbook.Author}+{newbook.Publication_date}+{newbook.Available}");
