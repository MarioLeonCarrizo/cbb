using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using cbb.core;

namespace cbb.ui
{
    /// <summary>
    /// Lógica de interacción para FamilyLists.xaml
    /// </summary>
    public partial class FamilyListsControl : UserControl
    {
        public FamilyListsControl()
        {
            InitializeComponent();
            DataContext = new FamilyListViewModel();
        }
    }
}
