using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToRT_UA_FotoManager
{
    static class Program
    {
        internal static Form_Main MainMenuForm;
        internal static Form_Config ConfigForm;
        internal static Form_LookAtMe LookAtMeForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainMenuForm = new Form_Main();
            ConfigForm = new Form_Config();
            LookAtMeForm = new Form_LookAtMe();

            Application.Run(MainMenuForm);
        }
    }
}
