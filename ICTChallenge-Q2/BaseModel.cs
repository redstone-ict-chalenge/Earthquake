using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTChallenge_Q2
{
    public class BaseModel : INotifyPropertyChanged
    {
        private string _title;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName)); }
        public string Title { get { return _title; } set { _title = value; OnPropertyChanged("Title"); } }
    }
}
