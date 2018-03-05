using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Article
{
    public class ArticleLabel : IEntity<int>
    {
        public int Id { get; set; }
        public string Value { get; set; }
        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
        [ForeignKey("LabelId")]
        public virtual Label Label { get; set; }
    }
}
