using System.Windows.Forms.Design;

namespace kontrols
{
    public class NonResizableControlDesigner : ControlDesigner
    {
        public override SelectionRules SelectionRules => SelectionRules.Visible | SelectionRules.Moveable;
    }
}