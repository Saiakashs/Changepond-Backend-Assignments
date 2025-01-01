using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIONamespace
{
    public class FileClass
    {
        public void Files()
        {
            {
                if (Directory.Exists(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3") == true)
                {
                    Directory.Delete(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3", true);
                }
                Directory.CreateDirectory(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3");
                Console.WriteLine("Folder created");
                File.Create(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3\file1.txt").Close();
                Console.WriteLine("File created");
                File.Copy(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3\file1.txt", @"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3\file2.txt");
                Console.WriteLine("File created");
                File.Move(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3\file2.txt", @"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3\file3.txt");
                Console.WriteLine("File moved");
                Console.WriteLine("File exists: " + File.Exists(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\samplefolder3\file3.txt"));
            }
        }
    }
}
