using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
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
            catch(NullReferenceException)
            {
                return "\nHAPPY...";
            }
            
        }
    }
}