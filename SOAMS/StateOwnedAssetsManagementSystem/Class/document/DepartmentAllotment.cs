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
    /// 部门调拨单
    /// 内部调拨：院系内部门或保管人发生变化无需审核
    /// 业务发起人：DepartmentAdminstrtor，CollegeAdminstrator
    /// 审核序列：调出方院系领导，资产归口管理员，调入方院系管理员，调入方院系领导
    /// 审核序列：无
    /// </summary>
    public class DepartmentAllotment : Document
    {

    }
}
