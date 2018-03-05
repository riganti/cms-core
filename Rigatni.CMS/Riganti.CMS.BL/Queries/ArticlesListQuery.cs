using Riganti.CMS.BL.DTO;
using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riganti.CMS.BL.Queries
{
    public class ArticlesListQuery : AppQueryBase<ArticlesListDTO>
    {
        public ArticlesListQuery(IUnitOfWorkProvider provider) : base(provider)
        {
        }

        protected override IQueryable<ArticlesListDTO> GetQueryable()
        {
            return Context.Articles.Select(a => new ArticlesListDTO() { ShortArticleText = a.ArticleText });
        }
    }
}
