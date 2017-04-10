using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Lab1
{
    /*public class SubjectToCityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                //var stationName = ((KeyValuePair<String, Color>)value);
                var subjectName = value as String;
                if (String.IsNullOrWhiteSpace(subjectName))
                {
                    return "Москва";
                }

                switch (subjectName)
                {
                    case "Москва":
                        {
                            return new List<String>() { "Москва" };
                        }
                    case "Санкт-Петербург":
                        {
                            return new List<String>() { "Санкт-Петербург" };
                        }
                    case "Московская область":
                        {
                            return new List<String>()
                            {
                                "Балашиха",
                                "Домодедово",
                                "Красноармейск",
                                "Королёв",
                                "Котельники",
                                "Мытищи",
                                "Подольск",
                                "Реутов",
                                "Химки",
                                "Электросталь"
                            };
                        }
                    case "Вологодская область":
                        {
                            return new List<String>()
                            {
                                "Вологда",
                                "Череповец",
                                "Бабаево",
                                "Белозёрск",
                                "Великий Устюг",
                                "Вытерга",
                                "Грязовец",
                                "Кириллов",
                                "Никольск",
                                "Сокол",
                                "Тотьма",
                                "Устюжна",
                                "Харовск"
                            };
                        }
                    case "Чувашская Республика":
                        {
                            return new List<String>()
                            {
                                "Чебоксары",
                                "Маринский Посад",
                                "Шумерля",
                                "Канаш",
                                "Ядрин",
                                "Новочебоксарск",
                                "Красноармейское",
                                "Козловка",
                                "Цивильск"
                            };
                        }
                    default:
                        {
                            return new List<String>() { "Москва" };
                        }
                }
            }
            catch
            {
                return new List<String>() { "Москва" };
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }*/
}
