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
        
        [TestMethod]
        public void TestCustomException_ShouldReturn_CustomNullMsgException_When_given_null()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                moodAnalyser.AnalyseMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Message should not be null", e.Message);
            }

        }

        [TestMethod]
        public void TestCustomException_ShouldReturn_CustomEmptyMsgException_When_given_empty()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                moodAnalyser.AnalyseMood();
            }
            catch (CustomException e)
            {

                Assert.AreEqual("Message should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object()
        {
            string className = "MoodAnalyserProgram.MoodAnalyser";
            string constructorName = "MoodAnalyser";
            MoodAnalyser expected = new MoodAnalyser();
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyser(className, constructorName);
            expected.Equals(resultObj);
        }

        [TestMethod]
        public void ImproperClassName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                string className = "WrongNamespace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyser(className, constructorName);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("class not found", e.Message);
            }
        }

        [TestMethod]
        public void ImproperConstructorName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                string className = "MoodAnalyserProgram.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyser(className, constructorName);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("constructor not found", e.Message);
            }
        }
    }
}