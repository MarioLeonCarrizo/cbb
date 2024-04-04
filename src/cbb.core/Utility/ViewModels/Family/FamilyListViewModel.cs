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

        private List<string> mPaths = new List<string>
        {
            @"C:\Users\MSI_DB\Pictures\Test"
        };

        public ObservableCollection<FamilyItem> Items { get; set; }

        public FamilyListViewModel()
        {
            // Populate Items list for list control.
            Items = Populate(mPaths);
        }

        private ObservableCollection<FamilyItem> Populate(List<string> paths)
        {
            var items = new ObservableCollection<FamilyItem>();

            foreach (var path in paths)
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
