﻿namespace Shop.UIForms.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Shop.Common.Models;
    using Shop.UIForms.Views;

    public class MainViewModel
    {
        private static MainViewModel instance;

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }
        public TokenResponse Token { get; set; }

        public LoginViewModel Login { get; set; }

        public ProductsViewModel Products { get; set; }

        public AddProductViewModel AddProduct { get; set; }

        public ICommand AddProductCommand { get { return new RelayCommand(this.GoAddProduct); } }

        private async void GoAddProduct()
        {
            this.AddProduct = new AddProductViewModel();
            await App.Navigator.PushAsync(new AddProductPage());
        }

        public MainViewModel()
        {
            instance = this;
            this.LoadMenus();
        }

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }

        private void LoadMenus()
        {
            var menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "ic_info_outline",
                    PageName = "AboutPage",
                    Title = "About"
                },

                new Menu
                {
                    Icon = "ic_phonelink_setup",
                    PageName = "SetupPage",
                    Title = "Setup"
                },

                new Menu
                {
                    Icon = "ic_exit_to_app",
                    PageName = "LoginPage",
                    Title = "Close session"
                }
            };

            this.Menus = new ObservableCollection<MenuItemViewModel>(menus.Select(m => new MenuItemViewModel
            {
                Icon = m.Icon,
                PageName = m.PageName,
                Title = m.Title
            }).ToList());
        }
    }
}
