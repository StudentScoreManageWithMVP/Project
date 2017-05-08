using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile.StudentRegisteFile
{
    public partial class StudentRegiste : StudentView,IRegisteView
    {
        private IStudentPresenter<IRegisteView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = StudentPresenter<IRegisteView>.GetInstance();
            mPresenter.BindView(this);
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = "小明";
            student.Password = "123456";
            student.Sex = "男";
            student.Profession = "鸡";
            student.Nation = "保加利亚";
            student.PoliticalOutlook = "少先队员";
            student.UsedName = "无";
            student.IdentityCardNum = "142724199507052779";
            student.Birthday = Convert.ToDateTime("2016-4-3 11:35:06");
            student.OriginPlace = "不知道是哪里的";
            student.Health = "心理不健康";
            student.EnrollmenYear = Convert.ToDateTime("2016-4-3");
            student.HomeAddress = "真不知道";
            student.PhoneNumber = "12345678912";
            student.Mail = "789456123@qq.com";
            student.StudentId = "2014888";
            mPresenter.StudentRegiste(student);
        }
    }
}