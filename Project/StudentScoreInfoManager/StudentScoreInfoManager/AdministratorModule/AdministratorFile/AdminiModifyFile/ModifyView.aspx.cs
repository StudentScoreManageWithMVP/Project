using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiModifyFile
{
    public partial class ModifyView : BaseView,IAdministratorView
    {
        protected IAdministratorPresenter<IAdministratorView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = AdministratorPresenter<IAdministratorView>.GetInstance();
            mPresenter.BindView(this);
        }
    }
}