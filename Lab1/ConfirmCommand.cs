using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Lab1
{
    public class ConfirmCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var apply = parameter as MainWindowViewModel;
            if (apply.HouseNumber.Equals("0") && apply.HouseBlock.Equals("0") && apply.Flat.Equals("0"))
            {
                throw new ArgumentNullException("Извините, мы не обрабатываем пустые заявки");
            }
            if (String.IsNullOrWhiteSpace(apply.SelectedSubject.Name))
                throw new ArgumentNullException("Пожалуйста, укажите субъект");

            if (String.IsNullOrWhiteSpace(apply.SelectedCity.Name))
                throw new ArgumentNullException("Пожалуйста, укажите город");

            MessageBox.Show("Заявка отправлена");
        }
    }
}
