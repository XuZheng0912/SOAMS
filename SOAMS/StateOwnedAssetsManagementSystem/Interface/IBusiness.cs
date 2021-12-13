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

namespace StateOwnedAssetsManagementSystem.Interface
{
    interface IBusiness
    {
        WarehouseEntry InitiateAssetWarehouse();
    }
}
