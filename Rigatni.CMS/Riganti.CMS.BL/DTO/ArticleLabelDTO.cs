using System;
using System.Collections.Generic;
using System.Text;

namespace Riganti.CMS.BL.DTO
{
    public class ArticleLabelDTO 
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int ArticleId { get; set; }
        public string LabelKey { get; set; }
    }
}
