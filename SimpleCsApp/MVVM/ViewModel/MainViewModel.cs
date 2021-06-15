using SimpleCsApp.Core;

namespace SimpleCsApp.MVVM.ViewModel
{
    public class MainViewModel : ObservableObjects
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DistancesViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DistancesViewModel DistancesVM { get; set; }

        public object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DistancesVM = new DistancesViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVM; });
            DistancesViewCommand = new RelayCommand(o => { CurrentView = DistancesVM; });
        }
    }
}