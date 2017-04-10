using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace Lab1
{
    public enum TimeInterval { Morning = 1, Daytime = 2, Evening = 3 }
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public List<Subject> Subjects { get; set; }
        public List<City> Cities { get; set; }
        public List<Street> Streets { get; set; }
        public Int16 HouseNumber { get; set; }
        public Byte HouseBlock { get; set; }
        public Int16 Flat { get; set; }
        public TimeInterval Time { get; set; }
        public String Comment { get; set; }

        public ICommand Confirm { get; set; }

        private Subject _selectedSubject;
        public Subject SelectedSubject
        {
            get { return _selectedSubject; }
            set
            {
                _selectedSubject = value;
                DoPropertyChanged("SelectedCountry");
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
            set { _selectedStreet = value; }
        }

        public MainWindowViewModel()
        {
            FillSubjects();
            this.SelectedCity = this.Subjects[2].Cities[0];
            this.SelectedStreet = this.Subjects[2].Cities[0].Streets[0];
            Confirm = new ConfirmCommand();
        }
        public void FillSubjects()
        {
            this.Subjects = new List<Subject>()
            {
                new Subject(){ Name = "Вологодская область", Code = 35,
                    Cities = new List<City>()
                    {
                        new City(){ Name = "Вологда", Streets = new List<Street>() {
                            new Street("Первая Вологодская"),
                            new Street("Вторая Вологодская")
                        } },
                        new City(){ Name = "Череповец", Streets = new List<Street>() {
                            new Street("Первая Череповецкая"),
                            new Street("Вторая Череповецкая")
                        } },
                        new City(){ Name = "Бабаево", Streets = new List<Street>() {
                            new Street("Первая Бабаевская"),
                            new Street("Вторая Бабаевская")
                        } },
                        new City(){ Name = "БелоЗёрск", Streets = new List<Street>() {
                            new Street("Первая Белозёрская"),
                            new Street("Вторая Белозёрская")
                        } },
                        new City(){ Name = "Великий Устюг", Streets = new List<Street>() {
                            new Street("Первая Великая"),
                            new Street("Вторая Великая")
                        } },
                        new City(){ Name = "Вытерга", Streets = new List<Street>() {
                            new Street("Первая Вытерговская"),
                            new Street("Вторая Вытерговская")
                        } },
                        new City(){ Name = "Грязовец", Streets = new List<Street>() {
                            new Street("Первая Грязовецкая"),
                            new Street("Вторая Грязовецкая")
                        } },
                        new City(){ Name = "Кириллов", Streets = new List<Street>() {
                            new Street("Первая Кирилловская"),
                            new Street("Вторая Кирилловская")
                        } },
                        new City(){ Name = "Никольск", Streets = new List<Street>() {
                            new Street("Первая Вологодская"),
                            new Street("Вторая Вологодская")
                        } },
                        new City(){ Name = "Сокол", Streets = new List<Street>() {
                            new Street("Первая Соколовская"),
                            new Street("Вторая Соколовская")
                        } },
                        new City(){ Name = "Тотьма", Streets = new List<Street>() {
                            new Street("Первая Тотьмовская"),
                            new Street("Вторая Тотьмовская")
                        } },
                        new City(){ Name = "Устюжна", Streets = new List<Street>() {
                            new Street("Первая Устюжинская"),
                            new Street("Вторая Устюжинская")
                        } },
                        new City(){ Name = "Харовск", Streets = new List<Street>() {
                            new Street("Первая Харовская"),
                            new Street("Вторая Харовская")
                        } },
                    }
                },
                new Subject(){ Name = "Чувашская Республика", Code = 21,
                    Cities = new List<City>()
                    {
                        new City(){ Name = "Чебоксары", Streets = new List<Street>() {
                            new Street("Первая Чебоксарская"),
                            new Street("Вторая Чебоксарская")
                        } },
                        new City(){ Name = "Маринский Посад", Streets = new List<Street>() {
                            new Street("Первая Посадская"),
                            new Street("Вторая Посадская")
                        } },
                        new City(){ Name = "Шумерля", Streets = new List<Street>() {
                            new Street("Первая Шумерлинская"),
                            new Street("Вторая Шумерлинская")
                        } },
                        new City(){ Name = "Канаш", Streets = new List<Street>() {
                            new Street("Первая Канашская"),
                            new Street("Вторая Канашская")
                        } },
                        new City(){ Name = "Ядрин", Streets = new List<Street>() {
                            new Street("Первая Ядринская"),
                            new Street("Вторая Ядринская")
                        } },
                        new City(){ Name = "Новочебоксарск", Streets = new List<Street>() {
                            new Street("Первая Новочебоксарская"),
                            new Street("Вторая Новочебоксарская")
                        } },
                        new City(){ Name = "Красноармейское", Streets = new List<Street>() {
                            new Street("Первая Красная"),
                            new Street("Вторая Красная")
                        } },
                        new City(){ Name = "Козловка", Streets = new List<Street>() {
                            new Street("Первая Козловская"),
                            new Street("Вторая Козловская")
                        } },
                        new City(){ Name = "Цивильск", Streets = new List<Street>() {
                            new Street("Первая Цивильская"),
                            new Street("Вторая Цивильская")
                        } }
                    }
                },
                new Subject() { Name="Московская область", Code= 50,
                    Cities = new List<City>()
                    {
                        new City() { Name = "Балашиха", Streets = new List<Street>() {
                            new Street("Первая Балашихинская"),
                            new Street("Вторая Балашихинская")
                        }  },
                        new City() { Name = "Домодедово", Streets = new List<Street>() {
                            new Street("Первая Домодедовская"),
                            new Street("Вторая Домодедовская")
                        }  },
                        new City() { Name = "Красноармейск", Streets = new List<Street>() {
                            new Street("Первая Красноармейская"),
                            new Street("Вторая Красноармейская")
                        }  },
                        new City() { Name = "Королёв", Streets = new List<Street>() {
                            new Street("Первая Королевская"),
                            new Street("Вторая Королевская")
                        }  },
                        new City() { Name = "Котельники", Streets = new List<Street>() {
                            new Street("Первая Котельная"),
                            new Street("Вторая Котельная")
                        }  },
                        new City() { Name = "Мытищи", Streets = new List<Street>() {
                            new Street("Первая Мытищинская"),
                            new Street("Вторая Мытищинская")
                        }  },
                        new City() { Name = "Подольск", Streets = new List<Street>() {
                            new Street("Первая Подольская"),
                            new Street("Вторая Подольская")
                        }  },
                        new City() { Name = "Реутов", Streets = new List<Street>() {
                            new Street("Первая Реутовская"),
                            new Street("Вторая Реутовская")
                        }  },
                        new City() { Name = "Химки", Streets = new List<Street>() {
                            new Street("Первая Химкинская"),
                            new Street("Вторая Химкинская")
                        }  },
                        new City() { Name = "Электросталь", Streets = new List<Street>() {
                            new Street("Первая Стальная"),
                            new Street("Вторая Стальная")
                        }  }
                    }
                },
                new Subject(){ Name = "Москва", Code = 77,
                    Cities = new List<City>()
                    {
                        new City(){ Name = "Москва", Streets = new List<Street>() {
                            new Street("Первая Московская"),
                            new Street("Вторая Московская")
                        }  }
                    }
                },
                new Subject(){ Name = "Санкт-Петербург", Code = 50,
                    Cities = new List<City>()
                    {
                        new City(){ Name = "Санкт-Петербург", Streets = new List<Street>() {
                            new Street("Первая Санкт-Петебургская"),
                            new Street("Вторая Санкт-Петебургская")
                        }  }
                    }
                }
            };

            this.SelectedSubject = this.Subjects[2];
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
