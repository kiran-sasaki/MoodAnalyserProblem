namespace MoodAnalyserProbelm
{
    public class MoodAnalyser
    {
        public static string MoodAnalyse(string message)
        {
            if (message.Contains("Sad") || message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}