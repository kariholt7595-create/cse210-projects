using System;

class Program
{ 
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Make Cookies", "Kari's Kitchen", 360);

        Comment comment1 = new Comment("Sarah", "These cookies look delicious!");
        Comment comment2 = new Comment("Mark", "I want to try this recipe.");
        Comment comment3 = new Comment("Emily", "Thanks for explaining it clearly.");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);


        Video video2 = new Video("Easy Garden Tips", "Backyard Basics", 420);

        Comment comment4 = new Comment("Liam", "This helped me understand when to water.");
        Comment comment5 = new Comment("Mia", "I'm going to try this with my tomatoes.");
        Comment comment6 = new Comment("Noah", "The soil tip was really helpful.");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);


        Video video3 = new Video("Beginner Photography Tips", "Creative Camera", 510);

        Comment comment7 = new Comment("Olivia", "The lighting examples were really helpful.");
        Comment comment8 = new Comment("Ethan", "I finally understand how to frame a picture.");
        Comment comment9 = new Comment("Ava", "I am going to practice these tips this weekend.");

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        Video video4 = new Video("Simple Home Organization Ideas", "Organized Living", 475);

        Comment comment10 = new Comment("Sophia", "The basket idea would work well in my house.");
        Comment comment11 = new Comment("Jackson", "I like how simple these ideas are.");
        Comment comment12 = new Comment("Grace", "The closet tip was my favorite.");
        Comment comment13 = new Comment("Lucas", "I am going to try organizing one room at a time.");

        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);
        video4.AddComment(comment13);

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}