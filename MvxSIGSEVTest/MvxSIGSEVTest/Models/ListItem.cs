using MvvmCross.Core.ViewModels;
using MvxRecyclerViewLeakTest.Models;

namespace MvxSIGSEVTest.Models
{
    public class ListItem :MvxNotifyPropertyChanged, IListItem
    {
        private int m_count;

        public int Count
        {
            get
            {
                return m_count;
            }
            set
            {
                m_count = value;
                RaisePropertyChanged(() => Count);
            }
        }

        public string Name { get; set; }

        public ListItem(string sName)
        {
            Name = sName;
            Count = 0;
        }

    }
}
