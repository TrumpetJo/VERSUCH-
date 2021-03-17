using System;
using System.Collections.Generic;
using System.ComponentModel;
using VERSUCH_.Models;
using VERSUCH_.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VERSUCH_.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}