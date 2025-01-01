using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIONamespace
{
    public class StreamReaderClass
    {
        public void StreamReader()
        {
            //check the file exists or not
            FileInfo f = new FileInfo(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\file1.txt");
            if (f.Exists == true)
            {
                //open the file
                FileStream fs = new FileStream(@"C:\Users\sai.kutthalingam\Downloads\Changepond\Backend\C#\file1.txt", FileMode.Open, FileAccess.Read);
                //read the file
                StreamReader sr = new StreamReader(fs);
                string s = sr.ReadToEnd();
                //close the file
                sr.Close();
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }
    }
}
