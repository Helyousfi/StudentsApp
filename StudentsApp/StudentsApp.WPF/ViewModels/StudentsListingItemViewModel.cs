using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentsApp.WPF.ViewModels
{
    internal class StudentsListingItemViewModel : ViewModelBase
    {
        public string? Username { get; }
        public ICommand? EditCommand { get; }
        public ICommand? DeleteCommand { get; }

        public StudentsListingItemViewModel(string username)    
        {
            Username = username;
        }

    }
}
