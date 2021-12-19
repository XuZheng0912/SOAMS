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
    /// 申购单类
    /// 审核序列：CollegeAuthority，BudgetCentralAuthority，FinanceAuthority，UniversityAssetSpecificAuthority or UniversityAuthority
    /// </summary>
    public class PurchaseOrder : Document
    {
        public PurchaseOrder(string department, int amount, double value)
        {
            Department = department;
            Amount = amount;
            Value = value;
        }

        public PurchaseOrder(User user, string department, int amount, double value) : this(department, amount, value)
        {
            Number = DateTime.Now.ToFileTime().ToString();
            Initiator = user.Name;
            Date = DateTime.Now.ToString();
            CheckStatuses = InitializeCheckStatuses();
        }

        public string Department { get; set; }
        public int Amount { get; set; }
        public double Value { get; set; }

        private new List<CheckStatus> InitializeCheckStatuses()
        {
            List<CheckStatus> checkStatuses = new List<CheckStatus>();
            checkStatuses.Add(new CheckStatus("CollegeAuthority", false));
            checkStatuses.Add(new CheckStatus("BudgetCentralAuthority", false));
            checkStatuses.Add(new CheckStatus("FinanceAuthority", false));
            checkStatuses.Add(new CheckStatus("UniversityAssetSpecificAuthority", false));
            checkStatuses.Add(new CheckStatus("UniversityAuthority", false));
            return checkStatuses;
        }
    }

    /// <summary>
    /// 申购明细
    /// </summary>
    public class PurchaseDetial
    {
        public PurchaseDetial(string type, string name, double value, string keeper)
        {
            Type = type;
            Name = name;
            Value = value;
            Keeper = keeper;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Keeper { get; set; }

    }
}
