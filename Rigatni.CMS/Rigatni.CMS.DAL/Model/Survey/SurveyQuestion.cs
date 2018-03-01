using Riganti.Utils.Infrastructure.Core;

namespace Rigatni.CMS.DAL.Model.Survey
{
    public class SurveyQuestion : IEntity<int>
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}