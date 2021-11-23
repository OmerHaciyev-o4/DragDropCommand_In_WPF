using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TestDragDrop.ViewModels;

namespace TestDragDrop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindowViewModel viewmodel = new MainWindowViewModel();
            MainWindow main = new MainWindow();
            main.DataContext = viewmodel;
            main.Show();
        }
    }
}
