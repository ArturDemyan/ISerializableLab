using System.Text.Json;
using System.Xml.Serialization;
class Person
{
    public string name { get; }
    public int age { get; set; }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

namespace ISerializableLB
{  
    internal class Program
    {
        private static ClassSquad? squadPareserJson;
        static void Main(string[] args)
        {
            try
            {
                string directoryPath = @"C:\Users\artur\source\repos\ISerializableLB\ISerializableLB\Date";
                SearchFile searchFile = new SearchFile(directoryPath);
                var fils = searchFile.FindFile();
                using (FileStream fs = new FileStream(fils, FileMode.OpenOrCreate))
                {
                    squadPareserJson = JsonSerializer.Deserialize<ClassSquad>(fs);
                }

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClassSquad));

                using (FileStream fs = new FileStream("squadName", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, squadPareserJson);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
