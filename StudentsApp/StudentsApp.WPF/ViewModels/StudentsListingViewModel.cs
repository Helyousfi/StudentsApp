using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.WPF.ViewModels
{
    internal class StudentsListingViewModel : ViewModelBase
    {
        // We use an observable collection to update the UI simultaneously
        private readonly ObservableCollection<StudentsListingItemViewModel>? 
            _studentsListingItemViewModels;
        public IEnumerable<StudentsListingItemViewModel>? StudentsListingItemViewModels
            => _studentsListingItemViewModels;
        public StudentsListingViewModel()
        {
            _studentsListingItemViewModels = new ObservableCollection<StudentsListingItemViewModel>();
            _studentsListingItemViewModels.Add(new StudentsListingItemViewModel("John"));
            _studentsListingItemViewModels.Add(new StudentsListingItemViewModel("Sean"));
            _studentsListingItemViewModels.Add(new StudentsListingItemViewModel("Alan"));
        }
    }
}
