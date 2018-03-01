using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.Core.Model.Article
{
    public class ArticleLabel : IEntity<int>
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public Article Article { get; set; }
        public Label Label { get; set; }
    }
}
