using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs
{
    public static class AppConfig
    {
        public static string chilkatUnlockCode = "GABOSP.CBX112020_9fFCSJMMnRBy";
        public static string DocumentsPath = @"\\fox.uta.pl\Bartek\UTACRMUA\DokumentyWspolne";
        public static string utaFtpDataRozpakowane = @"\\fox.uta.pl\Bartek\timex6\UtaFtpUA\Rozpakowane\";
        public static string utaFtpDataZaimportowane = @"\\fox.uta.pl\Bartek\timex6\UtaFtpUA\Zaimportowane\";

        public static string ConnectionStringL => "XpoProvider=MSSqlServer;data source=localhost;user id=sa;password=N!Ezapominajka1;initial catalog=UTACRM1;Persist Security Info=true";

        // public static string ConnectionString => "XpoProvider=MSSqlServer;data source=192.168.48.107;user id=jk;password=NIEzapominajka2017;initial catalog=UTACRM;Persist Security Info=true";
        public static string ConnectionString => "XpoProvider=MSSqlServer;data source=192.168.48.107;user id=jk;password=NIEzapominajka2017;initial catalog=UTACRM_Test2;Persist Security Info=true";
    }
}
