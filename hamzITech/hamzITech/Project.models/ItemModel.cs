using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.models
{
    public class ItemModel : BaseModel
    {
        public int ItemId { get; set; }
        public int? PakingTypeId { get; set; }
        public int StoreId { get; set; }
        public int? CategoryId { get; set; }
        public int? ReOrderQty { get; set; }
        public string Rack { get; set; }
        public int? Strip { get; set; }
        public string Shelf { get; set; }


        public int? CortonUnit { get; set; }
        public int? CompanyId { get; set; }
        public string Description { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? TradePrice { get; set; }
        public int? IsDiscount { get; set; }
        public decimal? PurchaseDiscount { get; set; }
    }
}
