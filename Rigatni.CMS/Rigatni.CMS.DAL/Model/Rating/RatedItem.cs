using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Rating
{
    public class RatedItem : IEntity<int>
    {
        public int Id { get; set; }
        public List<Rating> Ratings { get; set; }
        public int MaximumValue { get; set; }
        public int MinimumValue { get; set; }
    }

}
