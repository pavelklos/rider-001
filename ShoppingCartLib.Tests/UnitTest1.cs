using FluentAssertions;
using Flurl.Http.Testing;
using Xunit.Abstractions;

namespace ShoppingCartLib.Tests;

public class UnitTest1(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void ANewCartShouldBeEmpty()
    {
        var sut = new ShoppingCart();
        sut.Get()
            .Should()
            .BeEquivalentTo([]);

        // This line is commented out because it does not work in the context of xUnit
        // Console.WriteLine("Some log");
        testOutputHelper.WriteLine("Some log");
    }

    [Fact]
    public void AddAProduct()
    {
        var sut = new ShoppingCart();
        sut.Add("Docker course");
        sut.Get()
            .Should()
            .BeEquivalentTo(["Docker course"]);
    }

    [Fact]
    public void AddMultipleProducts()
    {
        var sut = new ShoppingCart();
        sut.Add("Docker course");
        sut.Add("Kubernetes course");
        sut.Get()
            .Should()
            .BeEquivalentTo(["Docker course", "Kubernetes course"]);
    }

    [Fact]
    public void RemoveProduct()
    {
        var sut = new ShoppingCart();
        sut.Add("Docker course");
        sut.Add("Kubernetes course");
        sut.Remove("Docker course");
        sut.Get()
            .Should()
            .BeEquivalentTo(["Kubernetes course"]);
    }

    [Fact]
    public void ContainsProduct()
    {
        var sut = new ShoppingCart();
        sut.Add("Docker course");
        sut.Contains("Docker course")
            .Should()
            .BeTrue();
    }

    [Fact]
    public void DoesNotContainProduct()
    {
        var sut = new ShoppingCart();
        sut.Add("Docker course");
        sut.Contains("Kubernetes course")
            .Should()
            .BeFalse();
    }

    [Fact]
    public void ClearCart()
    {
        var sut = new ShoppingCart();
        sut.Add("Docker course");
        sut.Add("Kubernetes course");
        sut.Clear();
        sut.Get()
            .Should()
            .BeEquivalentTo([]);
    }

    [Fact]
    public void CountProducts()
    {
        var sut = new ShoppingCart();
        sut.Add("Docker course");
        sut.Add("Kubernetes course");
        sut.Count()
            .Should()
            .Be(2);
    }

    [Fact]
    public void TestWithResultTrue()
    {
        Assert.True(true);
    }

    // [Fact]
    // public void TestWithResultFalse()
    // {
    //     // This test is intentionally failing
    //     Assert.True(false);
    // }
    
    [Fact]
    public void TestWithHttpClient()
    {
        var httpTest = new HttpTest();
    }
}