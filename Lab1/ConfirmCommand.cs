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
    class ConfirmCommand:ICommand
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
                throw new ArgumentNullException("Извините, мы не обрабатываем пустые заявки");
            }
            if (String.IsNullOrWhiteSpace(apply.SelectedSubject.Name))
                throw new ArgumentNullException("Пожалуйста, укажите субъект");

            if (String.IsNullOrWhiteSpace(apply.SelectedCity.Name))
                throw new ArgumentNullException("Пожалуйста, укажите город");

            /*var flats = vmFilter.Flats.Where(
                x => x.Area >= vmFilter.AreaMin && x.Area <= vmFilter.AreaMax &&
                x.Price >= vmFilter.PriceMin && x.Price <= vmFilter.PriceMax &&
                x.SubwayStation.Equals(vmFilter.SelectedStation.Key, StringComparison.CurrentCultureIgnoreCase)
                );

            ObservableCollection<FlatViewModel> newElements = new ObservableCollection<FlatViewModel>();
            foreach (var f in flats)
            {
                newElements.Add(f);
            }


            var prop = parameter.GetType().GetProperty("Flats", System.Reflection.BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance);
            prop.SetValue(parameter, newElements);

            var meth = parameter.GetType().GetMethod("DoPropertyChanged");
            if (meth != null)
            {
                Object[] parameters = new object[] { "Flats" };
                meth.Invoke(parameter, parameters);
            }*/
            MessageBox.Show("Заявка отправлена");
            //throw new NotImplementedException();
        }
    }
}
