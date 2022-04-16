using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2CSharp.Tools;
using Lab2CSharp.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
namespace Lab2CSharp.ViewModels
{
    class PersonAnalyserViewModel
    {
        #region Fields
        private PersonCandidate _person = new PersonCandidate();
        private RelayCommand<object> _proceedCommand;
        #endregion

        #region Properties
        public string FirstName
        {
            get
            {
                return _person.FirstName;
            }
            set
            {
                _person.FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _person.LastName;
            }
            set
            {
                _person.LastName = value;
            }
        }
        public string Email
        {
            get
            {
                return _person.Email;
            }
            set
            {
                _person.Email = value;
            }
        }
        public DateTime? Birthdate
        {
            get
            {
                return _person.Birthdate;
            }
            set
            {
                _person.Birthdate = value;
            }
        }
        #endregion

        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _proceedCommand ??= new RelayCommand<object>(_ => Proceed(), CanExecute);
            }
        }

        private async void Proceed()
        {
                try
                {
                    await Task.Run(() => AnalysePersonCandidate(_person));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Process failed: {ex.Message}");
                    return;
                }
        }

        private void AnalysePersonCandidate(PersonCandidate pCandidate)
        {
            Thread.Sleep(2000);
            Person person = new Person(pCandidate.FirstName, pCandidate.LastName, pCandidate.Email, pCandidate.Birthdate.Value);
            if(person.GetAge()>135 || person.GetAge()<0)
            {
                MessageBox.Show("Wrong date!\nYou cannot be over 135 years old and your date of birth must be today or earlier!");
            } else
            {
                MessageBox.Show("First Name: " + person.FirstName + "\n"
                + "Last Name: " + person.LastName + "\n"
                + "Email: " + person.Email + "\n"
                + "Birthdate: " + person.Birthdate.ToShortDateString() + "\n"
                + "Is Adult: " + person.IsAdult + "\n"
                + "Sun Sign: " + person.SunSign + "\n"
                + "Chinese Sign : " + person.ChineseSign + "\n"
                + "Is Birthday : " + person.IsBirthday + "\n");
            }
        }

        private bool CanExecute(object obj)
        {
            return !String.IsNullOrWhiteSpace(_person.FirstName) 
                && !String.IsNullOrWhiteSpace(_person.LastName)
                && !String.IsNullOrWhiteSpace(_person.Email)
                && Birthdate!=null;
        }
    }
}
