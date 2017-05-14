using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.CourseFile
{
    public interface ICoursePresenter<V>:IBasePresenter<V> where V:ICourseView
    {
        //获取单个课程信息
        Course GetCourseById(int CourseId);
        //课程添加
        void CourseAdd(Course course);
        //课程信息修改
        void CourseInfoModify(Course course);
        //课程删除
        void CourseDeleteById(int CourseId);
    }
}
