using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace photo_book_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook = new PhotoBook();
            Console.WriteLine(photoBook.GetNumberPages());
            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.GetNumberPages());
        }
    }
    class PhotoBook
    {
        protected int numpage { get; set; }
        public int GetNumberPages()
        {
            return numpage;
        }
        public PhotoBook()
        {
            numpage = 16;
        }
        public PhotoBook(int s)
        {
            numpage = s;
        }

    }
    class BigPhotoBook: PhotoBook
    {
        
        public BigPhotoBook()
        {
            numpage = 64;
        }
        
    }
    class PhotoBookTest: PhotoBook
    {


    }
}
