namespace WpfApp1.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        public MainViewModel()
        {
            Message = "Hello";
        }

        public string Message { get; set; }

        public string Message2 { get; set; }

    }
}
