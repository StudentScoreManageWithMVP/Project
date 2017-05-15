using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile.StudentBrowseFile
{
    public partial class BrowseView : StudentView,IBrowseView
    {
        protected IStudentPresenter<IBrowseView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = StudentPresenter<IBrowseView>.GetInstance();
            mPresenter.BindView(this);
            
        }

        public void ShowStudentInfo(Student student) { }
    }
}