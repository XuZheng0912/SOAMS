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

namespace StateOwnedAssetsManagementSystem.Class
{
    public class User : IBusiness
    {
        private string number;
        private string name;
        private string college;
        private string department;

        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public string College { get => college; set => college = value; }
        public string Department { get => department; set => department = value; }

        public virtual WarehouseEntry InitiateAssetWarehouse(string type, string name, double value, string keeper)
        {
            throw new NotImplementedException();
        }

        public virtual PurchaseOrder InitiateAssetPurchase()
        {
            throw new NotImplementedException();
        }

        public virtual CentralAllotment InitiateCentralAllotment()
        {
            throw new NotImplementedException();
        }

        public virtual DepartmentAllotment InitiateDepartmentAllotment()
        {
            throw new NotImplementedException();
        }

        public virtual OriginalValueChangeBill InitiateOriginalValueChangeBill()
        {
            throw new NotImplementedException();
        }

        public virtual void CollegeDepartmentRegistr()
        {
            throw new NotImplementedException();
        }

        public virtual void CollegeStaffRegistr()
        {
            throw new NotImplementedException();
        }

        public virtual void CollegeKeeperRegistr()
        {
            throw new NotImplementedException();
        }

        public virtual AssetDisposalBill InitiateAssetDisposalBill()
        {
            throw new NotImplementedException();
        }

        public virtual void Check()
        {
            throw new NotImplementedException();
        }

        public virtual void AssetStatistics()
        {
            throw new NotImplementedException();
        }

        public virtual void AssetsInquiry()
        {
            throw new NotImplementedException();
        }
    }
}
