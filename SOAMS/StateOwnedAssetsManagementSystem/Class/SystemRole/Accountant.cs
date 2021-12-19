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
    class Accountant : User
    {

        public Accountant(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public void Check(WarehouseEntry document, bool status)
        {
            document["Accountant"].Status = status;
            document.Voucher = DateTime.Now.ToFileTime().ToString();
        }

        public void Check(Document document, bool status, string reason)
        {
            document["Accountant"].Status = status;
            document["Accountant"].Reason = reason;
        }
    }
}
