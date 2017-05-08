using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.NetManageFile
{
    public interface INetManagePresenter<V>:IBasePresenter<V> where V:INetManageView
    {
        //上传修改内容
        void NoticeModify(Notice notice);
    }
}
