using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Article
{
    public class ArticleVersion : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }

        public Language Language { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
