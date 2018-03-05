using Microsoft.EntityFrameworkCore;
using Rigatni.CMS.DAL.Model.Article;
using Rigatni.CMS.DAL.Model.FileStore;
using Rigatni.CMS.DAL.Model.Survey;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.DAL
{
    public class CmsDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<FileStore> FileStores { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyStatistic> SurveyStatistics { get; set; }

        public CmsDbContext(DbContextOptions options) : base(options)
        {

        }

        public CmsDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CMS");
        }
    }
}
