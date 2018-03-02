using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Survey
{
    public class SurveyStatistic : IEntity<int>
    {
        public int Id { get; set; }
        public Survey Survey { get; set; }
        public SurveyQuestion SurveyQuestion { get; set; }
        public SurveyAnswer SurveyAnswer { get; set; }
        public bool AnsweredCorrect { get; set; }
    }
}
