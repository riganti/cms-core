using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rigatni.CMS.DAL.Model.Article
{
    public class Label : IEntity<int>
    {
        public int Id { get; set; }
        public string Key { get; set; }
    }
}
