using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using valar_gui.Models;

namespace valar_gui.ViewModels
{
    internal class SessionViewModel
    {
        private Session m_session;

        public SessionViewModel()
        {
            m_session = new Session();
        }

        internal Session Session { get => m_session; }

        public void SaveChanges()
        {

        }
    }

}
