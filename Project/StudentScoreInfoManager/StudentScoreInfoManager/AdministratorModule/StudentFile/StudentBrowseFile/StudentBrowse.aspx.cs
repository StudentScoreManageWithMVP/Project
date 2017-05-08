using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile.StudentBrowseFile
{
    public partial class StudentBrowse : StudentView,IBrowseView
    {
        private IStudentPresenter<IBrowseView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = StudentPresenter<IBrowseView>.GetInstance();
            mPresenter.BindView(this);
            mPresenter.GetStudentInfo(1);
        }
        public void ShowStudentInfo(Student student) {
            l1.Text = student.Id + student.Name + student.EnrollmenYear;
        }
    }
}