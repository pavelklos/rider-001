using System.Diagnostics;
using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace DometrainDebuggingPlayground.Tests;

public class PodcastTests
{
    //pavelklos: Run all tests in this class
    
    [Fact]
    public async Task GetPodcastsTests()
    {
        var client = new WebApplicationFactory<Program>().CreateClient();
        var response = await client.GetAsync("/podcasts");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
    
    // Test to check if podcasts endpoint returns 200 OK status code for valid genre
    [Fact]
    public async Task GetPodcastsBySearchTerm_ValidSearchTerm_ReturnsOk()
    {
        var client = new WebApplicationFactory<Program>().CreateClient();
        var response = await client.GetAsync("/podcasts/bygenre?genre=dotnet");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
    
    // Test to check if podcasts endpoint returns 404 Not Found status code for invalid genre
    [Fact]
    public async Task GetPodcastsByGenre_InvalidGenre_ReturnsNotFound()
    {
        var client = new WebApplicationFactory<Program>().CreateClient();
        var response = await client.GetAsync("/podcasts/bygenre?genre=invalid");
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}       