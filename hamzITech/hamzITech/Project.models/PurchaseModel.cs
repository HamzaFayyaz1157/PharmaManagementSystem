using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.models
{
    public class PurchaseModel : BaseModel
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int VendorId { get; set; }
        public string Remarks { get; set; }
        public int? StatusId { get; set; }


        public int PurchaseDetailId { get; set; }
        public int MasterId { get; set; }
        public int ItemId { get; set; }


        public DateTime ExpiryDate { get; set; }
        public decimal PurchaseQty { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SaleRate { get; set; }
        public decimal PurchaseTax { get; set; }
        public decimal AdditionTax { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
