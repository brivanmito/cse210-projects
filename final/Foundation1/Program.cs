using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video FirstVideo = new Video("Baby Shark Dance", "Rovio", 180);

        FirstVideo.AddComment("Arturo Mata", "Very nive Video");
        FirstVideo.AddComment("Jose Miguel", "I don't Like it");
        FirstVideo.AddComment("Bryan Miño", "I enjoy this video");

        Video SecondVideo = new Video("Detergent Tyde", "Tyde Corp", 160);

        SecondVideo.AddComment("Joseph Murillo", "Works perfectly, thank you!");
        SecondVideo.AddComment("Bryan Josue", "Excellent quality and design!");
        SecondVideo.AddComment("Camila Cabello", "Incredibly useful, highly recommend.");

        Video ThirdVideo = new Video("Air dryer", "Black & Decker", 200);

        ThirdVideo.AddComment("Andrea Bocelli", "Fast shipping, very satisfied!");
        ThirdVideo.AddComment("Raul Mina", "Beautiful and practical, love it.");
        ThirdVideo.AddComment("Santiago Mena", "Meets all my expectations.");

        videos.Add(FirstVideo);
        videos.Add(SecondVideo);
        videos.Add(ThirdVideo);
        
        //Display the information for each Video
        foreach(Video video in videos)
        {
            video.DisplayInformation();
        }
        
    }
}