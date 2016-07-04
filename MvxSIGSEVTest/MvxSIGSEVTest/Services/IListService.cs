using System.Collections.ObjectModel;
using MvxRecyclerViewLeakTest.Models;
using MvxSIGSEVTest.Models;

namespace MvxSIGSEVTest.Services
{
    public interface IListService
    {
        ObservableCollection<IListItem> ListItems { get; }
    }
}
