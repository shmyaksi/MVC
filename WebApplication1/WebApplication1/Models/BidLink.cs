using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BidLink
    {
        public int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Link { get; set; }
    }
}