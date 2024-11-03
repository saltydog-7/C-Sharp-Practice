using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Video
    {
        public string title;
        public string author;
        public string type;
        public static int video_count = 0; //創建static屬性變數video_count

        public Video(string title, string author, string type)
        {
            this.title = title;
            this.author = author;
            this.type = type;
            video_count++; //每創建一個新的video物件就+1
        }

        public int getVideoCount() //創建method
        {
            return video_count;
        }
    }
}
