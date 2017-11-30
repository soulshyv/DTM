using System;
using System.Windows.Forms;
using DTM.Database;
using DTM.User;

namespace DTM
{
    public partial class DtmMainWindow : Form
    {
        public DtmMainWindow(UserManager userManager)
        {
            UserManager = userManager;
            DbManager = Database.DbManager.GetInstance();
            InitializeComponent();
        }

        private IDbManager DbManager { get; set; }
        private UserManager UserManager { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}