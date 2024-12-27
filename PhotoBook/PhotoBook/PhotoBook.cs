using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBook
{
    internal class PhotoBook
    {
        private int _numPages;

        public int Pages {
            get
            {
                return _numPages;
            }

            set
            {
                _numPages = value;   
            }
        }


        public int GetNumberPages()
        {
            return _numPages;
        }

        public PhotoBook()
        {
            this._numPages = 16;
        }

        public PhotoBook(int numpages)
        {
            this._numPages = numpages;
        }
    }

    class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            Pages = 64;
        }
    }
}
