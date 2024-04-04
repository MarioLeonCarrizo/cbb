using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using cbb.core;

namespace cbb.ui
{
    /// <summary>
    /// Lógica de interacción para PreferencesList.xaml
    /// </summary>
    public partial class RepositoryListControl : UserControl
    {
        public RepositoryListControl()
        {
            InitializeComponent();

            DataContext = new RepositoryListViewModel();
        }
    }
}
