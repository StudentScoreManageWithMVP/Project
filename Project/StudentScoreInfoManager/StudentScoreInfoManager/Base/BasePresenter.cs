using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentScoreInfoManager.Base
{
    public class BasePresenter<V> : IBasePresenter<V> where V : IBaseView
    {
        public V mbaseView { get; set; }
        public void BindView(V view)
        {
            this.mbaseView = view;
        }
    }
}