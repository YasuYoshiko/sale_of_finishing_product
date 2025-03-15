using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace sale_of_finishing_product.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty] UserControl page = new NewUserView();
    }
}
