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

namespace StateOwnedAssetsManagementSystem.Class.document
{
    /// <summary>
    /// 入库单类
    /// 业务发起人：保管人，院系管理员，归口管理员，部门管理员
    /// 审核序列：AssetCentralAdminstrator，Accountant
    /// </summary>
    public class WarehouseEntry : Document
    {

        private string type;
        private string name;
        private double value;
        private string keeper;
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
                //单据发起人User作为参数传入构造函数，用户名字即单据发起人姓名
            this.Date = DateTime.Now.ToString();
                //获取制单日期
            this.CheckStatuses = this.InitializeCheckStatuses();
                //初始化审核人表
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
