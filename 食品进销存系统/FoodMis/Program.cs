using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodMis
{
    static class Program
    {

        public static int s=5;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                LoginForm loginForm = new LoginForm();
                Application.Run(loginForm);
         
           
            if (loginForm.DialogResult == DialogResult.OK)
            {

                switch (s)
                {
                    case 0:
                        FSupMainForm mainForm = new FSupMainForm();
                        Application.Run(mainForm);
                        mainForm.Show();
                        break;
                    case 1:
                        FAdminForm faForm = new FAdminForm();
                        Application.Run(faForm);
                        faForm.Show();
                        break;
                    case 2:
                        FKucunForm fkForm = new FKucunForm();
                        Application.Run(fkForm);
                        fkForm.Show();
                        break;
                    case 3:
                        FBuyerForm fbForm = new FBuyerForm();
                        Application.Run(fbForm);
                        fbForm.Show();
                        break;
                    case 4:
                        FSaleForm fsForm = new FSaleForm();
                        Application.Run(fsForm);
                        fsForm.Show();
                        break;
                    default: break;
                }
            
            }
            else
            {
                Application.Exit();
            }
       
        }
    }
}
