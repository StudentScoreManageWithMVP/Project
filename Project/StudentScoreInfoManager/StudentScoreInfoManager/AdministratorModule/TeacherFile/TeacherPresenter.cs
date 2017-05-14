using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.TeacherFile
{
    public class TeacherPresenter<V>:BasePresenter<V>,ITeacherPresenter<V> where V:ITeacherView
    {

    }
}