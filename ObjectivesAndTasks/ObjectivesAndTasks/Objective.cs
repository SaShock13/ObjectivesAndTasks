using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ObjectivesAndTasks
{
    public class Objective : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }


        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }
        private int priority;

        public int Priority
        {
            get { return priority; }
            set
            {
                priority = value;
                OnPropertyChanged("Priority");
            }
        }
        private bool isAchived;

        public bool IsAchived
        {
            get { return isAchived; }
            set
            {
                isAchived = value;
                OnPropertyChanged("IsAchived");
            }
        }
        private string status;

        public string Status
        {
            get
            {
                string achived = " не достигнута";
                if (IsAchived == true)
                {
                    achived = "достигнута!";
                }
                else achived = "пока не достигнута.";
                return "Цель \"" + $"{Name}" + $"\" {achived}";
            }
            set { status = value; OnPropertyChanged("Status"); }
        }


        public Objective(string name, string description, int priority)
        {
            Name = name;
            Description = description;
            Priority = priority;
            IsAchived = false;
            Status = $"Цель {Name} пока не достигнута.";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return $"{Name} {Description}, Приоритет : {Priority}";
        }

        
    }
}
