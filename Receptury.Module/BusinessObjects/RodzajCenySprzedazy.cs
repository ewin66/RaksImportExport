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
    public class RodzajCenySprzedazy : XPObject
    {
        public RodzajCenySprzedazy(Session session) : base(session)
        { }
        int id;
        /// <summary>
        /// Identyfikator rodzaju cen sprzedaży
        /// <summary>

        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
        string nazwa;
        /// <summary>
        /// Nazwa rodzaju cen sprzedaży
        /// <summary>
        [Size(25)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }
        int idwaluty;
        /// <summary>
        /// Identyfikator waluty
        /// <summary>
        public int IdWaluty
        {
            get => idwaluty;
            set => SetPropertyValue(nameof(IdWaluty), ref idwaluty, value);
        }
        int odceny;
        /// <summary>
        /// Sposób wyliczania ceny sprzedaży
        /// <summary>
        public int OdCeny
        {
            get => odceny;
            set => SetPropertyValue(nameof(OdCeny), ref odceny, value);
        }
        int innacena;
        /// <summary>
        /// Identyfikator innego rodzaju cen sprzedaży przy sposobie wyliczania "Od innej ceny sprzedaży"
        /// <summary>
        public int InnaCena
        {
            get => innacena;
            set => SetPropertyValue(nameof(InnaCena), ref innacena, value);
        }
        string narzutprocentowy;
        /// <summary>
        /// Narzut procentowy podczas wyliczania
        /// <summary>
        public string NarzutProcentowy
        {
            get => narzutprocentowy;
            set => SetPropertyValue(nameof(NarzutProcentowy), ref narzutprocentowy, value);
        }
        string narzutkwotowy;
        /// <summary>
        /// Narzut kwotowy podczas wyliczania
        /// <summary>
        public string NarzutKwotowy
        {
            get => narzutkwotowy;
            set => SetPropertyValue(nameof(NarzutKwotowy), ref narzutkwotowy, value);
        }
        string uwagi;
        /// <summary>
        /// Opis rodzaju cen, uwagi
        /// <summary>
        [Size(100)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }
        string nazwainnejceny;
        /// <summary>
        /// Nazwa innego rodzaju cen sprzedaży przy sposobie wyliczania "Od innej ceny sprzedaży"
        /// <summary>
        [Size(40)]
        public string NazwaInnejCeny
        {
            get => nazwainnejceny;
            set => SetPropertyValue(nameof(NazwaInnejCeny), ref nazwainnejceny, value);
        }
        string kodwaluty;
        /// <summary>
        /// Kod waluty
        /// <summary>
        [Size(3)]
        public string KodWaluty
        {
            get => kodwaluty;
            set => SetPropertyValue(nameof(KodWaluty), ref kodwaluty, value);
        }
        string nazwawaluty;
        /// <summary>
        /// Nazwa waluty
        /// <summary>
        [Size(50)]
        public string NazwaWaluty
        {
            get => nazwawaluty;
            set => SetPropertyValue(nameof(NazwaWaluty), ref nazwawaluty, value);
        }
        int mnoznik;
        /// <summary>
        /// Mnożnik waluty przy podawaniu kursu (np. 100 JEN)
        /// <summary>
        public int Mnoznik
        {
            get => mnoznik;
            set => SetPropertyValue(nameof(Mnoznik), ref mnoznik, value);
        }
        bool dodajdocennika;
        /// <summary>
        /// Czy automatycznie umieszczać ten rodzaj cen w nowych dokumentach zmiany cen sprzedaży
        /// <summary>
        public bool DodajDoCennika
        {
            get => dodajdocennika;
            set => SetPropertyValue(nameof(DodajDoCennika), ref dodajdocennika, value);
        }
        int newid;
        /// <summary>
        /// 
        /// <summary>
        public int NewId
        {
            get => newid;
            set => SetPropertyValue(nameof(NewId), ref newid, value);
        }
        int typ;
        /// <summary>
        /// Sposób liczenia
        /// <summary>
        public int Typ
        {
            get => typ;
            set => SetPropertyValue(nameof(Typ), ref typ, value);
        }
        int narzutczymarza;
        /// <summary>
        /// Doliczać do ceny marzę czy narzut
        /// <summary>
        public int NarzutCzyMarza
        {
            get => narzutczymarza;
            set => SetPropertyValue(nameof(NarzutCzyMarza), ref narzutczymarza, value);
        }
        string marza;
        /// <summary>
        /// Marża procentowa
        /// <summary>
        public string Marza
        {
            get => marza;
            set => SetPropertyValue(nameof(Marza), ref marza, value);
        }
        int zaokraglanieprecyzja;
        /// <summary>
        /// Sposób zaokrąglania ceny w generatorze cen 0-10, 1-5, 2-1, 3-0.5, 4-0.1, 5-0,05, 6-0.01, 7-0.001, 8-0.0001
        /// <summary>
        public int ZaokraglaniePrecyzja
        {
            get => zaokraglanieprecyzja;
            set => SetPropertyValue(nameof(ZaokraglaniePrecyzja), ref zaokraglanieprecyzja, value);
        }
        // by Kashiash generator                                                   



    }

}
