using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentScoreInfoManager.Base;
using StudentScoreInfoManager.LinqClass;
using StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiBMFile;

namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile
{
    public class AdministratorPresenter<V>:BasePresenter<V>,IAdministratorPresenter<V> where V:IAdministratorView
    {
        private static AdministratorPresenter<V> _instance = null;
        private AdministratorDataContext mdataContext;
        private AdministratorPresenter()
        {
            mdataContext = new AdministratorDataContext();
        }
        public static AdministratorPresenter<V> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AdministratorPresenter<V>();
                return _instance;
            }
            return _instance;
        }

        /// <summary>
        /// 处理管理员个人信息浏览逻辑
        /// </summary>
        /// <param name="AdministratorId"></param>
        public void Browse(int AdministratorId)
        {
            Administrator admi = GetAdminiById(AdministratorId);
            if (admi == null)
            {
                mbaseView.Alert("查找失败");
            }
            else
            {
                ((IBMView)mbaseView).ShowAdminiInfo(admi);
            }
        }

        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="administrator">管理员修改后的信息</param>
        public void ModifyAInfo(Administrator administrator)
        {
            if (mbaseView is IBMView)
            {
                Administrator ad = GetAdminiById(administrator.Id);
                #region 修改判断
                if (administrator.Name != null)
                {
                    ad.Name = administrator.Name;
                }
                if (administrator.Password != null)
                {
                    ad.Password = administrator.Password;
                }
                if (administrator.OriginPlace != null)
                {
                    ad.OriginPlace = administrator.OriginPlace;
                }
                if (administrator.PhoneNumber != null)
                {
                    ad.PhoneNumber = administrator.PhoneNumber;
                }
                if (administrator.Sex != null)
                {
                    ad.Sex = administrator.Sex;
                }
                if (administrator.Age != null)
                {
                    ad.Age = administrator.Age;
                }
                #endregion
                mdataContext.SubmitChanges();
                ((IBMView)mbaseView).ModifySuccess();
            }

        }

        /// <summary>
        /// 管理员注册
        /// </summary>
        /// <param name="administrator">要新增的管理员信息</param>
        /// <returns></returns>
        public void InsertInfo(Administrator administrator)
        {
            mdataContext.Administrator.InsertOnSubmit(administrator);
            mdataContext.SubmitChanges();
            mbaseView.Alert("添加成功");
        }

        /// <summary>
        /// 通过管理员编号从数据库获取管理员个人信息
        /// </summary>
        /// <param name="AdminiId">管理员编号</param>
        /// <returns>管理员实体对象</returns>
        public Administrator GetAdminiById(int AdminiId)
        {
            var administrator = (from a in mdataContext.Administrator
                                 where a.Id == AdminiId
                                 select a).FirstOrDefault();
            return administrator;
        }
    }
}