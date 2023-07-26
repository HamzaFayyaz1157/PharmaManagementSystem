using hamzITech.Project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.DataAccessLayer
{
    public interface IPurchase
    {
        ResponseViewModel Save(PurchaseModel Purchase);
        //ResponseViewModel SaveDiscount(PurchaseDiscountModel Discount);

        ResponseViewModel GetId();
    }
}
