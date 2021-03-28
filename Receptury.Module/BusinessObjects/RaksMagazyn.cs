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
    public class RaksMagazyn : XPObject
    {
        public RaksMagazyn(Session session) : base(session)
        { }


        string analityka;
        string numer;
        string uwagi;
        string nazwa;
        int id;
   
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


        public string Numer
        {
            get => numer;
            set => SetPropertyValue(nameof(Numer), ref numer, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Analityka
        {
            get => analityka;
            set => SetPropertyValue(nameof(Analityka), ref analityka, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }

    }
}
