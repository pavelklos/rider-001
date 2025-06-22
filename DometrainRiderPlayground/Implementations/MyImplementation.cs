using DometrainRiderPlayground.Interfaces;

// using System.Text.Json;

namespace DometrainRiderPlayground.Implementations;

public class MyImplementation : IMyInterface
{
    public int MyPublicMethodCallCounter { get; set; }

    public void MyPublicMethod()
    {
        Console.WriteLine($"Hi! I'm public, and I've been called {MyPublicMethodCallCounter} times!");
        MyPublicMethodCallCounter++;
        var items = MyPrivateMethod();

        var foo = Foo(items);

        Console.WriteLine(foo);

        foreach (var item in items) Console.WriteLine(item);
    }

    // private void MyPrivateMethod()
    // {
    //     Console.WriteLine("Shhh, I'm private!");
    //
    //     var myList = new List<string>();
    //
    //     foreach (var item in GetItems())
    //     {
    //         if (item.StartsWith("Foo"))
    //             myList.Add(item);
    //     }
    // }

    private List<string> MyPrivateMethod()
    {
        Console.WriteLine("Shhh, I'm private!");

        return GetItems()
            .Where(item => item.StartsWith("Foo"))
            .ToList();
    }

    private static string Foo(List<string> items)
    {
        return items.Count switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            _ => ""
        };
    }

    // private List<string>? GetItems() =>
    //     new List<string> { "Foo", "Bar" };
    private List<string> GetItems()
    {
        return ["Foo", "Bar"];
    }
}