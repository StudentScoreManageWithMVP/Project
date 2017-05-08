using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.MessageFile.MessageBrowseFile
{
    public partial class MessageBrowse : BaseView,IBrowseView
    {
        private IMessagePresenter<IBrowseView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = MessagePresenter<IBrowseView>.GetInstance();
            mPresenter.BindView(this);
        }

        //消息的界面显示方式
        public void ShowMessage(Message message){
            
        }
    }
}