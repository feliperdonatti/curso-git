using System;
using System.Collections.Generic;
using System.Text;

namespace Cap9StringBuilder.Entities
{
    class Comment
    {
        public String Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
