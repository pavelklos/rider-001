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
        
        // Postfix Completion
        // https://www.jetbrains.com/help/rider/Settings_Postfix_Completion.html
        // foo.notnull => if (foo != null) {}
        // items.foreach => foreach (var item in items) {}

        Console.WriteLine(foo);
        
        // foreach (var item in items) Console.WriteLine(item);
        
        // Live Templates (foreach) + Surround with Live Template (try)
        foreach (var item in items)
        {
            try
            {
                Console.WriteLine(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
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

// Live Templates (New Template) "mhandler" for "MediatR Handler"
// https://github.com/jbogard/MediatR
// https://github.com/jbogard/MediatR/wiki#requestresponse
// public class GetProductsHandler : IRequestHandler<GetProducts, string>
// {
//     public Task<string> Handle(GetProducts request, CancellationToken cancellationToken)
//     {
//         
//     }
// }