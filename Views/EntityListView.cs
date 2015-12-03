using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ControlTester.ViewModels;
using Sage.SageOne.SageOneMobile.Controls.ViewCells;
using Xamarin.Forms;

namespace ControlTester.Views
{
    public class EntityListView : ListView
    {
        EntityListViewModel _viewModel;


        public EntityListView(EntityListViewModel viewModel)
        {
            _viewModel = viewModel;

            RowHeight = 70;
            BackgroundColor = Color.FromHex("d3d3d3");
            SeparatorVisibility = SeparatorVisibility.None;
            ItemsSource = _viewModel.EntityList;
            ItemTemplate = new DataTemplate(typeof(EntityListViewCell));

            ItemTapped += delegate(object sender, ItemTappedEventArgs e)
            {
                if (e==null) return;
                ((ListView)sender).SelectedItem = null;
            };
        }


    }
}

