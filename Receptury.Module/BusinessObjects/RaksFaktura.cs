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
    public class RaksFaktura : XPCustomObject
    {
        public RaksFaktura(Session session) : base(session)
        { }

        //_NAZWA,_TYP,_SZEROKOSC,_OPIS,_WYMAGANE
        //ID,Integer,0,Identyfikator rekordu,Tak

        bool mechanizmPodzielonejPlatnosci;
        string kodKrajuPrzeznaczenia;
        DateTime dataZmiany;
        string zmienil;
        DateTime dataPodpisania;
        string wystawil;
        string uwagi;
        decimal wartoscZlotowkowaOpkKaucjonowanych;
        decimal wartoscSprzedazyOpkKaucjonowanych;
        decimal wartoscBruttoZlotowkowa;
        decimal kwotaVatZlotowkowa;
        decimal wartoscVatZlotowkowa;
        decimal wartoscNettoZlotowkowa;
        decimal wartoscBruttoSprzedazy;
        decimal kwotaVatSprzedazy;
        decimal wartoscNettoSprzdazy;
        DateTime dataPlatnosci;
        RaksSposobPlatnosci sposobPlatnosci;
        DateTime dataSprzedazy;
        int sposobWyliczania;
        decimal kursWaluty;
        decimal mnoznikWaluty;
        RaksWaluta waluta;
        string idTabeliKursowej;
        string idRodzajuCen;
        string idRodzajuRabatu;
        RaksKontakt akwizytor;
        string idAkwizytora;
        RaksKontakt odbiorca;
        RaksKontakt nabywca;
        bool zafiskalizowany;
        int blokada;
        bool transakcjaTrojstronna;
        string nazwaDokumentu;
        string nrDokumentu;
        DateTime dataWystawienia;
        string kodDokumentu;
        string rodzajDokumentuSprzedazy;
        RaksMagazyn magazyn;
        int id;
        [Key(true)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }


        public RaksMagazyn Magazyn
        {
            get => magazyn;
            set => SetPropertyValue(nameof(Magazyn), ref magazyn, value);
        }
        //ID_MAGAZYNU,Integer,0,Identyfikator magazynu,Tak
        //NUMER_MAGAZYNU,String,5,Numer magazynu,Tak
        //NAZWA_MAGAZYNU,String,25,Nazwa magazynu,Tak

        //ANALITYKA_FK_MAGAZYNU,String,20,Numer analityki konta FK magazynu,Nie
        //ID_SPRZEDAWCY,Integer,0,Identyfikator sprzedawcy (-1 - dane firmy; -ID-1 - dane filii),Tak
        //NAZWA_SKROCONA_SPRZEDAWCY,String,50,Nazwa skrócona sprzedawcy,Tak
        //NAZWA_PELNA_SPRZEDAWCY,String,200,Nazwa pełna sprzedawcy,Tak
        //NIP_SPRZEDAWCY,String,25,Numer NIP sprzedawcy,Nie
        //KOD_KRESKOWY_SPRZEDAWCY,String,40,Kod kreskowy sprzedawcy,Nie



        //RODZAJ_DOK_SPRZEDAZY,String,3,"Rodzaj dokumentu sprzedaży, możliwe wartości to: PA - paragon, FS - faktura VAT, FE - faktura eksportowa",Tak
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string RodzajDokumentuSprzedazy
        {
            get => rodzajDokumentuSprzedazy;
            set => SetPropertyValue(nameof(RodzajDokumentuSprzedazy), ref rodzajDokumentuSprzedazy, value);
        }

        //KOD_DOKUMENTU,String,5,Kod dokumentu,Tak


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string KodDokumentu
        {
            get => kodDokumentu;
            set => SetPropertyValue(nameof(KodDokumentu), ref kodDokumentu, value);
        }
        //DATA_WYSTAWIENIA,Date,0,Data wystawienia dokumentu (data operacji),Tak

        public DateTime DataWystawienia
        {
            get => dataWystawienia;
            set => SetPropertyValue(nameof(DataWystawienia), ref dataWystawienia, value);
        }
        //NUMER_DOKUMENTU,String,255,Numer dokumentu,Tak

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NrDokumentu
        {
            get => nrDokumentu;
            set => SetPropertyValue(nameof(NrDokumentu), ref nrDokumentu, value);
        }

        //NAZWA_DOKUMENTU,String,250,Nazwa dokumentu,Tak


        [Size(255)]
        public string NazwaDokumentu
        {
            get => nazwaDokumentu;
            set => SetPropertyValue(nameof(NazwaDokumentu), ref nazwaDokumentu, value);
        }
        //TRANSAKCJA_TROJSTRONNA,Boolean,0,Czy transakcja trojstronna,Tak

        public bool TransakcjaTrojstronna
        {
            get => transakcjaTrojstronna;
            set => SetPropertyValue(nameof(TransakcjaTrojstronna), ref transakcjaTrojstronna, value);
        }

        //SYGNATURA,String,100,Sygnatura dokumentu,Nie
        //ZNACZNIKI,BLOB.text,0,Znaczniki dokumentu,Nie
        //ANALITYKA_FK,String,20,Numer analityki konta FK,Nie
        //BLOKADA,Integer,0,"Status blokad dokumentu określany bitowo:
        // ustawiony bit 1 - dokument zablokowany
        // ustawiony bit 2 - dokument zaksięgowany
        // bit 3 - zarezerwowane, wpisywać zawsze 0
        // ustawiony bit 1 - dokument zablokowany przez moduł FK",Tak


        public int Blokada
        {
            get => blokada;
            set => SetPropertyValue(nameof(Blokada), ref blokada, value);
        }
        //ZAFISKALIZOWANY,Boolean,0,Czy dokument został już zafiskalizowany,Tak

        public bool Zafiskalizowany
        {
            get => zafiskalizowany;
            set => SetPropertyValue(nameof(Zafiskalizowany), ref zafiskalizowany, value);
        }
        //ID_NABYWCY,Integer,0,Identyfikator nabywcy z sekcji KONTAKTY,Tak
        //NAZWA_SKROCONA_NABYWCY,String,50,"Nazwa skrócona nabywcy, dla paragonów Sprzedaż detaliczna",Tak
        //NAZWA_PELNA_NABYWCY,String,250,"Nazwa pełna nabywcy, pole nie wymagane dla paragonów",Tak
        //KOD_KRESKOWY_NABYWCY,String,40,"Kod kreskowy nabywcy, pole nie wymagane dla paragonów",Nie
        //NIP_NABYWCY,String,25,"Numer NIP nabywcy, pole nie wymagane dla paragonów",Nie
        //ULICA_NABYWCY,String,50,"Nazwa ulicy, przy której jest siedziba nabywcy",Nie
        //NR_DOMU_NABYWCY,String,10,"Numer budynku, w którym mieści się siedziba nabywcy",Nie
        //NR_LOKALU_NABYWCY,String,10,"Numer lokalu, w którym mieści się siedziba nabywcy",Nie
        //KOD_POCZTOWY_NABYWCY,String,10,"Kod pocztowy miejscowości, w której mieści się siedziba nabywcy",Nie
        //MIEJSCOWOSC_NABYWCY,String,50,"Miejscowość, w której znajduje się siedziba nabywcy",Nie
        //PANSTWO_NABYWCY,String,25,"Państwo, w którym znajduje się siedziba nabywcy",Nie
        //CZY_NABYWCA_PLATNIKIEM_VAT,Boolean,0,Czy nabywca jest płatnikiem VAT,Tak


        public RaksKontakt Nabywca
        {
            get => nabywca;
            set => SetPropertyValue(nameof(Nabywca), ref nabywca, value);
        }
        //ID_ODBIORCY,Integer,0,Identyfikator odbiorcy z sekcji KONTAKTY,Tak
        //NAZWA_SKROCONA_ODBIORCY,String,50,"Nazwa skrócona odbiorcy, dla paragonów Sprzedaż detaliczna",Tak
        //NAZWA_PELNA_ODBIORCY,String,250,nazwa pełna odbiorcy; pole nie wymagane dla paragonów,Tak
        //KOD_KRESKOWY_ODBIORCY,String,40,Kod kreskowy odbiorcy; pole nie wymagane dla paragonów,Nie
        //NIP_ODBIORCY,String,25,Numer NIP odbiorcy; pole nie wymagane dla paragonów,Nie
        //ULICA_ODBIORCY,String,50,"Nazwa ulicy, przy której jest siedziba odbiorcy",Nie
        //NR_DOMU_ODBIORCY,String,10,"Numer budynku, w którym mieści się siedziba odbiorcy",Nie
        //NR_LOKALU_ODBIORCY,String,10,"Numer lokalu, w którym mieści się siedziba odbiorcy",Nie
        //KOD_POCZTOWY_ODBIORCY,String,10,"Kod pocztowy miejscowości, w której mieści się siedziba odbiorcy",Nie
        //MIEJSCOWOSC_ODBIORCY,String,50,"Miejscowość, w której znajduje się siedziba odbiorcy",Nie
        //PANSTWO_ODBIORCY,String,25,"Państwo, w którym znajduje się siedziba odbiorcy",Nie
        //CZY_ODBIORCA_PLATNIKIEM_VAT,Boolean,0,Czy odbiorca jest płatnikiem VAT,Tak


        public RaksKontakt Odbiorca
        {
            get => odbiorca;
            set => SetPropertyValue(nameof(Odbiorca), ref odbiorca, value);
        }

        //ID_AKWIZYTORA,Integer,0,Identyfikator akwizytora z sekcji KONTAKTY,Tak



        public RaksKontakt Akwizytor
        {
            get => akwizytor;
            set => SetPropertyValue(nameof(Akwizytor), ref akwizytor, value);
        }
        //NAZWA_SKROCONA_AKWIZYTORA,String,50,Nazwa skrócona akwizytora,Nie
        //NAZWA_PELNA_AKWIZYTORA,String,250,Nazwa pełna akwizytora,Nie
        //KOD_KRESKOWY_AKWIZYTORA,String,40,Kod kreskowy akwizytora,Nie
        //NIP_AKWIZYTORA,String,25,Numer NIP akwizytora,Nie

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string IdRodzajuRabatu
        {
            get => idRodzajuRabatu;
            set => SetPropertyValue(nameof(IdRodzajuRabatu), ref idRodzajuRabatu, value);
        }
        //ID_RODZAJU_RABATU,Integer,0,Identyfikator rodzaju rabatu z sekcji RABATY,Tak
        //NAZWA_RODZAJU_RABATU,String,50,"Nazwa rodzaju rabatu, używana do wyszukiwania, jeśli odnalezienie po ID_RODZAJU_RABATU nie powiedzie się",Nie

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string IdRodzajuCen
        {
            get => idRodzajuCen;
            set => SetPropertyValue(nameof(IdRodzajuCen), ref idRodzajuCen, value);
        }
        //ID_RODZAJU_CEN,Integer,0,Identyfikator rodzaju ceny sprzedaży z sekcji RODZAJE_CEN_SPRZEDAZY,Tak
        //NAZWA_RODZAJU_CEN,String,25,"Nazwa rodzaju cany sprzedaży, używana do wyszukiwania, jeśli odnalezienie po ID_RODZAJU_CEN nie powiedzie się",Nie

        //OSOBA_UPOWAZNIONA_DO_ODB_TOWARU,String,30,Nazwisko osoby upoważnionej do odbioru towaru i podpisania faktury,Nie
        //ID_TABELI_KURSOWEJ,Integer,0,Identyfikator użytej tabeli kursowej,Tak


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string IdTabeliKursowej
        {
            get => idTabeliKursowej;
            set => SetPropertyValue(nameof(IdTabeliKursowej), ref idTabeliKursowej, value);
        }
        //NUMER_TABELI_KURSOWEJ,String,25,Numer użytej tabeli kursowej,Nie

        public RaksWaluta Waluta
        {
            get => waluta;
            set => SetPropertyValue(nameof(Waluta), ref waluta, value);
        }
        //ID_WALUTY_DOKUMENTU,Integer,0,Identyfikator waluty dokumentu,Tak
        //KOD_WALUTY_DOKUMENTU,String,5,Kod waluty dokumentu,Tak
        //NAZWA_WALUTY_DOKUMENTU,String,50,Nazwa waluty dokumentu,Tak
        //MNOZNIK_WALUTY_DOKUMENTU,Integer,0,Mnożnik waluty dokumentu,Tak

        public decimal MnoznikWaluty
        {
            get => mnoznikWaluty;
            set => SetPropertyValue(nameof(MnoznikWaluty), ref mnoznikWaluty, value);
        }

        //KURS_WALUTY_DOKUMENTU,Float,0,Kurs waluty dokumentu wynikający z tabeli kursowej,Tak

        public decimal KursWaluty
        {
            get => kursWaluty;
            set => SetPropertyValue(nameof(KursWaluty), ref kursWaluty, value);
        }
        //SPOSOB_WYLICZANIA_DOKUMENTU,Integer,0,"Sposób wyliczania wartości dokumentu, możliwe wartości to: 0 - od netto, 1 - od brutto, 2 - sumy",Tak


        public int SposobWyliczania
        {
            get => sposobWyliczania;
            set => SetPropertyValue(nameof(SposobWyliczania), ref sposobWyliczania, value);
        }


        public DateTime DataSprzedazy
        {
            get => dataSprzedazy;
            set => SetPropertyValue(nameof(DataSprzedazy), ref dataSprzedazy, value);
        }
        //DATA_SPRZEDAZY,Date,0,Data sprzedaży,Nie
        //ID_SPOSOBU_PLATNOSCI,Integer,0,Identyfikator sposobu zapłaty za fakturę z sekcji SPOSOBY_ZAPLATY,Tak
        //SPOSOB_PLATNOSCI,String,100,"Sposób zapłaty za fakturę, używane do wyszukiwania, jeśli odnalezienie po ID_SPOSOBU_PLATNOSCI nie powiedzie się",Tak

        public RaksSposobPlatnosci SposobPlatnosci
        {
            get => sposobPlatnosci;
            set => SetPropertyValue(nameof(SposobPlatnosci), ref sposobPlatnosci, value);
        }


        public DateTime DataPlatnosci
        {
            get => dataPlatnosci;
            set => SetPropertyValue(nameof(DataPlatnosci), ref dataPlatnosci, value);
        }
        //DATA_PLATNOSCI,Date,0,Data płatności za fakturę,Tak
        //WARTOSC_NETTO_SPRZEDAZY,Float,0,Wartość dokumentu w cenach sprzedaży netto (w walucie dokumentu) (w jednostkach kontrahenta),Tak

        public decimal WartoscNettoSprzdazy
        {
            get => wartoscNettoSprzdazy;
            set => SetPropertyValue(nameof(WartoscNettoSprzdazy), ref wartoscNettoSprzdazy, value);
        }
        //KWOTA_VAT_SPRZEDAZY,Float,0,Kwota VAT podatku należnego (w jednostkach kontrahenta),Tak

        public decimal KwotaVatSprzedazy
        {
            get => kwotaVatSprzedazy;
            set => SetPropertyValue(nameof(KwotaVatSprzedazy), ref kwotaVatSprzedazy, value);
        }
        //WARTOSC_BRUTTO_SPRZEDAZY,Float,0,Wartość dokumentu w cenach  brutto (w walucie dokumentu) (w jednostkach kontrahenta),Tak

        public decimal WartoscBruttoSprzedazy
        {
            get => wartoscBruttoSprzedazy;
            set => SetPropertyValue(nameof(WartoscBruttoSprzedazy), ref wartoscBruttoSprzedazy, value);
        }

        public decimal WartoscNettoZlotowkowa
        {
            get => wartoscNettoZlotowkowa;
            set => SetPropertyValue(nameof(WartoscNettoZlotowkowa), ref wartoscNettoZlotowkowa, value);
        }
        //WARTOSC_NETTO_ZLOTOWKOWA,Float,0,Wartość dokumentu w cenach netto w złotówkach (w jednostkach kontrahenta),Tak

        public decimal WartoscVatZlotowkowa
        {
            get => wartoscVatZlotowkowa;
            set => SetPropertyValue(nameof(WartoscVatZlotowkowa), ref wartoscVatZlotowkowa, value);
        }
        //KWOTA_VAT_ZLOTOWKOWA,Float,0,Wartość podatku należnego w złotówkach (w jednostkach kontrahenta),Tak

        public decimal KwotaVatZlotowkowa
        {
            get => kwotaVatZlotowkowa;
            set => SetPropertyValue(nameof(KwotaVatZlotowkowa), ref kwotaVatZlotowkowa, value);
        }
        //WARTOSC_BRUTTO_ZLOTOWKOWA,Float,0,Wartość dokumentu w cenach brutto w złotówkach (w jednostkach kontrahenta),Tak

        public decimal WartoscBruttoZlotowkowa
        {
            get => wartoscBruttoZlotowkowa;
            set => SetPropertyValue(nameof(WartoscBruttoZlotowkowa), ref wartoscBruttoZlotowkowa, value);
        }
        //WARTOSC_SPRZEDAZY_OPK_KAUCJONOWNYCH,Float,0,Wartość opakowań kaucjonowanych w cenach sprzedaży (w walucie dokumentu) (w jednostkach kontrahenta),Tak

        public decimal WartoscSprzedazyOpkKaucjonowanych
        {
            get => wartoscSprzedazyOpkKaucjonowanych;
            set => SetPropertyValue(nameof(WartoscSprzedazyOpkKaucjonowanych), ref wartoscSprzedazyOpkKaucjonowanych, value);
        }
        //WARTOSC_ZLOTOWKOWA_OPK_KAUCJONOWNYCH,Float,0,Wartość opakowań kaucjonowanych w cenach sprzedaży (w złotówkach) (w jednostkach kontrahenta),Tak

        public decimal WartoscZlotowkowaOpkKaucjonowanych
        {
            get => wartoscZlotowkowaOpkKaucjonowanych;
            set => SetPropertyValue(nameof(WartoscZlotowkowaOpkKaucjonowanych), ref wartoscZlotowkowaOpkKaucjonowanych, value);
        }


        //UWAGI,String,8000,Uwagi do dokumentu (maks. 8000 znaków),Nie

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }
        //WYSTAWIL,String,15,"Identyfikator osoby, która wystawiła dokument",Nie

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Wystawil
        {
            get => wystawil;
            set => SetPropertyValue(nameof(Wystawil), ref wystawil, value);
        }
        //DATA_DOPISANIA,DateTime,0,Data wystawienia dokumentu w systemie (może się różnić od DATA_WYSTAWIENIA),Nie

        public DateTime DataPodpisania
        {
            get => dataPodpisania;
            set => SetPropertyValue(nameof(DataPodpisania), ref dataPodpisania, value);
        }
        //ZMIENIL,String,15,"Identyfikator osoby, która ostatnio zmodyfikowała dokument",Nie

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Zmienil
        {
            get => zmienil;
            set => SetPropertyValue(nameof(Zmienil), ref zmienil, value);
        }
        //DATA_ZMIANY,DateTime,0,Data ostatniej modyfikacji dokumentu,Nie

        public DateTime DataZmiany
        {
            get => dataZmiany;
            set => SetPropertyValue(nameof(DataZmiany), ref dataZmiany, value);
        }
        //ID_KRAJU_PRZEZNACZENIA,Integer,0,Identyfikator kraju przeznaczenia,Nie

        //KOD_KRAJU_PRZEZNACZENIA,String,2,Kod kraju przeznaczenia,Nie

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string KodKrajuPrzeznaczenia
        {
            get => kodKrajuPrzeznaczenia;
            set => SetPropertyValue(nameof(KodKrajuPrzeznaczenia), ref kodKrajuPrzeznaczenia, value);
        }
        //ID_WARUNKU_DOSTAWY,Integer,0,Identyfikator warunku dostawy,Nie
        //KOD_WARUNKU_DOSTAWY,String,5,Kod warunków dostawy,Nie
        //ID_RODZAJU_TRANSPORTU,Integer,0,Identyfikator rodzaju transportu,Nie
        //KOD_RODZAJU_TRANSPORTU,String,5,Kod rodzaju transportu,Nie
        //ID_RODZAJU_TRANSAKCJI,Integer,0,Identyfikator rodzaju transakcji,Nie
        //KOD_RODZAJU_TRANSAKCJI,String,5,Kod rodzaju transakcji,Nie
        //ANALITYKA_FK_GRUP_MAG,String,20,Numer analityki konta FK grup magazynowych,Nie
        //ID_RDS,Integer,0,Identyfikator raportu dobowego sprzedaży z sekcji RAPORTY_DOBOWE_SPRZEDAZY.,Nie
        //GLN_NABYWCY,String,13,Globalny numer lokalizacji (GLN) nabywcy,Nie
        //GLN_ODBIORCY,String,13,Globalny numer lokalizacji (GLN) odbiorcy,Nie
        //PODSTAWA_ZWOLNIENIA_Z_VAT,String,250,Podstawa prawna zwolnienia z podatku VAT,Nie
        //MECHANIZM_PODZIELONEJ_PLATNOSCI,Integer,0,Mechanizm podzielonej płatności,Nie

        
        public bool MechanizmPodzielonejPlatnosci
        {
            get => mechanizmPodzielonejPlatnosci;
            set => SetPropertyValue(nameof(MechanizmPodzielonejPlatnosci), ref mechanizmPodzielonejPlatnosci, value);
        }
        //PROCEDURY_VAT,String,100,Procedury VAT powiązane z dokumentem,Nie
        //NUMER_FS_DO_PA,String,255,Numer faktury do paragonu,Nie
        //DATA_FS_DO_PA,Date,0,Data wystawienia faktury do paragonu,Nie
        //NIP_KOD_KRAJU_PLATNIKA,String,2,Kod kraju płatnika,Nie

        [Association("RaksFaktura-Rozrachunki")]
        public XPCollection<RaksRozrachunek> Rozrachunki{
            get
            {
                return GetCollection<RaksRozrachunek>(nameof(Rozrachunki));
            }
        }


        [Association("RaksFaktura-Platnosci")]
        public XPCollection<RaksPlatnosci> Platnosci{
            get
            {
                return GetCollection<RaksPlatnosci>(nameof(Platnosci));
            }
        }

        [Association("RaksFaktura-Pozycje")]
        public XPCollection<RaksPozycjeFaktury> Pozycje
        {
            get
            {
                return GetCollection<RaksPozycjeFaktury>(nameof(Pozycje));
            }
        }
        [Association("RaksFaktura-WartoscWstawkachVat")]
        public XPCollection<RaksWartosciFakturyWStawkachVat> WartoscWstawkachVat{
            get
            {
                return GetCollection<RaksWartosciFakturyWStawkachVat>(nameof(WartoscWstawkachVat));
            }
        }

        [Association("RaksFaktura-WartoscWstawkachVatPoZaliczkach")]
        public XPCollection<RaksWartoscFakturyWStawkachVatPoZaliczkach> WartoscWstawkachVatPoZaliczkach
        {
            get
            {
                return GetCollection<RaksWartoscFakturyWStawkachVatPoZaliczkach>(nameof(WartoscWstawkachVatPoZaliczkach));
            }
        }
    }
}
