using Rigatni.CMS.DAL.Model.Article;
using Rigatni.CMS.DAL.Model.Rating;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Riganti.CMS.BL.DTO
{
    public class ArticlesListDTO
    {
        public int Id { get; set; }

        public string ShortArticleText { get; set; }

        public decimal Rating { get; set; }

        [UIHint("Image")]
        public string ThumbnailImageUrl { get; set; }

        public ArticleLabel ArticleLabel { get; set; }

        [DisplayFormat(DataFormatString = "g")]
        public DateTime? PublishedDate { get; set; }
    }
}
