using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.MessageFile.MessageSendFile
{
    public partial class MessageSend : BaseView,ISendView
    {
        private IMessagePresenter<ISendView> mPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            mPresenter = MessagePresenter<ISendView>.GetInstance();
            mPresenter.BindView(this);
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            //老师逻辑
            //学生逻辑
            if (mPresenter.GetIdWithStudentID("xxx") != 0) { 
                //拼装Message
                Message messgae = new Message();

                mPresenter.MessageSend(messgae);
            }
        }
    }
}