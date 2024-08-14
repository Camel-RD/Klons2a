using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib7.BindingListView
{
    public  interface IMyBindingListView
    {
        void KillView();
        public IList SourceLists { get; set; }
        public IList NewItemsList { get; set; }

    }
}
