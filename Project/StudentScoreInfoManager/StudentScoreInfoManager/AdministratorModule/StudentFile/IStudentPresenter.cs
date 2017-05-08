using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile
{
    public interface IStudentPresenter<V>:IBasePresenter<V> where V:IStudentView
    {
        //浏览学生信息
        void GetStudentInfo(int StuentId);
        //修改学生信息
        void ModifyStduentInfo(Student student);
        //学生注册
        void StudentRegiste(Student student);
        //学生删除
        void StudentDelete(int StudentId);
        //学生信息查询
        void StudentQuery();
    }
}
