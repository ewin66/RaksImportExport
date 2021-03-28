using DevExpress.ExpressApp.DC;
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
    [XafDefaultProperty(nameof(Nazwa))]
    public class RaksGrupaArtykulow : XPObject
    {
        public RaksGrupaArtykulow(Session session) : base(session)
        { }


        string analityka;
        string nazwa;
        int id;
        int idNadrzednej;


        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
        public int IdNadrzednej
        {
            get => idNadrzednej;
            set => SetPropertyValue(nameof(IdNadrzednej), ref idNadrzednej, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Analityka
        {
            get => analityka;
            set => SetPropertyValue(nameof(Analityka), ref analityka, value);
        }
    }
}
