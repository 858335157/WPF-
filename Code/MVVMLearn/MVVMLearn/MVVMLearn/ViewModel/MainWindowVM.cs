using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMLearn.Sys;

namespace MVVMLearn.ViewModel
{
    class MainWindowVM : NotifyObject
    {
        private int _indexValue = 0;
        private int _maxValue = 3;
        /// <summary>
        /// Double类型的测试数据
        /// </summary>
        public int IndexValue
        {
            get { return _indexValue ; }
            set
            {
                if (_indexValue != value )
                {
                    _indexValue = value ;
                    RaisePropertyChanged("IndexValue");
                    RaisePropertyChanged("IndexValueReverse");
                }
            }
        }

        public int MaxValue
        {
            get { return _maxValue; }
        }

        public int IndexValueReverse
        {
            get { return _maxValue-_indexValue; }
            set
            {
                if (_maxValue-_indexValue != value)
                {
                    _indexValue = _maxValue-value;
                    RaisePropertyChanged("IndexValue");
                    RaisePropertyChanged("IndexValueReverse");
                }
            }
        }

    }
}
