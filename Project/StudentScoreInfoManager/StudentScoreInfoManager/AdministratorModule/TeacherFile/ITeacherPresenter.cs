﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.TeacherFile
{
    public interface ITeacherPresenter<V>:IBasePresenter<V> where V:ITeacherView
    {
    }
}
