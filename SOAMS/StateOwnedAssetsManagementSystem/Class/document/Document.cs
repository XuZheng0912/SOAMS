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
    /// 所有单据的父类
    /// 以空方法体实现IDocumentCheck接口便于子类继承
    /// </summary>
    public class Document : IDocumentCheck
    {

        private string number;
        private string initiator;
        private string date;
        private List<CheckStatus> checkStatuses;

        public string Number { get => number; set => number = value; }
        public string Initiator { get => initiator; set => initiator = value; }
        public string Date { get => date; set => date = value; }
        public List<CheckStatus> CheckStatuses { get => checkStatuses; set => checkStatuses = value; }

        public CheckStatus this[string index]
        {
            get
            {
                for (int i = 0; i < CheckStatuses.Count; i++)
                {
                    if (CheckStatuses[i].Checker == index)
                    {
                        return CheckStatuses[i];
                    }
                }
                return null;
            }
        }

        public bool Check()
        {
            throw new NotImplementedException();
        }

        public List<bool> InitializeCheckStatuses()
        {
            throw new NotImplementedException();
        }

        public User LastChecker()
        {
            throw new NotImplementedException();
        }

        public User NextChecker()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 审核状态类
    /// </summary>
    public class CheckStatus
    {
        public string Checker { get; set; }
        public bool Status { get; set; }
        public string Reason { get; set; }

        public CheckStatus(string checker, bool status)
        {
            Checker = checker;
            Status = status;
        }
    }
}
