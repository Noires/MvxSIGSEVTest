using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvxRecyclerViewLeakTest.Models;

namespace MvxRecyclerViewLeakTest.ViewModels
{
    public class RecyclerViewTestViewModel : BaseViewModel
    {
        private ObservableCollection<ListItem> m_testList;

        public ObservableCollection<ListItem> TestList
        {
            get { return m_testList; }
            set
            {
                m_testList = value;
                RaisePropertyChanged(() => TestList);
            }
        }

        public RecyclerViewTestViewModel()
        {
            TestList = new ObservableCollection<ListItem>();
        }

        public virtual ICommand ButtonClick
        {
            get
            {
                return new MvxCommand(() =>
                {
                    TestList.Clear();
                    for (int i = 0; i < 500; i++)
                    {
                        TestList.Add(new ListItem("Test"+i));
                    }
                });
            }
        }

    }
}
