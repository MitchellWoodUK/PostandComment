using System;
using System.Collections.Generic;
using System.Text;

namespace PostandComment
{
    public class Comment
    {
        public User author;
        public string comment;
        public DateTime timeStamp;

        public Comment(User Author, string Comment)
        {
            this.author = Author;
            this.comment = Comment;
            this.timeStamp = DateTime.Now;
        }
    }
}
