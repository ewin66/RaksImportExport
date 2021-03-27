using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    public class RaksSkladnikReceptury : XPObject
    {
        public RaksSkladnikReceptury(Session session) : base(session)
        { }


        string cechy;
        decimal ilosc;
        int idArtykulu;
        string indeksArtykulu;

        RaksArtykul artykul;
        int id;
        RaksReceptura receptura;


        //[Key(false)]
        //public int Id
        //{
        //    get => id;
        //    set => SetPropertyValue(nameof(Id), ref id, value);
        //}
        [Association("RaksReceptura-RaksSkladnikiReceptur")]
        public RaksReceptura Receptura
        {
            get => receptura;
            set => SetPropertyValue(nameof(Receptura), ref receptura, value);
        }


        public RaksArtykul Artykul
        {
            get => artykul;
            set => SetPropertyValue(nameof(Artykul), ref artykul, value);
        }


        public decimal Ilosc
        {
            get => ilosc;
            set => SetPropertyValue(nameof(Ilosc), ref ilosc, value);
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



        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Cechy
        {
            get => cechy;
            set => SetPropertyValue(nameof(Cechy), ref cechy, value);
        }




    }
}
