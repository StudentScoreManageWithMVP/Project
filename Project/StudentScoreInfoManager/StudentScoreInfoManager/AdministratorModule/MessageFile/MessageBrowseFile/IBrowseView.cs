using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.MessageFile.MessageBrowseFile
{
    public interface IBrowseView:IMessageView
    {
        //消息的界面显示方式
        void ShowMessage(Message message);
    }
}
