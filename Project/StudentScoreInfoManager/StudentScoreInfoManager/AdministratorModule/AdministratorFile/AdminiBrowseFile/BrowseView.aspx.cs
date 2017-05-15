using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiBMFile
{
    public partial class BrowseModify : AdministratorView,IBrowseView
    {
        protected IAdministratorPresenter<IBrowseView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = AdministratorPresenter<IBrowseView>.GetInstance();
            mPresenter.BindView(this);
        }

        public void ShowAdminiInfo(Administrator administrator) { 
            
        }
        public void ModifySuccess() { 
            
        }
        public void ModifyFail(string s) { 
            
        }
    }
}