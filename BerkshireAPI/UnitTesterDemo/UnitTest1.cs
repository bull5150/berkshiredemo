using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesterDemo
{
    [TestClass]
    public class ListBuilderTester
    {
        [TestMethod]
        public void CountTest()
        {
            List<API_Scratcher.Models.reasons_list> testList = new List<API_Scratcher.Models.reasons_list>();
            testList = new API_Scratcher.Services.list_builder().buildList(testList);
            Assert.AreEqual(3, testList.Count);
        }
    }
    [TestClass]
    public class DescriptionTester
    {
        [TestMethod]
        public void IntNotFoundTest1()
        {
            API_Scratcher.Models.reasons_description description = new API_Scratcher.Services.reason_builder().descriptionBuilder(3500);
            Assert.AreEqual(999, description.id);
        }
        [TestMethod]
        public void IntNotFoundTest2()
        {
            API_Scratcher.Models.reasons_description description = new API_Scratcher.Services.reason_builder().descriptionBuilder(-1);
            Assert.AreEqual(999, description.id);
        }
    }
}
