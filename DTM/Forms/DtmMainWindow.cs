using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTM.Database;
using DTM.RunConfig;
using DTM.User;

namespace DTM.Forms
{
    public partial class DtmMainWindow : Form
    {
        public DtmMainWindow(IDbManager dbManager, IUserManager userManager)
        {

            DbManager = dbManager;
            UserManager = userManager;

            if (!UserManager.IsConnected)
            {
                var loginWindow = InjectionModule.Container.GetInstance<DtmLoginWindow>();
                Hide();
                loginWindow.Parent = this;
                loginWindow.Show();
            }

            InitializeComponent();
        }

        public IDbManager DbManager { get; }
        public IUserManager UserManager { get; }

        private void DtmMainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
