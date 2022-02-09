using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class WPPContext : DbContext
    {
        public WPPContext(DbContextOptions<WPPContext> options) : base(options)
        {
        }
        public DbSet<Item> Item { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Format> Format { get; set; }

        /// <summary>
        /// Overriding OnModelCreating to let ef know about our entities configs
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Format>().HasData(new Format[] {
                new Format {FormatId = 1, Name = "On-demand Videos"},
                new Format {FormatId = 2, Name = "Events and Webinars"},
                new Format {FormatId = 3, Name = "Articles and eBooks"},
                new Format {FormatId = 4, Name = "Immersion Workshops"},
                new Format {FormatId = 5, Name = "Technical Training"},
                new Format {FormatId = 6, Name = "End User Training"},
            });
            modelBuilder.Entity<Category>().HasData(new Category[] {
                new Category {CategoryId = 1, Name = "Hybrid Work"},
                new Category {CategoryId = 2, Name = "Hybrid Work Research"},
                new Category {CategoryId = 3, Name = "Modern Collaboration"},
                new Category {CategoryId = 4, Name = "Employee Experience"},
                new Category {CategoryId = 5, Name = "Next Gen Endpoints and Devices"},
            });
            modelBuilder.Entity<Item>().HasData(new Item[] {
                new Item {
                    ItemId = 1, 
                    Title = "The effects of remote work on collaboration among information workers",
                    Description = "Learn about the lasting impact of remote work on collaboration work patterns.", 
                    Image = "", 
                    Link = "", 
                    CategoryId = 1, 
                    FormatId = 1
                },
                new Item {
                    ItemId = 2, 
                    Title = "Sign up for Microsoft Teams Connect", 
                    Description = "Sign up for Teams Connect to collaborate seamlessly in the same digital environment with anyone, wether inside or outside your organization.", 
                    Image = "", 
                    Link = "", 
                    CategoryId = 2, 
                    FormatId = 2
                },
                new Item {
                    ItemId = 3, 
                    Title = "Empowering Hybrid Work for Brands & Retailers", 
                    Description = "Learn how Microsoft is partnering with leading brands and retailers from across the globe on their hybrid work journeys.", 
                    Image = "", 
                    Link = "", 
                    CategoryId = 3, 
                    FormatId = 3
                },
                new Item {
                    ItemId = 4, 
                    Title = "Digitizing hybrid Work processes", 
                    Description = "Learn how you can use collaborative apps to simplify and streamline business processes.", 
                    Image = "", 
                    Link = "", 
                    CategoryId = 4, 
                    FormatId = 4
                },
                new Item {
                    ItemId = 5, 
                    Title = "Hybrid Windows for a Hybrid World", 
                    Description = "Learn more about Windows 365, see a product demo, and discover the opportunities that Cloud OC presents in the hybrid workplace.", 
                    Image = "", 
                    Link = "", 
                    CategoryId = 5, 
                    FormatId = 5
                },
                new Item {
                    ItemId = 6, 
                    Title = "Modernizing Endpoints in the Digital Estate", 
                    Description = "Explore the key principles behind Microsoft's approach to modern endpoints and the learn why endpoint management and compliance is essential to your Zero Trust security journey.", 
                    Image = "", 
                    Link = "", 
                    CategoryId = 1, 
                    FormatId = 6
                },
            });
        }
    }
}
