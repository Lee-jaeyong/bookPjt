using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace bookPjt.util
{
    class UtilClass
    {
        public static Bitmap imgResize(Bitmap img,int width,int height)
        {
            Size resize = new Size(width, height);
            img = new Bitmap(img, resize);
            return img;
        }
    }
}
