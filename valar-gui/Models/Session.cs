using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valar_gui.Models
{
    internal class Session : INotifyPropertyChanged
    {
        private bool m_started;

        public Session()
        {
            Started = true;
        }

        public bool Started
        {
            get => m_started;
            set
            {
                m_started = value;
                OnPropertyChanged("Started");
            }
        }

        #region INotify
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
