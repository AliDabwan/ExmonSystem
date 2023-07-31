using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
    public class MyDbContext:DbContext
    {
        //public MyDbContext():base(Properties.Settings.Default.ConType=="Server"?"name=cn": "name=cn")
        public MyDbContext():base(Properties.Settings.Default.ConName)
        {
            //Database.CreateIfNotExists();

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDbContext, Migrations.Configuration>());

            //using (MyDbContext temp = new MyDbContext())
            //{
            //    temp.Dat abase.Initialize(true);
            //}
            //Database.SetInitializer<MyDbContext>(new CreateDatabaseIfNotExists<MyDbContext>());
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //   // modelBuilder.Entity<Bill>()
        //   //     .HasOptional<Accounts>(d => d.fromAccount)
        //   //          .WithOptionalDependent()
        //   //  .WillCascadeOnDelete(false);


        //   // modelBuilder.Entity<Bill>()
        //   //   .HasOptional<Accounts>(d => d.toAccount)
        //   //        .WithOptionalDependent()
        //   //.WillCascadeOnDelete(false);



        //    //modelBuilder.Entity<Bill>()
        //    // .HasOptional(d => d.ToAccount)
        //    //         .WithOptionalDependent()
        //    // .WillCascadeOnDelete(false);
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }





     
        public DbSet<RollNames> RollName { get; set; }
        public DbSet<RollGroups> RollGroup { get; set; }
        public DbSet<Rolls> Roll { get; set; }
        public DbSet<User> Users { get; set; }



        public DbSet<AccountsLabels> accountsLabel { get; set; }
        public DbSet<Accounts> account { get; set; }
     

        public DbSet<AccountsTransactionSub> AccountsTransactionSubs { get; set; }

      
        public DbSet<myVersionInfo> MyVersionInfo { get; set; }

        public DbSet<Company> companies { get; set; }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<CompanyTorism> CompanyTorisms { get; set; }
        public DbSet<ItemGover> ItemGovers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<AirLine> AirLines { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<ExCompany> ExCompanies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderSub> OrderSubs { get; set; }




    }
}
