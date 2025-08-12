namespace GamblingServer.Models;

public class OverUnderRequest
{
    public int CardValue { get; set; }
    public string Guess { get; set; } = "";
}
