using Riganti.Utils.Infrastructure.Core;
using Rigatni.CMS.DAL.Model.Rating;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rigatni.CMS.Core.Model.Article
{
    public class Article : IEntity<int>
    {
        public int Id { get; set; }

        public ArticleVersion ArticleVersion { get; set; }

        [Column(TypeName = "text")]
        public string ArticleText { get; set; }

        public RatedItem Rating { get; set; }


        public ArticleLabel ArticleLabel { get; set; }
    }
}
