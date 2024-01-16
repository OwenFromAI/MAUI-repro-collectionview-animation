using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddItemsDemo.ViewModels
{
    public partial class Reading : ObservableObject
    {

        [ObservableProperty]
        private string _stationNumber = "0000";

        [ObservableProperty]
        private string _marker = "";

        [ObservableProperty]
        private string _reading1 = "";

        [ObservableProperty]
        private string _reading2 = "";

        [ObservableProperty]
        private string _remarks = "";

    }
}
