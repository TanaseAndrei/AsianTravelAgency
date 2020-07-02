using AsianTravelAgency.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AsianTravelAgency
{
    public class AsianTravelAgencyContext : DbContext
    {
        public AsianTravelAgencyContext(DbContextOptions<AsianTravelAgencyContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<AboutUsPost> AboutUsPostSet { get; set; }
        
        public DbSet<FAQ> FAQSet { get; set; }

        public DbSet<Pictures> PictureSet { get; set; }

        public DbSet<Post> PostSet { get; set; }

        public DbSet<Prices> PriceSet { get; set; }

        public DbSet<User> UserSet { get; set; }
    }
}
