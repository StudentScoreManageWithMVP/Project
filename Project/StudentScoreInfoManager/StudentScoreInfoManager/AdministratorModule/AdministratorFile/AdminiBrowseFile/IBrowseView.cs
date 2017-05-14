using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoreInfoManager.LinqClass;

namespace StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiBMFile
{
    public interface IBrowseView : IAdministratorView
    {
        void ShowAdminiInfo(Administrator administrator);
        void ModifySuccess();
        void ModifyFail(string s);
    }
}
