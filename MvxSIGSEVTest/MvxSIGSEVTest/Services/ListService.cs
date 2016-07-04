using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvxRecyclerViewLeakTest.Models;
using MvxSIGSEVTest.Models;

namespace MvxSIGSEVTest.Services
{
    public class ListService:IListService
    {
        public ListService()
        {
            ListItems = new ObservableCollection<IListItem>();
            for (int i = 0; i < 200; i++)
            {
                ListItems.Add(new ListItem("Item"+i));
            }
        }

        public ObservableCollection<IListItem> ListItems { get; }
    }
}
