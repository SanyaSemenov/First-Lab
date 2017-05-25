using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Lab1
{
    class ResetCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var apply = parameter as MainWindowViewModel;
            apply.Comment = "";
            apply.SelectedSubject = apply.Subjects[3];
            apply.SelectedCity = apply.Subjects[3].Cities[0];
            apply.SelectedStreet = apply.Subjects[3].Cities[0].Streets[0];
            apply.HouseNumber = null;
            apply.HouseBlock = null;
            apply.Flat = null;
            apply.Time = TimeInterval.Daytime;
            apply.HouseNumber = null;
            apply.DoPropertyChanged("Comment");
            apply.DoPropertyChanged("SelectedSubject");
            apply.DoPropertyChanged("SelectedCity");
            apply.DoPropertyChanged("SelectedStreet");
            apply.DoPropertyChanged("HouseNumber");
            apply.DoPropertyChanged("HouseBlock");
            apply.DoPropertyChanged("Flat");
            apply.DoPropertyChanged("Time");
        }
    }
}
