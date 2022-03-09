using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class LinkContext : DbContext
    {
        public DbSet<Links> Links { get; set; }
        public DbSet<BidLink> Bids { get; set; }


    }
}