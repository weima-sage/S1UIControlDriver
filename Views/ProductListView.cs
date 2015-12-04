using ControlTester.ViewModels;
using Xamarin.Forms;
using ControlTester.ViewCells;

namespace ControlTester.Views
{
    public class ProductListView : ListView 
    {
        ProductListViewModel _viewModel;

        public ProductListView(ProductListViewModel viewModel)
        {
            _viewModel = viewModel;

            RowHeight = 70;
            BackgroundColor = Color.FromHex("ebedef");
            SeparatorVisibility = SeparatorVisibility.None;
            ItemsSource = _viewModel.EntityList;
            ItemTemplate = new DataTemplate(typeof(ProductListViewCell));

            ItemTapped += delegate(object sender, ItemTappedEventArgs e)
            {
                if (e==null) return;
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
