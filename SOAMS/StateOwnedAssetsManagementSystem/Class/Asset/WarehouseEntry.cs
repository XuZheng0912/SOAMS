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

namespace StateOwnedAssetsManagementSystem.Class.Asset
{
    class WarehouseEntry : Document
    {
        private string type;    //类型可有用户动态创建
        private string name;    //资产名称
        private double value;   //资产价值
        private string keeper;  //资产保管人
        private string voucher;

        public WarehouseEntry(string type, string name, string keeper, double value)
        {
            this.Type = type;
            this.Name = name;
            this.Keeper = keeper;
            this.Value = value;
        }

        public WarehouseEntry(User user, string type, string name, double value, string keeper) : this(type, name, keeper, value)
        {
            this.Number = DateTime.Now.ToFileTime().ToString();
                //获取系统时间的纳秒形式作为编号，几乎无重复
            this.Initiator = user.Name;
            this.Date = DateTime.Now.ToString();
            this.CheckStatuses = this.InitializeCheckStatuses();
        }

        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public double Value { get => value; set => this.value = value; }
        public string Keeper { get => keeper; set => keeper = value; }
        public string Voucher { get => voucher; set => voucher = value; }

        /// <summary>
        /// 初始化审核序列
        /// 审核序列：归口管理员，记账员
        /// </summary>
        /// <returns></returns>
        private new List<CheckStatus> InitializeCheckStatuses()
        {
            List<CheckStatus> checkStatuses = new List<CheckStatus>();
            checkStatuses.Add(new CheckStatus("AssetCentralAdminstrator", false));
            checkStatuses.Add(new CheckStatus("Accountant", false));
            return checkStatuses;
        }
    }
}
