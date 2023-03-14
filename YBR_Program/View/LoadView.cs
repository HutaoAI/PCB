using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YBR_Program.View
{
    public partial class LoadView : Form
    {
        private readonly LoginView loginView;
        private readonly EventHand eventHand;

        public LoadView(LoginView loginView,EventHand eventHand)
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
            this.loginView = loginView;
            this.eventHand = eventHand;
        }
        public async void Init()
        {
            eventHand.Close_hand += new Action(() =>
            {
                this.Close();
            });

            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            this.Hide();
            loginView.Show();
        }
    }
}
