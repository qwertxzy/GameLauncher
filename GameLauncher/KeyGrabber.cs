using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class KeyGrabber : Form
    {
        Options o;
        string keyReference;

        public KeyGrabber(Options o, string keyReference)
        {
            InitializeComponent();

            this.o = o;
            this.keyReference = keyReference;
        }

        private void KeyGrabber_KeyDown(object sender, KeyEventArgs e)
        {
            o.registerKey(e.KeyValue, this.keyReference);
            this.Close();
        }
    }
}
