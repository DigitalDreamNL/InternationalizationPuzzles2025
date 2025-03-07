namespace InternationalizationPuzzles2025.Puzzles.Puzzle1;

public static class MessageExtensions
{
    private const int MaxSmsByteSize = 160;
    private const int MaxTweetCharacterSize = 140;

    public static MessageType GetMessageType(this string message)
    {
        var validSms = System.Text.Encoding.UTF8.GetByteCount(message) <= MaxSmsByteSize;
        var validTweet = message.Length <= MaxTweetCharacterSize;

        return (validSms, validTweet) switch
        {
            (true, true) => MessageType.SmsAndTweet,
            (true, false) => MessageType.Sms,
            (false, true) => MessageType.Tweet,
            _ => MessageType.Invalid
        };
    }
}