using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Data.SqlClient;

namespace Lab1
{
    public enum TimeInterval { Morning = 1, Daytime = 2, Evening = 3 }
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public List<Subject> Subjects { get; set; }
        public List<City> Cities { get; set; }
        public List<Street> Streets { get; set; }
        public Int16? HouseNumber { get; set; }
        public Int16? HouseBlock { get; set; }
        public Int16? Flat { get; set; }
        public TimeInterval Time { get; set; }
        public String Comment { get; set; }

        public ICommand Confirm { get; set; }
        public ICommand Reset { get; set; }

        private Subject _selectedSubject;
        public Subject SelectedSubject
        {
            get { return _selectedSubject; }
            set
            {
                if (value == null)
                    return;
                _selectedSubject = value;
                DoPropertyChanged("SelectedSubject");
                this.Cities = _selectedSubject.Cities;
                DoPropertyChanged("Cities");
            }
        }

        private City _selectedCity;
        public City SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                if (value == null)
                    return;
                _selectedCity = value;
                DoPropertyChanged("SelectedCity");
                this.Streets = _selectedCity.Streets;
                DoPropertyChanged("Streets");
            }
        }

        private Street _selectedStreet;
        public Street SelectedStreet
        {
            get { return _selectedStreet; }
            set
            {
                if (value == null)
                    return;
                _selectedStreet = value;
                DoPropertyChanged("SelectedStreet");
            }
        }

        public MainWindowViewModel()
        {
            FillSubjects();
            //InsertSubjects();
            //InsertCities();
            //InsertStreets();
            //Correlate();
            Confirm = new ConfirmCommand();
            Reset = new ResetCommand();
        }

        /*public void InsertSubjects()
        {
            using (SqlConnection Con = new SqlConnection("Server=HOOLIGAN\\SQLEXPRESS;Database=FirstDataBase;Trusted_Connection=True;"))
            {
                Con.Open();
                SqlCommand cmdSubjects = new SqlCommand("SELECT * FROM Subjects s", Con);
                Subjects = new List<Subject>();
                var SubjectsReader = cmdSubjects.ExecuteReader();
                while (SubjectsReader.Read())
                {
                    Subjects.Add(new Subject() { Code = (int)SubjectsReader["ID"], Name = (String)SubjectsReader["Name"] });
                }
            }
        }
        public void InsertCities()
        {
            using (SqlConnection Con = new SqlConnection("Server=HOOLIGAN\\SQLEXPRESS;Database=FirstDataBase;Trusted_Connection=True;"))
            {
                Con.Open();
                SqlCommand cmdCity = new SqlCommand("SELECT * FROM Cities c", Con);
                Cities = new List<City>();

                var CityReader = cmdCity.ExecuteReader();
                while (CityReader.Read())
                {
                    Cities.Add(new City() { Code = (int)CityReader["ID"], Name = (String)CityReader["City"], SubjectID = (int)CityReader["SubjectID"] });
                }
            }
        }

        public void InsertStreets()
        {
            using (SqlConnection Con = new SqlConnection("Server=HOOLIGAN\\SQLEXPRESS;Database=FirstDataBase;Trusted_Connection=True;"))
            {
                Con.Open();
                SqlCommand cmdStreet = new SqlCommand("SELECT * FROM Streets t", Con);
                Streets = new List<Street>();
                var StreetReader = cmdStreet.ExecuteReader();
                while (StreetReader.Read())
                {
                    Streets.Add(new Street() { Code = (int)StreetReader["ID"], Name = (String)StreetReader["Street"], CityID = (int)StreetReader["CityID"] });
                }
            }
        }

        public void Correlate()
        {
            for (int i = 0; i < Cities.Count; i++)
            {
                for (int j = 0; j < Subjects.Count; j++)
                {
                    if (Cities[i].SubjectID == Subjects[j].Code)
                    {
                        Subjects[j].Cities.Add(Cities[i]);
                    }
                }
            }
        }*/

        public void FillSubjects()
        {
            this.Subjects = new List<Subject>()
            {
                new Subject(){ Name = "Вологодская область", Code = 35,
                    Cities = new List<City>()
                    {
                        new City(){ Code = 3501, Name = "Вологда", Streets = new List<Street>() {
                            new Street(35011, "Первая Вологодская"),
                            new Street(35012, "Вторая Вологодская")
                        } },
                        new City(){ Code = 3502, Name = "Череповец", Streets = new List<Street>() {
                            new Street(35021, "Первая Череповецкая"),
                            new Street(35022, "Вторая Череповецкая")
                        } },
                        new City(){ Code = 3503, Name = "Бабаево", Streets = new List<Street>() {
                            new Street(35031, "Первая Бабаевская"),
                            new Street(35032, "Вторая Бабаевская")
                        } },
                        new City(){ Code = 3504, Name = "БелоЗёрск", Streets = new List<Street>() {
                            new Street(35041, "Первая Белозёрская"),
                            new Street(35042, "Вторая Белозёрская")
                        } },
                        new City(){ Code = 3505, Name = "Великий Устюг", Streets = new List<Street>() {
                            new Street(35051, "Первая Великая"),
                            new Street(35052, "Вторая Великая")
                        } },
                        new City(){ Code = 3506, Name = "Вытерга", Streets = new List<Street>() {
                            new Street(35061, "Первая Вытерговская"),
                            new Street(35062, "Вторая Вытерговская")
                        } },
                        new City(){ Code = 3507, Name = "Грязовец", Streets = new List<Street>() {
                            new Street(35071, "Первая Грязовецкая"),
                            new Street(35072, "Вторая Грязовецкая")
                        } },
                        new City(){ Code = 3508, Name = "Кириллов", Streets = new List<Street>() {
                            new Street(35081, "Первая Кирилловская"),
                            new Street(35082, "Вторая Кирилловская")
                        } },
                        new City(){ Code = 3509, Name = "Никольск", Streets = new List<Street>() {
                            new Street(35091, "Первая Вологодская"),
                            new Street(35092, "Вторая Вологодская")
                        } },
                        new City(){ Code = 3510, Name = "Сокол", Streets = new List<Street>() {
                            new Street(35101, "Первая Соколовская"),
                            new Street(35102, "Вторая Соколовская")
                        } },
                        new City(){ Code = 3511, Name = "Тотьма", Streets = new List<Street>() {
                            new Street(35111, "Первая Тотьмовская"),
                            new Street(35112, "Вторая Тотьмовская")
                        } },
                        new City(){ Code = 3512, Name = "Устюжна", Streets = new List<Street>() {
                            new Street(35121, "Первая Устюжинская"),
                            new Street(35122, "Вторая Устюжинская")
                        } },
                        new City(){ Code = 3513, Name = "Харовск", Streets = new List<Street>() {
                            new Street(35131, "Первая Харовская"),
                            new Street(35132, "Вторая Харовская")
                        } },
                    }
                },
                new Subject(){ Name = "Чувашская Республика", Code = 21,
                    Cities = new List<City>()
                    {
                        new City(){ Code = 2101, Name = "Чебоксары", Streets = new List<Street>() {
                            new Street(21011, "Первая Чебоксарская"),
                            new Street(21012, "Вторая Чебоксарская")
                        } },
                        new City(){ Code = 2102, Name = "Маринский Посад", Streets = new List<Street>() {
                            new Street(21021, "Первая Посадская"),
                            new Street(21022, "Вторая Посадская")
                        } },
                        new City(){ Code = 2103, Name = "Шумерля", Streets = new List<Street>() {
                            new Street(21031, "Первая Шумерлинская"),
                            new Street(21032, "Вторая Шумерлинская")
                        } },
                        new City(){ Code = 2104, Name = "Канаш", Streets = new List<Street>() {
                            new Street(21041, "Первая Канашская"),
                            new Street(21042, "Вторая Канашская")
                        } },
                        new City(){ Code = 2105, Name = "Ядрин", Streets = new List<Street>() {
                            new Street(21051, "Первая Ядринская"),
                            new Street(21052, "Вторая Ядринская")
                        } },
                        new City(){ Code = 2106, Name = "Новочебоксарск", Streets = new List<Street>() {
                            new Street(21061, "Первая Новочебоксарская"),
                            new Street(21062, "Вторая Новочебоксарская")
                        } },
                        new City(){ Code = 2107, Name = "Красноармейское", Streets = new List<Street>() {
                            new Street(21071, "Первая Красная"),
                            new Street(21072, "Вторая Красная")
                        } },
                        new City(){ Code = 2108, Name = "Козловка", Streets = new List<Street>() {
                            new Street(21081, "Первая Козловская"),
                            new Street(21082, "Вторая Козловская")
                        } },
                        new City(){ Code = 2109, Name = "Цивильск", Streets = new List<Street>() {
                            new Street(21091, "Первая Цивильская"),
                            new Street(21092, "Вторая Цивильская")
                        } }
                    }
                },
                new Subject() { Name="Московская область", Code= 50,
                    Cities = new List<City>()
                    {
                        new City() { Code = 5001, Name = "Балашиха", Streets = new List<Street>() {
                            new Street(50011, "Первая Балашихинская"),
                            new Street(50012, "Вторая Балашихинская")
                        }  },
                        new City() { Code = 5002, Name = "Домодедово", Streets = new List<Street>() {
                            new Street(50021, "Первая Домодедовская"),
                            new Street(50022, "Вторая Домодедовская")
                        }  },
                        new City() { Code = 5003, Name = "Красноармейск", Streets = new List<Street>() {
                            new Street(50031, "Первая Красноармейская"),
                            new Street(50032, "Вторая Красноармейская")
                        }  },
                        new City() { Code = 5004, Name = "Королёв", Streets = new List<Street>() {
                            new Street(50041, "Первая Королевская"),
                            new Street(50042, "Вторая Королевская")
                        }  },
                        new City() { Code = 5005, Name = "Котельники", Streets = new List<Street>() {
                            new Street(50051, "Первая Котельная"),
                            new Street(50052, "Вторая Котельная")
                        }  },
                        new City() { Code = 5006, Name = "Мытищи", Streets = new List<Street>() {
                            new Street(50061, "Первая Мытищинская"),
                            new Street(50062, "Вторая Мытищинская")
                        }  },
                        new City() { Code = 5007, Name = "Подольск", Streets = new List<Street>() {
                            new Street(50071, "Первая Подольская"),
                            new Street(50072, "Вторая Подольская")
                        }  },
                        new City() { Code = 5008, Name = "Реутов", Streets = new List<Street>() {
                            new Street(50081, "Первая Реутовская"),
                            new Street(50082, "Вторая Реутовская")
                        }  },
                        new City() { Code = 5009, Name = "Химки", Streets = new List<Street>() {
                            new Street(50091, "Первая Химкинская"),
                            new Street(50092, "Вторая Химкинская")
                        }  },
                        new City() { Code = 5010, Name = "Электросталь", Streets = new List<Street>() {
                            new Street(50101, "Первая Стальная"),
                            new Street(50102, "Вторая Стальная")
                        }  }
                    }
                },
                new Subject(){ Name = "Москва", Code = 77,
                    Cities = new List<City>()
                    {
                        new City(){ Code = 7701, Name = "Москва", Streets = new List<Street>() {
                            new Street(77011, "Первая Московская"),
                            new Street(77012, "Вторая Московская")
                        }  }
                    }
                },
                new Subject(){ Name = "Санкт-Петербург", Code = 78,
                    Cities = new List<City>()
                    {
                        new City(){ Code = 7801, Name = "Санкт-Петербург", Streets = new List<Street>() {
                            new Street(78011, "Первая Санкт-Петебургская"),
                            new Street(78012, "Вторая Санкт-Петебургская")
                        }  }
                    }
                }
            };

            this.SelectedSubject = this.Subjects[0];
            this.SelectedCity = this.Subjects[0].Cities[0];
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(String Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Name));
            }
        }
    }
}
