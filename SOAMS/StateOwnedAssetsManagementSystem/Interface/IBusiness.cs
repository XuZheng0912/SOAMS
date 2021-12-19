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

namespace StateOwnedAssetsManagementSystem.Interface
{
    interface IBusiness
    {
        //发起资产入库业务
        WarehouseEntry InitiateAssetWarehouse(string type, string name, double value, string keeper);
        //发起资产申购业务
        PurchaseOrder InitiateAssetPurchase();
        //发起部门调拨业务
        DepartmentAllotment InitiateDepartmentAllotment();
        //发起归口调拨业务
        CentralAllotment InitiateCentralAllotment();
        //发起原值变动业务
        OriginalValueChangeBill InitiateOriginalValueChangeBill();
        //发起资产处置业务
        AssetDisposalBill InitiateAssetDisposalBill();
        //登记本院系部门
        void CollegeDepartmentRegistr();
        //登记本院系人员
        void CollegeStaffRegistr();
        //登记本院系资产保管人
        void CollegeKeeperRegistr();
        //审核单据
        void Check();
        //资产统计
        void AssetStatistics();
        //资产查询
        void AssetsInquiry();
    }
}
