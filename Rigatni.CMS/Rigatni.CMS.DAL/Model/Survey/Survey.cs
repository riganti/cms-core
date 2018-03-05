using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Survey
{
    public class Survey : IEntity<int>
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public List<SurveyQuestion> Questions { get; set; }

    }
}
