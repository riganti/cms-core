using Riganti.Utils.Infrastructure.Core;

namespace Rigatni.CMS.DAL.Model.Survey
{
    public class SurveyAnswer : IEntity<int>
    {
        public int Id { get; set; }
        public string Text { get; set; }

    }
}