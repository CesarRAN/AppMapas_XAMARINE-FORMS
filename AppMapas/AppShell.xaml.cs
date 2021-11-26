using AppMapas.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppMapas
{
    public partial class AppShell : Shell
    {
        public AppShell()  
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LocateEntryPage), typeof(LocateEntryPage));
        }
    }

}
