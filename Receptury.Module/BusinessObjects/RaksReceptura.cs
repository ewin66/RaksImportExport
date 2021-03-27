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
    public class RaksReceptura : XPCustomObject
    {
        public RaksReceptura(Session session) : base(session)
        { }


        string cechy;
        string uwagi;
        int idArtykulu;
        decimal ilosc;
        string indeksArtykulu;
        string nazwa;
        string kodKreskowy;
        int id;
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string KodKreskowy
        {
            get => kodKreskowy;
            set => SetPropertyValue(nameof(KodKreskowy), ref kodKreskowy, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }

        public int IdArtykulu
        {
            get => idArtykulu;
            set => SetPropertyValue(nameof(IdArtykulu), ref idArtykulu, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string IndeksArtykulu
        {
            get => indeksArtykulu;
            set => SetPropertyValue(nameof(IndeksArtykulu), ref indeksArtykulu, value);
        }

        public decimal Ilosc
        {
            get => ilosc;
            set => SetPropertyValue(nameof(Ilosc), ref ilosc, value);
        }


        [Size(SizeAttribute.Unlimited)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }

        
        [Size(SizeAttribute.Unlimited)]
        public string Cechy
        {
            get => cechy;
            set => SetPropertyValue(nameof(Cechy), ref cechy, value);
        }

        [Association("RaksReceptura-RaksSkladnikiReceptur")]
        public XPCollection<RaksSkladnikReceptury> SkladnikiReceptur
        {
            get
            {
                return GetCollection<RaksSkladnikReceptury>(nameof(SkladnikiReceptur));
            }
        }
    }
}
