using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cbb.core
{
    public class RepositoryItem
    {
        public string FullPath { get; set; }
        public string Name => PathHelpers.GetFolderName(FullPath);

        public ICommand AddRespositoryCommand { get; set; }
        public ICommand RemoveRespositoryCommand { get; set; }
        public ICommand PropertiesRespositoryCommand { get; set; }


        public RepositoryItem()
        {
            AddRespositoryCommand = new RouteCommands(AddRespositoryCmdFunc);
            RemoveRespositoryCommand = new RouteCommands(RemoveRespositoryCmdFunc);
            PropertiesRespositoryCommand = new RouteCommands(PropertiesRespositoryCmdFunc);
        }

        private void PropertiesRespositoryCmdFunc()
        {
            var createTime = Directory.GetCreationTime(FullPath);
            var lastWriteTime = Directory.GetLastWriteTime(FullPath);
            var msg = new StringBuilder();
            msg.AppendLine("Last Write Time: " + lastWriteTime + "\n Created: " + createTime);
            Message.Display(msg.ToString(), WindowType.Information);
        }

        private void RemoveRespositoryCmdFunc()
        {
            var prefs = Preferences.Load();
            var repository = prefs.Repository;

            var index = repository.IndexOf(FullPath);

            for(int i = 0; i < repository.Count; i++)
            {
                if (repository[index].Equals(FullPath))
                    repository.RemoveAt(index);
            }

            prefs.Repository = repository;
            prefs.Save();
        }

        private void AddRespositoryCmdFunc()
        {
            Repository.Add();
        }
    }
}
