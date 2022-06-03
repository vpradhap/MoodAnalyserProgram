using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string meassage)
        {
            if (meassage.ToLower().Contains("sad"))
            {
                return "\nSAD MOOD";
            }
            else
            {
                return "\nHAPPY MOOD";
            }
        }
    }
}
