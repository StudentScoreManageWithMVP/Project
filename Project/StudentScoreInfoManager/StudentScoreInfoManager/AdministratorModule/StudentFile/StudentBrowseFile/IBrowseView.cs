using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile.StudentBrowseFile
{
    public interface IBrowseView:IStudentView
    {
        void ShowStudentInfo(Student student);
    }
}
