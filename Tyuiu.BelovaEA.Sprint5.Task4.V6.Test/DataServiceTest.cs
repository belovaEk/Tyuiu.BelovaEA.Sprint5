using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint5.Task4.V6.Lib;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";

            FileInfo info = new FileInfo(path);
            bool tyta = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }
    }
}
