public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What am I grateful for today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was my favorite interaction I had today?",
        "What did I learn today?",
        "What's something I could have done better today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}