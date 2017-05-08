using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.MessageFile.MessageReceiveFile
{
    public interface IReceiveView:IMessageView
    {
        //消息概览界面显示
        void MessageOverView(IEnumerable<Message> Messages);
    }
}
