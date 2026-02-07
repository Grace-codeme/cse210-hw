using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 360),
            new Video("Video 2", "Author 2", 420),
            new Video("Video 3", "Author 3", 300)
        };

        videos[0].AddComment(new Comment("Emmanuel", "Great video!"));
        videos[0].AddComment(new Comment("Jennifer", "Love it!"));
        videos[0].AddComment(new Comment("John", "Nice content"));

        videos[1].AddComment(new Comment("Mercy", "Awesome!"));
        videos[1].AddComment(new Comment("Grace", "Good stuff"));

        videos[2].AddComment(new Comment("Samuel", "Excellent"));
        videos[2].AddComment(new Comment("Emmanuella", "Well done!"));
        videos[2].AddComment(new Comment("David", "Great job"));

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
