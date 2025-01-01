using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIONamespace
{
    public class FileInfoClass
    {

        public void FileInfo()
        {
            FileInfo f;
            f = new FileInfo(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\sampletext.txt");
            Console.WriteLine("Exists: " + f.Exists);
            if (f.Exists)
            {
                Console.WriteLine("Full name: " + f.FullName);
                Console.WriteLine("Name: " + f.Name);
                Console.WriteLine("Directory name: " + f.DirectoryName);
                Console.WriteLine("Extension: " + f.Extension);
                Console.WriteLine("Creation date and time: " + f.CreationTime);
                Console.WriteLine("Modification date and time: " + f.LastWriteTime);
                Console.WriteLine("Access date and time: " + f.LastAccessTime);
                Console.WriteLine("Length: " + f.Length + " bytes");
            }

            else
            {
                Console.WriteLine("The file is not there in that path");
            }
        }
    }
}
