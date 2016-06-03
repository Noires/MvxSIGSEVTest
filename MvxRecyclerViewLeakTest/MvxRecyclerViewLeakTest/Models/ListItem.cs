using MvvmCross.Core.ViewModels;

namespace MvxRecyclerViewLeakTest.Models
{
    public class ListItem : MvxNotifyPropertyChanged
    {
        public string Name { get; set; }

        public ListItem(string sName)
        {
            Name = sName;
        }
    }
}
