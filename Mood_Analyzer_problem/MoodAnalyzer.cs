using System;
namespace Mood_Analyzer_problem
{
    public enum Mood
    {
        Happy,
        sad
    }

    public class MoodAnalyzer
    {
        public string CheckMood(string msg)
        {
            //msg : Rishabh is Happy for his new laptop
            //msg : Rishabh is Sad after getting bad marks
            if (msg.Contains("happy", StringComparison.OrdinalIgnoreCase))
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
