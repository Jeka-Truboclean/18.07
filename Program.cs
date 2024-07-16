using System.Text;

namespace _18._07
{
    internal class Program
    {
        static void Main()
        {
            string fileName = "file.txt";
            using (FileStream fs = File.Create(fileName))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(fileName);
                fs.Write(info, 0, info.Length);
            }

            using (StreamReader st = File.OpenText(fileName))
            {
                string s = "";
                while ((s = st.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
