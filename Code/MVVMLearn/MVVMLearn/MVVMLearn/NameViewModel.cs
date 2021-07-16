using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearn
{
    class NameViewModel : INotifyPropertyChanged
    {
        public NameViewModel()
        {
            _userName = new Name() { UserName = "王宇杰", CompanyName = "三江电子" };
        }

        Name _userName;

        public string UserName
        {
            get
            {
                return _userName.UserName;
            }
            set
            {
                _userName.UserName = value; RaisePropertyChanged("UserName");
            }
        }

        public string CompanyName
        {
            get
            {
                return _userName.CompanyName;
            }
            set
            {
                _userName.CompanyName = value; RaisePropertyChanged("CompanyName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
