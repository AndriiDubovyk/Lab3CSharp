using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp.Models
{
    class Person
    {
        #region Fields
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _birthdate;
        #endregion

        #region Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
        public bool IsAdult { get; }
        public string SunSign { get; }
        public string ChineseSign { get; }
        public bool IsBirthday { get; }
        #endregion

        #region Constructors
        public Person(string firstName, string lastName, string email, DateTime bitrhdate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _birthdate = bitrhdate;
        }

        public Person(string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }

        public Person(string firstName, string lastName, DateTime bitrhdate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthdate = bitrhdate;
        }
        #endregion

    }
}
