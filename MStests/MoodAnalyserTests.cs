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
        public void AnalyseMoodTestSad()
        {
            string expected = "\nSAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad mood");

            string actual = moodAnalyser.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AnalyseMoodTestHappy()
        {
            string expected = "\nHAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in any mood");

            string actual = moodAnalyser.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }
    }
}