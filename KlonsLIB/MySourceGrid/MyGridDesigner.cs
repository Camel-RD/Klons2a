using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DotNet.DesignTools.Designers;

namespace KlonsLIB.MySourceGrid
{
    internal class MyGridDesigner : ControlDesigner
    {
        protected DesignerVerbCollection designerVerbs;

        public MyGridDesigner()
        {
        }

        public override DesignerVerbCollection Verbs
        {
            get
            {
                if (designerVerbs == null)
                {
                    designerVerbs =
                    [
                        new DesignerVerb("Edit RowList", new EventHandler(this.OnEditRowList)),
                        new DesignerVerb("Edit RowTemplateList", new EventHandler(this.OnEditRowTemplateList)),
                    ];
                }
                return designerVerbs;
            }
        }

        public void OnEditRowList(object sender, EventArgs e)
        {
            InvokePropertyEditor(nameof(MyGrid.RowList));
        }

        public void OnEditRowTemplateList(object sender, EventArgs e)
        {
            InvokePropertyEditor(nameof(MyGrid.RowTemplateList));
        }
    }
}
