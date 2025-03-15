using CommunityToolkit.Mvvm.ComponentModel;
using sale_of_finishing_product.Models;

namespace sale_of_finishing_product.ViewModels
{
    public class ViewModelBase : ObservableObject
    {
        DBSupabase db = new DBSupabase();
    }
}
