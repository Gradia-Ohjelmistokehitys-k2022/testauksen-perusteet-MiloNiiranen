using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using FileOperations3;

namespace FileOperationsTest
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty()
            {
                // Arrange
                List<string> systemConfig;
                string winDir = "C:\\Windows";
                string path = "\\system.ini";


                // Act
                systemConfig = FileOperations3.Program.ReadFile(new List<string>(), winDir, path);
        
                // Assert
                 Assert.IsTrue(systemConfig.Count > 0);
            }

        [TestMethod]
        public void ReadFile_ReturnsFileExist_()
        {
            // arrange
           List<string> systemConfig;
            string winDir = "C:\\Windows";
            string path = "\\Moi.txt";

            // act and assert
            Assert.ThrowsException<FileNotFoundException>(() =>
            {
                systemConfig = FileOperations3.Program.ReadFile(new List<string>(), winDir, path);
            });


        }

        [TestMethod]
        public void PrintFile_WritesInConsole_ExpectedResultNotEmpty()
        {
            // arrange
            List<string> systemConfig = new List<string> { "Moi", "Hei" };


            // act
            FileOperations3.Program.PrintFile(systemConfig);

            // assert
            Assert.IsTrue (systemConfig.Count > 0);
        }
    }
}