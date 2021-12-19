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
    /// <summary>
    /// 各部门设立的专职或兼职固定资产管理员
    /// </summary>
    class DepartmentAdminstrtor : User
    {

        public override PurchaseOrder InitiateAssetPurchase()
        {

        }

        public override WarehouseEntry InitiateAssetWarehouse(string type, string name, double value, string keeper)
        {
            return new WarehouseEntry(this, type, name, value, keeper);
        }

        public override DepartmentAllotment InitiateDepartmentAllotment()
        {

        }

        public override AssetDisposalBill InitiateAssetDisposalBill()
        {

        }

        public override OriginalValueChangeBill InitiateOriginalValueChangeBill()
        {

        }

        public override void Check()
        {

        }

        public override void AssetStatistics()
        {

        }

        public override void AssetsInquiry()
        {

        }
    }
}
