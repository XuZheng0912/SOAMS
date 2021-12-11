using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateOwnedAssetsManagementSystem.Class.Asset
{
    class GodownEntry
    {
        private readonly string number;
        private readonly string documentMakeDate;

        private string mode;
        private string warehouseDate;
        private string name;
        private string specificationModel;
        private int quantity;
        private double originalValue;
        private string department;
        private string central;
        private string acquisitionDate;
        private string voucher; //记账凭证
        private string contractNumber;
        private string invoiceNumber;
        private string supplier;
        private string documentMaker;

        private bool centralCheck;  //归口审核结果
        private bool AccountChecj;  //记账审核结果
    }
}
