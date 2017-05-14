using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.StudentScoreFile
{
    public class StudentScorePresenter<V>:BasePresenter<V>,IStudentScorePresenter<V> where V:IStudentScoreView
    {
        private static StudentScorePresenter<V> _instance = null;
        //待完成
        //private StudentDataContext mdataContext;
        private StudentScorePresenter()
        {
            //待完成
            //mdataContext = new StudentDataContext();
        }
        public static StudentScorePresenter<V> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StudentScorePresenter<V>();
                return _instance;
            }
            return _instance;
        }
    }
}