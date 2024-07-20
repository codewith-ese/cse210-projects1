using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;
class Program
{

static void Main(string[] args)
{
    Console.WriteLine("");
    Console.WriteLine(" ************************ ");
    Console.WriteLine(" YouTube Video Tracker 2024 ");
    Console.WriteLine(" ************************ ");

    Video video = new Video();
    video.Author = "Natalia";
    video._title = "Product Video 101";
  //  video.DisplayInfo();

    Comment comment1 = new Comment("Mark Benjamin", "Wonderful Video!, nice one guys, keep it up. ");
    Comment comment2 = new Comment("Moses John ", "Great video! Thanks for sharing.");
    Comment comment3 = new Comment("Omonigho Banabas ", "Thanks for sharing this info.");
    Comment comment4 = new Comment("Galadima Banabas ", "Great concept ! Thanks for sharing.");
    video._comments.Add(comment1);
    video._comments.Add(comment2);
    video._comments.Add(comment3);
    video._comments.Add(comment4);

    video.DisplayInfo();

    // here i am making list for more videos and the comment
    List<Video> videos = new List<Video>();

    Video video2 = new Video();
    video2.Author = "Abc Mark";
    video2._title = "Product Video 102";
    video2.AddComment(" Jecob Ben ", " Nice job! keep it up ");
    video2.AddComment(" Collins Ben ", " Nice job! keep it up ");
    video2.AddComment(" Mark Ben ", " Nice job! keep it up ");
    video2.AddComment(" Eseinone Monday ", " Nice one! thanks for sharing  it up ");
    videos.Add(video2);

    Video video3 = new Video();
    video3.Author = "Monday";
    video3._title = "Product video 103";
    video3.AddComment("Collins", " Nice video!");
    video3.AddComment("Charls ", " Wow! This is cool ");
    video3.AddComment(" Lilian", "Nice one guys! You are doing greate job ");
    video3.AddComment(" Alma ", " I am very ok with the concept!");
    videos.Add(video3);

    
    Video video4 = new Video();
    video4.Author = "Eseinone Erirore ";
    video4._title = "Product video 104";
    video4.AddComment("Glory Goodman ", " Greate video!");
    video4.AddComment("Charls Mark ", " Wow! This is cool ");
    video4.AddComment(" Lilian Bush", "Nice one guys! You are doing greate job ");
    video4.AddComment(" Nephi Lee ", " Nice concept!");
    videos.Add(video4);

    // here i loop through the video list 
    // and display it to the terminal 
    foreach (var v in videos)
    {
        v.DisplayInfo();     
    }
}


}




// class Program
// {
//     static void Main(string[] args)
//     {
           
//         Video video = new Video();
//         video._author = "Natalia";
//         video._title = " Product 101  ";
//         video.DisplayInfo();
        
//         Comment comment = new Comment(" Mark Benjamim ", " This product is nice, I have used it and it was so cool ");
//         comment.DisplayComment();
        
       
        
//         List<Video> videos = new List<Video>();
//         video._author = "Abc Mark ";
//         video._title = " product 102 ";
//         videos.Append(video);
//       //  video.DisplayInfo();

//         video._author ="monday ";
//         video._title = " Product 103 ";
//         comment._commentText = " I really love this product! ";
//         comment._name = "Collins ";
//         video.DisplayInfo();
    
 
       


        
//     }
// }

