using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equin.ApplicationFramework
{
    public  class ObjectViewEndEditEventArgs : EventArgs
    {
        public bool HasChanges { get; private set; } = true;
        public ObjectViewEndEditEventArgs(bool haschanges) 
        {
            HasChanges = haschanges;
        }
    }
}
