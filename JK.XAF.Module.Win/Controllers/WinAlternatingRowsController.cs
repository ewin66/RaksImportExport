using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.IO;


namespace Fleetman.Module.Win.Controllers
{
    public partial class WinAlternatingRowsController : ViewController<ListView>
    {
        GridListEditor gridListEditor = null;

        public WinAlternatingRowsController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
            gridListEditor = View.Editor as GridListEditor;
            if(gridListEditor != null)
            {
            }
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }

        protected override void OnDeactivated()
        {
            if(gridListEditor != null)
            {
                gridListEditor = null;
            }
            base.OnDeactivated();
        }

        private void WinAlternatingRowsController_ViewControlsCreated(object sender, EventArgs e)
        {
            GridListEditor listEditor = View.Editor as GridListEditor;

            if(listEditor != null)
            {
                GridView gridView = listEditor.GridView;

                SetListView(gridView);
            }
        }

        private static void SetListView(GridView gridView)
        {
            gridView.OptionsView.EnableAppearanceOddRow = true;
            //  checkbox do zaznaczania rekordów
            //  gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            //  gridView.Appearance.OddRow.BackColor = Color.FromArgb(244, 244, 244);
            gridView.OptionsView.ShowFooter = false;
            //  gridView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            gridView.OptionsPrint.ExpandAllGroups = false;
            //  właczamy filtry pod nagłowkami

            //  właczamy scroll - ustaw false 
            gridView.OptionsView.ColumnAutoWidth = false;
            //  właczamy zmiane rozmiru kolumn
            gridView.OptionsView.RowAutoHeight = true;

            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsFind.AlwaysVisible = false;

            gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            gridView.OptionsView.BestFitMaxRowCount = 20;
            gridView.OptionsView.BestFitMode = GridBestFitMode.Fast;
            gridView.BestFitColumns();

            gridView.UserCellPadding = new System.Windows.Forms.Padding(0);
            gridView.CalcRowHeight += GridView_CalcRowHeight;
        }

        private static void GridView_CalcRowHeight(object sender, RowHeightEventArgs e) { e.RowHeight = 5; }
    }
}

