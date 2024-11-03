// static attribute 靜態屬性
// 靜態屬性屬於class

using ConsoleApp18;
using System;

Video video1 = new Video("A", "Tom", "Music");
Video video2 = new Video("B", "Mary", "Education");

Console.WriteLine(Video.video_count); //video_count屬於class，因此無法以物件形式（video1.video_count）呼叫
Console.WriteLine(video2.type);

//執行第一次video_count後再創建新的video3物件
Video video3 = new Video("C", "Peter", "Others");
Console.WriteLine(video3.getVideoCount()); //使用video3.getVideoCount()方式以物件形式呼叫屬於class的video_count