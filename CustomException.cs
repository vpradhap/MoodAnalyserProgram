using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE
        }

        public readonly ExceptionType Type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
