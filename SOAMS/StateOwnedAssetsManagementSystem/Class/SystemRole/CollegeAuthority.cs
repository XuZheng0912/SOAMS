using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateOwnedAssetsManagementSystem;
using StateOwnedAssetsManagementSystem.Class;
using StateOwnedAssetsManagementSystem.Class.document;
using StateOwnedAssetsManagementSystem.Class.Entity;
using StateOwnedAssetsManagementSystem.Class.SystemRole;
using StateOwnedAssetsManagementSystem.Interface;

namespace StateOwnedAssetsManagementSystem.Class.SystemRole
{
    class CollegeAuthority : User
    {

        public void Check(PurchaseOrder document, bool status)
        {
            document["CollegeAuthority"].Status = status;
        }

        public void Check(PurchaseOrder document, bool status, string reason)
        {
            document["CollegeAuthority"].Status = status;
            document["CollegeAuthority"].Reason = reason;
        }
    }
}
