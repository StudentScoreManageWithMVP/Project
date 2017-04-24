using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoreInfoManager.Base
{
    public interface IBasePresenter<V> where V : IBaseView
    {
        void BindView(V view);
    }
}
