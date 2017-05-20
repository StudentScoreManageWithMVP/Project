using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentScoreInfoManager.AdministratorModule.StudentFile.StudentModifyFile
{
    public partial class ModifyView : StudentView,IModifyView
    {
        private IStudentPresenter<IModifyView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = StudentPresenter<IModifyView>.GetInstance();
            mPresenter.BindView(this);
        }
    }
}