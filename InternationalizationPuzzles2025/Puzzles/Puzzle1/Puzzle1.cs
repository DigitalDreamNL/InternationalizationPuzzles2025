namespace InternationalizationPuzzles2025.Puzzles.Puzzle1;

public class Puzzle1 : Puzzle
{
    protected override string FileName => "puzzle1.txt";

    private const int SmsAndTweetPrice = 13;
    private const int SmsPrice = 11;
    private const int TweetPrice = 7;

    public override string Execute()
    {
        var cost = Input.Sum(CalculateMessageCost);

        return cost.ToString();
    }

    private static int CalculateMessageCost(string message) =>
        message.GetMessageType() switch
        {
            MessageType.SmsAndTweet => SmsAndTweetPrice,
            MessageType.Sms => SmsPrice,
            MessageType.Tweet => TweetPrice,
            _ => 0
        };
}

