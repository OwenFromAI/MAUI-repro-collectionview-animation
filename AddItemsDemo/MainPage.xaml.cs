using AddItemsDemo.ViewModels;

namespace AddItemsDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

       
    }

}
