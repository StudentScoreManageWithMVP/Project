using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;
namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile
{
    public interface IAdministratorPresenter<V>:IBasePresenter<V> where V:IAdministratorView
    {
        void Browse(int AdministratorId);
        void ModifyAInfo(Administrator administrator);
        void InsertInfo(Administrator administrator);
        //通过id获取管理员信息
        Administrator GetAdministratorById(int AdministratorId);
    }
}
