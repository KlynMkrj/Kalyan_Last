using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileService.Tests
{
    [TestClass()]
    public class ServiceFileTests
    {
        [TestMethod()]
        public void BringFileInformationTest()
        {
            ServiceFile objTest = new ServiceFile("--size", "c:/test.txt");

            string strActualResult = objTest.BringFileInformation();

            Assert.IsTrue(strActualResult.Contains("File Size"));
        }
    }
}