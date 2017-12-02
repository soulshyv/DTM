using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTM.Database;
using DTM.Properties;
using DTM.User;

namespace DTM.Forms
{
    public partial class DtmLoginWindow : Form
    {
        public DtmLoginWindow(UserManager userManager, IDbManager dbManager)
        {
            UserManager = userManager;
            DbManager = dbManager;
            InitializeComponent();
        }

        private IDbManager DbManager { get; set; }
        private UserManager UserManager { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void SignIn_Click(object sender, EventArgs e)
        {
            var userName = Login_UserName.Text;
            var password = Login_Pwd.Text;

            Login_Error.Text = "";
            Login_Error.Visible = false;

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(password))
            {
                Login_Error.Text = Resources.Login_Empty;
                Login_Error.Visible = true;
            }
            else
            {
                if (UserManager.IsConnected)
                {
                    var dtmMainWindow = new DtmMainWindow();
                    dtmMainWindow.Show();
                }
                else
                {
                    var connecting = await UserManager.Connect(userName, password);

                    switch (connecting)
                    {
                        case -1:
                            Login_Error.Text = Resources.Username_Error;
                            Login_Error.Visible = true;
                            break;
                        case 0:
                            Login_Error.Text = Resources.Password_Error;
                            Login_Error.Visible = true;
                            break;
                        default:
                            var dtmMainWindow = new DtmMainWindow();
                            dtmMainWindow.Show();
                            break;
                    }
                }
            }
        }

        private async void SignUp_Click(object sender, EventArgs e)
        {
            await Task.CompletedTask;
        }
    }
}