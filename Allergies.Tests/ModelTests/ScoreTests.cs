using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergies.Models;

namespace Allergies.Tests
{
    [TestClass]
    public class ScoreTests
    {
        [TestMethod]
        public void InstanceOfConstructor_CreatesInstanceOfScore_Score()
        {
            Score instanceOfScore = new Score(100);
            Assert.AreEqual(typeof(Score), instanceOfScore.GetType());
        }
        [TestMethod]
        public void Score_CheckAllergiesOneItem_OneItem()
        {
            Score instanceOfScore = new Score(1);
            List<string> result = new List<string>{"eggs"};
            CollectionAssert.AreEqual(instanceOfScore.CheckAllergies(), result);
        }
        [TestMethod]
        public void Score_CheckAllergiesMultipleItem_MultipleItem()
        {
            Score instanceOfScore = new Score(9);
            List<string> result = new List<string>{"strawberries", "eggs"};
            CollectionAssert.AreEqual(instanceOfScore.CheckAllergies(), result);
        }
    }
}