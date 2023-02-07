using hamzITech.Project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.DataAccessLayer
{
    public interface IPackingType
    {
        ResponseViewModel Save(PackingTypeModel packingType);

        ResponseViewModel GetId();
    }
}
