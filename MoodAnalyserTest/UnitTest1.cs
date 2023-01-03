using MoodAnalyserProbelm;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //UC1.1
        public void SadMoodShouldReturnSad()
        {
            string message = MoodAnalyser.MoodAnalyse("Sad");
            Assert.AreEqual(message, "Sad");
        }
        [TestMethod]
        //UC1.2
        public void AnyMoodShouldReturnHappy()
        {
            string message = MoodAnalyser.MoodAnalyse("I am in Any Mood");
            Assert.AreEqual(message, "Happy");
        }
    }
}