using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.CourseFile
{
    public interface ICoursePresenter<V>:IBasePresenter<V> where V:ICourseView
    {
    }
}
