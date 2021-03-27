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
    [XafDefaultProperty(nameof(NazwaSkrocona))]
    public class RaksKontakt : XPCustomObject
    {
        public RaksKontakt(Session session) : base(session)
        { }


        string uwagi;
        int typKontaktu;
        RaksAdres adresDomyslny;
        string nip;
        string kodKreskowy;
        bool odbiorca;
        bool dostawca;
        bool akwizytor;
        string nazwaPelna;
        string nazwaSkrocona;
        RaksGrupaKontaktow grupa;
        int id;
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }


        public RaksGrupaKontaktow Grupa
        {
            get => grupa;
            set => SetPropertyValue(nameof(Grupa), ref grupa, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NazwaSkrocona
        {
            get => nazwaSkrocona;
            set => SetPropertyValue(nameof(NazwaSkrocona), ref nazwaSkrocona, value);
        }


        [Size(200)]
        public string NazwaPelna
        {
            get => nazwaPelna;
            set => SetPropertyValue(nameof(NazwaPelna), ref nazwaPelna, value);
        }

        public bool Akwizytor
        {
            get => akwizytor;
            set => SetPropertyValue(nameof(Akwizytor), ref akwizytor, value);
        }

        public bool Dostawca
        {
            get => dostawca;
            set => SetPropertyValue(nameof(Dostawca), ref dostawca, value);
        }

        public bool Odbiorca
        {
            get => odbiorca;
            set => SetPropertyValue(nameof(Odbiorca), ref odbiorca, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string KodKreskowy
        {
            get => kodKreskowy;
            set => SetPropertyValue(nameof(KodKreskowy), ref kodKreskowy, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nip
        {
            get => nip;
            set => SetPropertyValue(nameof(Nip), ref nip, value);
        }


        public int TypKontaktu
        {
            get => typKontaktu;
            set => SetPropertyValue(nameof(TypKontaktu), ref typKontaktu, value);
        }

        public RaksAdres AdresDomyslny
        {
            get => adresDomyslny;
            set => SetPropertyValue(nameof(AdresDomyslny), ref adresDomyslny, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }


        [Association("RaksKontakt-Adresy"), DevExpress.Xpo.Aggregated]
        public XPCollection<RaksAdres> Adresy{
            get
            {
                return GetCollection<RaksAdres>(nameof(Adresy));
            }
        }
    }


}
