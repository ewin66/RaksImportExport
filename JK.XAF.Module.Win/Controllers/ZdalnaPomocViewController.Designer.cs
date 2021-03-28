namespace Common.Module.Controllers
{
    partial class ZdalnaPomocViewController
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
            this.ZdalnaPomoc1 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ZdalnaPomoc1
            // 
            this.ZdalnaPomoc1.Caption = "Zdalna pomoc";
            this.ZdalnaPomoc1.Category = "Tools";
            this.ZdalnaPomoc1.ConfirmationMessage = null;
            this.ZdalnaPomoc1.Id = "ZdalnaPomoc";
            this.ZdalnaPomoc1.ImageName = "zdalna_pomoc";
            this.ZdalnaPomoc1.ToolTip = null;
            this.ZdalnaPomoc1.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ZdalnaPomoc1_Execute);
            // 
            // ZdalnaPomocViewController
            // 
            this.Actions.Add(this.ZdalnaPomoc1);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ZdalnaPomoc1;
    }
}
