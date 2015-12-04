using System;
using Xamarin.Forms;
using ControlTester.ViewModels;
using ControlTester.Views;
using Sage.SageOne.SageOneMobile.Controls.ViewModels;
using ControlTester.ViewCells;

namespace ControlTester
{
    public class App : Application
    {
        NavigationPage _navPage;

        public App()
        {

            var rootPage = new ContentPage();
            _navPage = new NavigationPage(rootPage);
             

            rootPage.Content = new StackLayout {
                Children = { 
                    InvoiceButton(),
                    ProductButton(),
                    ExpenseButton()
                }
            };
                    
            // The root page of your application
            MainPage = _navPage;

            if (Device.OS == TargetPlatform.iOS) {
                // move layout under the status bar
                MainPage.Padding = new Thickness (0, 20, 0, 0);
            }
        }
         

        protected Button InvoiceButton()
        {
            var button = new Button { Text = "Invoices" };
            button.Clicked += (sender, e) => _navPage.PushAsync(InvoiceListPage());
            return button;
        }
            
        protected Page InvoiceListPage() 
        {
            var listViewModel = new InvoiceListViewModel();
            return new ContentPage {
                Content = new StackLayout{
                    Children = {
                        new InvoiceListView(listViewModel)
                    },
                },
            };
        }


        protected Button ProductButton()
        {
            var button = new Button { Text = "Products" };
            button.Clicked += (sender, e) => _navPage.PushAsync(ProductListPage());
            return button;
        }

        protected Page ProductListPage() 
        {
            var listViewModel = new ProductListViewModel();
            return new ContentPage {
                Content = new StackLayout{
                    Children = {
                        new ProductListView(listViewModel)
                    },
                },
            };
        }


        protected Button ExpenseButton()
        {
            var button = new Button { Text = "Expenses" };
            button.Clicked += (sender, e) => _navPage.PushAsync(ExpenseListPage());
            return button;
        }

        protected Page ExpenseListPage() 
        {
            var listViewModel = new ExpenseListViewModel();
            return new ContentPage {
                Content = new StackLayout{
                    Children = {
                        new ExpenseListView(listViewModel)
                    },
                },
            };
        }
            
    }
}

