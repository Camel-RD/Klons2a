using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using KlonsLIB.Misc;
using KlonsLIB.Forms;

namespace KlonsLIB.Components
{
    public class MyPropertyGrid : PropertyGrid
    {
        public MyPropertyGrid() { }

        private int _labelColumnWidth = -1;
        [DefaultValue(0)]
        public int LabelColumnWidth
        {
            get
            {
                FieldInfo fi = Utils.GetField(this.GetType(), "_gridView");
                var view = fi?.GetValue(this);
                PropertyInfo pi = view.GetType().GetProperty("LabelWidth");
                if (pi == null) return this.Width / 2;
                int ret = (int)pi.GetValue(view);
                if (ret == -1 && _labelColumnWidth == -1) return this.Width / 2;
                if (_labelColumnWidth > 0) return _labelColumnWidth;
                return ret;
            }
            set
            {
                if (value <= 0) return;
                FieldInfo fi = Utils.GetField(this.GetType(), "_gridView");
                Control view = fi?.GetValue(this) as Control;
                MethodInfo mi = view?.GetType().GetMethod("MoveSplitterTo", BindingFlags.Instance | BindingFlags.NonPublic);
                mi?.Invoke(view, new object[] { value });
                _labelColumnWidth = value;
            }
        }

        private int _firstLabelColumnWidth = -1;
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            _firstLabelColumnWidth = _labelColumnWidth;
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            var f = FindForm() as MyFormBase;
            if (f == null || _firstLabelColumnWidth < 0) return;
            LabelColumnWidth = (int)(_firstLabelColumnWidth * f.ScaleFactor.Width);
        }


    }
}
