using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.models
{
    public class ItemDiscountModel :  BaseModel 
    {
        public int DiscountId { get; set; }
        public int ItemId { get; set; }
        public int DiscountType { get; set; }
        public decimal? Value { get; set; }
        public decimal? Percentage { get; set; }
        public int? TargetQty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Remarks { get; set; }
        
    }
}
