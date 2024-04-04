using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    public class FamilyListViewModel : BaseViewModel
    {
        public ObservableCollection<FamilyItem> Items { get; set; }

        public FamilyListViewModel()
        {
            // Populate Items list for list control.
            Items = Populate();
        }

        private ObservableCollection<FamilyItem> Populate()
        {
            var items = new ObservableCollection<FamilyItem>();

            foreach (var path in Preferences.Load().Repository)
            {
                // Get family items from repository.
                var children = FamilyList.GetItems(path);

                // Add them to collection.
                foreach (var child in children)
                    items.Add(child);
            }

            return items;
        }
    }
}
