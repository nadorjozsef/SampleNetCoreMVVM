using System.Windows.Input;

namespace Project.Wpf.ViewModels
{
    internal interface IMainViewModel
    {
        string Message { get; set; }

        ICommand ChangeNameCommand { get; }
    }
}