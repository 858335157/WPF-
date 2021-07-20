using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMLearn.Sys;

namespace MVVMLearn.ViewModel
{
    class DataBindTestVM : NotifyObject
    {
        private double _doubleValue;
        /// <summary>
        /// Double类型的测试数据
        /// </summary>
        public double DoubleValue
        {
            get { return _doubleValue; }
            set
            {
                if (_doubleValue != value)
                {
                    _doubleValue = value;
                    RaisePropertyChanged("DoubleValue");
                }
            }
        }

        private DataBindTestData _selectedData;
        /// <summary>
        /// 列表中选中行的对象
        /// </summary>
        public DataBindTestData SelectedData
        {
            get { return _selectedData; }
            set
            {
                if (_selectedData != value)
                {
                    _selectedData = value;
                    RaisePropertyChanged("SelectedData");
                }
            }
        }


        private List<DataBindTestData> _testDataList;
        /// <summary>
        /// 列表类数据
        /// </summary>
        public List<DataBindTestData> TestDataList
        {
            get { return _testDataList; }
            set
            {
                if (_testDataList != value)
                {
                    _testDataList = value;
                }
            }
        }

        public DataBindTestVM()
        {
            _doubleValue = 0.5;
            TestDataList = DataBindTestData.GetTestData().ToList();
        }
    }
}
