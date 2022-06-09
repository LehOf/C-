using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Postt
    {
    
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Conent { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Postt()
        {

        }

        public Postt(DateTime Moment, string Title, string Conent, int Likes)
        {
            this.Moment = Moment;
            this.Title = Title;
            this.Conent = Conent;
            this.Likes = Likes;

        }

        public void AddComments(Comment comments)
        {
            Comments.Add(comments);

        }

        public void RemoveComments(Comment comments)
        {
            Comments.Remove(comments);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Comments: ");

            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}


