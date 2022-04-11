using System;
namespace Mood_Analyzer_problem
{
    public enum  Mood
    {
        Happy,
        sad
    }

    public class MoodAnalyzer
    {
        public string CheckMood(string msg)
        {
            if (msg.Contains("happy" , StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }



}
