using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiModifyFile
{
    public partial class ModifyView : BaseView,IModifyView
    {
        protected IAdministratorPresenter<IModifyView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = AdministratorPresenter<IModifyView>.GetInstance();
            mPresenter.BindView(this);
        }

        /// <summary>
        /// 修改按钮触发事件
        /// </summary>
        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Administrator modifyAdmini = new Administrator();
            Administrator sessionAdmini = Session["Administrator"] as Administrator;
            modifyAdmini.Id=sessionAdmini.Id;
            if(string.Compare(Request.Form["nameInput"] as string,sessionAdmini.Name)!=0){
                modifyAdmini.Name = Request.Form["nameInput"] as string;
            }
            else if (string.Compare(Request.Form["sexInput"] as string, sessionAdmini.Sex) != 0) {
                modifyAdmini.Sex = Request.Form["sexInput"] as string;
            }
            else if (Convert.ToInt32(Request.Form["ageInput"])!=sessionAdmini.Age)
            {
                modifyAdmini.Age = Convert.ToInt32(Request.Form["ageInput"]);
            }
            else if (string.Compare(Request.Form["phoneInput"] as string, sessionAdmini.PhoneNumber) != 0) {
                modifyAdmini.PhoneNumber = Request.Form["phoneInput"] as string;
            }
            else if (string.Compare(Request.Form["originPlaceInput"] as string, sessionAdmini.OriginPlace) != 0) {
                modifyAdmini.OriginPlace = Request.Form["originPlaceInput"] as string;
            }
            else if (string.Compare(Request.Form["brifeInput"] as string, sessionAdmini.Brief_Introducation) != 0) {
                modifyAdmini.Brief_Introducation = Request.Form["brifeInput"] as string;
            }
            mPresenter.ModifyAInfo(modifyAdmini);
        }

        //修改成功时进行页面跳转(未用)
        public void ModifySuccessful() {
            Response.Redirect("~/AdministratorModule/AdministratorFile/AdminiBrowseFile/BrowseView.aspx");
        }
        /// <summary>
        /// 修改session中的值
        /// </summary>
        /// <param name="admini">保存有页面修改的信息，未修改的未保存</param>
        public void ModifySession(Administrator admini) {
            Administrator session = Session["Administrator"] as Administrator;
            System.Reflection.PropertyInfo[] adminips = admini.GetType().GetProperties();
            System.Reflection.PropertyInfo[] sessionps = session.GetType().GetProperties();
            for (int i = 1; i < adminips.Length; i++) {
                var value = adminips[i].GetValue(admini);
                if (value != null) {
                    sessionps[i].SetValue(session,value);
                }
            }
        }
    }
}