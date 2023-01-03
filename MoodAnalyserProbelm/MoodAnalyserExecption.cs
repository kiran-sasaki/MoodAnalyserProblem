using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProbelm
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE, NULL_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType Type;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
