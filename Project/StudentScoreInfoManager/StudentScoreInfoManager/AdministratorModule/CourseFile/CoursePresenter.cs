using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.CourseFile
{
    public class CoursePresenter<V>:BasePresenter<V>,ICoursePresenter<V> where V:ICourseView
    {
        private static CoursePresenter<V> _instance = null;
        private CourseDataContext mdataContext;
        private CoursePresenter()
        {
            mdataContext = new CourseDataContext();
        }
        public static CoursePresenter<V> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CoursePresenter<V>();
                return _instance;
            }
            return _instance;
        }


    }
}