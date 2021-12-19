using StateOwnedAssetsManagementSystem.Class.document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateOwnedAssetsManagementSystem.Class.SystemRole
{
    public class AssetDisposalAdminstrator : User
    {
        public AssetDisposalAdminstrator(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public override AssetDisposalBill InitiateAssetDisposalBill()
        {
            return base.InitiateAssetDisposalBill();
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
