using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIONamespace
{
    public class DirectoryClass
    {
        public void Directorys()
        {
            if (Directory.Exists(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder1") == true)
            {
                Directory.Delete(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder1", true);
            }
            if (Directory.Exists(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder2") == true)
            {
                Directory.Delete(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder2", true);
            }
            Directory.CreateDirectory(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder1");
            Console.WriteLine("folder1 created");
            Console.WriteLine("folder1 exists: " + Directory.Exists(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder1"));
            //Output: True

            Directory.Delete(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder1");
            Console.WriteLine("folder1 deleted");
            Console.WriteLine("folder1 exists: " + Directory.Exists(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder1"));
            //Output: False

            Directory.CreateDirectory(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder1");
            Console.WriteLine("folder1 created");
            Directory.Move(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder1", @"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder2");
            Console.WriteLine("folder1 moved as folder2");
        }
    }
}
