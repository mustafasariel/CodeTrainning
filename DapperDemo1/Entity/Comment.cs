using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo1.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
     
    }
}
