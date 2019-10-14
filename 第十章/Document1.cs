using System;
using System.Collections.Generic;
using System.Text;

namespace 第十章
{
  public  class Document1
    {
        public string Title { get; private set; }
        public  string Content { get; private set; }
       
        public Document1(string title,string content)
        {
            this.Title = title;
            this.Content = content;
           
        }
    }
}
