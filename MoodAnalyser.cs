using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "\nSAD";
            }
            else
            {
                return "\nHAPPY";
            }
        }
    }
}
