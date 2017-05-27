using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace Lab1
{
    public class ConfirmCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var apply = parameter as MainWindowViewModel;
            if (apply.SelectedSubject == null || String.IsNullOrWhiteSpace(apply.SelectedSubject.Name) ||
                apply.SelectedCity == null || String.IsNullOrWhiteSpace(apply.SelectedCity.Name) ||
                apply.SelectedStreet == null || String.IsNullOrWhiteSpace(apply.SelectedStreet.Name) ||
                apply.HouseNumber == null || apply.HouseNumber == 0 ||
                apply.Flat == null || apply.Flat == 0 ||
                apply.Time != TimeInterval.Daytime && apply.Time != TimeInterval.Morning && apply.Time != TimeInterval.Evening)
                MessageBox.Show("Проверьте правильность введенных данных и повторите");

            else MessageBox.Show("Спасибо! Заявка отправлена");
        }
    }
}
