using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.WPF.ViewModels
{
    /* - The ViewModelBase class is a base class for view models in a WPF application.
     * - It implements the INotifyPropertyChanged interface, which allows the class 
     *      to raise a PropertyChanged event when a property is changed.
     * - 
     */
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
