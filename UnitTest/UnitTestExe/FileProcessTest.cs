using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using UnitTest;

namespace UnitTestExe
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new FileProcess();

            bool fromCall;

            //Caminho correto
            fromCall = fp.FileExist(@"C:\Windows\regedit.exe");

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new FileProcess();

            bool fromCall;

            //Caminho incorreto
            fromCall = fp.FileExist(@"C:\Windows\r22egedit.exe");

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpety_ThrowArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExist(@"");
        }
    }
}