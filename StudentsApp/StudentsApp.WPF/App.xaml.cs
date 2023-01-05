using StudentsApp.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

/*
 * The App.xaml file is usually accompanied by an App.xaml.cs code-behind file, which contains the code 
 * for the application class. The application class is responsible for handling application-level events, 
 * such as the startup and shutdown of the application.
 */
namespace StudentsApp.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new StudentsInfoViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }


    }
}
