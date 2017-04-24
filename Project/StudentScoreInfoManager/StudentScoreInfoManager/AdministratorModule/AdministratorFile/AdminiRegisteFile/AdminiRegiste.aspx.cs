using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiRegisteFile
{
    public partial class AdminiRegiste : BaseView,IRegisteView
    {
        private IAdministratorPresenter<IRegisteView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = AdministratorPresenter<IRegisteView>.GetInstance();
            mPresenter.BindView(this);
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Administrator admini = new Administrator();
            admini.Name = "test";
            admini.OriginPlace = "不知道";
            mPresenter.InsertInfo(admini);
        }
    }
}