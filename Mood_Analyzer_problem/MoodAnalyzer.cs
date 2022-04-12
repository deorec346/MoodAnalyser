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

            if (msg.Contains("happy" , StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            else if(msg.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }
            else if(msg.Contains("null", StringComparison.OrdinalIgnoreCase))
            {
                return "Happy";
            }
            else
            {
                return null;
            }
        }  
    }
}
