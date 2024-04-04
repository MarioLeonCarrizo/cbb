using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    public class RepositoryListViewModel
    {
        public ObservableCollection<RepositoryItem> Repository { get; set; }

        public RepositoryListViewModel()
        {
            Repository = GetRepositories();
        }

        private ObservableCollection<RepositoryItem> GetRepositories()
        {
            var items = new ObservableCollection<RepositoryItem>();

            var prefs = Preferences.Load();

            foreach(var path in prefs.Repository)
            {
                var respository = new RepositoryItem
                {
                    FullPath = path,
                };
                items.Add(respository);
            }

            return items;
        }
    }
}
