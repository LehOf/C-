﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Course.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }

        public Comment(string Text) {
            this.Text = Text;
        }
    }
}
