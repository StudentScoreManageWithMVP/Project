using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile
{
    public class StudentView:BaseView,IStudentView
    {
        public bool IsAdministratorLogined()
        {
            if (Session["AdminiId"] == null)
                return false;
            else
                return true;
        }
    }
}