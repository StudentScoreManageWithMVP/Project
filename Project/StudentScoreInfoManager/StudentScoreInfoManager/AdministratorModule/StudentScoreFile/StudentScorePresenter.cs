using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.StudentScoreFile
{
    public class StudentScorePresenter<V>:BasePresenter<V>,IStudentScorePresenter<V> where V:IStudentScoreView
    {
    }
}