using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint5.Task2.V3.Lib;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            string path = @"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint5\Tyuiu.BelovaEA.Sprint5.Task2.V3\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool tyta = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }
    }
}
