using System;

namespace StackOverflowPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("C# OOP classes", "access modifiers");

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            Console.WriteLine("Current Vote value : " + post.VoteValue);

            Console.WriteLine("Title: "+post.Title);
            Console.WriteLine("Description: " + post.Description);
            Console.WriteLine("Created At :" + post.CreatedAt);
        }
    }
}
