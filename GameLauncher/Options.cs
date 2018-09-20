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
    public partial class Options : Form
    {
        Menu m;

        int SelectKey;
        int QuitKey;
        int ForwardsKey;
        int ReverseKey;

        public Options(Menu m)
        {
            InitializeComponent();
            this.m = m;

            this.SelectKey =   (int)m.jsonConfig.Bindings.SelectKey;
            this.QuitKey =     (int)m.jsonConfig.Bindings.ExitKey;
            this.ForwardsKey = (int)m.jsonConfig.Bindings.ForwardsKey;
            this.ReverseKey =  (int)m.jsonConfig.Bindings.ReverseKey;

            LabelSelect.Text =   Enum.GetName(typeof(Keys), (int)m.jsonConfig.Bindings.SelectKey);
            LabelQuit.Text =     Enum.GetName(typeof(Keys), (int)m.jsonConfig.Bindings.ExitKey);
            LabelForwards.Text = Enum.GetName(typeof(Keys), (int)m.jsonConfig.Bindings.ForwardsKey);
            LabelReverse.Text =  Enum.GetName(typeof(Keys), (int)m.jsonConfig.Bindings.ReverseKey);
            SensivityUpDown.Value = m.jsonConfig.Misc.Threshold;
            VertUpDown.Value = m.jsonConfig.Misc.VerticalCount;
            HorizUpDown.Value = m.jsonConfig.Misc.HorizontalCount;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            KeyGrabber k = new KeyGrabber(this, "quit");
            k.ShowDialog();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            KeyGrabber k = new KeyGrabber(this, "select");
            k.ShowDialog();
        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            KeyGrabber k = new KeyGrabber(this, "reverse");
            k.ShowDialog();
        }

        private void BtnForwards_Click(object sender, EventArgs e)
        {
            KeyGrabber k = new KeyGrabber(this, "forwards");
            k.ShowDialog();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            m.jsonConfig.Bindings.SelectKey = SelectKey;
            m.jsonConfig.Bindings.ExitKey = QuitKey;
            m.jsonConfig.Bindings.ForwardsKey = ForwardsKey;
            m.jsonConfig.Bindings.ReverseKey = ReverseKey;

            m.jsonConfig.Misc.Threshold = (int)SensivityUpDown.Value;
            m.jsonConfig.Misc.HorizontalCount = (int)HorizUpDown.Value;
            m.jsonConfig.Misc.VerticalCount = (int)VertUpDown.Value;

            this.Close();
        }

        public void registerKey(int keyValue, string keyReference)
        {
            switch(keyReference)
            {
                case "select":
                    LabelSelect.Text = Enum.GetName(typeof(Keys), keyValue);
                    SelectKey = keyValue;
                    break;

                case "quit":
                    LabelQuit.Text = Enum.GetName(typeof(Keys), keyValue);
                    QuitKey = keyValue;
                    break;

                case "forwards":
                    LabelForwards.Text = Enum.GetName(typeof(Keys), keyValue);
                    ForwardsKey = keyValue;
                    break;

                case "reverse":
                    LabelReverse.Text = Enum.GetName(typeof(Keys), keyValue);
                    ReverseKey = keyValue;
                    break;
            }
        }
    }
}
