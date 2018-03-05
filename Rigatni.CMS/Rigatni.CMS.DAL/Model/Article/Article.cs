using Riganti.Utils.Infrastructure.Core;
using Rigatni.CMS.DAL.Model.Rating;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Article
{
    public class Article : IEntity<int>
    {
        public int Id { get; set; }

        public string ArticleTitle { get; set; }

        [Column(TypeName = "text")]
        public string  ArticleLead { get; set; }

        [Column(TypeName = "text")]
        public string ArticleText { get; set; }

        public RatedItem Rating { get; set; }

        public string ThumbnailImageUrl { get; set; }

        public List<ArticleLabel> ArticleLabel { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}
