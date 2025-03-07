using InternationalizationPuzzles2025.Puzzles.Puzzle1;
using Shouldly;

namespace InternationalizationPuzzles2025.Test.Puzzles.Puzzle1;

public class MessageTests
{
    [Fact]
    public void DetermineMessageType()
    {
        Messages.InvalidSmsAndTweetMessage.GetMessageType().ShouldBe(MessageType.Invalid);
        Messages.ValidSmsMessage.GetMessageType().ShouldBe(MessageType.Sms);
        Messages.ValidTweetMessage.GetMessageType().ShouldBe(MessageType.Tweet);
        Messages.ValidSmsAndTweetMessage.GetMessageType().ShouldBe(MessageType.SmsAndTweet);
    }
}