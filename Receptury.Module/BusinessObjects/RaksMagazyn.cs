using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class RaksMagazyn : XPCustomObject
    {
        public RaksMagazyn(Session session) : base(session)
        { }


        string uwagi;
        string nazwa;
        int id;
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }

    }
}
