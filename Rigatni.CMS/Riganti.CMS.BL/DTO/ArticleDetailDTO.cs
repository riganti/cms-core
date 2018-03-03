using Riganti.Utils.Infrastructure.Core;
using Rigatni.CMS.DAL.Model.Article;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Riganti.CMS.BL.DTO
{
    public class ArticleDetailDTO : IEntity<int>
    {
        public int Id { get; set; }
        public ArticleVersion ArticleVersion { get; set; }

        public string ArticleText { get; set; }

        public decimal Rating { get; set; }

        [UIHint("Image")]
        public string ThumbnailImageUrl { get; set; }

        public ArticleLabel ArticleLabel { get; set; }

        [DisplayFormat(DataFormatString = "g")]
        public DateTime? PublishedDate { get; set; }
    }
}
