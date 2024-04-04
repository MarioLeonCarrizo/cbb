using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cbb.core
{
    public class FamilyManagerMainPageViewModel : BaseViewModel
    {
        public ApplicationPageType CurrentPage { get; set; } = ApplicationPageType.Family;
        public ICommand FamilyBtnCommand { get; set; }
        public ICommand PreferencesBtnCommand { get; set; }

        public FamilyManagerMainPageViewModel()
        {
            // Application page switch commands and actions.
            FamilyBtnCommand = new RouteCommands(() => CurrentPage = ApplicationPageType.Family);
            PreferencesBtnCommand = new RouteCommands(() => CurrentPage = ApplicationPageType.Preferences);
        }
    }
}
