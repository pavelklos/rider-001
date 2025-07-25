using FluentAssertions;
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
    public void TestWithResultTrue()
    {
        Assert.True(true);
    }

    [Fact]
    public void TestWithResultFalse()
    {
        // This test is intentionally failing
        Assert.True(false);
    }
}