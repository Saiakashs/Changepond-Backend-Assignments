using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIONamespace
{
    public class DirectoryInfoClass
    {
        public void DirectoryInfo()
        {
            DirectoryInfo d;
            d = new DirectoryInfo(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#");
            Console.WriteLine("Exists: " + d.Exists);
            if (d.Exists)
            {
                Console.WriteLine("Full name: " + d.FullName);
                Console.WriteLine("Name: " + d.Name);
                Console.WriteLine("Directory name: " + d.Parent);
                Console.WriteLine("Creation date and time: " + d.CreationTime);
                Console.WriteLine("Modification date and time: " +
               d.LastWriteTime);
                Console.WriteLine("Access date and time: " + d.LastAccessTime);
                Console.WriteLine("\nFiles:");
                FileInfo[] files = d.GetFiles();
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i].FullName);
                }

                Console.WriteLine("\nSub directories:");
                DirectoryInfo[] directories = d.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {
                    Console.WriteLine(directories[i].FullName);
                }
            }

            else
            {
                Console.WriteLine("The directory is not there in that path");
            }
        }
    }
}

