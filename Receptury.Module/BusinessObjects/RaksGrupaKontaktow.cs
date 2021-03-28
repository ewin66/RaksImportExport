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
    public class RaksGrupaKontaktow : XPObject
    {
        public RaksGrupaKontaktow(Session session) : base(session)
        { }


        string analitykaPracownika;
        string analitykaOdbiorcy;
        string analitykaDostawcy;
        string analitykaAkwizytora;
        string nazwa;
        RaksGrupaKontaktow grupaNadrzedna;
        int id;

        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }


        public RaksGrupaKontaktow GrupaNadrzedna
        {
            get => grupaNadrzedna;
            set => SetPropertyValue(nameof(GrupaNadrzedna), ref grupaNadrzedna, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AnalitykaAkwizytora
        {
            get => analitykaAkwizytora;
            set => SetPropertyValue(nameof(AnalitykaAkwizytora), ref analitykaAkwizytora, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AnalitykaDostawcy
        {
            get => analitykaDostawcy;
            set => SetPropertyValue(nameof(AnalitykaDostawcy), ref analitykaDostawcy, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AnalitykaOdbiorcy
        {
            get => analitykaOdbiorcy;
            set => SetPropertyValue(nameof(AnalitykaOdbiorcy), ref analitykaOdbiorcy, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AnalitykaPracownika
        {
            get => analitykaPracownika;
            set => SetPropertyValue(nameof(AnalitykaPracownika), ref analitykaPracownika, value);
        }
    }
}
