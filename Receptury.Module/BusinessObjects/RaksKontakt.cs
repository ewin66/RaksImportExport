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


        int idgrupy;
        /// <summary>
        /// Identyfikator grupy
        /// <summary>
        public int IdGrupy
        {
            get => idgrupy;
            set => SetPropertyValue(nameof(IdGrupy), ref idgrupy, value);
        }
        string nazwagrupy;
        /// <summary>
        /// nazwa grupy
        /// <summary>
        [Size(50)]
        public string NazwaGrupy
        {
            get => nazwagrupy;
            set => SetPropertyValue(nameof(NazwaGrupy), ref nazwagrupy, value);
        }


        string nip;
        /// <summary>
        /// NIP
        /// <summary>
        [Size(25)]
        public string Nip
        {
            get => nip;
            set => SetPropertyValue(nameof(Nip), ref nip, value);
        }

        int idadresudomyslnego;
        /// <summary>
        /// Identyfikator adresu domyślnego
        /// <summary>
        public int IdAdresuDomyslnego
        {
            get => idadresudomyslnego;
            set => SetPropertyValue(nameof(IdAdresuDomyslnego), ref idadresudomyslnego, value);
        }
        string ulica;
        /// <summary>
        /// Ulica
        /// <summary>
        [Size(40)]
        public string Ulica
        {
            get => ulica;
            set => SetPropertyValue(nameof(Ulica), ref ulica, value);
        }
        string numerbudynku;
        /// <summary>
        /// Numer budynku
        /// <summary>
        [Size(10)]
        public string NumerBudynku
        {
            get => numerbudynku;
            set => SetPropertyValue(nameof(NumerBudynku), ref numerbudynku, value);
        }
        string numerlokalu;
        /// <summary>
        /// Numer lokalu
        /// <summary>
        [Size(10)]
        public string NumerLokalu
        {
            get => numerlokalu;
            set => SetPropertyValue(nameof(NumerLokalu), ref numerlokalu, value);
        }
        string kodpocztowy;
        /// <summary>
        /// Kod pocztowy
        /// <summary>
        [Size(10)]
        public string KodPocztowy
        {
            get => kodpocztowy;
            set => SetPropertyValue(nameof(KodPocztowy), ref kodpocztowy, value);
        }
        string miejscowosc;
        /// <summary>
        /// Miejscowość
        /// <summary>
        [Size(40)]
        public string Miejscowosc
        {
            get => miejscowosc;
            set => SetPropertyValue(nameof(Miejscowosc), ref miejscowosc, value);
        }
        string wojewodztwo;
        /// <summary>
        /// Województwo
        /// <summary>
        [Size(30)]
        public string Wojewodztwo
        {
            get => wojewodztwo;
            set => SetPropertyValue(nameof(Wojewodztwo), ref wojewodztwo, value);
        }
        string kraj;
        /// <summary>
        /// Kraj
        /// <summary>
        [Size(40)]
        public string Kraj
        {
            get => kraj;
            set => SetPropertyValue(nameof(Kraj), ref kraj, value);
        }
        string kodkrajuue;
        /// <summary>
        /// Kod kraju Unii Europejskiej
        /// <summary>
        [Size(2)]
        public string KodKrajuUe
        {
            get => kodkrajuue;
            set => SetPropertyValue(nameof(KodKrajuUe), ref kodkrajuue, value);
        }

        int newid;
        /// <summary>
        /// Identyfikator pomocniczy
        /// <summary>
        public int NewId
        {
            get => newid;
            set => SetPropertyValue(nameof(NewId), ref newid, value);
        }
        int sprzdetal;
        /// <summary>
        /// Znacznik sprzedaży detalicznej
        /// <summary>
        public int SprzDetal
        {
            get => sprzdetal;
            set => SetPropertyValue(nameof(SprzDetal), ref sprzdetal, value);
        }
        string kodwaluty;
        /// <summary>
        /// Kod waluty do zakładania kont księgowych dla kontrahenta
        /// <summary>
        [Size(3)]
        public string KodWaluty
        {
            get => kodwaluty;
            set => SetPropertyValue(nameof(KodWaluty), ref kodwaluty, value);
        }
        string powiat;
        /// <summary>
        /// Powiat
        /// <summary>
        [Size(50)]
        public string Powiat
        {
            get => powiat;
            set => SetPropertyValue(nameof(Powiat), ref powiat, value);
        }
        string gmina;
        /// <summary>
        /// Gmina
        /// <summary>
        [Size(50)]
        public string Gmina
        {
            get => gmina;
            set => SetPropertyValue(nameof(Gmina), ref gmina, value);
        }
        string kodgminywggus;
        /// <summary>
        /// Kod gminy wg GUS
        /// <summary>
        [Size(7)]
        public string KodGminyWgGus
        {
            get => kodgminywggus;
            set => SetPropertyValue(nameof(KodGminyWgGus), ref kodgminywggus, value);
        }
        string poczta;
        /// <summary>
        /// Poczta
        /// <summary>
        [Size(40)]
        public string Poczta
        {
            get => poczta;
            set => SetPropertyValue(nameof(Poczta), ref poczta, value);
        }
        string gln;
        /// <summary>
        /// Globalny numer lokalizacji (GLN)
        /// <summary>
        [Size(13)]
        public string Gln
        {
            get => gln;
            set => SetPropertyValue(nameof(Gln), ref gln, value);
        }
        string nipkodkraju;
        /// <summary>
        /// Kod kraju nadania NIP
        /// <summary>
        [Size(2)]
        public string NipKodKraju
        {
            get => nipkodkraju;
            set => SetPropertyValue(nameof(NipKodKraju), ref nipkodkraju, value);
        }
        // by Kashiash generato


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
