using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvxRecyclerViewLeakTest.Models;
using MvxSIGSEVTest.Models;
using MvxSIGSEVTest.Services;

namespace MvxSIGSEVTest.ViewModels
{
    public class RecyclerViewTestViewModel2 : BaseViewModel
    {
        private readonly IListService m_listService;
        private ObservableCollection<IListItem> m_testList;

        public ObservableCollection<IListItem> TestList
        {
            get { return m_testList; }
            set
            {
                m_testList = value;
                RaisePropertyChanged(() => TestList);
            }
        }

        public RecyclerViewTestViewModel2(IListService listService)
        {
            m_listService = listService;
            TestList = new ObservableCollection<IListItem>();
        }

        public void Update()
        {
            TestList.Clear();
            foreach (var item in m_listService.ListItems)
            {
                TestList.Add(item);
                item.Count = 0;
                // Switch out above with following code to avoid error:
                //var binder = new ListItemBinder(item);
                //TestList.Add(binder);
                //binder.Count = 0;
            }
        }

        public virtual ICommand ButtonClick
        {
            get
            {
                return new MvxCommand(() =>
                {
                    Update();
                });
            }
        }

    }
}
