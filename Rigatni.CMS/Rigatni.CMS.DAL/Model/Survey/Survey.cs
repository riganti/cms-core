using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Survey
{
    public class Survey : IEntity<int>
    {
        public int Id { get; set; }

        public List<SurveyQuestion> Questions { get; set; }

        public List<SurveyAnswer> Answers { get; set; }
    }
}
