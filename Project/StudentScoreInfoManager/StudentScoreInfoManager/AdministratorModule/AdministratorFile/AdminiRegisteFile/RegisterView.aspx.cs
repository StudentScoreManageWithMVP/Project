using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.LinqClass;
using StudentScoreInfoManager.Base;

namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiRegisteFile
{
    public partial class RegisterView : BaseView,IRegisteView
    {
        protected IAdministratorPresenter<IRegisteView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = AdministratorPresenter<IRegisteView>.GetInstance();
            mPresenter.BindView(this);
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Administrator admini = new Administrator();
            admini.Name = Request.Form["nameInput"].ToString();
            admini.Password = Request.Form["passwordInput"].ToString();
            admini.Sex = Request.Form["sexInput"].ToString();
            admini.Age = Convert.ToInt32(Request.Form["ageInput"]);
            admini.PhoneNumber = Request.Form["phoneInput"].ToString();
            admini.OriginPlace = Request.Form["originPlaceInput"].ToString();
            admini.Brief_Introducation = Request.Form["brifeInput"].ToString();
            admini.ImageUrl = file.Value;
            Alert(admini.ImageUrl);
            mPresenter.InsertInfo(admini);
        }

    }
}