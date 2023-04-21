using System.IO;
using System.Text;
using System.Xml.Linq;

namespace DZ10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new DirectoryInfo("c:\\Otus\\TestDir1").Create();
            new DirectoryInfo("c:\\Otus\\TestDir2").Create();

            for (int i = 1; i < 11; i++)
            {
                File.Create("c:\\Otus\\TestDir1\\file" + i).Close();
                File.Create("c:\\Otus\\TestDir2\\file" + i).Close();
            }
            for (int i = 1; i < 11; i++)

            {

                File.Open($"c:\\Otus\\TestDir1\\file{i}", FileMode.OpenOrCreate, FileAccess.Write).Close();
                File.Open($"c:\\Otus\\TestDir2\\file{i}", FileMode.OpenOrCreate, FileAccess.Write).Close();

                File.WriteAllText($"c:\\Otus\\TestDir1\\file{i}", $"file{i}", Encoding.UTF8);
                File.WriteAllText($"c:\\Otus\\TestDir2\\file{i}", $"file{i}", Encoding.UTF8);

                File.AppendAllText($"c:\\Otus\\TestDir1\\file{i}", ("   Date Time  " + DateTime.Now.ToString()));
                File.AppendAllText($"c:\\Otus\\TestDir2\\file{i}", ("   Date Time  " + DateTime.Now.ToString()));
            }
            for (int i = 1; i < 11; i++)

            {

                Console.WriteLine("c:\\Otus\\TestDir1\\file" + i + ": " +File.ReadAllText("c:\\Otus\\TestDir1\\file" + i));
                Console.WriteLine("c:\\Otus\\TestDir2\\file" + i + ": " + File.ReadAllText("c:\\Otus\\TestDir2\\file" + i));
            }

            Console.ReadKey();
        }
    }
}