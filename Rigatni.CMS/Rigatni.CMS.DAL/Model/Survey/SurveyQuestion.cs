using Riganti.Utils.Infrastructure.Core;
using System.Collections.Generic;

namespace Rigatni.CMS.DAL.Model.Survey
{
    public class SurveyQuestion : IEntity<int>
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<SurveyAnswer> Answers { get; set; }
        public int? CorrectAnswer { get; set; }

    }
}