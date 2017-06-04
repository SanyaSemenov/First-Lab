using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Data.SqlClient;

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

            else
            {
                using (SqlConnection con = new SqlConnection("Server=HOOLIGAN\\SQLEXPRESS;Database=FirstDataBase;Trusted_Connection=True;"))
                {
                    con.Open();
                    String query = String.Format("INSERT INTO DeliveryReadOnly(SubjectID, Subject, CityID, City, StreetID, Street, House_Number, House_Block, Flat, Time_Interval, Comment) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", apply.SelectedSubject.Code, apply.SelectedSubject.Name, apply.SelectedCity.Code, apply.SelectedCity.Name, apply.SelectedStreet.Code, apply.SelectedStreet.Name, apply.HouseNumber, apply.HouseBlock, apply.Flat, Convert.ToString(apply.Time), apply.Comment);
                    SqlCommand cmdSave = new SqlCommand(query, con);
                    cmdSave.ExecuteNonQuery();
                }

                MessageBox.Show("Спасибо! Заявка отправлена");
            }
        }
    }
}
