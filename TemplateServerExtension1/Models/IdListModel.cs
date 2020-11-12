using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateServerExtension1.Models
{
    public class IdListModel
    {
        public IList<Guid> idList { get; set; }
        public string stateName { get; set; }
    }
}