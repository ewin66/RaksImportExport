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
    public class RaksSposobPlatnosci : XPCustomObject
    {
        public RaksSposobPlatnosci(Session session) : base(session)
        { }
        int id;
        /// <summary>
        /// Identyfikator rekordu
        /// <summary>
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
        string nazwa;
        /// <summary>
        /// Nazwa sposobu zapłaty (musi być unikalna)
        /// <summary>
        [Size(100)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }
        int termin;
        /// <summary>
        ///Termin płatności w dniach
        /// <summary>
        public int Termin
        {
            get => termin;
            set => SetPropertyValue(nameof(Termin), ref termin, value);
        }
        string analitykafk;
        /// <summary>
        ///Analityka konta księgowego, na które mają trafiać wpłaty
        /// <summary>
        [Size(30)]
        public string AnalitykaFk
        {
            get => analitykafk;
            set => SetPropertyValue(nameof(AnalitykaFk), ref analitykafk, value);
        }
        bool rozliczeniegotowkowe;
        /// <summary>
        ///Czy rozliczenie za pomoca gotówki (True) czy za pomocą innych środków płatniczych (False), np. czek, karta płatnicza, przelew
        /// <summary>
        public bool RozliczenieGotowkowe
        {
            get => rozliczeniegotowkowe;
            set => SetPropertyValue(nameof(RozliczenieGotowkowe), ref rozliczeniegotowkowe, value);
        }
        bool rozliczeniecalkowite;
        /// <summary>
        ///Czy należy wymuszać natychmiastowe całkowite rozliczenie dokumentu (pełną zapłatę za niego)
        /// <summary>
        public bool RozliczenieCalkowite
        {
            get => rozliczeniecalkowite;
            set => SetPropertyValue(nameof(RozliczenieCalkowite), ref rozliczeniecalkowite, value);
        }
        string rodzajrozliczenia;
        /// <summary>
        ///Przez co jest obsługiwane rozliczenie tego sposobu zapłaty:
        ///0 - przez kasę
        ///1 - przez bank
        /// <summary>
        [Size(1)]
        public string RodzajRozliczenia
        {
            get => rodzajrozliczenia;
            set => SetPropertyValue(nameof(RodzajRozliczenia), ref rodzajrozliczenia, value);
        }
        int idmetodyplatnosci;
        /// <summary>
        ///Identyfikator metody płatności
        /// <summary>
        public int IdMetodyPlatnosci
        {
            get => idmetodyplatnosci;
            set => SetPropertyValue(nameof(IdMetodyPlatnosci), ref idmetodyplatnosci, value);
        }
        string nazwametodyplatnosci;
        /// <summary>
        ///Nazwa metody płatności (np. czek, karta płatnicza)
        /// <summary>
        [Size(50)]
        public string NazwaMetodyPlatnosci
        {
            get => nazwametodyplatnosci;
            set => SetPropertyValue(nameof(NazwaMetodyPlatnosci), ref nazwametodyplatnosci, value);
        }
        int idrachunkubankowego;
        /// <summary>
        ///Identyfikator rachunku bankowego z sekcji RACHUNKI_BANKOWE
        /// <summary>
        public int IdRachunkuBankowego
        {
            get => idrachunkubankowego;
            set => SetPropertyValue(nameof(IdRachunkuBankowego), ref idrachunkubankowego, value);
        }
        string numerrachunkubankowego;
        /// <summary>
        ///Numer rachunku bankowego z sekcji RACHUNKI_BANKOWE, używany do wyszukiwania jeśli nie uda się odnajdywanie po ID_RACHUNKU_BANKOWEGO
        /// <summary>
        [Size(50)]
        public string NumerRachunkuBankowego
        {
            get => numerrachunkubankowego;
            set => SetPropertyValue(nameof(NumerRachunkuBankowego), ref numerrachunkubankowego, value);
        }
        int newid;
        /// <summary>
        ///Zarezerwowane, wpisywać zawsze 0
        /// <summary>
        public int NewId
        {
            get => newid;
            set => SetPropertyValue(nameof(NewId), ref newid, value);
        }
        int podstawaterminusp;
        /// <summary>
        ///Kod rodzaju podstawy wyliczania terminu płatności dla sprzedaży: 0 - od daty wystawienia, 1 - od daty sprzedaży, 2 - od daty bieżącej
        /// <summary>
        public int PodstawaTerminuSp
        {
            get => podstawaterminusp;
            set => SetPropertyValue(nameof(PodstawaTerminuSp), ref podstawaterminusp, value);
        }
        int podstawaterminuzak;
        /// <summary>
        ///Kod rodzaju podstawy wyliczania terminu płatności dla zakupu: 0 - od daty wystawienia, 1 - od daty dostawy, 2 - od daty bieżącej
        /// <summary>
        public int PodstawaTerminuZak
        {
            get => podstawaterminuzak;
            set => SetPropertyValue(nameof(PodstawaTerminuZak), ref podstawaterminuzak, value);
        }
        bool pominsobotysp;
        /// <summary>
        ///Podczas wyliczania terminu zapłaty na dokumentach sprzedaży pomiń soboty
        /// <summary>
        public bool PominSobotySp
        {
            get => pominsobotysp;
            set => SetPropertyValue(nameof(PominSobotySp), ref pominsobotysp, value);
        }
        bool pominniedzielesp;
        /// <summary>
        ///Podczas wyliczania terminu zapłaty na dokumentach sprzedaży pomiń niedziele
        /// <summary>
        public bool PominNiedzieleSp
        {
            get => pominniedzielesp;
            set => SetPropertyValue(nameof(PominNiedzieleSp), ref pominniedzielesp, value);
        }
        bool pominsobotyzak;
        /// <summary>
        ///Podczas wyliczania terminu zapłaty na dokumentach zakupu pomiń soboty
        /// <summary>
        public bool PominSobotyZak
        {
            get => pominsobotyzak;
            set => SetPropertyValue(nameof(PominSobotyZak), ref pominsobotyzak, value);
        }
        bool pominniedzielezak;
        /// <summary>
        ///Podczas wyliczania terminu zapłaty na dokumentach zakupu pomiń niedziele
        /// <summary>
        public bool PominNiedzieleZak
        {
            get => pominniedzielezak;
            set => SetPropertyValue(nameof(PominNiedzieleZak), ref pominniedzielezak, value);
        }
        string nazwadladrukfiskal;
        /// <summary>
        ///Nazwa drukowana na drukarce fiskalnej
        /// <summary>
        [Size(20)]
        public string NazwaDlaDrukFiskal
        {
            get => nazwadladrukfiskal;
            set => SetPropertyValue(nameof(NazwaDlaDrukFiskal), ref nazwadladrukfiskal, value);
        }
        bool widocznydlaplatnosci;
        /// <summary>
        ///Określenie czy sposób ma być widoczny w systemie płatności w POS
        /// <summary>
        public bool WidocznyDlaPlatnosci
        {
            get => widocznydlaplatnosci;
            set => SetPropertyValue(nameof(WidocznyDlaPlatnosci), ref widocznydlaplatnosci, value);
        }
        bool platnoscizlozona;
        /// <summary>
        ///Określa czy płatność jest złożona
        /// <summary>
        public bool PlatnosciZlozona
        {
            get => platnoscizlozona;
            set => SetPropertyValue(nameof(PlatnosciZlozona), ref platnoscizlozona, value);
        }
        bool widocznydlaplatnoscisp;
        /// <summary>
        ///Określenie czy sposób ma być widoczny w systemie płatności w Sprzedaży
        /// <summary>
        public bool WidocznyDlaPlatnosciSp
        {
            get => widocznydlaplatnoscisp;
            set => SetPropertyValue(nameof(WidocznyDlaPlatnosciSp), ref widocznydlaplatnoscisp, value);
        }
        bool tworzrozrachunki;
        /// <summary>
        ///
        /// <summary>
        public bool TworzRozrachunki
        {
            get => tworzrozrachunki;
            set => SetPropertyValue(nameof(TworzRozrachunki), ref tworzrozrachunki, value);
        }
        bool pominswietazak;
        /// <summary>
        ///Podczas wyliczania terminu płatności na dokumentach zakupu pomiń niedziele i święta jeżeli wypadaja w dniu zapłaty
        /// <summary>
        public bool PominSwietaZak
        {
            get => pominswietazak;
            set => SetPropertyValue(nameof(PominSwietaZak), ref pominswietazak, value);
        }
        bool pominswietasp;
        /// <summary>
        ///Podczas wyliczania terminu płatności na dokumentach sprzedaży pomiń niedziele i święta jeżeli wypadaja w dniu zapłaty
        /// <summary>
        public bool PominSwietaSp
        {
            get => pominswietasp;
            set => SetPropertyValue(nameof(PominSwietaSp), ref pominswietasp, value);
        }
        // by Kashiash generator                                                   



    }

}
