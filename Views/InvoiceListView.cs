using ControlTester.ViewModels;
using Xamarin.Forms;
using ControlTester.ViewCells;

namespace ControlTester.Views
{
    public class InvoiceListView : ListView 
    {
        InvoiceListViewModel _viewModel;

        public InvoiceListView(InvoiceListViewModel viewModel)
        {
            _viewModel = viewModel;

            RowHeight = 70;
            BackgroundColor = Color.FromHex("d3d3d3");
            SeparatorVisibility = SeparatorVisibility.None;
            ItemsSource = _viewModel.EntityList;
            ItemTemplate = new DataTemplate(typeof(InvoiceListViewCell));

            ItemTapped += delegate(object sender, ItemTappedEventArgs e)
            {
                if (e==null) return;
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}

