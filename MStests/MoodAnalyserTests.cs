using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram.Tests
{
    [TestClass()]
    public class MoodAnalyserTests
    {
        [TestMethod()]
        public void AnalyseMoodTest()
        {
            string expected = "\nSAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            string actual = moodAnalyser.AnalyseMood("I am in sad mood");

            Assert.AreEqual(expected, actual);
        }
    }
}