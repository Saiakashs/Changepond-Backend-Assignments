using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBook
{
    internal class PhotoBookTest
    {
        public static void Main(string[] args)
        {
            PhotoBook defaultpages = new PhotoBook();
            Console.WriteLine("Show the number of pages in the default contructor:" + defaultpages.GetNumberPages());

            PhotoBook userpages = new PhotoBook(24);
            Console.WriteLine("Show the number of pages given by user:" + userpages.GetNumberPages());

            BigPhotoBook largepages = new BigPhotoBook();
            Console.WriteLine("Show the number of pages for large book:" + largepages.GetNumberPages());
            
        }
    }
}
