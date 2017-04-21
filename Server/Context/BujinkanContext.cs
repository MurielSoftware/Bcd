using Server.Model;
using Shared.Core.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Context
{
    public class BujinkanContext : DbContext, IDatabaseContext
    {
        private const string DB_CONTEXT_NAME = "d002747";

        public DbSet<Actuality> Actualities { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Dojo> Dojos { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDefinable> UserDefinables { get; set; }
        public DbSet<Vocabulary> Vocabularies { get; set; }

        public BujinkanContext()
            : base(DB_CONTEXT_NAME)
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.AutoDetectChangesEnabled = false;

#if DEBUG
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BujinkanContext>());
#endif
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Map<BlogCategory>(m => m.Requires("Discriminator").HasValue(BlogCategory.DISC))
                .Map<LinkCategory>(m => m.Requires("Discriminator").HasValue(LinkCategory.DISC))
                .Map<ProductCategory>(m => m.Requires("Discriminator").HasValue(ProductCategory.DISC));

            modelBuilder.Entity<Event>()
                .Map<PublicEvent>(m => m.Requires("Discriminator").HasValue(PublicEvent.DISC))
                .Map<Seminar>(m => m.Requires("Discriminator").HasValue(Seminar.DISC));

            modelBuilder.Entity<Event>()
                .HasMany(x => x.Users)
                .WithMany(y => y.Events)
                .Map(m =>
                {
                    m.ToTable("USER_EVENT");
                    m.MapLeftKey("EventId");
                    m.MapRightKey("UserId");
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
