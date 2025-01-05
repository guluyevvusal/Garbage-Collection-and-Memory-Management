using System;
using System.IO;

class Program
{
    class MyClass
    {
        public int Id { get; set; }

        ~MyClass() // Destructor (Finalizer) - Called when the object is being destroyed
        {
            Console.WriteLine($"Object {Id} has been destroyed.");
        }
    }

    static void Main(string[] args)
    {
        // 1. Creating objects
        for (int i = 1; i <= 5; i++)
        {
            MyClass obj = new MyClass { Id = i };
            Console.WriteLine($"Object {obj.Id} created.");
        }

        // 2. Triggering Garbage Collection multiple times to ensure cleanup
        Console.WriteLine("\nGarbage Collector is being called...");

        GC.Collect(); // Manually invoking the Garbage Collector

        GC.WaitForPendingFinalizers(); // Ensures finalizers have completed

        // Calling GC again to ensure it runs after finalizers

        GC.Collect(); // Additional call to ensure cleanup

    

        Console.WriteLine("\nProgram has ended.");
    }
}














