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

        /// <summary>
        /// 获取单个课程信息
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        public Course GetCourseById(int CourseId) {
            var course = (from c in mdataContext.Course
                         where c.Id == CourseId
                         select c).SingleOrDefault();
            return course;
        }
        /// <summary>
        /// 课程添加逻辑处理
        /// </summary>
        /// <param name="course"></param>
        public void CourseAdd(Course course) {
            mdataContext.Course.InsertOnSubmit(course);
            mdataContext.SubmitChanges();
            mbaseView.Alert("添加成功");
        }
        /// <summary>
        /// 课程信息修改逻辑处理
        /// </summary>
        /// <param name="course"></param>
        public void CourseInfoModify(Course course) {
            Course modifyCourse = mdataContext.Course.SingleOrDefault<Course>(c => c.Id == course.Id);
            #region 通过反射获取修改值
            System.Reflection.PropertyInfo[] coursePs = course.GetType().GetProperties();
            System.Reflection.PropertyInfo[] modifyCoursePs = modifyCourse.GetType().GetProperties();
            for (int i = 1; i < coursePs.Length; i++)
            {
                var value = coursePs[i].GetValue(course);
                if (value != null) {
                    modifyCoursePs[i].SetValue(modifyCourse,value);
                }
            }
            #endregion
            mdataContext.SubmitChanges();
            mbaseView.Alert("修改成功");
        }
        /// <summary>
        /// 通过Id删除课程信息
        /// </summary>
        /// <param name="CourseId"></param>
        public void CourseDeleteById(int CourseId) {
            var course = mdataContext.Course.SingleOrDefault<Course>(c=>c.Id==CourseId);
            mdataContext.Course.DeleteOnSubmit(course);
            mdataContext.SubmitChanges();
            mbaseView.Alert("修改成功");
        }
    }
}