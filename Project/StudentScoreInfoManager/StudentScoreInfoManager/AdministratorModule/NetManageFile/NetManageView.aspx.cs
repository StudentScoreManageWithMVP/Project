using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.NetManageFile
{
    public partial class NetManageView : BaseView,INetManageView
    {
        private INetManagePresenter<INetManageView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = NetManagePresenter<INetManageView>.GetInstance();
            mPresenter.BindView(this);

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            this.Alert(file1.PostedFile.FileName);
            Notice notice = new Notice();
            notice.ImageUrl = file1.PostedFile.FileName;
            notice.Word = "不知道写什么";
            notice.ModifyTime = DateTime.Now;
            mPresenter.NoticeModify(notice);
        }
        //修改成功的界面提示
        public void ModifySuccess() {
            Alert("修改成功");
        }
    }
}