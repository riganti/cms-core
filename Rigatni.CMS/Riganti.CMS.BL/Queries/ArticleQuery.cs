using AutoMapper.QueryableExtensions;
using Riganti.CMS.BL.DTO;
using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riganti.CMS.BL.Queries
{
    public class ArticleQuery : AppQueryBase<ArticleDTO>
    {
        public ArticleQuery(IUnitOfWorkProvider provider) : base(provider)
        {
        }

        public List<ArticleLabelDTO> Labels { get; set; } = new List<ArticleLabelDTO>();
        protected override IQueryable<ArticleDTO> GetQueryable()
        {
            var query = Context.Articles.ProjectTo<ArticleDTO>();

            //check label value and key 
            query = query.Where(a => Labels.Any(l => a.ArticleLabel.Label.Key == l.LabelKey && a.ArticleLabel.Value == l.Value));

            return query;
        }
    }
}
