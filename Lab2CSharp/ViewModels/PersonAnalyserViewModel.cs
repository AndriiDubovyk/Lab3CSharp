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

namespace Lab2CSharp.ViewModels
{
    class PersonAnalyserViewModel : INotifyPropertyChanged
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
        public DateTime Birthday
        {
            get
            {
                return _person.Birthday;
            }
            set
            {
                _person.Birthday = value;
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

        private void Proceed()
        {
            MessageBox.Show(Birthday.Year.ToString());
        }

        private bool CanExecute(object obj)
        {
            return true;
        }

        #region EventsAndHandlers
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion
    }
}
