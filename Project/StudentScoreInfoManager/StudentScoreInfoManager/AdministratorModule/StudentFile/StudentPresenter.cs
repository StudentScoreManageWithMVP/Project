using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;
using StudentScoreInfoManager.AdministratorModule.StudentFile.StudentBrowseFile;
using StudentScoreInfoManager.AdministratorModule.StudentFile.StudentModifyFile;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile
{
    public class StudentPresenter<V>:BasePresenter<V>,IStudentPresenter<V> where V:IStudentView
    {
        private static StudentPresenter<V> _instance = null;
        private StudentDataContext mdataContext;
        private StudentPresenter()
        {
            mdataContext = new StudentDataContext();
        }
        public static StudentPresenter<V> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StudentPresenter<V>();
                return _instance;
            }
            return _instance;
        }
        /// <summary>
        /// 处理浏览学生信息逻辑
        /// </summary>
        /// <param name="StuentId"></param>
        public void GetStudentInfo(int StuentId) {
            if (mbaseView is IBrowseView) {
                var student = mdataContext.Student.FirstOrDefault<Student>(s => s.Id == StuentId);
                ((IBrowseView)mbaseView).ShowStudentInfo(student);
            }
        }
        /// <summary>
        /// 处理修改学生信息的逻辑
        /// </summary>
        /// <param name="student"></param>
        public void ModifyStduentInfo(Student student) {
                if (!mbaseView.IsAdministratorLogined())
                {
                    //处理未登录逻辑
                    mbaseView.Alert("您好未登录");
                }
                else { 
                    //处理修改逻辑
                    Student modifyStu = mdataContext.Student.SingleOrDefault<Student>(s => s.Id == student.Id);
                    #region 反射获取修改值
                    System.Reflection.PropertyInfo[] stuPS = student.GetType().GetProperties();
                    System.Reflection.PropertyInfo[] modifyStuPS = modifyStu.GetType().GetProperties();
                    for (int i = 1; i < stuPS.Length; i++) {
                        var value = stuPS[i].GetValue(student);
                        if (value != null)
                            modifyStuPS[i].SetValue(modifyStu, value);
                    }                   
                    #endregion
                    mdataContext.SubmitChanges();
                    mbaseView.Alert("修改成功");
                }
        }
        /// <summary>
        /// 处理学生注册逻辑
        /// </summary>
        /// <param name="student"></param>
        public void StudentRegiste(Student student) {
            mdataContext.Student.InsertOnSubmit(student);
            mdataContext.SubmitChanges();
            mbaseView.Alert("添加成功");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StduentId"></param>
        public void StudentDelete(int StduentId) {
            Student student = mdataContext.Student.Single(s => s.Id == StduentId);
            mdataContext.Student.DeleteOnSubmit(student);
            mdataContext.SubmitChanges();
        }
        /// <summary>
        /// 学生信息查询
        /// </summary>
        public void StudentQuery() { 
            //待定
        }

        /*private Student GetStudentById(int id) { 
        }*/
    }
}