using Riganti.CMS.BL.DTO;
using Riganti.CMS.BL.Queries;
using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.Services.Facades;
using Rigatni.CMS.DAL.Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riganti.CMS.BL.Facades
{
    public class ArticlesFacade : AppCrudFacadeBase<Article, int, ArticlesListDTO, ArticleDetailDTO>
    {
        public ArticlesFacade(Func<ArticlesListQuery> query, IRepository<Article, int> repository, IEntityDTOMapper<Article, ArticleDetailDTO> mapper) : base(query, repository, mapper)
        {
        }

        public override ArticleDetailDTO Save(ArticleDetailDTO detail)
        {
            //detect changes and save as new version
            if (ChangesDetected(detail))
            {
                //TODO
            }
            return base.Save(detail);
        }

        private bool ChangesDetected(ArticleDetailDTO detail)
        {
            //TODO
            return false;
        }
    }
}
