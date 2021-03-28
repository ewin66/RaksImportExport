using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using System.Diagnostics;

namespace Common.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ZdalnaPomocViewController : ViewController
    {
        public ZdalnaPomocViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }

        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }

        private void ZdalnaPomoc1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo { UseShellExecute = false, FileName = "tvserwis.exe" };

            using (Process.Start(startInfo))
            {
            }
        }
    }
}
