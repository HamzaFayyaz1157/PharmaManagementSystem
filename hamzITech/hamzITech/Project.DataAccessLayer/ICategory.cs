using hamzITech.Project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.DataAccessLayer
{
    public interface ICategory
    {
        ResponseViewModel Save(CategoryModel category);

        ResponseViewModel GetId();
    }
}
