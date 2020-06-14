using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            }//txtValue
            {
                log.SelectionMode = SelectionMode.None;
            }//log
            {
                birim.BorderColor = Color.Transparent;
                birim.AccentColor = Color.Transparent;
            }//birim
        }
    }
}
