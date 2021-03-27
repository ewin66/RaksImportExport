using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using Receptury.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module
{
   public class FakturyReader
    {
        IObjectSpace objectSpace;
        public FakturyReader(IObjectSpace os)
        {
            objectSpace = os;
        }

        public void ReadKontakty(string xmlString)
        {

            Chilkat.Xml xml = new Chilkat.Xml();

            xml.LoadXml(xmlString);

            string WIERSZ_ID;
            string WIERSZ_ID_GRUPY;
            string WIERSZ_NAZWA_GRUPY;
            string WIERSZ_NAZWA_SKROCONA;
            string WIERSZ_NAZWA_PELNA;
            string WIERSZ_AKWIZYTOR;
            string WIERSZ_DOSTAWCA;
            string WIERSZ_ODBIORCA;
            string WIERSZ_KOD_KRESKOWY;
            string WIERSZ_NIP;
            string WIERSZ_TYP_KONTAKTU;
            string WIERSZ_ID_ADRESU_DOMYSLNEGO;
            string WIERSZ_ULICA;
            string WIERSZ_NUMER_BUDYNKU;
            string WIERSZ_NUMER_LOKALU;
            string WIERSZ_KOD_POCZTOWY;
            string WIERSZ_MIEJSCOWOSC;
            string WIERSZ_WOJEWODZTWO;
            string WIERSZ_KRAJ;
            string WIERSZ_KOD_KRAJU_UE;
            string WIERSZ_UWAGI;
            string WIERSZ_NEW_ID;
            string WIERSZ_SPRZ_DETAL;
            string WIERSZ_KOD_WALUTY;
            string WIERSZ_POWIAT;
            string WIERSZ_GMINA;
            string WIERSZ_KOD_GMINY_WG_GUS;
            string WIERSZ_POCZTA;
            string WIERSZ_GLN;
            string WIERSZ_NIP_KOD_KRAJU;
            int j;
            int count_j;
            string WIERSZ_ID_WALUTY;
            string WIERSZ_NUMER_RACHUNKU;
            string WIERSZ_MAKSYMALNY_DEBET;
            string WIERSZ_SYMBOL_WALUTY;
            string WIERSZ_NAZWA_RACHUNKU;
            string WIERSZ_TYP_RACHUNKU;
            string WIERSZ_ID_KONTRAHENTA;
            string WIERSZ_TYP_HOMEBANKING;
            string WIERSZ_KATALOG_HOMEBANKING;
            string WIERSZ_MNOZNIK_WALUTY;
            string WIERSZ_NAZWA_WALUTY;
            string WIERSZ_RACHUNEK_DOMYSLNY;
            string WIERSZ_KONTO_KSIEGOWE;
            string WIERSZ_SKRACAJ_NAZWE_KONTRAH_HMB;
            string WIERSZ_SWIFT;
            string WIERSZ_AUTO_ZAMIANA_ZNAKOW_HMB;
            string WIERSZ_ARCHIWALNY;
            string WIERSZ_KONTO_AKWIZYTORA;
            string WIERSZ_KONTO_DOSTAWCY;
            string WIERSZ_KONTO_ODBIORCY;
            string WIERSZ_KONTO_PRACOWNIKA;
            string WIERSZ_ID_TYPU_FIRMY;
            string WIERSZ_NAZWA_TYPU_FIRMY;
            string WIERSZ_REGON;
            string WIERSZ_NUMER_REJESTRU_SADOWEGO;
            string WIERSZ_PESEL;
            string WIERSZ_NUMER_DOWODU_OS;
            string WIERSZ_DATA_WYDANIA_DOWODU_OS;
            string WIERSZ_ORGAN_WYDAJACY_DOWOD_OS;
            string WIERSZ_PLATNIK_VAT;
            string WIERSZ_ROLNIK_INDYWIDUALNY;
            string WIERSZ_MAKS_WARTOSC_DLUGU_WOBEC_DOSTAWCY;
            string WIERSZ_MAKS_ILOSC_DOKUMENTOW_SPRZED_W_KREDYCIE;
            string WIERSZ_MAKS_ILOSC_DOKUMENTOW_SPRZED_W_KREDYCIE_PRZETERM;
            string WIERSZ_ID_AKWIZYTORA;
            string WIERSZ_PROWIZJA;
            string WIERSZ_MAKS_WARTOSC_KREDYTU_DLA_KLIENTA;
            string WIERSZ_MAKS_WARTOSC_KREDYTU_DLA_KLIENTA_PRZETERM;
            string WIERSZ_ID_SPOSOBU_ZAPLATY;
            string WIERSZ_ID_SPOSOBU_ZAPLATY_DOST;
            string WIERSZ_SPOSOB_LICZENIA_DOST;
            string WIERSZ_ID_RODZAJU_CENY;
            string WIERSZ_ID_RABATU;
            string WIERSZ_MNOZNIK;
            string WIERSZ_ID_PLATNIKA;
            string WIERSZ_BLOKADA;
            string WIERSZ_BLOKADA_POWOD;
            string WIERSZ_KREDYT;
            string WIERSZ_DLUG;
            string WIERSZ_NEW_FIRM_ID;
            string WIERSZ_NEW_SM_ID;
            string WIERSZ_ID_NAGLOWKA;
            string WIERSZ_NEW_WORKER_ID;
            string WIERSZ_MASS_PAYMENT_NR;
            string WIERSZ_NASZ_NUMER_U_KONTRAHENTA;
            string WIERSZ_IMIE_PIERWSZE;
            string WIERSZ_IMIE_DRUGIE;
            string WIERSZ_NAZWISKO;
            string WIERSZ_NAZWISKO_RODOWE;
            string WIERSZ_NAZWA_WYSWIETLANA;
            string WIERSZ_PLEC;
            string WIERSZ_DATA_URODZENIA;
            string WIERSZ_JEZYK;
            string WIERSZ_NARODOWOSC;
            string WIERSZ_OBYWATELSTWO;
            string WIERSZ_HOBBY;
            string WIERSZ_WSPOLMALZONEK;
            string WIERSZ_URODZINY_WSPOLMALZONKA;
            string WIERSZ_ROCZNICA_SLUBU;
            string WIERSZ_ZLECENIOWY;
            string WIERSZ_ETATOWY;
            string WIERSZ_DATA_ROZP_ROZLICZEN;
            string WIERSZ_TYP_DOK_TOZSAMOSCI;
            string WIERSZ_IMIE_OJCA;
            string WIERSZ_IMIE_MATKI;
            string WIERSZ_MIEJSCE_URODZENIA;
            string WIERSZ_TYTUL_NAUKOWY;
            string WIERSZ_US_GUID;
            string WIERSZ_US_NAZWA;
            string WIERSZ_US_ULICA;
            string WIERSZ_US_DOM;
            string WIERSZ_US_KOD_POCZTOWY;
            string WIERSZ_US_MIEJSCOWOSC;
            string WIERSZ_NR_AKTU_MALZENSTWA;
            string WIERSZ_WSPOLNE_GOSPODARSTWO;
            string WIERSZ_WYNAGRODZENIE_PRZELEWEM;
            string WIERSZ_KOD_ODDZIALU_NFZ;
            string WIERSZ_DOK_TOZS_WYDANY_PRZEZ;
            string WIERSZ_DOK_TOZS_WAZNY_OD;
            string WIERSZ_DOK_TOZS_WAZNY_DO;
            string WIERSZ_IDENTYFIKATOR_PODATKOWY;
            string WIERSZ_IDENTYFIKATOR_PLATNIKA;
            string WIERSZ_ID_ADRESU_DO_DEKLARACJI;
            string WIERSZ_KRAJ_DO_DEKLARACJI;
            string WIERSZ_IDENT_DO_DEKLARACJI;
            string WIERSZ_RODZAJ_IDENT_DO_DEKLARACJI;
            string WIERSZ_NIEREZYDENT;
            string WIERSZ_GLOWNE_MIEJSCE_PRACY;
            string WIERSZ_ALLOW_EMAIL;
            string WIERSZ_ALLOW_PHONE;
            string WIERSZ_ALLOW_FAX;
            string WIERSZ_ALLOW_POST;
            string WIERSZ_PREFFERED_CONTACT;
            string WIERSZ_ZAWIADOMIC_OSOBE;
            string WIERSZ_PRACOWNIK_NAUKOWY;
            string WIERSZ_NR_EWIDENCYJNY;
            string WIERSZ_PRZELOZONY;
            string WIERSZ_KONTAKT_DO_PRZELOZONEGO;
            string WIERSZ_ASYSTENT;
            string WIERSZ_KONTAKT_DO_ASYSTENTA;
            string WIERSZ_TYTUL_ZAWODOWY;
            string WIERSZ_KONTRAHENT_POWIAZANY;
            string WIERSZ_NUMER_DOMU;
            string WIERSZ_NAZWA_TYPU;

            int i = 0;
            int count_i = xml.NumChildrenHavingTag("WIERSZ");
            while (i < count_i)
            {
                xml.I = i;



                 WIERSZ_ID = xml.ChilkatPath("WIERSZ[i]|(ID)");
                var kontakt = FindKontakt(WIERSZ_ID);

                 WIERSZ_ID_GRUPY = xml.ChilkatPath("WIERSZ[i]|(ID_GRUPY)");
                 WIERSZ_NAZWA_GRUPY = xml.ChilkatPath("WIERSZ[i]|(NAZWA_GRUPY)");



                RaksGrupaKontaktow grupa = FindGrupaKontaktu(WIERSZ_ID_GRUPY, WIERSZ_NAZWA_GRUPY);
                kontakt.Grupa = grupa;
                kontakt.NazwaSkrocona = xml.ChilkatPath("WIERSZ[i]|(NAZWA_SKROCONA)");
                kontakt.NazwaPelna = xml.ChilkatPath("WIERSZ[i]|(NAZWA_PELNA)");
                kontakt.Akwizytor = bool.Parse(xml.ChilkatPath("WIERSZ[i]|(AKWIZYTOR)"));
                kontakt.Dostawca = bool.Parse(xml.ChilkatPath("WIERSZ[i]|(DOSTAWCA)"));
                kontakt.Odbiorca = bool.Parse(xml.ChilkatPath("WIERSZ[i]|(ODBIORCA)"));
                kontakt.KodKreskowy = xml.ChilkatPath("WIERSZ[i]|(KOD_KRESKOWY)");
                kontakt.Nip = xml.ChilkatPath("WIERSZ[i]|(NIP)");
                kontakt.TypKontaktu = int.Parse(xml.ChilkatPath("WIERSZ[i]|(TYP_KONTAKTU)"));
                string ID_ADRESU_DOMYSLNEGO = xml.ChilkatPath("WIERSZ[i]|(ID_ADRESU_DOMYSLNEGO)");

                kontakt.Uwagi = xml.ChilkatPath("WIERSZ[i]|(UWAGI)");


                WIERSZ_ID = xml.ChilkatPath("WIERSZ[i]|(ID)");
                WIERSZ_ID_GRUPY = xml.ChilkatPath("WIERSZ[i]|(ID_GRUPY)");
                WIERSZ_NAZWA_GRUPY = xml.ChilkatPath("WIERSZ[i]|(NAZWA_GRUPY)");
                WIERSZ_NAZWA_SKROCONA = xml.ChilkatPath("WIERSZ[i]|(NAZWA_SKROCONA)");
                WIERSZ_NAZWA_PELNA = xml.ChilkatPath("WIERSZ[i]|(NAZWA_PELNA)");
                WIERSZ_AKWIZYTOR = xml.ChilkatPath("WIERSZ[i]|(AKWIZYTOR)");
                WIERSZ_DOSTAWCA = xml.ChilkatPath("WIERSZ[i]|(DOSTAWCA)");
                WIERSZ_ODBIORCA = xml.ChilkatPath("WIERSZ[i]|(ODBIORCA)");
                WIERSZ_KOD_KRESKOWY = xml.ChilkatPath("WIERSZ[i]|(KOD_KRESKOWY)");
                WIERSZ_NIP = xml.ChilkatPath("WIERSZ[i]|(NIP)");
                WIERSZ_TYP_KONTAKTU = xml.ChilkatPath("WIERSZ[i]|(TYP_KONTAKTU)");
                WIERSZ_ID_ADRESU_DOMYSLNEGO = xml.ChilkatPath("WIERSZ[i]|(ID_ADRESU_DOMYSLNEGO)");
                WIERSZ_ULICA = xml.ChilkatPath("WIERSZ[i]|(ULICA)");
                WIERSZ_NUMER_BUDYNKU = xml.ChilkatPath("WIERSZ[i]|(NUMER_BUDYNKU)");
                WIERSZ_NUMER_LOKALU = xml.ChilkatPath("WIERSZ[i]|(NUMER_LOKALU)");
                WIERSZ_KOD_POCZTOWY = xml.ChilkatPath("WIERSZ[i]|(KOD_POCZTOWY)");
                WIERSZ_MIEJSCOWOSC = xml.ChilkatPath("WIERSZ[i]|(MIEJSCOWOSC)");
                WIERSZ_WOJEWODZTWO = xml.ChilkatPath("WIERSZ[i]|(WOJEWODZTWO)");
                WIERSZ_KRAJ = xml.ChilkatPath("WIERSZ[i]|(KRAJ)");
                WIERSZ_KOD_KRAJU_UE = xml.ChilkatPath("WIERSZ[i]|(KOD_KRAJU_UE)");
                WIERSZ_UWAGI = xml.ChilkatPath("WIERSZ[i]|(UWAGI)");
                WIERSZ_NEW_ID = xml.ChilkatPath("WIERSZ[i]|(NEW_ID)");
                WIERSZ_SPRZ_DETAL = xml.ChilkatPath("WIERSZ[i]|(SPRZ_DETAL)");
                WIERSZ_KOD_WALUTY = xml.ChilkatPath("WIERSZ[i]|(KOD_WALUTY)");
                WIERSZ_POWIAT = xml.ChilkatPath("WIERSZ[i]|(POWIAT)");
                WIERSZ_GMINA = xml.ChilkatPath("WIERSZ[i]|(GMINA)");
                WIERSZ_KOD_GMINY_WG_GUS = xml.ChilkatPath("WIERSZ[i]|(KOD_GMINY_WG_GUS)");
                WIERSZ_POCZTA = xml.ChilkatPath("WIERSZ[i]|(POCZTA)");
                WIERSZ_GLN = xml.ChilkatPath("WIERSZ[i]|(GLN)");
                WIERSZ_NIP_KOD_KRAJU = xml.ChilkatPath("WIERSZ[i]|(NIP_KOD_KRAJU)");
                j = 0;
                count_j = xml.NumChildrenHavingTag("WIERSZ[i]|ADRESY|WIERSZ");
                while (j < count_j)
                {
                    xml.J = j;


                    WIERSZ_ID = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(ID)");
                    RaksAdres adres = FindAdres(WIERSZ_ID);
                    if (WIERSZ_ID == ID_ADRESU_DOMYSLNEGO)
                    {
                        kontakt.AdresDomyslny = adres;
                    }
                    kontakt.Adresy.Add(adres);
                    adres.Ulica = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(ULICA)");
                    adres.NumerDomu = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(NUMER_DOMU)");
                    adres.NumerLokalu = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(NUMER_LOKALU)");
                    adres.KodPocztowy = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(KOD_POCZTOWY)");
                    adres.Miejscowosc = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(MIEJSCOWOSC)");
                    adres.Wojewodztwo = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(WOJEWODZTWO)");
                    adres.Kraj = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(KRAJ)");
                    adres.NazwaTypu = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(NAZWA_TYPU)");
                    adres.Powiat = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(POWIAT)");
                    adres.Gmina = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(GMINA)");
                    adres.KodGminyWgGus = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(KOD_GMINY_WG_GUS)");
                    adres.Poczta = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(POCZTA)");
                    adres.Gln = xml.ChilkatPath("WIERSZ[i]|ADRESY|WIERSZ[j]|(GLN)");



                    j = j + 1;
                }

                j = 0;
                count_j = xml.NumChildrenHavingTag("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ");
                while (j < count_j)
                {
                    xml.J = j;
                    WIERSZ_ID = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(ID)");
                    WIERSZ_ID_WALUTY = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(ID_WALUTY)");
                    WIERSZ_NUMER_RACHUNKU = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(NUMER_RACHUNKU)");
                    WIERSZ_MAKSYMALNY_DEBET = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(MAKSYMALNY_DEBET)");
                    WIERSZ_SYMBOL_WALUTY = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(SYMBOL_WALUTY)");
                    WIERSZ_NAZWA_RACHUNKU = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(NAZWA_RACHUNKU)");
                    WIERSZ_TYP_RACHUNKU = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(TYP_RACHUNKU)");
                    WIERSZ_ID_KONTRAHENTA = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(ID_KONTRAHENTA)");
                    WIERSZ_TYP_HOMEBANKING = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(TYP_HOMEBANKING)");
                    WIERSZ_KATALOG_HOMEBANKING = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(KATALOG_HOMEBANKING)");
                    WIERSZ_MNOZNIK_WALUTY = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(MNOZNIK_WALUTY)");
                    WIERSZ_NAZWA_WALUTY = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(NAZWA_WALUTY)");
                    WIERSZ_RACHUNEK_DOMYSLNY = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(RACHUNEK_DOMYSLNY)");
                    WIERSZ_KONTO_KSIEGOWE = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(KONTO_KSIEGOWE)");
                    WIERSZ_NEW_ID = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(NEW_ID)");
                    WIERSZ_SKRACAJ_NAZWE_KONTRAH_HMB = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(SKRACAJ_NAZWE_KONTRAH_HMB)");
                    WIERSZ_SWIFT = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(SWIFT)");
                    WIERSZ_AUTO_ZAMIANA_ZNAKOW_HMB = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(AUTO_ZAMIANA_ZNAKOW_HMB)");
                    WIERSZ_ARCHIWALNY = xml.ChilkatPath("WIERSZ[i]|RACHUNKI_BANKOWE|WIERSZ[j]|(ARCHIWALNY)");
                    j = j + 1;
                }

                j = 0;
                count_j = xml.NumChildrenHavingTag("WIERSZ[i]|DANE_DODATKOWE|WIERSZ");
                while (j < count_j)
                {
                    xml.J = j;
                    WIERSZ_ID = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID)");
                    WIERSZ_KONTO_AKWIZYTORA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KONTO_AKWIZYTORA)");
                    WIERSZ_KONTO_DOSTAWCY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KONTO_DOSTAWCY)");
                    WIERSZ_KONTO_ODBIORCY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KONTO_ODBIORCY)");
                    WIERSZ_KONTO_PRACOWNIKA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KONTO_PRACOWNIKA)");
                    WIERSZ_ID_TYPU_FIRMY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_TYPU_FIRMY)");
                    WIERSZ_NAZWA_TYPU_FIRMY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NAZWA_TYPU_FIRMY)");
                    WIERSZ_REGON = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(REGON)");
                    WIERSZ_NUMER_REJESTRU_SADOWEGO = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NUMER_REJESTRU_SADOWEGO)");
                    WIERSZ_PESEL = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(PESEL)");
                    WIERSZ_NUMER_DOWODU_OS = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NUMER_DOWODU_OS)");
                    WIERSZ_DATA_WYDANIA_DOWODU_OS = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(DATA_WYDANIA_DOWODU_OS)");
                    WIERSZ_ORGAN_WYDAJACY_DOWOD_OS = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ORGAN_WYDAJACY_DOWOD_OS)");
                    WIERSZ_PLATNIK_VAT = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(PLATNIK_VAT)");
                    WIERSZ_ROLNIK_INDYWIDUALNY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ROLNIK_INDYWIDUALNY)");
                    WIERSZ_MAKS_WARTOSC_DLUGU_WOBEC_DOSTAWCY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(MAKS_WARTOSC_DLUGU_WOBEC_DOSTAWCY)");
                    WIERSZ_MAKS_ILOSC_DOKUMENTOW_SPRZED_W_KREDYCIE = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(MAKS_ILOSC_DOKUMENTOW_SPRZED_W_KREDYCIE)");
                    WIERSZ_MAKS_ILOSC_DOKUMENTOW_SPRZED_W_KREDYCIE_PRZETERM = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(MAKS_ILOSC_DOKUMENTOW_SPRZED_W_KREDYCIE_PRZETERM)");
                    WIERSZ_ID_AKWIZYTORA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_AKWIZYTORA)");
                    WIERSZ_PROWIZJA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(PROWIZJA)");
                    WIERSZ_MAKS_WARTOSC_KREDYTU_DLA_KLIENTA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(MAKS_WARTOSC_KREDYTU_DLA_KLIENTA)");
                    WIERSZ_MAKS_WARTOSC_KREDYTU_DLA_KLIENTA_PRZETERM = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(MAKS_WARTOSC_KREDYTU_DLA_KLIENTA_PRZETERM)");
                    WIERSZ_ID_SPOSOBU_ZAPLATY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_SPOSOBU_ZAPLATY)");
                    WIERSZ_ID_SPOSOBU_ZAPLATY_DOST = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_SPOSOBU_ZAPLATY_DOST)");
                    WIERSZ_SPOSOB_LICZENIA_DOST = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(SPOSOB_LICZENIA_DOST)");
                    WIERSZ_ID_RODZAJU_CENY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_RODZAJU_CENY)");
                    WIERSZ_ID_RABATU = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_RABATU)");
                    WIERSZ_ID_WALUTY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_WALUTY)");
                    WIERSZ_KOD_WALUTY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KOD_WALUTY)");
                    WIERSZ_NAZWA_WALUTY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NAZWA_WALUTY)");
                    WIERSZ_MNOZNIK = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(MNOZNIK)");
                    WIERSZ_ID_PLATNIKA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_PLATNIKA)");
                    WIERSZ_BLOKADA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(BLOKADA)");
                    WIERSZ_BLOKADA_POWOD = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(BLOKADA_POWOD)");
                    WIERSZ_KREDYT = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KREDYT)");
                    WIERSZ_DLUG = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(DLUG)");
                    WIERSZ_NEW_FIRM_ID = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NEW_FIRM_ID)");
                    WIERSZ_NEW_SM_ID = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NEW_SM_ID)");
                    WIERSZ_ID_NAGLOWKA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_NAGLOWKA)");
                    WIERSZ_NEW_WORKER_ID = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NEW_WORKER_ID)");
                    WIERSZ_MASS_PAYMENT_NR = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(MASS_PAYMENT_NR)");
                    WIERSZ_NASZ_NUMER_U_KONTRAHENTA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NASZ_NUMER_U_KONTRAHENTA)");
                    WIERSZ_IMIE_PIERWSZE = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(IMIE_PIERWSZE)");
                    WIERSZ_IMIE_DRUGIE = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(IMIE_DRUGIE)");
                    WIERSZ_NAZWISKO = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NAZWISKO)");
                    WIERSZ_NAZWISKO_RODOWE = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NAZWISKO_RODOWE)");
                    WIERSZ_NAZWA_WYSWIETLANA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NAZWA_WYSWIETLANA)");
                    WIERSZ_PLEC = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(PLEC)");
                    WIERSZ_DATA_URODZENIA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(DATA_URODZENIA)");
                    WIERSZ_JEZYK = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(JEZYK)");
                    WIERSZ_NARODOWOSC = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NARODOWOSC)");
                    WIERSZ_OBYWATELSTWO = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(OBYWATELSTWO)");
                    WIERSZ_HOBBY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(HOBBY)");
                    WIERSZ_WSPOLMALZONEK = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(WSPOLMALZONEK)");
                    WIERSZ_URODZINY_WSPOLMALZONKA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(URODZINY_WSPOLMALZONKA)");
                    WIERSZ_ROCZNICA_SLUBU = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ROCZNICA_SLUBU)");
                    WIERSZ_ZLECENIOWY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ZLECENIOWY)");
                    WIERSZ_ETATOWY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ETATOWY)");
                    WIERSZ_ARCHIWALNY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ARCHIWALNY)");
                    WIERSZ_DATA_ROZP_ROZLICZEN = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(DATA_ROZP_ROZLICZEN)");
                    WIERSZ_TYP_DOK_TOZSAMOSCI = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(TYP_DOK_TOZSAMOSCI)");
                    WIERSZ_IMIE_OJCA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(IMIE_OJCA)");
                    WIERSZ_IMIE_MATKI = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(IMIE_MATKI)");
                    WIERSZ_MIEJSCE_URODZENIA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(MIEJSCE_URODZENIA)");
                    WIERSZ_TYTUL_NAUKOWY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(TYTUL_NAUKOWY)");
                    WIERSZ_US_GUID = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(US_GUID)");
                    WIERSZ_US_NAZWA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(US_NAZWA)");
                    WIERSZ_US_ULICA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(US_ULICA)");
                    WIERSZ_US_DOM = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(US_DOM)");
                    WIERSZ_US_KOD_POCZTOWY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(US_KOD_POCZTOWY)");
                    WIERSZ_US_MIEJSCOWOSC = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(US_MIEJSCOWOSC)");
                    WIERSZ_NR_AKTU_MALZENSTWA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NR_AKTU_MALZENSTWA)");
                    WIERSZ_WSPOLNE_GOSPODARSTWO = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(WSPOLNE_GOSPODARSTWO)");
                    WIERSZ_WYNAGRODZENIE_PRZELEWEM = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(WYNAGRODZENIE_PRZELEWEM)");
                    WIERSZ_KOD_ODDZIALU_NFZ = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KOD_ODDZIALU_NFZ)");
                    WIERSZ_DOK_TOZS_WYDANY_PRZEZ = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(DOK_TOZS_WYDANY_PRZEZ)");
                    WIERSZ_DOK_TOZS_WAZNY_OD = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(DOK_TOZS_WAZNY_OD)");
                    WIERSZ_DOK_TOZS_WAZNY_DO = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(DOK_TOZS_WAZNY_DO)");
                    WIERSZ_IDENTYFIKATOR_PODATKOWY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(IDENTYFIKATOR_PODATKOWY)");
                    WIERSZ_IDENTYFIKATOR_PLATNIKA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(IDENTYFIKATOR_PLATNIKA)");
                    WIERSZ_ID_ADRESU_DO_DEKLARACJI = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ID_ADRESU_DO_DEKLARACJI)");
                    WIERSZ_KRAJ_DO_DEKLARACJI = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KRAJ_DO_DEKLARACJI)");
                    WIERSZ_IDENT_DO_DEKLARACJI = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(IDENT_DO_DEKLARACJI)");
                    WIERSZ_RODZAJ_IDENT_DO_DEKLARACJI = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(RODZAJ_IDENT_DO_DEKLARACJI)");
                    WIERSZ_NIEREZYDENT = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NIEREZYDENT)");
                    WIERSZ_GLOWNE_MIEJSCE_PRACY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(GLOWNE_MIEJSCE_PRACY)");
                    WIERSZ_ALLOW_EMAIL = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ALLOW_EMAIL)");
                    WIERSZ_ALLOW_PHONE = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ALLOW_PHONE)");
                    WIERSZ_ALLOW_FAX = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ALLOW_FAX)");
                    WIERSZ_ALLOW_POST = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ALLOW_POST)");
                    WIERSZ_PREFFERED_CONTACT = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(PREFFERED_CONTACT)");
                    WIERSZ_ZAWIADOMIC_OSOBE = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ZAWIADOMIC_OSOBE)");
                    WIERSZ_PRACOWNIK_NAUKOWY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(PRACOWNIK_NAUKOWY)");
                    WIERSZ_NR_EWIDENCYJNY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(NR_EWIDENCYJNY)");
                    WIERSZ_PRZELOZONY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(PRZELOZONY)");
                    WIERSZ_KONTAKT_DO_PRZELOZONEGO = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KONTAKT_DO_PRZELOZONEGO)");
                    WIERSZ_ASYSTENT = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(ASYSTENT)");
                    WIERSZ_KONTAKT_DO_ASYSTENTA = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KONTAKT_DO_ASYSTENTA)");
                    WIERSZ_TYTUL_ZAWODOWY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(TYTUL_ZAWODOWY)");
                    WIERSZ_KONTRAHENT_POWIAZANY = xml.ChilkatPath("WIERSZ[i]|DANE_DODATKOWE|WIERSZ[j]|(KONTRAHENT_POWIAZANY)");
                    j = j + 1;
                }

                i = i + 1;
            }





        }


        public void ReadArtykuly(string xmlString)
        {

            Chilkat.Xml xml = new Chilkat.Xml();

            //  Insert code here to load the above XML into the xml object.

            string WIERSZ_ID;
            string WIERSZ_ID_GRUPY;
            string WIERSZ_RODZAJ;
            string WIERSZ_LICENCJA;
            string WIERSZ_INDEKS;
            string WIERSZ_NAZWA;
            string WIERSZ_INDEKS2;
            string WIERSZ_PKWIU;
            string WIERSZ_ID_STAWKI_VAT;
            string WIERSZ_STAWKA_VAT;
            string WIERSZ_TYP_STAWKI_VAT;
            string WIERSZ_ID_JEDNOSTKI_MIARY;
            string WIERSZ_SKROT_JEDNOSTKI_MIARY;
            string WIERSZ_NAZWA_JEDNOSTKI_MIARY;
            string WIERSZ_PODZIELNOSC;
            string WIERSZ_ANALITYKA_FK;
            string WIERSZ_ID_OPAKOWANIA;
            string WIERSZ_SZTUK_W_OPAKOWANIU;
            string WIERSZ_NEW_ID;
            string WIERSZ_GTIN;
            string WIERSZ_MECHANIZM_PODZIELONEJ_PLATNOSCI;
            string WIERSZ_OZNACZENIE_GTU_VAT;
            string WIERSZ_ID_DOMYSLNEGO_RABATU;
            string WIERSZ_NAZWA_DOMYSLNEGO_RABATU;
            string WIERSZ_OSTRZEGAJ_O_SPRZ_PONIZEJ_CENY_ZAKUPU;
            string WIERSZ_WAGA_NETTO;
            string WIERSZ_WAGA_BRUTTO;
            string WIERSZ_UWAGI;
            string WIERSZ_PROWIZJA_AKWIZYTORA;
            string WIERSZ_DNI_PRZYDATNOSCI;
            string WIERSZ_STAN_MINIMALNY;
            string WIERSZ_STAN_MAKSYMALNY;
            string WIERSZ_ID_DOSTAWCY;
            string WIERSZ_NIP_DOSTAWCY;
            string WIERSZ_NAZWA_SKROCONA_DOSTAWCY;
            string WIERSZ_ID_PRODUCENTA;
            string WIERSZ_NIP_PRODUCENTA;
            string WIERSZ_NAZWA_SKROCONA_PRODUCENTA;
            string WIERSZ_KOD_CN;
            string WIERSZ_KOD_CN_NAZWA;
            string WIERSZ_JM_CN;
            string WIERSZ_SKROT_JEDNOSTKI_MIARY_CN;
            string WIERSZ_NAZWA_JEDNOSTKI_MIARY_CN;
            string WIERSZ_PRZELICZNIK_CN;
            string WIERSZ_BEZ_MASY;
            string WIERSZ_INTRASTAT;
            string WIERSZ_PCN;
            string WIERSZ_KOD_KRESKOWY;
            string WIERSZ_MASKA_KODU_KRESKOWEGO;
            string WIERSZ_MIN_ILOSC_PSP;
            string WIERSZ_MIN_ILOSC_ZD;
            string WIERSZ_MIN_ILOSC_ZO;
            string WIERSZ_MIN_ILOSC_PR;
            string WIERSZ_FUNDUSZ_PROMOCJI;

            int i = 0;
            int count_i = xml.NumChildrenHavingTag("WIERSZ");
            while (i < count_i)
            {
                xml.I = i;
                WIERSZ_ID = xml.ChilkatPath("WIERSZ[i]|(ID)");
                WIERSZ_ID_GRUPY = xml.ChilkatPath("WIERSZ[i]|(ID_GRUPY)");
                WIERSZ_RODZAJ = xml.ChilkatPath("WIERSZ[i]|(RODZAJ)");
                WIERSZ_LICENCJA = xml.ChilkatPath("WIERSZ[i]|(LICENCJA)");
                WIERSZ_INDEKS = xml.ChilkatPath("WIERSZ[i]|(INDEKS)");
                WIERSZ_NAZWA = xml.ChilkatPath("WIERSZ[i]|(NAZWA)");
                WIERSZ_INDEKS2 = xml.ChilkatPath("WIERSZ[i]|(INDEKS2)");
                WIERSZ_PKWIU = xml.ChilkatPath("WIERSZ[i]|(PKWIU)");
                WIERSZ_ID_STAWKI_VAT = xml.ChilkatPath("WIERSZ[i]|(ID_STAWKI_VAT)");
                WIERSZ_STAWKA_VAT = xml.ChilkatPath("WIERSZ[i]|(STAWKA_VAT)");
                WIERSZ_TYP_STAWKI_VAT = xml.ChilkatPath("WIERSZ[i]|(TYP_STAWKI_VAT)");
                WIERSZ_ID_JEDNOSTKI_MIARY = xml.ChilkatPath("WIERSZ[i]|(ID_JEDNOSTKI_MIARY)");
                WIERSZ_SKROT_JEDNOSTKI_MIARY = xml.ChilkatPath("WIERSZ[i]|(SKROT_JEDNOSTKI_MIARY)");
                WIERSZ_NAZWA_JEDNOSTKI_MIARY = xml.ChilkatPath("WIERSZ[i]|(NAZWA_JEDNOSTKI_MIARY)");
                WIERSZ_PODZIELNOSC = xml.ChilkatPath("WIERSZ[i]|(PODZIELNOSC)");
                WIERSZ_ANALITYKA_FK = xml.ChilkatPath("WIERSZ[i]|(ANALITYKA_FK)");
                WIERSZ_ID_OPAKOWANIA = xml.ChilkatPath("WIERSZ[i]|(ID_OPAKOWANIA)");
                WIERSZ_SZTUK_W_OPAKOWANIU = xml.ChilkatPath("WIERSZ[i]|(SZTUK_W_OPAKOWANIU)");
                WIERSZ_NEW_ID = xml.ChilkatPath("WIERSZ[i]|(NEW_ID)");
                WIERSZ_GTIN = xml.ChilkatPath("WIERSZ[i]|(GTIN)");
                WIERSZ_MECHANIZM_PODZIELONEJ_PLATNOSCI = xml.ChilkatPath("WIERSZ[i]|(MECHANIZM_PODZIELONEJ_PLATNOSCI)");
                WIERSZ_OZNACZENIE_GTU_VAT = xml.ChilkatPath("WIERSZ[i]|(OZNACZENIE_GTU_VAT)");
                WIERSZ_ID_DOMYSLNEGO_RABATU = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(ID_DOMYSLNEGO_RABATU)");
                WIERSZ_NAZWA_DOMYSLNEGO_RABATU = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(NAZWA_DOMYSLNEGO_RABATU)");
                WIERSZ_OSTRZEGAJ_O_SPRZ_PONIZEJ_CENY_ZAKUPU = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(OSTRZEGAJ_O_SPRZ_PONIZEJ_CENY_ZAKUPU)");
                WIERSZ_WAGA_NETTO = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(WAGA_NETTO)");
                WIERSZ_WAGA_BRUTTO = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(WAGA_BRUTTO)");
                WIERSZ_UWAGI = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(UWAGI)");
                WIERSZ_PROWIZJA_AKWIZYTORA = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(PROWIZJA_AKWIZYTORA)");
                WIERSZ_DNI_PRZYDATNOSCI = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(DNI_PRZYDATNOSCI)");
                WIERSZ_STAN_MINIMALNY = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(STAN_MINIMALNY)");
                WIERSZ_STAN_MAKSYMALNY = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(STAN_MAKSYMALNY)");
                WIERSZ_ID_DOSTAWCY = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(ID_DOSTAWCY)");
                WIERSZ_NIP_DOSTAWCY = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(NIP_DOSTAWCY)");
                WIERSZ_NAZWA_SKROCONA_DOSTAWCY = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(NAZWA_SKROCONA_DOSTAWCY)");
                WIERSZ_ID_PRODUCENTA = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(ID_PRODUCENTA)");
                WIERSZ_NIP_PRODUCENTA = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(NIP_PRODUCENTA)");
                WIERSZ_NAZWA_SKROCONA_PRODUCENTA = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(NAZWA_SKROCONA_PRODUCENTA)");
                WIERSZ_KOD_CN = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(KOD_CN)");
                WIERSZ_KOD_CN_NAZWA = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(KOD_CN_NAZWA)");
                WIERSZ_JM_CN = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(JM_CN)");
                WIERSZ_SKROT_JEDNOSTKI_MIARY_CN = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(SKROT_JEDNOSTKI_MIARY_CN)");
                WIERSZ_NAZWA_JEDNOSTKI_MIARY_CN = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(NAZWA_JEDNOSTKI_MIARY_CN)");
                WIERSZ_PRZELICZNIK_CN = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(PRZELICZNIK_CN)");
                WIERSZ_BEZ_MASY = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(BEZ_MASY)");
                WIERSZ_INTRASTAT = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(INTRASTAT)");
                WIERSZ_PCN = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(PCN)");
                WIERSZ_KOD_KRESKOWY = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(KOD_KRESKOWY)");
                WIERSZ_MASKA_KODU_KRESKOWEGO = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(MASKA_KODU_KRESKOWEGO)");
                WIERSZ_MIN_ILOSC_PSP = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(MIN_ILOSC_PSP)");
                WIERSZ_MIN_ILOSC_ZD = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(MIN_ILOSC_ZD)");
                WIERSZ_MIN_ILOSC_ZO = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(MIN_ILOSC_ZO)");
                WIERSZ_MIN_ILOSC_PR = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(MIN_ILOSC_PR)");
                WIERSZ_FUNDUSZ_PROMOCJI = xml.ChilkatPath("WIERSZ[i]|DODATKOWE|WIERSZ|(FUNDUSZ_PROMOCJI)");
                i = i + 1;

                RaksArtykul artykul = FindArtykul(WIERSZ_ID);
                artykul.Rodzaj = WIERSZ_RODZAJ;
                artykul.IdGrupy = int.Parse(WIERSZ_ID_GRUPY);
                artykul.Indeks = WIERSZ_INDEKS;
                artykul.Indeks2 = WIERSZ_INDEKS2;
                artykul.Nazwa = WIERSZ_NAZWA;
                artykul.Pkwiu = WIERSZ_PKWIU;
                artykul.IdStawki = int.Parse(WIERSZ_ID_STAWKI_VAT);
                artykul.StawkaVat = decimal.Parse(WIERSZ_STAWKA_VAT);
                artykul.TypStawki = int.Parse(WIERSZ_TYP_STAWKI_VAT);
                artykul.IdJednostkiMiary = int.Parse(WIERSZ_ID_JEDNOSTKI_MIARY);
                artykul.Gtin = WIERSZ_GTIN;
                artykul.SkrotJednostkiMiary = WIERSZ_SKROT_JEDNOSTKI_MIARY;
                artykul.NazwaJednostkiMiary = WIERSZ_NAZWA_JEDNOSTKI_MIARY;
                artykul.KodKreskowy = WIERSZ_KOD_KRESKOWY;


                artykul.IdDostawcy = int.Parse(WIERSZ_ID_DOSTAWCY);
                artykul.NipDostawcy = WIERSZ_NIP_DOSTAWCY;
                artykul.NazwaDostawcy = WIERSZ_NAZWA_SKROCONA_DOSTAWCY;

   
                artykul.Dostawca = FindKontakt(WIERSZ_ID_DOSTAWCY, WIERSZ_NIP_DOSTAWCY, WIERSZ_NAZWA_SKROCONA_DOSTAWCY);


                artykul.IdProducenta = WIERSZ_ID_PRODUCENTA == "" ? 0 : int.Parse(WIERSZ_ID_PRODUCENTA);
                artykul.NipProducenta = WIERSZ_NIP_PRODUCENTA;
                artykul.NazwaProducenta = WIERSZ_NAZWA_SKROCONA_PRODUCENTA;

                artykul.Producent = FindKontakt(WIERSZ_ID_PRODUCENTA, WIERSZ_NIP_PRODUCENTA, WIERSZ_NAZWA_SKROCONA_PRODUCENTA);

                artykul.IdJednostkiMiary = WIERSZ_ID_JEDNOSTKI_MIARY == "" ? 0 : int.Parse(WIERSZ_ID_JEDNOSTKI_MIARY);
                artykul.NazwaJednostkiMiary = WIERSZ_NAZWA_JEDNOSTKI_MIARY;
                artykul.SkrotJednostkiMiary = WIERSZ_SKROT_JEDNOSTKI_MIARY;


                if (artykul.Jednostka == null)
                {
                    RaksJednostkaMiary jm = FindJednMiary(artykul.IdJednostkiMiary,artykul.SkrotJednostkiMiary,artykul.NazwaJednostkiMiary);
                    artykul.Jednostka = jm;
                }


                if (artykul.Vat == null)
                {
                    StawkaVat rec = FindStawkaVat(artykul.IdStawki,artykul.StawkaVat, artykul.TypStawki);
                    artykul.Vat = rec;
                }

            }


        }



        public void ReadFaktury(string xmlString)
        {
            Chilkat.Xml xml = new Chilkat.Xml();

            xml.LoadXml(xmlString);

            string WIERSZ_ID_WZ;
            string WIERSZ_ID_ARTYKULU;
            string WIERSZ_INDEKS_ARTYKULU;
            string WIERSZ_TYP_ARTYKULU;
            string WIERSZ_INDEKS_WG_PLATNIKA;
            string WIERSZ_NAZWA_WG_PLATNIKA;
            string WIERSZ_ID_JEDNOSTKI_MIARY;
            string WIERSZ_SKROT_JEDNOSTKI_MIARY;
            string WIERSZ_NAZWA_JEDNOSTKI_MIARY;
            string WIERSZ_WSPOLCZYNNIK_JEDNOSTEK;
            string WIERSZ_ILOSC;
            string WIERSZ_ID_RODZAJU_CENY_SPRZEDAZY;
            string WIERSZ_NAZWA_RODZAJU_CENY_SPRZEDAZY;
            string WIERSZ_CENA_NETTO_PRZED_RABATEM;
            string WIERSZ_CENA_BRUTTO_PRZED_RABATEM;
            string WIERSZ_RABAT;
            string WIERSZ_CENA_NETTO_PO_RABACIE;
            string WIERSZ_ID_STAWKI_SPRZEDAZY;
            string WIERSZ_STAWKA_SPRZEDAZY;
            string WIERSZ_TYP_STAWKI_SPRZEDAZY;
            string WIERSZ_CENA_BRUTTO_PO_RABACIE;
            string WIERSZ_CENA_ZLOTOWKOWA_NETTO;
            string WIERSZ_CENA_ZLOTOWKOWA_BRUTTO;
            string WIERSZ_WARTOSC_NETTO;
            string WIERSZ_KWOTA_VAT;
            string WIERSZ_WARTOSC_BRUTTO;
            string WIERSZ_WARTOSC_NETTO_PLN;
            string WIERSZ_KWOTA_VAT_PLN;
            string WIERSZ_WARTOSC_BRUTTO_PLN;
            string WIERSZ_NUMER_SERYJNY;
            string WIERSZ_NUMER_SERYJNY_SPRZEDAZY;
            string WIERSZ_ID_OPAKOWANIA;
            string WIERSZ_SKROT_OPAKOWANIA;
            string WIERSZ_ILOSC_OPAKOWAN;
            string WIERSZ_WAGA_NETTO;
            string WIERSZ_WAGA_BRUTTO;
            string WIERSZ_WAGA_OPAKOWAN;
            string WIERSZ_PROWIZJA_AKWIZYTORA;
            string WIERSZ_CECHY;
            string WIERSZ_DATA_WYDANIA;
            string WIERSZ_KURS;
            string WIERSZ_ID_STAWKI_VAT;
            string WIERSZ_STAWKA_VAT;
            string WIERSZ_TYP_STAWKI_VAT;
            string WIERSZ_ID_KONTAKTU;
            string WIERSZ_ID_METODY_PLATNOSCI;
            string WIERSZ_ID_ROZRACHUNKU;
            string WIERSZ_WARTOSC_PLN;
            string WIERSZ_WARTOSC_WAL;
            string WIERSZ_KOD_WALUTY;

            string WIERSZ_ID = xml.ChilkatPath("WIERSZ|(ID)");
            string WIERSZ_ID_MAGAZYNU = xml.ChilkatPath("WIERSZ|(ID_MAGAZYNU)");
            string WIERSZ_NUMER_MAGAZYNU = xml.ChilkatPath("WIERSZ|(NUMER_MAGAZYNU)");
            string WIERSZ_NAZWA_MAGAZYNU = xml.ChilkatPath("WIERSZ|(NAZWA_MAGAZYNU)");
            string WIERSZ_ANALITYKA_FK_MAGAZYNU = xml.ChilkatPath("WIERSZ|(ANALITYKA_FK_MAGAZYNU)");

            string WIERSZ_ID_SPRZEDAWCY = xml.ChilkatPath("WIERSZ|(ID_SPRZEDAWCY)");
            string WIERSZ_NAZWA_SKROCONA_SPRZEDAWCY = xml.ChilkatPath("WIERSZ|(NAZWA_SKROCONA_SPRZEDAWCY)");
            string WIERSZ_NAZWA_PELNA_SPRZEDAWCY = xml.ChilkatPath("WIERSZ|(NAZWA_PELNA_SPRZEDAWCY)");
            string WIERSZ_NIP_SPRZEDAWCY = xml.ChilkatPath("WIERSZ|(NIP_SPRZEDAWCY)");
            string WIERSZ_KOD_KRESKOWY_SPRZEDAWCY = xml.ChilkatPath("WIERSZ|(KOD_KRESKOWY_SPRZEDAWCY)");

            string WIERSZ_RODZAJ_DOK_SPRZEDAZY = xml.ChilkatPath("WIERSZ|(RODZAJ_DOK_SPRZEDAZY)");
            string WIERSZ_KOD_DOKUMENTU = xml.ChilkatPath("WIERSZ|(KOD_DOKUMENTU)");
            string WIERSZ_DATA_WYSTAWIENIA = xml.ChilkatPath("WIERSZ|(DATA_WYSTAWIENIA)");
            string WIERSZ_NUMER_DOKUMENTU = xml.ChilkatPath("WIERSZ|(NUMER_DOKUMENTU)");
            string WIERSZ_NAZWA_DOKUMENTU = xml.ChilkatPath("WIERSZ|(NAZWA_DOKUMENTU)");
            string WIERSZ_TRANSAKCJA_TROJSTRONNA = xml.ChilkatPath("WIERSZ|(TRANSAKCJA_TROJSTRONNA)");
            string WIERSZ_SYGNATURA = xml.ChilkatPath("WIERSZ|(SYGNATURA)");
            string WIERSZ_ZNACZNIKI = xml.ChilkatPath("WIERSZ|(ZNACZNIKI)");
            string WIERSZ_ANALITYKA_FK = xml.ChilkatPath("WIERSZ|(ANALITYKA_FK)");
            string WIERSZ_BLOKADA = xml.ChilkatPath("WIERSZ|(BLOKADA)");
            string WIERSZ_ZAFISKALIZOWANY = xml.ChilkatPath("WIERSZ|(ZAFISKALIZOWANY)");

            string WIERSZ_ID_NABYWCY = xml.ChilkatPath("WIERSZ|(ID_NABYWCY)");
            string WIERSZ_NAZWA_SKROCONA_NABYWCY = xml.ChilkatPath("WIERSZ|(NAZWA_SKROCONA_NABYWCY)");
            string WIERSZ_NAZWA_PELNA_NABYWCY = xml.ChilkatPath("WIERSZ|(NAZWA_PELNA_NABYWCY)");
            string WIERSZ_KOD_KRESKOWY_NABYWCY = xml.ChilkatPath("WIERSZ|(KOD_KRESKOWY_NABYWCY)");
            string WIERSZ_NIP_NABYWCY = xml.ChilkatPath("WIERSZ|(NIP_NABYWCY)");
            string WIERSZ_ULICA_NABYWCY = xml.ChilkatPath("WIERSZ|(ULICA_NABYWCY)");
            string WIERSZ_NR_DOMU_NABYWCY = xml.ChilkatPath("WIERSZ|(NR_DOMU_NABYWCY)");
            string WIERSZ_NR_LOKALU_NABYWCY = xml.ChilkatPath("WIERSZ|(NR_LOKALU_NABYWCY)");
            string WIERSZ_KOD_POCZTOWY_NABYWCY = xml.ChilkatPath("WIERSZ|(KOD_POCZTOWY_NABYWCY)");
            string WIERSZ_MIEJSCOWOSC_NABYWCY = xml.ChilkatPath("WIERSZ|(MIEJSCOWOSC_NABYWCY)");
            string WIERSZ_PANSTWO_NABYWCY = xml.ChilkatPath("WIERSZ|(PANSTWO_NABYWCY)");

            string WIERSZ_CZY_NABYWCA_PLATNIKIEM_VAT = xml.ChilkatPath("WIERSZ|(CZY_NABYWCA_PLATNIKIEM_VAT)");

            string WIERSZ_ID_ODBIORCY = xml.ChilkatPath("WIERSZ|(ID_ODBIORCY)");
            string WIERSZ_NAZWA_SKROCONA_ODBIORCY = xml.ChilkatPath("WIERSZ|(NAZWA_SKROCONA_ODBIORCY)");
            string WIERSZ_NAZWA_PELNA_ODBIORCY = xml.ChilkatPath("WIERSZ|(NAZWA_PELNA_ODBIORCY)");
            string WIERSZ_KOD_KRESKOWY_ODBIORCY = xml.ChilkatPath("WIERSZ|(KOD_KRESKOWY_ODBIORCY)");
            string WIERSZ_NIP_ODBIORCY = xml.ChilkatPath("WIERSZ|(NIP_ODBIORCY)");
            string WIERSZ_ULICA_ODBIORCY = xml.ChilkatPath("WIERSZ|(ULICA_ODBIORCY)");
            string WIERSZ_NR_DOMU_ODBIORCY = xml.ChilkatPath("WIERSZ|(NR_DOMU_ODBIORCY)");
            string WIERSZ_NR_LOKALU_ODBIORCY = xml.ChilkatPath("WIERSZ|(NR_LOKALU_ODBIORCY)");
            string WIERSZ_KOD_POCZTOWY_ODBIORCY = xml.ChilkatPath("WIERSZ|(KOD_POCZTOWY_ODBIORCY)");
            string WIERSZ_MIEJSCOWOSC_ODBIORCY = xml.ChilkatPath("WIERSZ|(MIEJSCOWOSC_ODBIORCY)");
            string WIERSZ_PANSTWO_ODBIORCY = xml.ChilkatPath("WIERSZ|(PANSTWO_ODBIORCY)");

            string WIERSZ_CZY_ODBIORCA_PLATNIKIEM_VAT = xml.ChilkatPath("WIERSZ|(CZY_ODBIORCA_PLATNIKIEM_VAT)");
            string WIERSZ_ID_AKWIZYTORA = xml.ChilkatPath("WIERSZ|(ID_AKWIZYTORA)");
            string WIERSZ_NAZWA_SKROCONA_AKWIZYTORA = xml.ChilkatPath("WIERSZ|(NAZWA_SKROCONA_AKWIZYTORA)");
            string WIERSZ_NAZWA_PELNA_AKWIZYTORA = xml.ChilkatPath("WIERSZ|(NAZWA_PELNA_AKWIZYTORA)");
            string WIERSZ_KOD_KRESKOWY_AKWIZYTORA = xml.ChilkatPath("WIERSZ|(KOD_KRESKOWY_AKWIZYTORA)");
            string WIERSZ_NIP_AKWIZYTORA = xml.ChilkatPath("WIERSZ|(NIP_AKWIZYTORA)");
            string WIERSZ_ID_RODZAJU_RABATU = xml.ChilkatPath("WIERSZ|(ID_RODZAJU_RABATU)");
            string WIERSZ_NAZWA_RODZAJU_RABATU = xml.ChilkatPath("WIERSZ|(NAZWA_RODZAJU_RABATU)");
            string WIERSZ_ID_RODZAJU_CEN = xml.ChilkatPath("WIERSZ|(ID_RODZAJU_CEN)");
            string WIERSZ_NAZWA_RODZAJU_CEN = xml.ChilkatPath("WIERSZ|(NAZWA_RODZAJU_CEN)");
            string WIERSZ_OSOBA_UPOWAZNIONA_DO_ODB_TOWARU = xml.ChilkatPath("WIERSZ|(OSOBA_UPOWAZNIONA_DO_ODB_TOWARU)");
            string WIERSZ_ID_TABELI_KURSOWEJ = xml.ChilkatPath("WIERSZ|(ID_TABELI_KURSOWEJ)");
            string WIERSZ_NUMER_TABELI_KURSOWEJ = xml.ChilkatPath("WIERSZ|(NUMER_TABELI_KURSOWEJ)");
            string WIERSZ_ID_WALUTY_DOKUMENTU = xml.ChilkatPath("WIERSZ|(ID_WALUTY_DOKUMENTU)");
            string WIERSZ_KOD_WALUTY_DOKUMENTU = xml.ChilkatPath("WIERSZ|(KOD_WALUTY_DOKUMENTU)");
            string WIERSZ_NAZWA_WALUTY_DOKUMENTU = xml.ChilkatPath("WIERSZ|(NAZWA_WALUTY_DOKUMENTU)");
            string WIERSZ_MNOZNIK_WALUTY_DOKUMENTU = xml.ChilkatPath("WIERSZ|(MNOZNIK_WALUTY_DOKUMENTU)");
            string WIERSZ_KURS_WALUTY_DOKUMENTU = xml.ChilkatPath("WIERSZ|(KURS_WALUTY_DOKUMENTU)");
            string WIERSZ_SPOSOB_WYLICZANIA_DOKUMENTU = xml.ChilkatPath("WIERSZ|(SPOSOB_WYLICZANIA_DOKUMENTU)");
            string WIERSZ_DATA_SPRZEDAZY = xml.ChilkatPath("WIERSZ|(DATA_SPRZEDAZY)");
            string WIERSZ_ID_SPOSOBU_PLATNOSCI = xml.ChilkatPath("WIERSZ|(ID_SPOSOBU_PLATNOSCI)");
            string WIERSZ_SPOSOB_PLATNOSCI = xml.ChilkatPath("WIERSZ|(SPOSOB_PLATNOSCI)");
            string WIERSZ_DATA_PLATNOSCI = xml.ChilkatPath("WIERSZ|(DATA_PLATNOSCI)");
            string WIERSZ_WARTOSC_NETTO_SPRZEDAZY = xml.ChilkatPath("WIERSZ|(WARTOSC_NETTO_SPRZEDAZY)");
            string WIERSZ_KWOTA_VAT_SPRZEDAZY = xml.ChilkatPath("WIERSZ|(KWOTA_VAT_SPRZEDAZY)");
            string WIERSZ_WARTOSC_BRUTTO_SPRZEDAZY = xml.ChilkatPath("WIERSZ|(WARTOSC_BRUTTO_SPRZEDAZY)");
            string WIERSZ_WARTOSC_NETTO_ZLOTOWKOWA = xml.ChilkatPath("WIERSZ|(WARTOSC_NETTO_ZLOTOWKOWA)");
            string WIERSZ_KWOTA_VAT_ZLOTOWKOWA = xml.ChilkatPath("WIERSZ|(KWOTA_VAT_ZLOTOWKOWA)");
            string WIERSZ_WARTOSC_BRUTTO_ZLOTOWKOWA = xml.ChilkatPath("WIERSZ|(WARTOSC_BRUTTO_ZLOTOWKOWA)");
            string WIERSZ_WARTOSC_SPRZEDAZY_OPK_KAUCJONOWNYCH = xml.ChilkatPath("WIERSZ|(WARTOSC_SPRZEDAZY_OPK_KAUCJONOWNYCH)");
            string WIERSZ_WARTOSC_ZLOTOWKOWA_OPK_KAUCJONOWNYCH = xml.ChilkatPath("WIERSZ|(WARTOSC_ZLOTOWKOWA_OPK_KAUCJONOWNYCH)");
            string WIERSZ_UWAGI = xml.ChilkatPath("WIERSZ|(UWAGI)");
            string WIERSZ_WYSTAWIL = xml.ChilkatPath("WIERSZ|(WYSTAWIL)");
            string WIERSZ_DATA_DOPISANIA = xml.ChilkatPath("WIERSZ|(DATA_DOPISANIA)");
            string WIERSZ_ZMIENIL = xml.ChilkatPath("WIERSZ|(ZMIENIL)");
            string WIERSZ_DATA_ZMIANY = xml.ChilkatPath("WIERSZ|(DATA_ZMIANY)");
            string WIERSZ_ID_KRAJU_PRZEZNACZENIA = xml.ChilkatPath("WIERSZ|(ID_KRAJU_PRZEZNACZENIA)");
            string WIERSZ_KOD_KRAJU_PRZEZNACZENIA = xml.ChilkatPath("WIERSZ|(KOD_KRAJU_PRZEZNACZENIA)");
            string WIERSZ_ID_WARUNKU_DOSTAWY = xml.ChilkatPath("WIERSZ|(ID_WARUNKU_DOSTAWY)");
            string WIERSZ_KOD_WARUNKU_DOSTAWY = xml.ChilkatPath("WIERSZ|(KOD_WARUNKU_DOSTAWY)");
            string WIERSZ_ID_RODZAJU_TRANSPORTU = xml.ChilkatPath("WIERSZ|(ID_RODZAJU_TRANSPORTU)");
            string WIERSZ_KOD_RODZAJU_TRANSPORTU = xml.ChilkatPath("WIERSZ|(KOD_RODZAJU_TRANSPORTU)");
            string WIERSZ_ID_RODZAJU_TRANSAKCJI = xml.ChilkatPath("WIERSZ|(ID_RODZAJU_TRANSAKCJI)");
            string WIERSZ_KOD_RODZAJU_TRANSAKCJI = xml.ChilkatPath("WIERSZ|(KOD_RODZAJU_TRANSAKCJI)");
            string WIERSZ_ANALITYKA_FK_GRUP_MAG = xml.ChilkatPath("WIERSZ|(ANALITYKA_FK_GRUP_MAG)");
            string WIERSZ_ID_RDS = xml.ChilkatPath("WIERSZ|(ID_RDS)");
            string WIERSZ_GLN_NABYWCY = xml.ChilkatPath("WIERSZ|(GLN_NABYWCY)");
            string WIERSZ_GLN_ODBIORCY = xml.ChilkatPath("WIERSZ|(GLN_ODBIORCY)");
            string WIERSZ_PODSTAWA_ZWOLNIENIA_Z_VAT = xml.ChilkatPath("WIERSZ|(PODSTAWA_ZWOLNIENIA_Z_VAT)");
            string WIERSZ_MECHANIZM_PODZIELONEJ_PLATNOSCI = xml.ChilkatPath("WIERSZ|(MECHANIZM_PODZIELONEJ_PLATNOSCI)");
            string WIERSZ_PROCEDURY_VAT = xml.ChilkatPath("WIERSZ|(PROCEDURY_VAT)");
            string WIERSZ_NUMER_FS_DO_PA = xml.ChilkatPath("WIERSZ|(NUMER_FS_DO_PA)");
            string WIERSZ_DATA_FS_DO_PA = xml.ChilkatPath("WIERSZ|(DATA_FS_DO_PA)");
            string WIERSZ_NIP_KOD_KRAJU_PLATNIKA = xml.ChilkatPath("WIERSZ|(NIP_KOD_KRAJU_PLATNIKA)");
            int i = 0;
            int count_i = xml.NumChildrenHavingTag("WIERSZ|POZYCJE|WIERSZ");
            while (i < count_i)
            {
                xml.I = i;
                WIERSZ_ID = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ID)");
                WIERSZ_ID_WZ = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ID_WZ)");
                WIERSZ_ID_ARTYKULU = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ID_ARTYKULU)");
                WIERSZ_INDEKS_ARTYKULU = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(INDEKS_ARTYKULU)");
                WIERSZ_TYP_ARTYKULU = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(TYP_ARTYKULU)");
                WIERSZ_INDEKS_WG_PLATNIKA = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(INDEKS_WG_PLATNIKA)");
                WIERSZ_NAZWA_WG_PLATNIKA = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(NAZWA_WG_PLATNIKA)");
                WIERSZ_ID_JEDNOSTKI_MIARY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ID_JEDNOSTKI_MIARY)");
                WIERSZ_SKROT_JEDNOSTKI_MIARY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(SKROT_JEDNOSTKI_MIARY)");
                WIERSZ_NAZWA_JEDNOSTKI_MIARY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(NAZWA_JEDNOSTKI_MIARY)");
                WIERSZ_WSPOLCZYNNIK_JEDNOSTEK = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(WSPOLCZYNNIK_JEDNOSTEK)");
                WIERSZ_ILOSC = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ILOSC)");
                WIERSZ_ID_RODZAJU_CENY_SPRZEDAZY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ID_RODZAJU_CENY_SPRZEDAZY)");
                WIERSZ_NAZWA_RODZAJU_CENY_SPRZEDAZY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(NAZWA_RODZAJU_CENY_SPRZEDAZY)");
                WIERSZ_ID_RODZAJU_RABATU = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ID_RODZAJU_RABATU)");
                WIERSZ_NAZWA_RODZAJU_RABATU = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(NAZWA_RODZAJU_RABATU)");
                WIERSZ_CENA_NETTO_PRZED_RABATEM = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(CENA_NETTO_PRZED_RABATEM)");
                WIERSZ_CENA_BRUTTO_PRZED_RABATEM = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(CENA_BRUTTO_PRZED_RABATEM)");
                WIERSZ_RABAT = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(RABAT)");
                WIERSZ_CENA_NETTO_PO_RABACIE = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(CENA_NETTO_PO_RABACIE)");
                WIERSZ_ID_STAWKI_SPRZEDAZY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ID_STAWKI_SPRZEDAZY)");
                WIERSZ_STAWKA_SPRZEDAZY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(STAWKA_SPRZEDAZY)");
                WIERSZ_TYP_STAWKI_SPRZEDAZY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(TYP_STAWKI_SPRZEDAZY)");
                WIERSZ_CENA_BRUTTO_PO_RABACIE = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(CENA_BRUTTO_PO_RABACIE)");
                WIERSZ_CENA_ZLOTOWKOWA_NETTO = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(CENA_ZLOTOWKOWA_NETTO)");
                WIERSZ_CENA_ZLOTOWKOWA_BRUTTO = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(CENA_ZLOTOWKOWA_BRUTTO)");
                WIERSZ_WARTOSC_NETTO = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(WARTOSC_NETTO)");
                WIERSZ_KWOTA_VAT = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(KWOTA_VAT)");
                WIERSZ_WARTOSC_BRUTTO = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(WARTOSC_BRUTTO)");
                WIERSZ_WARTOSC_NETTO_PLN = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(WARTOSC_NETTO_PLN)");
                WIERSZ_KWOTA_VAT_PLN = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(KWOTA_VAT_PLN)");
                WIERSZ_WARTOSC_BRUTTO_PLN = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(WARTOSC_BRUTTO_PLN)");
                WIERSZ_NUMER_SERYJNY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(NUMER_SERYJNY)");
                WIERSZ_NUMER_SERYJNY_SPRZEDAZY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(NUMER_SERYJNY_SPRZEDAZY)");
                WIERSZ_ID_OPAKOWANIA = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ID_OPAKOWANIA)");
                WIERSZ_SKROT_OPAKOWANIA = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(SKROT_OPAKOWANIA)");
                WIERSZ_ILOSC_OPAKOWAN = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ILOSC_OPAKOWAN)");
                WIERSZ_WAGA_NETTO = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(WAGA_NETTO)");
                WIERSZ_WAGA_BRUTTO = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(WAGA_BRUTTO)");
                WIERSZ_WAGA_OPAKOWAN = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(WAGA_OPAKOWAN)");
                WIERSZ_PROWIZJA_AKWIZYTORA = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(PROWIZJA_AKWIZYTORA)");
                WIERSZ_UWAGI = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(UWAGI)");
                WIERSZ_ZNACZNIKI = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(ZNACZNIKI)");
                WIERSZ_CECHY = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(CECHY)");
                WIERSZ_DATA_WYDANIA = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(DATA_WYDANIA)");
                WIERSZ_KURS = xml.ChilkatPath("WIERSZ|POZYCJE|WIERSZ[i]|(KURS)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ");
            while (i < count_i)
            {
                xml.I = i;
                WIERSZ_ID_STAWKI_VAT = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(ID_STAWKI_VAT)");
                WIERSZ_STAWKA_VAT = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(STAWKA_VAT)");
                WIERSZ_TYP_STAWKI_VAT = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(TYP_STAWKI_VAT)");
                WIERSZ_WARTOSC_NETTO = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(WARTOSC_NETTO)");
                WIERSZ_KWOTA_VAT = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(KWOTA_VAT)");
                WIERSZ_WARTOSC_BRUTTO = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(WARTOSC_BRUTTO)");
                WIERSZ_WARTOSC_NETTO_PLN = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(WARTOSC_NETTO_PLN)");
                WIERSZ_KWOTA_VAT_PLN = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(KWOTA_VAT_PLN)");
                WIERSZ_WARTOSC_BRUTTO_PLN = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH|WIERSZ[i]|(WARTOSC_BRUTTO_PLN)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ");
            while (i < count_i)
            {
                xml.I = i;
                WIERSZ_ID_STAWKI_VAT = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(ID_STAWKI_VAT)");
                WIERSZ_STAWKA_VAT = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(STAWKA_VAT)");
                WIERSZ_TYP_STAWKI_VAT = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(TYP_STAWKI_VAT)");
                WIERSZ_WARTOSC_NETTO = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(WARTOSC_NETTO)");
                WIERSZ_KWOTA_VAT = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(KWOTA_VAT)");
                WIERSZ_WARTOSC_BRUTTO = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(WARTOSC_BRUTTO)");
                WIERSZ_WARTOSC_NETTO_PLN = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(WARTOSC_NETTO_PLN)");
                WIERSZ_KWOTA_VAT_PLN = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(KWOTA_VAT_PLN)");
                WIERSZ_WARTOSC_BRUTTO_PLN = xml.ChilkatPath("WIERSZ|WARTOSCI_W_STAWKACH_PO_ZALICZKACH|WIERSZ[i]|(WARTOSC_BRUTTO_PLN)");
                i = i + 1;
            }

            i = 0;
            count_i = xml.NumChildrenHavingTag("WIERSZ|PLATNOSCI|WIERSZ");
            while (i < count_i)
            {
                xml.I = i;
                WIERSZ_ID_KONTAKTU = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(ID_KONTAKTU)");
                WIERSZ_ID_SPOSOBU_PLATNOSCI = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(ID_SPOSOBU_PLATNOSCI)");
                WIERSZ_ID_METODY_PLATNOSCI = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(ID_METODY_PLATNOSCI)");
                WIERSZ_ID_ROZRACHUNKU = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(ID_ROZRACHUNKU)");
                WIERSZ_DATA_PLATNOSCI = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(DATA_PLATNOSCI)");
                WIERSZ_WARTOSC_PLN = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(WARTOSC_PLN)");
                WIERSZ_WARTOSC_WAL = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(WARTOSC_WAL)");
                WIERSZ_KOD_WALUTY = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(KOD_WALUTY)");
                WIERSZ_UWAGI = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(UWAGI)");
                WIERSZ_ZNACZNIKI = xml.ChilkatPath("WIERSZ|PLATNOSCI|WIERSZ[i]|(ZNACZNIKI)");
                i = i + 1;
            }


        }

        private StawkaVat FindStawkaVat(int id,decimal stawka, int typ)
        {
            var rec = objectSpace.FindObject<StawkaVat>(new BinaryOperator(nameof(StawkaVat.Id), id));
            if (rec == null)
            {
                rec = objectSpace.CreateObject<StawkaVat>();
                rec.Id = id;
                rec.Wartosc = stawka;
                rec.TypStawki = typ;
            }

            return rec;
        }

        private RaksJednostkaMiary FindJednMiary(int id, string skrot, string nazwa)
        {
            var jm = objectSpace.FindObject<RaksJednostkaMiary>(new BinaryOperator(nameof(RaksJednostkaMiary.Id), id));
            if (jm == null)
            {
                jm = objectSpace.CreateObject<RaksJednostkaMiary>();
                jm.Id = id;
                jm.Skrot = skrot;
                jm.Nazwa = nazwa;
            }

            return jm;
        }

        private RaksArtykul FindArtykul(string id)
        {
            var artykul = objectSpace.FindObject<RaksArtykul>(new BinaryOperator(nameof(RaksGrupaArtykulow.Id), id));
            if (artykul == null)
            {
                artykul = objectSpace.CreateObject<RaksArtykul>();
                artykul.Id = int.Parse(id);
            }

            return artykul;
        }

        private RaksAdres FindAdres(string id)
        {

            if (string.IsNullOrEmpty(id))
                return null;


            int idrec = int.Parse(id) + 100;
            RaksAdres rec = objectSpace.FindObject<RaksAdres>(new BinaryOperator(nameof(RaksAdres.Id), idrec));
  
                if (rec == null)
                {
                    rec = objectSpace.CreateObject<RaksAdres>();
                    rec.Id = idrec;
                
                }
                return rec;
    
        }

        private RaksGrupaKontaktow FindGrupaKontaktu(string id, string nazwa, bool createIfNotExist = true)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            int idrec = int.Parse(id);
            RaksGrupaKontaktow rec = objectSpace.FindObject<RaksGrupaKontaktow>(new BinaryOperator(nameof(RaksGrupaKontaktow.Id), idrec));
            if (createIfNotExist)
            {
                if (rec == null)
                {
                    rec = objectSpace.CreateObject<RaksGrupaKontaktow>();
                    rec.Id = idrec;
                    rec.Nazwa = nazwa;
                }
                return rec;
            }
            return null;
        }

        private RaksKontakt FindKontakt(string id, bool createIfNotExist = true)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            if (id == "-1")
            {
                id = "99999999";
            }
            int idrec = int.Parse(id) + 100;
            RaksKontakt rec = objectSpace.FindObject<RaksKontakt>(new BinaryOperator(nameof(RaksKontakt.Id), idrec));
            if (createIfNotExist)
            {
                if (rec == null)
                {
                     rec = objectSpace.CreateObject<RaksKontakt>();
                    rec.Id = idrec;
                }
                return rec;
            }
            return null;
        }

        private RaksKontakt FindKontakt(string id, string nip, string nazwa)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            if (id == "-1")
            {
                id = "99999999";
            }
            int idrec = int.Parse(id) + 100;
            RaksKontakt rec = objectSpace.FindObject<RaksKontakt>(new BinaryOperator(nameof(RaksKontakt.Id), idrec));

                if (rec == null)
                {
                    rec = objectSpace.CreateObject<RaksKontakt>();
                    rec.Id = idrec;
                rec.NazwaSkrocona = nazwa;
                rec.Nip = nip;
                }
                return rec;

        }
    }
}
