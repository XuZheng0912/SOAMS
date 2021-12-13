using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateOwnedAssetsManagementSystem;
using StateOwnedAssetsManagementSystem.Class;
using StateOwnedAssetsManagementSystem.Class.Asset;
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

        /// <summary>
        /// 发起资产入库业务
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="keeper"></param>
        /// <returns></returns>
        public WarehouseEntry InitiateAssetWarehouse(string type, string name, double value, string keeper)
        {
            WarehouseEntry warehouseEntry = new WarehouseEntry(this, type, name, value, keeper);
            Check(warehouseEntry, true);
            return warehouseEntry;
        }

        public void Check(Document document, bool status)
        {
            document["AssetCentralAdminstrator"].Status = status;
        }

        public void Check(Document document, bool status, string reason)
        {
            document["AssetCentralAdminstrator"].Status = status;
            document["AssetCentralAdminstrator"].Reason = reason;
        }
    }
}
