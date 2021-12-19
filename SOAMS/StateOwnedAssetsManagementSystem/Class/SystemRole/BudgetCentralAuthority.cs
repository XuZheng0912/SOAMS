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
    class BudgetCentralAuthority : User
    {
        public void Check(PurchaseOrder document, bool status)
        {
            document["BudgetCentralAuthority"].Status = status;
        }

        public void Check(PurchaseOrder document, bool status, string reason)
        {
            document["BudgetCentralAuthority"].Status = status;
            document["BudgetCentralAuthority"].Reason = reason;
        }
    }

}
