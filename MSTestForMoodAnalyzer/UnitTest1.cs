using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_problem;

namespace MSTestForMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        //Arrangement
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

        [TestMethod]
        public void CheckMoodHappy()
        {
            //Action
            string res = moodAnalyzer.CheckMood("Rishabh is Happy for his new laptop");
            //Assert
            Assert.AreEqual("happy", res);
        }
        [TestMethod]
        public void CheckMoodSad()
        {
            //Action
            string res = moodAnalyzer.CheckMood("Rishabh is Sad after getting bad marks");
            //Assert
            Assert.AreEqual("sad", res);
        }
    }
}
