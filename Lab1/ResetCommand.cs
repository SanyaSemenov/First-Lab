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
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            var apply = parameter as MainWindowViewModel;
            if (apply == null)
            {
                MessageBox.Show("Форма уже пустая");
            }

            apply.Comment = "";
            apply.SelectedCity = new City() { Name = "Москва" };
            apply.SelectedSubject = new Subject() { Name = "Москва" };
            apply.HouseNumber = 0;
            apply.HouseBlock = 0;
            apply.Flat = 0;
            apply.Time = TimeInterval.Daytime;
        }
    }
}
