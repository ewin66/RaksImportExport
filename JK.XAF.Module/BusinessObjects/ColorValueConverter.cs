using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using DevExpress.Xpo.Metadata;

namespace JK.XAF.Module.BusinessObjects
{
    public class ColorValueConverter : ValueConverter
    {
        public override Type StorageType
        {
            get
            {
                return typeof(String);
            }
        }

        public override object ConvertFromStorageType(object value)
        {
            if (value is null)
                return Color.Empty;
            if (!(value is String))
                if (!(value.ToString().Length == 8))
                    return Color.Empty;

            Int32 argb = Int32.Parse(((String)value).Replace("#", string.Empty), NumberStyles.HexNumber);
            return Color.FromArgb(argb);
        }

        public override object ConvertToStorageType(object value)
        {
            if (value is null)
                return null;
            if (!(value is Color))
                return null;

            Color color = (Color)value;
            return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B);
        }
    }
}
