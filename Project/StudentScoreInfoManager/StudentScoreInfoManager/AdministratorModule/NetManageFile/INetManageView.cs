using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.NetManageFile
{
    public interface INetManageView:IBaseView
    {
        //修改成功的界面提示
        void ModifySuccess();
    }
}
