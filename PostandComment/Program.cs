using System;

namespace PostandComment
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("MitchellW");
            User user2 = new User("RichardK");
            User user3 = new User("MichaelS");

            //create a post or ISSUE
            Post post1 = new Post(user1, "Hope everyone has a great day!");
          
            //add comments or UPDATES
            post1.comments.Add(new Comment(user2, "Shut Up"));
            post1.comments.Add(new Comment(user3, "No one cares what you think!"));

            Console.WriteLine($"Post: {post1.post}\nAuthor: {post1.author.username}\nPosted: {post1.timeStamp}\n");
            foreach (Comment comment in post1.comments)
            {
                Console.WriteLine($"        Comment: {comment.comment}\n      Author: {comment.author.username}\n      Posted: {comment.timeStamp}\n");
            }

            Post post2 = new Post(user1, "Everyone is so mean!");
            post2.comments.Add(new Comment(user2, "Its because we hate you"));
            post2.comments.Add(new Comment(user3, "You stink"));

            Console.WriteLine($"Post: {post2.post}\nAuthor: {post2.author.username}\nPosted: {post2.timeStamp}\n");
            foreach (Comment comment in post2.comments)
            {
                Console.WriteLine($"        Comment: {comment.comment}\n      Author: {comment.author.username}\n      Posted: {comment.timeStamp}\n");
            }

            //user class- to assign a role
            //post class - which is going to create the posts
            //comment class - going to be used to update actions on posts

            //METHODS
            //view posts
            //comment on posts
            //close or delete posts






        }
    }
}
