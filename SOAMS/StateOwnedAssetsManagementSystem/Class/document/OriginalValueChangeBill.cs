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
using System.Data;
using System.Data.SqlClient;

namespace StateOwnedAssetsManagementSystem.Class.document
{
    /// <summary>
    /// 原值变动单
    /// 业务发起者：院系管理员，归口管理员，部门管理员
    /// 审核序列：归口管理员，记账员
    /// </summary>
    public class OriginalValueChangeBill : Document
    {

    }
}
