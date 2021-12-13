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
    /// 各部门设立的专职或兼职固定资产管理员
    /// </summary>
    class DepartmentAdminstrtor : User
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
            return new WarehouseEntry(this, type, name, value, keeper);
        }
    }
}
