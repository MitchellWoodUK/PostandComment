using System;
using System.Collections.Generic;
using System.Text;

namespace PostandComment
{
    public class Post
    {
        public User author;
        public string post;
        public DateTime timeStamp;
        public List<Comment> comments;

        //set active status
        public bool isOpen;

        public Post(User Author, string Comment)
        {
            this.author = Author;
            this.post = Comment;
            this.timeStamp = DateTime.Now;
            this.isOpen = true;
            this.comments = new List<Comment>();
        }

        //insert methods
    }
}
