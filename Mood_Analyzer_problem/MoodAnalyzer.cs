using System;
namespace Mood_Analyzer_problem
{
    public enum  Mood
    {
        Happy,
        sad,
    }

    public class MoodAnalyzer
    {
        public string CheckMood(string msg)
        {
            //msg : Rishabh is Happy for his new laptop
            //msg : Rishabh is Sad after getting bad marks
            if (msg == null)
            {
                throw new CustomMoodAnalyzerException("message is null", ExceptionType.NULL_VALUE);
            }
            else if (msg.Length < 1)
            {
                throw new CustomMoodAnalyzerException("provided message is empty", ExceptionType.EMPTY_TYPE);
            }

            if (msg.Contains("happy" , StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
             if(msg.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }
            return null;
        }  
    }
}
