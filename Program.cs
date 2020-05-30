using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StringFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Nick's PC\iter.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Nick's PC\Inlet.out.txt");
            int count = 0;
            int kolichestvo = 0;
            string line;
            string s0 = ("Окончание");
            while ((line = sr.ReadLine()) != null)
            {
                string s = Convert.ToString(line);
                s.Replace(" ", "");
                count = (s.Length - s.Replace(s0, "").Length) / s0.Length;
                kolichestvo += count;
            }
            Console.WriteLine("Kolichestvo slov: " + kolichestvo);
            if (kolichestvo != 0)
            {
                sw.WriteLine(Convert.ToString(kolichestvo));
            }
            else
            {
                sw.WriteLine("-1");
            }
            Console.WriteLine("Dannie uspeshno zapisani!");
            sw.Close();
            Console.ReadLine();
        }
    }
}