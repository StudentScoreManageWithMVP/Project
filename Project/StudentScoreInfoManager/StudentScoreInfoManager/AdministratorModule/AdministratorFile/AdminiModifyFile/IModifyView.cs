using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiModifyFile
{
    public interface IModifyView:IAdministratorView
    {
        //修改成功时进行页面跳转
        void ModifySuccessful();
        //修改成功时对session中存储中的Administrator进行修改
        void ModifySession(Administrator admini);
    }
}
