﻿using DometrainDebuggingPlayground.PodcastSource;

namespace DometrainDebuggingPlayground.PodcastsService;

public class PodcastService(
    IPodcastSource podcastSource,
    ILogger<PodcastService> logger)
    : IPodcastService
{
    public Task<IEnumerable<Podcast>> GetPodcastsAsync() =>
        podcastSource.GetPodcastsAsync();

    public async Task<IEnumerable<Podcast>> GetPodcastsByGenreAsync(string genre)
    {
        logger.LogInformation("Getting podcasts by genre {Genre}", genre);

        var podcasts = await podcastSource.GetPodcastsAsync();

        // Analyze Stack Trace or Thread Dump...
        // throw new TaskCanceledException();

        return podcasts
            .Where(x => x.Genre == genre)
            .OrderBy(x => x.Title)
            .ThenBy(x => x.Genre)
            .ToList();
    }

    public async IAsyncEnumerable<Podcast> GetPodcastsBySearchTermAsync(string searchTerm)
    {
        logger.LogInformation("Getting podcasts by search term {SearchTerm}", searchTerm);

        var podcasts = await podcastSource.GetPodcastsAsync();

        foreach(var podcast in podcasts)
        {
            if (podcast.Title.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
            {
                yield return podcast;
            }
        }
    }
    
    public static void Foo()
    {
        var jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWUsImlhdCI6MTUxNjIzOTAyMn0.KMUFsIDTnFmyG3nMiGM6H9FNFUROf3wh7SmqJp-QV30";
        Console.WriteLine("Foo called");
        Console.WriteLine($"JWT: {jwt}");
    }
}
