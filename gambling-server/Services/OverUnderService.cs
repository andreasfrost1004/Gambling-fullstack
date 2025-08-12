using GamblingServer.Models;

namespace GamblingServer.Services;

public class OverUnderService
{
    private readonly Random _random = new();

    public OverUnderResult PlayRound(OverUnderRequest request)
    {
        var newCard = _random.Next(1, 14); // Simulate card 1-13
        var win = (request.Guess == "over" && newCard > request.CardValue) ||
                  (request.Guess == "under" && newCard < request.CardValue);

        var result = new OverUnderResult
        {
            NewCard = newCard,
            Result = win ? "win" : "lose",
            NewBalance = win ? 6000 : 4000 // TODO: later fetch from DB
        };

        return result;
    }
}
