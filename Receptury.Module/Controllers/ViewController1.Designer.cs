
namespace Receptury.Module.Controllers
{
    partial class ViewController1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleAction1 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.simpleAction2 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.simpleAction3 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // simpleAction1
            // 
            this.simpleAction1.Caption = "Importuj receptury";
            this.simpleAction1.ConfirmationMessage = null;
            this.simpleAction1.Id = "8fb9a6e5-ba2f-49c1-ae2c-bc2dcab325fd";
            this.simpleAction1.ToolTip = null;
            this.simpleAction1.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
            // 
            // simpleAction2
            // 
            this.simpleAction2.Caption = "Uzupelnij Slowniki";
            this.simpleAction2.ConfirmationMessage = null;
            this.simpleAction2.Id = "9b8b481f-f2e6-4be3-ac09-971dee24330e";
            this.simpleAction2.TargetObjectType = typeof(Receptury.Module.BusinessObjects.RaksArtykul);
            this.simpleAction2.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.simpleAction2.ToolTip = null;
            this.simpleAction2.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.simpleAction2.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction2_Execute);
            // 
            // simpleAction3
            // 
            this.simpleAction3.Caption = null;
            this.simpleAction3.ConfirmationMessage = null;
            this.simpleAction3.Id = "b6c63abf-4c1f-4b87-bd70-dac3eaca702f";
            this.simpleAction3.ToolTip = null;
            this.simpleAction3.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction3_Execute);
            // 
            // ViewController1
            // 
            this.Actions.Add(this.simpleAction1);
            this.Actions.Add(this.simpleAction2);
            this.Actions.Add(this.simpleAction3);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction1;
        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction2;
        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction3;
    }
}
