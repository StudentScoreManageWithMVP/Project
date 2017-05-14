using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.StudentScoreFile
{
    public interface IStudentScorePresenter<V>:IBasePresenter<V> where V:IStudentScoreView
    {
    }
}
