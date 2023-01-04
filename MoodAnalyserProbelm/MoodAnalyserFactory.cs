using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserProbelm
{
    public class MoodAnalyserFactory
    {
        public static string InvokedAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserProbelm.MoodAnalyser");
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProbelm.MoodAnalyser", "MoodAnalyser", "Happy");
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                MoodAnalyserException exp = new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Method is not found");
                return exp.Message;
            }
        }
        public static object CreateMoodAnalyse(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "Happy" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Class Not Found");
            }
        }
    }
}
