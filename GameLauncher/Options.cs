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

            this.SelectKey = (int)m.jsonConfig["keybindings"]["select"];
            this.QuitKey = (int)m.jsonConfig["keybindings"]["exit"];
            this.ForwardsKey = (int)m.jsonConfig["keybindings"]["forwards"];
            this.ReverseKey = (int)m.jsonConfig["keybindings"]["reverse"];

            LabelSelect.Text = Enum.GetName(typeof(Keys), (int)m.jsonConfig["keybindings"]["select"]);
            LabelQuit.Text = Enum.GetName(typeof(Keys), (int)m.jsonConfig["keybindings"]["exit"]);
            LabelForwards.Text = Enum.GetName(typeof(Keys), (int)m.jsonConfig["keybindings"]["forwards"]);
            LabelReverse.Text = Enum.GetName(typeof(Keys), (int)m.jsonConfig["keybindings"]["reverse"]);
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
            m.jsonConfig["keybindings"]["select"] = SelectKey;
            m.jsonConfig["keybindings"]["exit"] = QuitKey;
            m.jsonConfig["keybindings"]["forwards"] = ForwardsKey;
            m.jsonConfig["keybindings"]["reverse"] = ReverseKey;

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
