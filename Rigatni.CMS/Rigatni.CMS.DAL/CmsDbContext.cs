using Microsoft.EntityFrameworkCore;
using Rigatni.CMS.DAL.Model.Article;
using Rigatni.CMS.DAL.Model.FileStore;
using Rigatni.CMS.DAL.Model.Rating;
using Rigatni.CMS.DAL.Model.Survey;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.DAL
{
    public class CmsDbContext : DbContext
    {
        //Articles section
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleLabel> ArticleLabels { get; set; }
        public DbSet<ArticleVersion> ArticleVersions { get; set; }
        public DbSet<Label> Labels { get; set; }

        //Files section
        public DbSet<FileStore> FileStores { get; set; }
        public DbSet<FileStoreItem> FileStoreItems { get; set; }
        public DbSet<FileVersion> FileVersions { get; set; }

        //Surveys section
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyStatistic> SurveyStatistics { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }

        //Rating section
        public DbSet<RatedItem> RatedItems { get; set; }


        public CmsDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CMS");
        }
    }
}
