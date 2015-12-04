using ControlTester.ViewModels;
using Xamarin.Forms;
using ControlTester.ViewCells;

namespace ControlTester.Views
{
    public class ExpenseListView : ListView 
    {
        ExpenseListViewModel _viewModel;

        public ExpenseListView(ExpenseListViewModel viewModel)
        {
            _viewModel = viewModel;

            RowHeight = 70;
            BackgroundColor = Color.FromHex("d3d3d3");
            SeparatorVisibility = SeparatorVisibility.None;
            ItemsSource = _viewModel.EntityList;
            ItemTemplate = new DataTemplate(typeof(ExpenseListViewCell));

            ItemTapped += delegate(object sender, ItemTappedEventArgs e)
            {
                if (e==null) return;
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}


