using MvvmCross.Core.ViewModels;
using MvxSIGSEVTest.Models;

namespace MvxRecyclerViewLeakTest.Models
{
    public class ListItemBinder:MvxNotifyPropertyChanged, IListItem
    {
        private readonly IListItem m_item;

        public ListItemBinder(IListItem item)
        {
            m_item = item;
        }

        public int Count
        {
            get
            {
                return m_item.Count;
            }
            set
            {
                m_item.Count = value;
                RaisePropertyChanged(() => Count);
            }
        }

        public string Name {
            get { return m_item.Name; }
            set
            {
                m_item.Name = value;
                RaisePropertyChanged(() => Name);
            } }
    }
}
