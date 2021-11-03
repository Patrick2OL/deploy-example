using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerapicFisicHelper.Data.Mapping;
using TerapicFisicHelper.Entities;

namespace TerapicFisicHelper.Data
{
    public class DbContextTerapicFisicHelperApp : DbContext
    {
        public DbContextTerapicFisicHelperApp(DbContextOptions<DbContextTerapicFisicHelperApp> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Equipament> Equipaments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<EquipamentSession> EquipamentSessions { get; set; }
        public DbSet<TagSession> TagSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new EquipamentMap());
            modelBuilder.ApplyConfiguration(new EquipamentSessionMap());
            modelBuilder.ApplyConfiguration(new HistoryMap());
            modelBuilder.ApplyConfiguration(new ReviewMap());
            modelBuilder.ApplyConfiguration(new SessionMap());
            modelBuilder.ApplyConfiguration(new SpecialistMap());
            modelBuilder.ApplyConfiguration(new SubscriptionMap());
            modelBuilder.ApplyConfiguration(new SubscriptionPlanMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new TagSessionMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
