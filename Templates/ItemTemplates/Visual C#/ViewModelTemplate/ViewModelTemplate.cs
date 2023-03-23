using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $rootnamespace$ {
    /// <summary>
    /// View model of $safeitemname$
    /// </summary>
    public class $safeitemname$ : INotifyPropertyChanged {
        #region 公共成员
        #region 事件
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region 属性

        #endregion
        #region 方法
        public void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion

        #region 构造函数

        #endregion

        #region 私有成员
        #region 字段

        #endregion
        #region 方法
       
        #endregion
        #endregion
    }
}
