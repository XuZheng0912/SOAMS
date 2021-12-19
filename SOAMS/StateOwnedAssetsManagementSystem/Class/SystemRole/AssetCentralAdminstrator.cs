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
    /// 资产归口管理员
    /// </summary>
    class AssetCentralAdminstrator : User
    {

        public AssetCentralAdminstrator(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public override PurchaseOrder InitiateAssetPurchase()
        {
            return base.InitiateAssetPurchase();
        }

        public override WarehouseEntry InitiateAssetWarehouse(string type, string name, double value, string keeper)
        {
            return base.InitiateAssetWarehouse(type, name, value, keeper);
        }

        public override OriginalValueChangeBill InitiateOriginalValueChangeBill()
        {
            return base.InitiateOriginalValueChangeBill();
        }

        public override CentralAllotment InitiateCentralAllotment()
        {
            return base.InitiateCentralAllotment();
        }

        public override void Check()
        {
            base.Check();
        }

        public override void AssetStatistics()
        {
            base.AssetStatistics();
        }

        public override void AssetsInquiry()
        {
            base.AssetsInquiry();
        }
    }
}
