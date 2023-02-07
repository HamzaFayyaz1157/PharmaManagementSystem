using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.models
{
    public class BaseModel
    {
        public string CreatedBy { get; set; }
        public int CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public decimal UpdateOn { get; set; }

        public bool ValidFlag { get; set; }
    }
}
