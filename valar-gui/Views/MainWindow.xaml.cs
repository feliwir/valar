using System.Windows;
using valar;
using valar_gui.ViewModels;

namespace valar_gui.Views
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DebugSession m_session;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new SessionViewModel();
        }
    }
}
