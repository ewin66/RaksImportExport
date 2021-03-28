
using System.Drawing;

namespace JK.XAF.Module.BusinessObjects
{
    public interface IColor
    {
        Color BackColor { get; set; }
        Color ForeColor { get; set; }

        FontStyle FontStyle { get; set; }
    }
}