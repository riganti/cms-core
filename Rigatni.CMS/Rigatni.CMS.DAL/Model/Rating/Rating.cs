using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Rating
{
    public class Rating : IEntity<int>
    {
        public int Id { get; set; }

        public int SelectedValue { get; set; }
    }
}
