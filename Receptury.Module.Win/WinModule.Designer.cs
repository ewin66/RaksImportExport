namespace Receptury.Module.Win {
    partial class RecepturyWindowsFormsModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // RecepturyWindowsFormsModule
            // 
            this.RequiredModuleTypes.Add(typeof(Receptury.Module.RecepturyModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule));
            this.RequiredModuleTypes.Add(typeof(JK.XAF.Module.JKXafModule));
            this.RequiredModuleTypes.Add(typeof(JK.XAF.Module.Win.JKXafWinModule));

        }

        #endregion
    }
}