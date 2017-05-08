using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;
using StudentScoreInfoManager.AdministratorModule.MessageFile.MessageReceiveFile;
using StudentScoreInfoManager.AdministratorModule.MessageFile.MessageBrowseFile;

namespace StudentScoreInfoManager.AdministratorModule.MessageFile
{
    public class MessagePresenter<V>:BasePresenter<V>,IMessagePresenter<V> where V:IMessageView
    {
        private static MessagePresenter<V> _instance = null;
        private MessageDataContext mdataContext;
        private StudentDataContext studentDt;
        private AdministratorDataContext administartorDt;
        private MessagePresenter()
        {
            mdataContext = new MessageDataContext();
        }
        public static MessagePresenter<V> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MessagePresenter<V>();
                return _instance;
            }
            return _instance;
        }
        /// <summary>
        /// 消息概览逻辑处理
        /// </summary>
        /// <param name="LineNums"></param>
        /// <returns></returns>
        public void MessageOverview(int LineNums) {
            var messages = (from m in mdataContext.Message
                            select m).Take(LineNums);
            IReceiveView view = mbaseView as IReceiveView;
            if (messages != null) {
                view.MessageOverView(messages);
            }
        }
        /// <summary>
        /// 消息发送逻辑处理
        /// </summary>
        /// <param name="message"></param>
        public void MessageSend(Message message) {
            /*
             SenderId
            RecipientId
            SenderType
            RecipientType
             */
            if (message.RecipientId == 2)
            {
                //接收者是老师的逻辑处理
            }
            else if(message.RecipientId == 3){
                var student = studentDt.Student.Single(s=>s.Id==message.RecipientId);
                if (student != null)
                {
                    mdataContext.Message.InsertOnSubmit(message);
                    mdataContext.SubmitChanges();
                }
                else { 
                    //数据库中没有该接收者的操作
                    
                }
            }
        }

        //根据学号获取学生ID
        public int GetIdWithStudentID(string Id) {
            var sid = (from s in studentDt.Student
                      where s.StudentId == Id
                      select new { s.Id }).Single();
            int id = sid.Id;
            return id;
        }
        //获取老师ID
        public int GetTecherID() {
            return 0;
        }

        /// <summary>
        /// 根据id获取消息内容
        /// </summary>
        /// <param name="MessageId">消息Id</param>
        public void GetMessageWithId(int MessageId) {
            var message = mdataContext.Message.Single(m => m.Id == MessageId);
            ((IBrowseView)mbaseView).ShowMessage(message);
        }
    }
}