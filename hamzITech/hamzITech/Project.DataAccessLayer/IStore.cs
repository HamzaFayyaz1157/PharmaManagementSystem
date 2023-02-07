using hamzITech.Project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.DataAccessLayer
{
    public interface IStore
    {
        ResponseViewModel Save(StoreModel store);

        ResponseViewModel GetId();
    }
}
