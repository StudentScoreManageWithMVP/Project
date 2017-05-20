using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile.StudentModifyFile
{
    public partial class WebForm1 : StudentView,IModifyView
    {
        private IStudentPresenter<IModifyView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = StudentPresenter<IModifyView>.GetInstance();
            mPresenter.BindView(this);
        }
        /// <summary>
        /// 修改信息操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Student modifyStudent = new Student();
            Student sessionStudent = Session["Student"] as Student;
            modifyStudent.Id = sessionStudent.Id;
            modifyStudent.Name = Request.Form["nameInput"];
            modifyStudent.Password = Request.Form["passwordInput"];
            modifyStudent.Sex = Request.Form["sexInput"];
            modifyStudent.Age = Convert.ToInt32(Request.Form["ageInput"]);
            modifyStudent.Profession = Request.Form["professionInput"];
            modifyStudent.Nation = Request.Form["nationInput"];
            modifyStudent.PoliticalOutlook = Request.Form["politicalInput"];
            modifyStudent.UsedName = Request.Form["usednameInput"];
            modifyStudent.IdentityCardNum = Request.Form["identityInput"];
            modifyStudent.Birthday = Convert.ToDateTime(Request.Form["birthdayInput"]);
            modifyStudent.Health = Request.Form["healthInput"];
            modifyStudent.EnrollmenYear = Convert.ToDateTime(Request.Form["enrollmenInput"]);
            modifyStudent.HomeAddress = Request.Form["homeInput"];
            modifyStudent.PhoneNumber = Request.Form["phoneInput"];
            modifyStudent.Mail = Request.Form["mailInput"];
            modifyStudent.ImageUrl = file.Value;
            mPresenter.ModifyStudentInfo1(modifyStudent,sessionStudent);
        }


    }
}