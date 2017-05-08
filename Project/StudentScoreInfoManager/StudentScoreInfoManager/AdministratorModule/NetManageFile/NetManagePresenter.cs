using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.NetManageFile
{
    public class NetManagePresenter<V>:BasePresenter<V>,INetManagePresenter<V> where V:INetManageView
    {
        private static NetManagePresenter<V> _instance = null;
        private NoticeDataContext mdataContext;
        private NetManagePresenter()
        {
            mdataContext = new NoticeDataContext();
        }
        public static NetManagePresenter<V> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NetManagePresenter<V>();
                return _instance;
            }
            return _instance;
        }

        //上传修改内容
        public void NoticeModify(Notice notice) {
            mdataContext.Notice.InsertOnSubmit(notice);
            mdataContext.SubmitChanges();
            mbaseView.Alert("修改成功");
        }
    }
}