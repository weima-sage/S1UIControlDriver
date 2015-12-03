using System;
using Xamarin.Forms;
using ControlTester.ViewModels;
using ControlTester.Views;

namespace ControlTester
{
    public class App : Application
    {
        public App()
        {
            ContentPage page = new ContentPage {
                Content = new StackLayout{
                    Children = {
                        new EntityListView(new EntityListViewModel())
                    },
                },
            };

            // The root page of your application
            MainPage =  page;

            if (Device.OS == TargetPlatform.iOS) {
                // move layout under the status bar
                MainPage.Padding = new Thickness (0, 20, 0, 0);
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

