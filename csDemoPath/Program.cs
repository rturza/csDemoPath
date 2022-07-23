using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csDemoPath
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\projects\CsharpBasic\csDemoPath\csDemoPath.sln";

            var dotIndex = path.IndexOf('.');
            var extention = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory: " + Path.GetDirectoryName(path));
        }
    }
}
