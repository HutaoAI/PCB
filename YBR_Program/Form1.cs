using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YBR_Program.View;

namespace YBR_Program
{
    public partial class Form1 : Form
    {
        private readonly HomeView homeView;
        private readonly DebugView debugView;
        private readonly EventHand eventHand;
        Dictionary<string,Form> keyValue_Form = new Dictionary<string, Form>();

        public Form1(HomeView homeView,DebugView debugView,EventHand eventHand)
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
            this.homeView = homeView;
            this.debugView = debugView;
            this.eventHand = eventHand;
            Panel_AddForm();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
            eventHand?.Close_hand();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;    
        }

        private void HomeBtn_Click(object sender,EventArgs e)
        {
            Panel_ShowFrom(sender);
        }

        #region //窗体控件操作
        //往panel控件里面添加窗体
        void Panel_AddForm()
        {
            keyValue_Form.Add("HomeBtn",homeView);
            keyValue_Form.Add("DebugBtn", debugView);

            foreach (var item in keyValue_Form.Keys)
            {
                keyValue_Form[item].TopLevel= false;
                keyValue_Form[item].Dock= DockStyle.Fill;   
                this.FormPanel.Controls.Add(keyValue_Form[item]);
            }
        }

        //显示控件
        void Panel_ShowFrom(object obj)
        { 
            var btn = obj as Button;
            if (btn == null) return;

            foreach (var item in keyValue_Form.Keys)
            {
                if (keyValue_Form.ContainsKey(btn.Name))
                    keyValue_Form[item].Hide();
            }

            if(keyValue_Form.ContainsKey(btn.Name))
                keyValue_Form[btn.Name].Show();
        }
        #endregion

        private void DebutBtn_Click(object sender, EventArgs e)
        {
            Panel_ShowFrom(sender);
        }

        #region 移动窗体界面
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                //这里一定要判断鼠标左键按下状态，否则会出现一个很奇葩的BUG，不信邪可以试一下~~
                ReleaseCapture();
                SendMessage(Handle, 0x00A1, 2, 0);
            }
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            int _Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            int _Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            this.Location = new Point(_Width / 2 - this.Width / 2, _Height / 2 - this.Height / 2);//这里需要再减去窗体本身的宽度和高度的一半
        }

        #endregion

        //启动窗体的时候自动点击HomeBtn按钮
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.HomeBtn.PerformClick();
        }
    }
}
