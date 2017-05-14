using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.TeacherFile
{
    public class TeacherPresenter<V>:BasePresenter<V>,ITeacherPresenter<V> where V:ITeacherView
    {
        private static TeacherPresenter<V> _instance = null;
        //待完成
        //private StudentDataContext mdataContext;
        private TeacherPresenter()
        {
            //待完成
            //mdataContext = new StudentDataContext();
        }
        public static TeacherPresenter<V> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TeacherPresenter<V>();
                return _instance;
            }
            return _instance;
        }
    }
}