using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;

namespace NETLINK.UI
{
    [System.ComponentModel.DefaultBindingProperty("Text")]
    public partial class RichTextBoxWithBigEditor : System.Windows.Forms.UserControl
    {
        public RichTextBoxWithBigEditor()
        {
            InitializeComponent();
            mode = new FormMode();
        }
        private FormMode mode;
        [Bindable(BindableSupport.Yes)]
        public string Text
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        public int MaxLength
        {
            get { return richTextBox1.MaxLength; }
            set { richTextBox1.MaxLength = value; }
        }
        public Font Font
        {
            get { return richTextBox1.Font; }
            set { richTextBox1.Font = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /// sử dụng tạm để truyền text
            mode.Item = this.Text;
            //// sử dụng tạm để truyền MaxLength
            mode.Id = MaxLength;
            RichTextBoxWithBigEditor_Form fr = new RichTextBoxWithBigEditor_Form(mode);
            fr.ShowDialog();
            this.Text = mode.Item.ToString() ;
        }

        private void RichTextBoxWithBigEditor_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
        private bool enable = true;
        public bool Enable
        {
            get { return enable; }
            set
            {
                if (value)
                {
                    richTextBox1.Enabled = true;
                    mode.IsEnable = true;
                    enable = true;
                }
                else
                {
                    richTextBox1.Enabled = false;
                    mode.IsEnable = false;
                    enable = false;
                }
            }
        }
        
    }
}
