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
    public class RaksAdres : XPObject
    {
        public RaksAdres(Session session) : base(session)
        { }


        RaksKontakt kontakt;
        string gln;
        string poczta;
        string kodGminyWgGus;
        string gmina;
        string powiat;
        string nazwaTypu;
        string kraj;
        string wojewodztwo;
        string miejscowosc;
        string kodPocztowy;
        string numerLokalu;
        string numerDomu;
        string ulica;
        int id;
    
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Ulica
        {
            get => ulica;
            set => SetPropertyValue(nameof(Ulica), ref ulica, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NumerDomu
        {
            get => numerDomu;
            set => SetPropertyValue(nameof(NumerDomu), ref numerDomu, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NumerLokalu
        {
            get => numerLokalu;
            set => SetPropertyValue(nameof(NumerLokalu), ref numerLokalu, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string KodPocztowy
        {
            get => kodPocztowy;
            set => SetPropertyValue(nameof(KodPocztowy), ref kodPocztowy, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Miejscowosc
        {
            get => miejscowosc;
            set => SetPropertyValue(nameof(Miejscowosc), ref miejscowosc, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Wojewodztwo
        {
            get => wojewodztwo;
            set => SetPropertyValue(nameof(Wojewodztwo), ref wojewodztwo, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Kraj
        {
            get => kraj;
            set => SetPropertyValue(nameof(Kraj), ref kraj, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NazwaTypu
        {
            get => nazwaTypu;
            set => SetPropertyValue(nameof(NazwaTypu), ref nazwaTypu, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Powiat
        {
            get => powiat;
            set => SetPropertyValue(nameof(Powiat), ref powiat, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Gmina
        {
            get => gmina;
            set => SetPropertyValue(nameof(Gmina), ref gmina, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string KodGminyWgGus
        {
            get => kodGminyWgGus;
            set => SetPropertyValue(nameof(KodGminyWgGus), ref kodGminyWgGus, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Poczta
        {
            get => poczta;
            set => SetPropertyValue(nameof(Poczta), ref poczta, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Gln
        {
            get => gln;
            set => SetPropertyValue(nameof(Gln), ref gln, value);
        }


        
        [Association("RaksKontakt-Adresy")]
        public RaksKontakt Kontakt
        {
            get => kontakt;
            set => SetPropertyValue(nameof(Kontakt), ref kontakt, value);
        }
    }
}
