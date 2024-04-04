using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace cbb.core
{
    public static class Repository
    {
        public static void Add()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                string path = "";

                if (dialog.ShowDialog() == DialogResult.OK)
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
    }
}
