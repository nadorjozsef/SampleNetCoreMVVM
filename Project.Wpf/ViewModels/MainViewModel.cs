using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Project.Wpf.ViewModels
{
    internal sealed class MainViewModel : ViewModelBase, IMainViewModel
    {
        private string _message;

        public MainViewModel()
        {
            Message = "Hello";
            ChangeNameCommand = new RelayCommand(() => Message = "Hello from command", () => true);
        }

        public string Message
        {
            get => _message;
            set => Set(ref _message, value);
        }

        public ICommand ChangeNameCommand { get; private set; }
    }
}
