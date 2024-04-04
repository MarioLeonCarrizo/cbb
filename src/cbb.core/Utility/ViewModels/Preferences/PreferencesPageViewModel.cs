using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace cbb.core
{
    public class PreferencesPageViewModel : BaseViewModel
    {
        public ICommand AddRespositoryCommand { get; set; }
        public ICommand RemoveRespositoryCommand { get; set; }

        public PreferencesPageViewModel()
        {
            AddRespositoryCommand = new RouteCommands(AddRespositoryCmdFunc);
            RemoveRespositoryCommand = new RouteCommands(RemoveRespositoryCmdFunc);
        }

        private void AddRespositoryCmdFunc()
        {
            using(var dialog = new FolderBrowserDialog())
            {
                string path = "";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    var prefs = Preferences.Load();
                    prefs.Repository.Add(path);
                    prefs.Save();
                }
                else
                {
                    Message.Display("Provided path is not valid", WindowType.Warning);
                    return;
                }
            }
        }

        private void RemoveRespositoryCmdFunc()
        {
            Message.Display("Remove Repository", WindowType.Information);
        }
    }
}
