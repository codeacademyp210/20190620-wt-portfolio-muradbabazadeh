using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adam.Models
{
    public class HeaderSection
    {
        public int Id { get; set; }
        public string Headerh1 { get; set; }
        public string Paragraph { get; set; }
        public string Title { get; set; }
        public string TopSpan { get; set; }
        public string MiddleSpan { get; set; }
        
        public string ProfileImg { get; set; }
        public string RightImg { get; set; }

        internal void ForEach(object p)
        {
            throw new NotImplementedException();
        }
    }
}