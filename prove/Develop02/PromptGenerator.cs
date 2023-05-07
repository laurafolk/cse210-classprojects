using System;
using System.Collections.Generic;
using System.IO;
class PromptGenerator
{
    List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "How have you seen the hand of God in your life today?",
            "What are three things you are grateful for today?",
            "What did you learn today?",
            "Did you do something nice for someone today?",
            "How did you serve someone today?",            
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, prompts.Count);
        return prompts[index];
    }
}