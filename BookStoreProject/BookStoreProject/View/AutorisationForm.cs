using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreProject.View
{
    public partial class AutorisationForm : Form
    {
        public event Action<string, string> NeedCheckInformation;
        public AutorisationForm()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var username = usernameBox.Text;
            var password = passwordBox.Text;
            NeedCheckInformation(username, password);
        }
    }
}
