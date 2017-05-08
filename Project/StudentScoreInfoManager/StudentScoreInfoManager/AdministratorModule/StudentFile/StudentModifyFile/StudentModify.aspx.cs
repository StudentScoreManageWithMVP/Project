using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile.StudentModifyFile
{
    public partial class StudentModify : StudentView,IModifyView
    {
        private IStudentPresenter<IModifyView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = StudentPresenter<IModifyView>.GetInstance();
            mPresenter.BindView(this);
        }

        

        protected void btn1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Id = 1;
            stu.Name = "写点什么";
            mPresenter.ModifyStduentInfo(stu);
        }
    }
}