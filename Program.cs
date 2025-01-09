using POS___IMS.Inventory;
using POS___IMS.PAL;
using POS___IMS.PAL.Inventory_Mgt;
using POS___IMS.PAL.Inventory_Mgt.Main_Menu;
using POS___IMS.PAL.POS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS___IMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set user details in the UserSession
            UserSession.Instance.Username = "Admin";
            UserSession.Instance.TerminalID = 1;
            UserSession.Instance.OutletName = "Galawilawatta";
            UserSession.Instance.OutletID = 1;




            Application.Run(new frmLogin());
        }
    }
}
