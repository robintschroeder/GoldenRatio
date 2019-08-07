using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using GoldenRatioInXaml.Models;

namespace GoldenRatioInXaml.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.GoldenRatio6, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.GoldenRatio9:
                        MenuPages.Add(id, new NavigationPage(new GoldenRatio9()));
                        break;
                    case (int)MenuItemType.GoldenRatio6:
                        MenuPages.Add(id, new NavigationPage(new GoldenRatio6()));
                        break;
                    case (int)MenuItemType.GoldenRatio4:
                        MenuPages.Add(id, new NavigationPage(new GoldenRatio4()));
                        break;
                    case (int)MenuItemType.GoldenRatio2:
                        MenuPages.Add(id, new NavigationPage(new GoldenRatio2()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}