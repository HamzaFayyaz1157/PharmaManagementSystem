using hamzITech.Project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.DataAccessLayer
{
    public interface Iitem
    {
        ResponseViewModel Save(ItemModel item);
        ResponseViewModel SaveDiscount(ItemDiscountModel Discount);

        ResponseViewModel GetId();
    }
}
