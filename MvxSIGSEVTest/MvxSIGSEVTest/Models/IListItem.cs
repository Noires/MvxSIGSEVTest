using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvxRecyclerViewLeakTest.Models
{
    public interface IListItem
    {
        int Count { get; set; }
        string Name { get; set; }
    }
}
