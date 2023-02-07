using hamzITech.Project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.DataAccessLayer
{
    public interface ICompany
    {
        ResponseViewModel Save(CompanyModel company);

        ResponseViewModel GetId();
    }
}
