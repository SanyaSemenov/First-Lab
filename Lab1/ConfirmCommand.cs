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
            if (apply.SelectedSubject == null || String.IsNullOrWhiteSpace(apply.SelectedSubject.Name))
                MessageBox.Show("Пожалуйста, укажите субъект");

            if (apply.SelectedCity == null || String.IsNullOrWhiteSpace(apply.SelectedCity.Name))
                MessageBox.Show("Пожалуйста, укажите город");

            if (apply.SelectedStreet == null || String.IsNullOrWhiteSpace(apply.SelectedStreet.Name))
                MessageBox.Show("Пожалуйста, укажите улицу");

            if (apply.HouseNumber == null || apply.HouseNumber == 0)
                MessageBox.Show("Пжалуйста, укажите номер дома");

            if (apply.HouseBlock == null || apply.HouseBlock == 0)
                MessageBox.Show("Пожалуйста, укажите номер корпуса (при отсутствии поставьте любое число)");

            if (apply.Flat == null || apply.Flat == 0)
                MessageBox.Show("Пжалуйста, укажите номер квартиры");

            if (apply.Time != TimeInterval.Daytime && apply.Time != TimeInterval.Morning && apply.Time != TimeInterval.Evening)
                MessageBox.Show("Пожалуйста, укажите временной интервал");

            else MessageBox.Show("Спасибо! Заявка отправлена");
        }
    }
}
