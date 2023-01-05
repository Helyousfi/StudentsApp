using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentsApp.WPF.ViewModels
{
    internal class StudentsInfoViewModel : ViewModelBase    
    {
        public ICommand? AddStudentsCommand { get; }
        public StudentsListingViewModel? StudentsListingViewModel { get; }
        public StudentsDetailsViewModel? StudentsDetailsViewModel { get; }

        public StudentsInfoViewModel()
        {
            StudentsListingViewModel = new StudentsListingViewModel();
            StudentsDetailsViewModel = new StudentsDetailsViewModel();
        }

    }
}
