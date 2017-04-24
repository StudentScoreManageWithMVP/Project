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
    public partial class BrowseAndModify : BaseView,IBMView
    {
        private IAdministratorPresenter<IBMView> mPresenter;
        private bool modifyState;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = AdministratorPresenter<IBMView>.GetInstance();
            mPresenter.BindView(this);
            mPresenter.Browse(1);
            modifyState = false;
        }

        /// <summary>
        /// 管理员信息具体的展示方式
        /// </summary>
        /// <param name="administrator"></param>
        public void ShowAdminiInfo(Administrator administrator)
        {
            t1.Text = administrator.Age + administrator.Id + administrator.Name;
        }
        /// <summary>
        /// 修改成功时的界面操作
        /// </summary>
        /// <param name="administrator"></param>
        public void ModifySuccess()
        {
            Alert("修改成功");
        }
        public void ModifyFail(string s)
        {
            Alert(s);
        }
        /// <summary>
        /// 修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn1_Click(object sender, EventArgs e)
        {
            if (modifyState == false)
            {
                t1.Enabled = true;
                modifyState = true;
                btn1.Text = "完成";
            }
            else {
                Administrator administartor = new Administrator();
                administartor.Id = 1;
                administartor.Name = "hahhaa";
                mPresenter.ModifyAInfo(administartor);
            }
        }
    }
}