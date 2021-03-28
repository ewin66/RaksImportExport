using CommonLibs;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JK.XAF.Module.Module.Controllers
{
    public class CustomizeWindowController : WindowController
    {
        protected override void OnActivated()
        {
            base.OnActivated();
            WindowTemplateController controller = Frame.GetController<WindowTemplateController>();
            controller.CustomizeWindowStatusMessages += Controller_CustomizeWindowStatusMessages;
        }

        protected override void OnDeactivated()
        {
            base.OnDeactivated();
            WindowTemplateController controller = Frame.GetController<WindowTemplateController>();
            controller.CustomizeWindowStatusMessages -= Controller_CustomizeWindowStatusMessages;
        }

        private void AddCompanyName(CustomizeWindowStatusMessagesEventArgs customizeWindowStatusMessagesEventArgs)
        { customizeWindowStatusMessagesEventArgs.StatusMessages.Add("© UTA Sp. z o.o."); }

        private static void AddDatabaseName(
            CustomizeWindowStatusMessagesEventArgs customizeWindowStatusMessagesEventArgs)
        {
            string calyConnectionString = AppConfig.ConnectionString.Trim();

            string nazwaBazy = string.Empty;
            if(calyConnectionString.StartsWith("XpoProvider=MSSqlServer"))
            {
                string czescDatabase = calyConnectionString.Split(';')
                    .FirstOrDefault(x => x.StartsWith("initial catalog"));

                if(czescDatabase != null)
                {
                    int indeksZnakuRownosci = czescDatabase.IndexOf('=');
                    nazwaBazy = czescDatabase.Substring(indeksZnakuRownosci + 1);
                }
            }

            if(!string.IsNullOrEmpty(nazwaBazy))
            {
                customizeWindowStatusMessagesEventArgs.StatusMessages.Add($"Połączenie do bazy: {nazwaBazy}");
            }
        }

        private void AddVersion(CustomizeWindowStatusMessagesEventArgs customizeWindowStatusMessagesEventArgs)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            customizeWindowStatusMessagesEventArgs.StatusMessages.Add($"Wersja: {version}");
        }

        private void Controller_CustomizeWindowStatusMessages(
            object sender,
            CustomizeWindowStatusMessagesEventArgs customizeWindowStatusMessagesEventArgs)
        {
            AddDatabaseName(customizeWindowStatusMessagesEventArgs);
            AddVersion(customizeWindowStatusMessagesEventArgs);
            AddCompanyName(customizeWindowStatusMessagesEventArgs);
        }
    }
}
