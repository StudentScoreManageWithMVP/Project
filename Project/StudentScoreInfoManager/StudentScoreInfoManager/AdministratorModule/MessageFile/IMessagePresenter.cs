using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.MessageFile
{
    public interface IMessagePresenter<V>:IBasePresenter<V> where V:IMessageView
    {
        //消息概览
        void MessageOverview(int LineNums);
        //消息发送
        void MessageSend(Message message);
        //根据学号获取学生ID
        int GetIdWithStudentID(string Id);
        //获取老师ID
        int GetTecherID();
        //根据消息id获取消息
        void GetMessageWithId(int MessageId);
    }
}
