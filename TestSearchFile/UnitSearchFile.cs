using ISerializableLB;
using System.Runtime.CompilerServices;

namespace TestSearchFile
{
    public class UnitSearchFile
    {
        [Fact]
        public void CheckingFileSearchMethodExpectingGetFilePath()
        {
            string directoryPath = @"C:\Users\artur\source\repos\ISerializableLB\ISerializableLB\Date";
            string expectedString = @"C:\Users\artur\source\repos\ISerializableLB\ISerializableLB\Date\SuperHeroSquad.json";
            SearchFile searchFileTest = new SearchFile(directoryPath);
            var result = searchFileTest.FindFile();
            Assert.Equal(result, expectedString);
        }
    }
}