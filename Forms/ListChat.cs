using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisChatClient.Forms
{
    public partial class ListChat : Form, IForm
    {
        public ListChat()
        {
            InitializeComponent();
        }
        public void ReInit()
        {

        }

        public void Toggle()
        {
            if (this.Visible)
            {
                this.Visible = false;
            }
            else
            {
                ReInit();
                this.Visible = true;
            }
        }
    }
}
