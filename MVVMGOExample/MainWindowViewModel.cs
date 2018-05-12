using MvvmGo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMGOExample
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            TestItems = new List<string>() { "ali", "Yousefi", "Telori" };
        }

        int _CurrentStatus;
        public int CurrentStatus
        {
            get
            {
                return _CurrentStatus;
            }
            set
            {
                _CurrentStatus = value;
                OnPropertyChanged(nameof(CurrentStatus));
            }
        }
        public List<string> TestItems { get; set; }

    }
}
