using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile.StudentRegisteFile
{
    public partial class RegisterView : StudentView,IRegisteView
    {
        protected IStudentPresenter<IRegisteView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = StudentPresenter<IRegisteView>.GetInstance();
            mPresenter.BindView(this);
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = Request.Form["nameInput"].ToString();
            student.Password = Request.Form["passwordInput"].ToString();
            //待改
            student.Sex = Request.Form["sexInput"].ToString();
            student.Age = Convert.ToInt32(Request.Form["ageInput"]);
            //待改
            student.Profession = Request.Form["professionInput"].ToString();
            //待改
            student.Nation = Request.Form["nationInput"].ToString();
            student.PoliticalOutlook = Request.Form["politicalInput"].ToString();
            student.UsedName = Request.Form["usednameInput"].ToString();
            student.IdentityCardNum = Request.Form["identityInput"].ToString();
            student.Birthday = Convert.ToDateTime(Request.Form["birthdayInput"].ToString());
            student.OriginPlace = Request.Form["originplaceInput"].ToString();
            student.Health = Request.Form["healthInput"].ToString();
            student.EnrollmenYear = Convert.ToDateTime(Request.Form["enrollmenInput"].ToString());
            student.HomeAddress = Request.Form["homeInput"].ToString();
            student.PhoneNumber = Request.Form["phoneInput"].ToString();
            student.Mail = Request.Form["mailInput"].ToString();
            student.ImageUrl = file.Value;
            mPresenter.StudentRegiste(student);
        }
    }
}