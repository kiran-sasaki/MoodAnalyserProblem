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
            MoodAnalyser analyser = new MoodAnalyser("Sad");
            string message = analyser.MoodAnalyse();
            Assert.AreEqual(message, "Sad");
        }
        [TestMethod]
        //UC1.2
        public void AnyMoodShouldReturnHappy()
        {
            MoodAnalyser analyser = new MoodAnalyser("I am in Any Mood");
            string message = analyser.MoodAnalyse();
            Assert.AreEqual(message, "Happy");
        }
    }
}