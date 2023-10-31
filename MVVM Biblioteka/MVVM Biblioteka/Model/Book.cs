using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Biblioteka
{
    internal class Book : INotifyPropertyChanged
    {
        public string title { get; set; }
        public string avtor { get; set; }
        public int acr { get; set; }
        public int count { get; set; }
        public DateTime age { get; set; }
        public User issuedToUser { get; set; }
        public bool isIssued { get; set; }

        public string Title
        {
            get { return title; }

            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Avtor
        {
            get { return avtor; }

            set
            {
                avtor = value;
                OnPropertyChanged("Avtor");
            }
        }
        public int Acr
        {
            get { return acr; }

            set
            {
                acr = value;
                OnPropertyChanged("Acr");
            }
        }
        public int Count
        {
            get { return count; }

            set
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }
        public DateTime Age
        {
            get { return age; }

            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        public User IssuedToUser
        {
            get { return issuedToUser; }

            set
            {
                issuedToUser = value;
                OnPropertyChanged("IssuedToUser");
            }
        }
        public bool IsIssued
        {
            get { return isIssued; }

            set
            {
                isIssued = value;
                OnPropertyChanged("isIssued");
            }
        }

        //The message is not supported on this version of Telegram.
        public Book(string title, string avtor, int count, int acr)
        {
            this.title = title;
            this.avtor = avtor;
            this.count = count;
            this.acr = acr;
            isIssued = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
}
