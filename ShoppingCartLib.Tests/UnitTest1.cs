using FluentAssertions;

namespace ShoppingCartLib.Tests;

public class UnitTest1
{
    [Fact]
    public void ANewCartShouldBeEmpty()
    {
        var sut = new ShoppingCart();
        sut.Get()
            .Should()
            .BeEquivalentTo([]);
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