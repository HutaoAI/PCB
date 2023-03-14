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
    public partial class LoginView : Form
    {
        public LoginView(Form1 form1,EventHand eventHand)
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
            this.form1 = form1;
            this.eventHand = eventHand;
            eventHand.Close_hand += Close_Windows;

            
        }
        
        private readonly Form1 form1;
        private readonly EventHand eventHand;

        private void LoginView_Load(object sender, EventArgs e)
        {
            this.comboBox1.Text = "攻城狮";

            this.comboBox1.Items.Add("操作员");
            this.comboBox1.Items.Add("攻城狮");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_HomeView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close_Windows();
            eventHand.Close_hand();
        }
        void Show_HomeView()
        { 
            this.Hide();
            form1.Show();
        }

        void Close_Windows()
        {
            this.Close();
        }
    }

    public class EventHand
    {
        public Action Close_hand;
    }
}
