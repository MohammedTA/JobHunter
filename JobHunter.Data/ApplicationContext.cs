using JobHunter.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JobHunter.Data.Configuration;
using JobHunter.Data.Configuration.InitialDataConfiguration;

namespace JobHunter.Data
{
    public class ApplicationContext : IdentityDbContext<User, IdentityRole<int>,int>
    {
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CompanyRate> CompanyRates { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Messenger> Messengers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbersPayments { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<Vacancy> Vacancies { get; set; }
        public virtual DbSet<VacancyCommentRate> VacancyCommentRates { get; set; }
        public virtual DbSet<VacancyFeedback> VacancyFeedbacks { get; set; }
        public virtual DbSet<Response> Responses { get; set; }
        public virtual DbSet<VacancyComplaint> VacancyComplaints { get; set; }
        public virtual DbSet<OperationLog> OperationLogs { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<FavoriteResume> FavoriteResumes { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }



        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\projectsv13;Database=jobhunterdb;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=jobhunterdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ResumeCountryConfiguration());
            builder.ApplyConfiguration(new VacancyFeedbackConfiguration());

            //Initial Data Configurations

            builder.ApplyConfiguration(new LanguageInitialConfig());
            builder.ApplyConfiguration(new CountryInitialConfig());
            builder.ApplyConfiguration(new StatusInitialConfig());

            //
            builder.Entity<Profile>().HasOne(x => x.User).WithOne(y => y.Profile);
            
            //

            base.OnModelCreating(builder);
        }

    }
}
