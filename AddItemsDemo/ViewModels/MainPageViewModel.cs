using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddItemsDemo.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private Timer? _timer;

        [ObservableProperty]
        public ObservableCollection<Reading> _readings = new ObservableCollection<Reading>();

        [RelayCommand]
        private void StartInsert()
        {
            if (_timer == null)
            {
                _timer = new Timer(Insert, null, 0, 750);
            }

            void Insert(object? _)
            {
                MainThread.BeginInvokeOnMainThread(() => Readings.Insert(0, new Reading() { StationNumber = "0001", Marker = "A", Reading1 = "1", Reading2 = "2", Remarks = "Remarks" }));
            }
        }


        [RelayCommand]
        private void StartAdd()
        {
            if (_timer == null)
            {
                _timer = new Timer(Insert, null, 0, 750);
            }

            void Insert(object? _)
            {
                MainThread.BeginInvokeOnMainThread(() => Readings.Add(new Reading() { StationNumber = "0001", Marker = "A", Reading1 = "1", Reading2 = "2", Remarks = "Remarks" }));
            }
        }

        [RelayCommand]
        private void Stop()
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }

            Readings.Clear();
        }
    }
}
