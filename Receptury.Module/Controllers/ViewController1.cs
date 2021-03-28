using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using RaksRecepturyImport;
using Receptury.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Receptury.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ViewController1 : ViewController
    {
        public ViewController1()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var reader = new ChilkatReader(ObjectSpace);
            reader.ReadXml();
            ObjectSpace.CommitChanges();
            View.Refresh();
        }

        private void simpleAction2_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var art = ObjectSpace.GetObjectsQuery<RaksArtykul>();
            foreach (RaksArtykul artykul in art)
            {

                if (artykul.Jednostka == null)
                {
                    var jm = ObjectSpace.FindObject<RaksJednostkaMiary>(new BinaryOperator(nameof(RaksJednostkaMiary.Id), artykul.IdJednostkiMiary));
                    if (jm == null)
                    {
                        jm = ObjectSpace.CreateObject<RaksJednostkaMiary>();
                        jm.Id = artykul.IdJednostkiMiary;
                        jm.Skrot = artykul.SkrotJednostkiMiary;
                        jm.Nazwa = artykul.NazwaJednostkiMiary;
                    }
                    artykul.Jednostka = jm;
                }


                if (artykul.Vat == null)
                {
                    var rec = ObjectSpace.FindObject<RaksStawkaVat>(new BinaryOperator(nameof(RaksStawkaVat.Id), artykul.IdStawki));
                    if (rec == null)
                    {
                        rec = ObjectSpace.CreateObject<RaksStawkaVat>();
                        rec.Id = artykul.IdStawki;
                        rec.WartoscProcentowa = artykul.StawkaVat;
                        rec.TypStawkiVat = artykul.TypStawki;
                    }
                    artykul.Vat = rec;
                }

                if (artykul.Dostawca == null)
                {
                    RaksKontakt rec = FindKontakt(artykul.IdDostawcy, artykul.NazwaDostawcy, artykul.NipDostawcy);
                    artykul.Dostawca = rec;
                }
                if (artykul.Producent == null && !string.IsNullOrEmpty(artykul.NazwaProducenta))
                {
                    RaksKontakt rec = FindKontakt(artykul.IdProducenta, artykul.NazwaProducenta, artykul.NipProducenta);
                    artykul.Producent = rec;
                }
            }
            ObjectSpace.CommitChanges();
        }

        private RaksKontakt FindKontakt(int id, string skrot,  string nip)
        {
        
            var rec = ObjectSpace.FindObject<RaksKontakt>(new BinaryOperator(nameof(RaksKontakt.Id), id));
            if (rec == null)
            {
                rec = ObjectSpace.CreateObject<RaksKontakt>();
                rec.Id = id;
                rec.NazwaPelna = skrot;
                rec.NazwaSkrocona = skrot;
                rec.Nip = nip;
            

            }

            return rec;
        }
        private void simpleAction3_Execute(object sender, SimpleActionExecuteEventArgs e)
        {


            var reader = new ChilkatReader(ObjectSpace);
            reader.ImportRaksKontakty();
            reader.ImportRaksArtykuly();
            reader.ImportRaksFaktury();
            ObjectSpace.CommitChanges();
            View.Refresh();


        }
    }
}
