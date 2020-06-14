using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSuite; // For Design
using MetroSuite.Extension; // For Design
namespace ZCrypto
{
    public partial class Form1 : MetroForm // Set Metro Form
    {
        public Form1()
        {
            InitializeComponent();
            SetDesign();
        }
        private void SetDesign()
        {
            {
                txt_Value.BorderColor = Color.Transparent;
                txt_Value.HoverColor = Color.Transparent;
                txt_Value.DefaultColor = Color.Black;
            }//txtValue
            {
                log.SelectionMode = SelectionMode.None;
            }//log
            {
                birim.Style = Design.Style.Custom;
                birim.BorderColor = Color.Transparent;
                birim.AccentColor = Color.Transparent;
                birim.DefaultColor = Color.Black;
                
            }//birim
            this.Style = Design.Style.Custom;
            this.BackColor = Color.Black;
            panel2.DefaultColor = Color.Black;
            panel3.DefaultColor = Color.Black;
            metroPanelCategory4.DefaultColor = Color.Black;
            metroPanelCategory7.DefaultColor = Color.Black;
            metroPanelCategory5.DefaultColor = Color.Black;
            metroPanelCategory6.DefaultColor = Color.Black;
            metroPanelCategory8.DefaultColor = Color.Black;
            metroPanelCategory9.DefaultColor = Color.Black;
            metroPanelCategory10.DefaultColor = Color.Black;

            log.Style = Design.Style.Custom;
            log.BackColor = Color.Black;
            tabcontrol.BorderColor = Color.Black;
            tabcontrol.HeaderItemColor = Color.Black;
            tabcontrol.TabContainerColor = Color.Black;
            tabcontrol.HoverColor = Color.Black;
            tabcontrol.HeaderForeColor = Color.Black;
            tabcontrol.ItemColor = Color.Black;
            anasayfa.BackColor = Color.Black;
            tabPage3.BackColor = Color.Black;
            tabPage4.BackColor = Color.Black;
            tabPage5.BackColor = Color.Black;
            tabPage6.BackColor = Color.Black;

            converter.BackColor = Color.Black;
            panel.BorderColor = Color.Black;
            panel.DefaultColor = Color.Black;
        }

        private void telegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/zenlty");
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/zenlty");

        }

        private void instagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/zenlty");

        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/zenlty");

        }
    }
}
