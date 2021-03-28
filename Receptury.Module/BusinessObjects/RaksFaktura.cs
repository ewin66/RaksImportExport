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
    public class RaksFaktura : XPObject
    {
        public RaksFaktura(Session session) : base(session)
        { }

        RaksAdres adresOdbiorcy;
        RaksKontakt odbiorca;
        RaksAdres adresNabywcy;
        RaksKontakt nabywca;
        RaksKontakt sprzedawca;
        RaksMagazyn magazyn;
        int id;
        //Identyfikator rekordu
 
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
        int idmagazynu;
        //Identyfikator magazynu
        public int IdMagazynu
        {
            get => idmagazynu;
            set => SetPropertyValue(nameof(IdMagazynu), ref idmagazynu, value);
        }
        string numermagazynu;
        //Numer magazynu
        [Size(5)]
        public string NumerMagazynu
        {
            get => numermagazynu;
            set => SetPropertyValue(nameof(NumerMagazynu), ref numermagazynu, value);
        }
        string nazwamagazynu;
        //Nazwa magazynu
        [Size(25)]
        public string NazwaMagazynu
        {
            get => nazwamagazynu;
            set => SetPropertyValue(nameof(NazwaMagazynu), ref nazwamagazynu, value);
        }
        string analitykafkmagazynu;
        //Numer analityki konta FK magazynu
        [Size(20)]
        public string AnalitykaFkMagazynu
        {
            get => analitykafkmagazynu;
            set => SetPropertyValue(nameof(AnalitykaFkMagazynu), ref analitykafkmagazynu, value);
        }



        public RaksMagazyn Magazyn
        {
            get => magazyn;
            set => SetPropertyValue(nameof(Magazyn), ref magazyn, value);
        }
        int idsprzedawcy;
        //Identyfikator sprzedawcy (-1 - dane firmy; -ID-1 - dane filii)
        public int IdSprzedawcy
        {
            get => idsprzedawcy;
            set => SetPropertyValue(nameof(IdSprzedawcy), ref idsprzedawcy, value);
        }
        string nazwaskroconasprzedawcy;
        //Nazwa skrócona sprzedawcy
        [Size(50)]
        public string NazwaSkroconaSprzedawcy
        {
            get => nazwaskroconasprzedawcy;
            set => SetPropertyValue(nameof(NazwaSkroconaSprzedawcy), ref nazwaskroconasprzedawcy, value);
        }
        string nazwapelnasprzedawcy;
        //Nazwa pełna sprzedawcy
        [Size(200)]
        public string NazwaPelnaSprzedawcy
        {
            get => nazwapelnasprzedawcy;
            set => SetPropertyValue(nameof(NazwaPelnaSprzedawcy), ref nazwapelnasprzedawcy, value);
        }
        string nipsprzedawcy;
        //Numer NIP sprzedawcy
        [Size(25)]
        public string NipSprzedawcy
        {
            get => nipsprzedawcy;
            set => SetPropertyValue(nameof(NipSprzedawcy), ref nipsprzedawcy, value);
        }
        string kodkreskowysprzedawcy;
        //Kod kreskowy sprzedawcy
        [Size(40)]
        public string KodKreskowySprzedawcy
        {
            get => kodkreskowysprzedawcy;
            set => SetPropertyValue(nameof(KodKreskowySprzedawcy), ref kodkreskowysprzedawcy, value);
        }



        public RaksKontakt Sprzedawca
        {
            get => sprzedawca;
            set => SetPropertyValue(nameof(Sprzedawca), ref sprzedawca, value);
        }
        string rodzajdoksprzedazy;
        //Rodzaj dokumentu sprzedaży, możliwe wartości to: PA - paragon, FS - faktura VAT, FE - faktura eksportowa
        [Size(3)]
        public string RodzajDokSprzedazy
        {
            get => rodzajdoksprzedazy;
            set => SetPropertyValue(nameof(RodzajDokSprzedazy), ref rodzajdoksprzedazy, value);
        }
        string koddokumentu;
        //Kod dokumentu
        [Size(5)]
        public string KodDokumentu
        {
            get => koddokumentu;
            set => SetPropertyValue(nameof(KodDokumentu), ref koddokumentu, value);
        }
        DateTime datawystawienia;
        //Data wystawienia dokumentu (data operacji)
        public DateTime DataWystawienia
        {
            get => datawystawienia;
            set => SetPropertyValue(nameof(DataWystawienia), ref datawystawienia, value);
        }
        string numerdokumentu;
        //Numer dokumentu
        [Size(255)]
        public string NumerDokumentu
        {
            get => numerdokumentu;
            set => SetPropertyValue(nameof(NumerDokumentu), ref numerdokumentu, value);
        }
        string nazwadokumentu;
        //Nazwa dokumentu
        [Size(250)]
        public string NazwaDokumentu
        {
            get => nazwadokumentu;
            set => SetPropertyValue(nameof(NazwaDokumentu), ref nazwadokumentu, value);
        }
        bool transakcjatrojstronna;
        //Czy transakcja trojstronna
        public bool TransakcjaTrojstronna
        {
            get => transakcjatrojstronna;
            set => SetPropertyValue(nameof(TransakcjaTrojstronna), ref transakcjatrojstronna, value);
        }
        string sygnatura;
        //Sygnatura dokumentu
        [Size(100)]
        public string Sygnatura
        {
            get => sygnatura;
            set => SetPropertyValue(nameof(Sygnatura), ref sygnatura, value);
        }
        string znaczniki;
        //Znaczniki dokumentu
        public string Znaczniki
        {
            get => znaczniki;
            set => SetPropertyValue(nameof(Znaczniki), ref znaczniki, value);
        }
        string analitykafk;
        //Numer analityki konta FK
        [Size(20)]
        public string AnalitykaFk
        {
            get => analitykafk;
            set => SetPropertyValue(nameof(AnalitykaFk), ref analitykafk, value);
        }
        int blokada;
        //Status blokad dokumentu określany bitowo:
        // ustawiony bit 1 - dokument zablokowany
        // ustawiony bit 2 - dokument zaksięgowany
        // bit 3 - zarezerwowane, wpisywać zawsze 0
        // ustawiony bit 1 - dokument zablokowany przez moduł FK
        public int Blokada
        {
            get => blokada;
            set => SetPropertyValue(nameof(Blokada), ref blokada, value);
        }
        bool zafiskalizowany;
        //Czy dokument został już zafiskalizowany
        public bool Zafiskalizowany
        {
            get => zafiskalizowany;
            set => SetPropertyValue(nameof(Zafiskalizowany), ref zafiskalizowany, value);
        }


        public RaksKontakt Nabywca
        {
            get => nabywca;
            set => SetPropertyValue(nameof(Nabywca), ref nabywca, value);
        }


        public RaksAdres AdresNabywcy
        {
            get => adresNabywcy;
            set => SetPropertyValue(nameof(AdresNabywcy), ref adresNabywcy, value);
        }
        int idnabywcy;
        //Identyfikator nabywcy z sekcji KONTAKTY
        public int IdNabywcy
        {
            get => idnabywcy;
            set => SetPropertyValue(nameof(IdNabywcy), ref idnabywcy, value);
        }
        string nazwaskroconanabywcy;
        //Nazwa skrócona nabywcy, dla paragonów Sprzedaż detaliczna
        [Size(50)]
        public string NazwaSkroconaNabywcy
        {
            get => nazwaskroconanabywcy;
            set => SetPropertyValue(nameof(NazwaSkroconaNabywcy), ref nazwaskroconanabywcy, value);
        }
        string nazwapelnanabywcy;
        //Nazwa pełna nabywcy, pole nie wymagane dla paragonów
        [Size(250)]
        public string NazwaPelnaNabywcy
        {
            get => nazwapelnanabywcy;
            set => SetPropertyValue(nameof(NazwaPelnaNabywcy), ref nazwapelnanabywcy, value);
        }
        string kodkreskowynabywcy;
        //Kod kreskowy nabywcy, pole nie wymagane dla paragonów
        [Size(40)]
        public string KodKreskowyNabywcy
        {
            get => kodkreskowynabywcy;
            set => SetPropertyValue(nameof(KodKreskowyNabywcy), ref kodkreskowynabywcy, value);
        }
        string nipnabywcy;
        //Numer NIP nabywcy, pole nie wymagane dla paragonów
        [Size(25)]
        public string NipNabywcy
        {
            get => nipnabywcy;
            set => SetPropertyValue(nameof(NipNabywcy), ref nipnabywcy, value);
        }
        string ulicanabywcy;
        //Nazwa ulicy, przy której jest siedziba nabywcy
        [Size(50)]
        public string UlicaNabywcy
        {
            get => ulicanabywcy;
            set => SetPropertyValue(nameof(UlicaNabywcy), ref ulicanabywcy, value);
        }
        string nrdomunabywcy;
        //Numer budynku, w którym mieści się siedziba nabywcy
        [Size(10)]
        public string NrDomuNabywcy
        {
            get => nrdomunabywcy;
            set => SetPropertyValue(nameof(NrDomuNabywcy), ref nrdomunabywcy, value);
        }
        string nrlokalunabywcy;
        //Numer lokalu, w którym mieści się siedziba nabywcy
        [Size(10)]
        public string NrLokaluNabywcy
        {
            get => nrlokalunabywcy;
            set => SetPropertyValue(nameof(NrLokaluNabywcy), ref nrlokalunabywcy, value);
        }
        string kodpocztowynabywcy;
        //Kod pocztowy miejscowości, w której mieści się siedziba nabywcy
        [Size(10)]
        public string KodPocztowyNabywcy
        {
            get => kodpocztowynabywcy;
            set => SetPropertyValue(nameof(KodPocztowyNabywcy), ref kodpocztowynabywcy, value);
        }
        string miejscowoscnabywcy;
        //Miejscowość, w której znajduje się siedziba nabywcy
        [Size(50)]
        public string MiejscowoscNabywcy
        {
            get => miejscowoscnabywcy;
            set => SetPropertyValue(nameof(MiejscowoscNabywcy), ref miejscowoscnabywcy, value);
        }
        string panstwonabywcy;
        //Państwo, w którym znajduje się siedziba nabywcy
        [Size(25)]
        public string PanstwoNabywcy
        {
            get => panstwonabywcy;
            set => SetPropertyValue(nameof(PanstwoNabywcy), ref panstwonabywcy, value);
        }
        bool czynabywcaplatnikiemvat;
        //Czy nabywca jest płatnikiem VAT
        public bool CzyNabywcaPlatnikiemVat
        {
            get => czynabywcaplatnikiemvat;
            set => SetPropertyValue(nameof(CzyNabywcaPlatnikiemVat), ref czynabywcaplatnikiemvat, value);
        }


        public RaksKontakt Odbiorca
        {
            get => odbiorca;
            set => SetPropertyValue(nameof(Odbiorca), ref odbiorca, value);
        }

        
        public RaksAdres AdresOdbiorcy
        {
            get => adresOdbiorcy;
            set => SetPropertyValue(nameof(AdresOdbiorcy), ref adresOdbiorcy, value);
        }
        int idodbiorcy;
        //Identyfikator odbiorcy z sekcji KONTAKTY
        public int IdOdbiorcy
        {
            get => idodbiorcy;
            set => SetPropertyValue(nameof(IdOdbiorcy), ref idodbiorcy, value);
        }
        string nazwaskroconaodbiorcy;
        //Nazwa skrócona odbiorcy, dla paragonów Sprzedaż detaliczna
        [Size(50)]
        public string NazwaSkroconaOdbiorcy
        {
            get => nazwaskroconaodbiorcy;
            set => SetPropertyValue(nameof(NazwaSkroconaOdbiorcy), ref nazwaskroconaodbiorcy, value);
        }
        string nazwapelnaodbiorcy;
        //nazwa pełna odbiorcy; pole nie wymagane dla paragonów
        [Size(250)]
        public string NazwaPelnaOdbiorcy
        {
            get => nazwapelnaodbiorcy;
            set => SetPropertyValue(nameof(NazwaPelnaOdbiorcy), ref nazwapelnaodbiorcy, value);
        }
        string kodkreskowyodbiorcy;
        //Kod kreskowy odbiorcy; pole nie wymagane dla paragonów
        [Size(40)]
        public string KodKreskowyOdbiorcy
        {
            get => kodkreskowyodbiorcy;
            set => SetPropertyValue(nameof(KodKreskowyOdbiorcy), ref kodkreskowyodbiorcy, value);
        }
        string nipodbiorcy;
        //Numer NIP odbiorcy; pole nie wymagane dla paragonów
        [Size(25)]
        public string NipOdbiorcy
        {
            get => nipodbiorcy;
            set => SetPropertyValue(nameof(NipOdbiorcy), ref nipodbiorcy, value);
        }
        string ulicaodbiorcy;
        //Nazwa ulicy, przy której jest siedziba odbiorcy
        [Size(50)]
        public string UlicaOdbiorcy
        {
            get => ulicaodbiorcy;
            set => SetPropertyValue(nameof(UlicaOdbiorcy), ref ulicaodbiorcy, value);
        }
        string nrdomuodbiorcy;
        //Numer budynku, w którym mieści się siedziba odbiorcy
        [Size(10)]
        public string NrDomuOdbiorcy
        {
            get => nrdomuodbiorcy;
            set => SetPropertyValue(nameof(NrDomuOdbiorcy), ref nrdomuodbiorcy, value);
        }
        string nrlokaluodbiorcy;
        //Numer lokalu, w którym mieści się siedziba odbiorcy
        [Size(10)]
        public string NrLokaluOdbiorcy
        {
            get => nrlokaluodbiorcy;
            set => SetPropertyValue(nameof(NrLokaluOdbiorcy), ref nrlokaluodbiorcy, value);
        }
        string kodpocztowyodbiorcy;
        //Kod pocztowy miejscowości, w której mieści się siedziba odbiorcy
        [Size(10)]
        public string KodPocztowyOdbiorcy
        {
            get => kodpocztowyodbiorcy;
            set => SetPropertyValue(nameof(KodPocztowyOdbiorcy), ref kodpocztowyodbiorcy, value);
        }
        string miejscowoscodbiorcy;
        //Miejscowość, w której znajduje się siedziba odbiorcy
        [Size(50)]
        public string MiejscowoscOdbiorcy
        {
            get => miejscowoscodbiorcy;
            set => SetPropertyValue(nameof(MiejscowoscOdbiorcy), ref miejscowoscodbiorcy, value);
        }
        string panstwoodbiorcy;
        //Państwo, w którym znajduje się siedziba odbiorcy
        [Size(25)]
        public string PanstwoOdbiorcy
        {
            get => panstwoodbiorcy;
            set => SetPropertyValue(nameof(PanstwoOdbiorcy), ref panstwoodbiorcy, value);
        }
        bool czyodbiorcaplatnikiemvat;
        //Czy odbiorca jest płatnikiem VAT
        public bool CzyOdbiorcaPlatnikiemVat
        {
            get => czyodbiorcaplatnikiemvat;
            set => SetPropertyValue(nameof(CzyOdbiorcaPlatnikiemVat), ref czyodbiorcaplatnikiemvat, value);
        }
        int idakwizytora;
        //Identyfikator akwizytora z sekcji KONTAKTY
        public int IdAkwizytora
        {
            get => idakwizytora;
            set => SetPropertyValue(nameof(IdAkwizytora), ref idakwizytora, value);
        }
        string nazwaskroconaakwizytora;
        //Nazwa skrócona akwizytora
        [Size(50)]
        public string NazwaSkroconaAkwizytora
        {
            get => nazwaskroconaakwizytora;
            set => SetPropertyValue(nameof(NazwaSkroconaAkwizytora), ref nazwaskroconaakwizytora, value);
        }
        string nazwapelnaakwizytora;
        //Nazwa pełna akwizytora
        [Size(250)]
        public string NazwaPelnaAkwizytora
        {
            get => nazwapelnaakwizytora;
            set => SetPropertyValue(nameof(NazwaPelnaAkwizytora), ref nazwapelnaakwizytora, value);
        }
        string kodkreskowyakwizytora;
        //Kod kreskowy akwizytora
        [Size(40)]
        public string KodKreskowyAkwizytora
        {
            get => kodkreskowyakwizytora;
            set => SetPropertyValue(nameof(KodKreskowyAkwizytora), ref kodkreskowyakwizytora, value);
        }
        string nipakwizytora;
        //Numer NIP akwizytora
        [Size(25)]
        public string NipAkwizytora
        {
            get => nipakwizytora;
            set => SetPropertyValue(nameof(NipAkwizytora), ref nipakwizytora, value);
        }
        int idrodzajurabatu;
        //Identyfikator rodzaju rabatu z sekcji RABATY
        public int IdRodzajuRabatu
        {
            get => idrodzajurabatu;
            set => SetPropertyValue(nameof(IdRodzajuRabatu), ref idrodzajurabatu, value);
        }
        string nazwarodzajurabatu;
        //Nazwa rodzaju rabatu, używana do wyszukiwania, jeśli odnalezienie po ID_RODZAJU_RABATU nie powiedzie się
        [Size(50)]
        public string NazwaRodzajuRabatu
        {
            get => nazwarodzajurabatu;
            set => SetPropertyValue(nameof(NazwaRodzajuRabatu), ref nazwarodzajurabatu, value);
        }
        int idrodzajucen;
        //Identyfikator rodzaju ceny sprzedaży z sekcji RODZAJE_CEN_SPRZEDAZY
        public int IdRodzajuCen
        {
            get => idrodzajucen;
            set => SetPropertyValue(nameof(IdRodzajuCen), ref idrodzajucen, value);
        }
        string nazwarodzajucen;
        //Nazwa rodzaju cany sprzedaży, używana do wyszukiwania, jeśli odnalezienie po ID_RODZAJU_CEN nie powiedzie się
        [Size(25)]
        public string NazwaRodzajuCen
        {
            get => nazwarodzajucen;
            set => SetPropertyValue(nameof(NazwaRodzajuCen), ref nazwarodzajucen, value);
        }
        string osobaupowaznionadoodbtowaru;
        //Nazwisko osoby upoważnionej do odbioru towaru i podpisania faktury
        [Size(30)]
        public string OsobaUpowaznionaDoOdbTowaru
        {
            get => osobaupowaznionadoodbtowaru;
            set => SetPropertyValue(nameof(OsobaUpowaznionaDoOdbTowaru), ref osobaupowaznionadoodbtowaru, value);
        }
        int idtabelikursowej;
        //Identyfikator użytej tabeli kursowej
        public int IdTabeliKursowej
        {
            get => idtabelikursowej;
            set => SetPropertyValue(nameof(IdTabeliKursowej), ref idtabelikursowej, value);
        }
        string numertabelikursowej;
        //Numer użytej tabeli kursowej
        [Size(25)]
        public string NumerTabeliKursowej
        {
            get => numertabelikursowej;
            set => SetPropertyValue(nameof(NumerTabeliKursowej), ref numertabelikursowej, value);
        }
        int idwalutydokumentu;
        //Identyfikator waluty dokumentu
        public int IdWalutyDokumentu
        {
            get => idwalutydokumentu;
            set => SetPropertyValue(nameof(IdWalutyDokumentu), ref idwalutydokumentu, value);
        }
        string kodwalutydokumentu;
        //Kod waluty dokumentu
        [Size(5)]
        public string KodWalutyDokumentu
        {
            get => kodwalutydokumentu;
            set => SetPropertyValue(nameof(KodWalutyDokumentu), ref kodwalutydokumentu, value);
        }
        string nazwawalutydokumentu;
        //Nazwa waluty dokumentu
        [Size(50)]
        public string NazwaWalutyDokumentu
        {
            get => nazwawalutydokumentu;
            set => SetPropertyValue(nameof(NazwaWalutyDokumentu), ref nazwawalutydokumentu, value);
        }
        int mnoznikwalutydokumentu;
        //Mnożnik waluty dokumentu
        public int MnoznikWalutyDokumentu
        {
            get => mnoznikwalutydokumentu;
            set => SetPropertyValue(nameof(MnoznikWalutyDokumentu), ref mnoznikwalutydokumentu, value);
        }
        decimal kurswalutydokumentu;
        //Kurs waluty dokumentu wynikający z tabeli kursowej
        public decimal KursWalutyDokumentu
        {
            get => kurswalutydokumentu;
            set => SetPropertyValue(nameof(KursWalutyDokumentu), ref kurswalutydokumentu, value);
        }
        int sposobwyliczaniadokumentu;
        //Sposób wyliczania wartości dokumentu, możliwe wartości to: 0 - od netto, 1 - od brutto, 2 - sumy
        public int SposobWyliczaniaDokumentu
        {
            get => sposobwyliczaniadokumentu;
            set => SetPropertyValue(nameof(SposobWyliczaniaDokumentu), ref sposobwyliczaniadokumentu, value);
        }
        DateTime datasprzedazy;
        //Data sprzedaży
        public DateTime DataSprzedazy
        {
            get => datasprzedazy;
            set => SetPropertyValue(nameof(DataSprzedazy), ref datasprzedazy, value);
        }
        int idsposobuplatnosci;
        //Identyfikator sposobu zapłaty za fakturę z sekcji SPOSOBY_ZAPLATY
        public int IdSposobuPlatnosci
        {
            get => idsposobuplatnosci;
            set => SetPropertyValue(nameof(IdSposobuPlatnosci), ref idsposobuplatnosci, value);
        }
        string sposobplatnosci;
        //Sposób zapłaty za fakturę, używane do wyszukiwania, jeśli odnalezienie po ID_SPOSOBU_PLATNOSCI nie powiedzie się
        [Size(100)]
        public string SposobPlatnosci
        {
            get => sposobplatnosci;
            set => SetPropertyValue(nameof(SposobPlatnosci), ref sposobplatnosci, value);
        }
        DateTime dataplatnosci;
        //Data płatności za fakturę
        public DateTime DataPlatnosci
        {
            get => dataplatnosci;
            set => SetPropertyValue(nameof(DataPlatnosci), ref dataplatnosci, value);
        }
        decimal wartoscnettosprzedazy;
        //Wartość dokumentu w cenach sprzedaży netto (w walucie dokumentu) (w jednostkach kontrahenta)
        public decimal WartoscNettoSprzedazy
        {
            get => wartoscnettosprzedazy;
            set => SetPropertyValue(nameof(WartoscNettoSprzedazy), ref wartoscnettosprzedazy, value);
        }
        decimal kwotavatsprzedazy;
        //Kwota VAT podatku należnego (w jednostkach kontrahenta)
        public decimal KwotaVatSprzedazy
        {
            get => kwotavatsprzedazy;
            set => SetPropertyValue(nameof(KwotaVatSprzedazy), ref kwotavatsprzedazy, value);
        }
        decimal wartoscbruttosprzedazy;
        //Wartość dokumentu w cenach  brutto (w walucie dokumentu) (w jednostkach kontrahenta)
        public decimal WartoscBruttoSprzedazy
        {
            get => wartoscbruttosprzedazy;
            set => SetPropertyValue(nameof(WartoscBruttoSprzedazy), ref wartoscbruttosprzedazy, value);
        }
        decimal wartoscnettozlotowkowa;
        //Wartość dokumentu w cenach netto w złotówkach (w jednostkach kontrahenta)
        public decimal WartoscNettoZlotowkowa
        {
            get => wartoscnettozlotowkowa;
            set => SetPropertyValue(nameof(WartoscNettoZlotowkowa), ref wartoscnettozlotowkowa, value);
        }
        decimal kwotavatzlotowkowa;
        //Wartość podatku należnego w złotówkach (w jednostkach kontrahenta)
        public decimal KwotaVatZlotowkowa
        {
            get => kwotavatzlotowkowa;
            set => SetPropertyValue(nameof(KwotaVatZlotowkowa), ref kwotavatzlotowkowa, value);
        }
        decimal wartoscbruttozlotowkowa;
        //Wartość dokumentu w cenach brutto w złotówkach (w jednostkach kontrahenta)
        public decimal WartoscBruttoZlotowkowa
        {
            get => wartoscbruttozlotowkowa;
            set => SetPropertyValue(nameof(WartoscBruttoZlotowkowa), ref wartoscbruttozlotowkowa, value);
        }
        decimal wartoscsprzedazyopkkaucjonownych;
        //Wartość opakowań kaucjonowanych w cenach sprzedaży (w walucie dokumentu) (w jednostkach kontrahenta)
        public decimal WartoscSprzedazyOpkKaucjonownych
        {
            get => wartoscsprzedazyopkkaucjonownych;
            set => SetPropertyValue(nameof(WartoscSprzedazyOpkKaucjonownych), ref wartoscsprzedazyopkkaucjonownych, value);
        }
        decimal wartosczlotowkowaopkkaucjonownych;
        //Wartość opakowań kaucjonowanych w cenach sprzedaży (w złotówkach) (w jednostkach kontrahenta)
        public decimal WartoscZlotowkowaOpkKaucjonownych
        {
            get => wartosczlotowkowaopkkaucjonownych;
            set => SetPropertyValue(nameof(WartoscZlotowkowaOpkKaucjonownych), ref wartosczlotowkowaopkkaucjonownych, value);
        }
        string uwagi;
        //Uwagi do dokumentu (maks. 8000 znaków)
        [Size(8000)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }
        string wystawil;
        //Identyfikator osoby, która wystawiła dokument
        [Size(15)]
        public string Wystawil
        {
            get => wystawil;
            set => SetPropertyValue(nameof(Wystawil), ref wystawil, value);
        }
        string datadopisania;
        //Data wystawienia dokumentu w systemie (może się różnić od DATA_WYSTAWIENIA)
        public string DataDopisania
        {
            get => datadopisania;
            set => SetPropertyValue(nameof(DataDopisania), ref datadopisania, value);
        }
        string zmienil;
        //Identyfikator osoby, która ostatnio zmodyfikowała dokument
        [Size(15)]
        public string Zmienil
        {
            get => zmienil;
            set => SetPropertyValue(nameof(Zmienil), ref zmienil, value);
        }
        string datazmiany;
        //Data ostatniej modyfikacji dokumentu
        public string DataZmiany
        {
            get => datazmiany;
            set => SetPropertyValue(nameof(DataZmiany), ref datazmiany, value);
        }
        int idkrajuprzeznaczenia;
        //Identyfikator kraju przeznaczenia
        public int IdKrajuPrzeznaczenia
        {
            get => idkrajuprzeznaczenia;
            set => SetPropertyValue(nameof(IdKrajuPrzeznaczenia), ref idkrajuprzeznaczenia, value);
        }
        string kodkrajuprzeznaczenia;
        //Kod kraju przeznaczenia
        [Size(2)]
        public string KodKrajuPrzeznaczenia
        {
            get => kodkrajuprzeznaczenia;
            set => SetPropertyValue(nameof(KodKrajuPrzeznaczenia), ref kodkrajuprzeznaczenia, value);
        }
        int idwarunkudostawy;
        //Identyfikator warunku dostawy
        public int IdWarunkuDostawy
        {
            get => idwarunkudostawy;
            set => SetPropertyValue(nameof(IdWarunkuDostawy), ref idwarunkudostawy, value);
        }
        string kodwarunkudostawy;
        //Kod warunków dostawy
        [Size(5)]
        public string KodWarunkuDostawy
        {
            get => kodwarunkudostawy;
            set => SetPropertyValue(nameof(KodWarunkuDostawy), ref kodwarunkudostawy, value);
        }
        int idrodzajutransportu;
        //Identyfikator rodzaju transportu
        public int IdRodzajuTransportu
        {
            get => idrodzajutransportu;
            set => SetPropertyValue(nameof(IdRodzajuTransportu), ref idrodzajutransportu, value);
        }
        string kodrodzajutransportu;
        //Kod rodzaju transportu
        [Size(5)]
        public string KodRodzajuTransportu
        {
            get => kodrodzajutransportu;
            set => SetPropertyValue(nameof(KodRodzajuTransportu), ref kodrodzajutransportu, value);
        }
        int idrodzajutransakcji;
        //Identyfikator rodzaju transakcji
        public int IdRodzajuTransakcji
        {
            get => idrodzajutransakcji;
            set => SetPropertyValue(nameof(IdRodzajuTransakcji), ref idrodzajutransakcji, value);
        }
        string kodrodzajutransakcji;
        //Kod rodzaju transakcji
        [Size(5)]
        public string KodRodzajuTransakcji
        {
            get => kodrodzajutransakcji;
            set => SetPropertyValue(nameof(KodRodzajuTransakcji), ref kodrodzajutransakcji, value);
        }
        string analitykafkgrupmag;
        //Numer analityki konta FK grup magazynowych
        [Size(20)]
        public string AnalitykaFkGrupMag
        {
            get => analitykafkgrupmag;
            set => SetPropertyValue(nameof(AnalitykaFkGrupMag), ref analitykafkgrupmag, value);
        }
        int idrds;
        //Identyfikator raportu dobowego sprzedaży z sekcji RAPORTY_DOBOWE_SPRZEDAZY.
        public int IdRds
        {
            get => idrds;
            set => SetPropertyValue(nameof(IdRds), ref idrds, value);
        }
        string glnnabywcy;
        //Globalny numer lokalizacji (GLN) nabywcy
        [Size(13)]
        public string GlnNabywcy
        {
            get => glnnabywcy;
            set => SetPropertyValue(nameof(GlnNabywcy), ref glnnabywcy, value);
        }
        string glnodbiorcy;
        //Globalny numer lokalizacji (GLN) odbiorcy
        [Size(13)]
        public string GlnOdbiorcy
        {
            get => glnodbiorcy;
            set => SetPropertyValue(nameof(GlnOdbiorcy), ref glnodbiorcy, value);
        }
        string podstawazwolnieniazvat;
        //Podstawa prawna zwolnienia z podatku VAT
        [Size(250)]
        public string PodstawaZwolnieniaZVat
        {
            get => podstawazwolnieniazvat;
            set => SetPropertyValue(nameof(PodstawaZwolnieniaZVat), ref podstawazwolnieniazvat, value);
        }
        int mechanizmpodzielonejplatnosci;
        //Mechanizm podzielonej płatności
        public int MechanizmPodzielonejPlatnosci
        {
            get => mechanizmpodzielonejplatnosci;
            set => SetPropertyValue(nameof(MechanizmPodzielonejPlatnosci), ref mechanizmpodzielonejplatnosci, value);
        }
        string proceduryvat;
        //Procedury VAT powiązane z dokumentem
        [Size(100)]
        public string ProceduryVat
        {
            get => proceduryvat;
            set => SetPropertyValue(nameof(ProceduryVat), ref proceduryvat, value);
        }
        string numerfsdopa;
        //Numer faktury do paragonu
        [Size(255)]
        public string NumerFsDoPa
        {
            get => numerfsdopa;
            set => SetPropertyValue(nameof(NumerFsDoPa), ref numerfsdopa, value);
        }
        DateTime datafsdopa;
        //Data wystawienia faktury do paragonu
        public DateTime DataFsDoPa
        {
            get => datafsdopa;
            set => SetPropertyValue(nameof(DataFsDoPa), ref datafsdopa, value);
        }
        string nipkodkrajuplatnika;
        //Kod kraju płatnika
        [Size(2)]
        public string NipKodKrajuPlatnika
        {
            get => nipkodkrajuplatnika;
            set => SetPropertyValue(nameof(NipKodKrajuPlatnika), ref nipkodkrajuplatnika, value);
        }

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
