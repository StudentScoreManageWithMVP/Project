using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentScoreInfoManager.Base
{
        public class BaseView : System.Web.UI.Page, IBaseView
        {
            public void baseshow()
            {
                Console.WriteLine("baseview commonshow");
            }
            public void Alert(string AlertStr)
            {
                Response.Write("<script>alert('" + AlertStr + "!')</script>");
            }
        }
}