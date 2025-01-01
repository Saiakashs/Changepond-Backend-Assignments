using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIONamespace
{
    public class StreamWriterClass
    {
        public void StreamWriter()
        {
            
                //delete the file, if it already exists
                FileInfo f = new FileInfo(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\file1.txt");
                if (f.Exists == true)
                    f.Delete();
                //create the file
                FileStream fs = new FileStream(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\file1.txt", FileMode.Create, FileAccess.Write);

                //write data to the file
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Hai");
                sw.WriteLine("Hello");
                sw.WriteLine("How are you");
                //close the file
                sw.Close();
                Console.WriteLine("The words successfully added in the file");
            
        }
    }
}
