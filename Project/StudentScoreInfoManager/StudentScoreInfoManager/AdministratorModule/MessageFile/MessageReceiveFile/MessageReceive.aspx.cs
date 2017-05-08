using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.MessageFile.MessageReceiveFile
{
    public partial class MessageReceive : MessageView,IReceiveView
    {
        private IMessagePresenter<IReceiveView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = MessagePresenter<IReceiveView>.GetInstance();
            mPresenter.BindView(this);
            mPresenter.MessageOverview(1);
        }
        public void MessageOverView(IEnumerable<Message> Messages) {
            grid1.DataSource = Messages;
            grid1.DataBind();
        }
    }
}