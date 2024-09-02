using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo2
{
    public class Person
    {
        #region Getter & Setter
        private DateTime _birthdate; //di sini harus PRIFATE nieman van buiten kan weten itu di bilang data hide


        public Person(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public void SetBirthdate(DateTime birthdate) //Setter. tpi prifate bissa di bicarakan di sini
        {
            _birthdate = birthdate; //set _birthdate dari yang atas da
        }
        public DateTime Getbirthdate() //Getter jika saya ingin membaca setter
        {
            return _birthdate; //Get brithday           
        }
        public int Age() //breken terug sturen hoe oud
        {
            TimeSpan timeSpan = DateTime.Today - _birthdate;
            int years = timeSpan.Days / 365;
            return years;

        }
        #endregion Getter

        #region Properties
        //private DateTime _birthDate; // sellau Prifate

        //public DateTime BrithDate
        //{
        //    get { return _birthDate; } //return
        //    set { _birthDate = value; } //waar
        //}

        //public int Age
        //{
        //    get
        //    {
        //        TimeSpan timeSpan = DateTime.Today - _birthDate;
        //        int years = timeSpan.Days / 365;
        //        return years;
               
        //    }

        //}


        #endregion
    }
}
