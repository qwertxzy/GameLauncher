using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Threading;
using GameLauncher.Models;
using Newtonsoft.Json;

namespace GameLauncher
{

    public partial class Menu : Form
    {
        List<Panel> panels = new List<Panel>();
        int selectedIndex = 0;

        int mouseXmid;
        int mouseYmid;

        public Config jsonConfig;

        public Menu()
        {
            //Read the json config file from the path specified in the arguments
            string t = System.IO.File.ReadAllText(Environment.GetCommandLineArgs()[1]);
            try
            {
                jsonConfig = JsonConvert.DeserializeObject<Config>(t);

                //initialize auto generated components
                InitializeComponent();

                //Set the Main Form's background color
                flowLayoutPanel1.BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.BackgroundColor);

                //padding stuff
                flowLayoutPanel1.Padding = new Padding(15);

                //iterate over all objects in the json file, create a container for each one
                for (int i = 0; i < jsonConfig.Games.Count; i++)
                {
                    // create the panel
                    Panel p = new Panel();

                    p.Location = new Point(3, 3);
                    p.Name = $"panel{i}";
                    p.Size = new Size((Screen.PrimaryScreen.WorkingArea.Width / jsonConfig.Misc.HorizontalCount) - 20, (Screen.PrimaryScreen.WorkingArea.Height / jsonConfig.Misc.VerticalCount) - 20);
                    p.Margin = new Padding(5);

                    // create the picture box
                    PictureBox pb = new PictureBox();

                    pb.Dock = DockStyle.Fill;
                    pb.Location = new Point(0, 0);
                    pb.Name = string.Format("pictureBox{0}", i);
                    try
                    {
                        pb.Image = Image.FromFile(jsonConfig.Games[i].IconPath);
                    }
                    catch (Exception) { }

                    pb.SizeMode = PictureBoxSizeMode.Zoom;

                    // create the label
                    Label lbl = new Label();

                    lbl.AutoSize = true;
                    lbl.Name = string.Format("label{0}", i);
                    lbl.Size = new Size(35, 250);
                    lbl.Dock = DockStyle.Bottom;
                    lbl.Font = new Font("Arial", 14, FontStyle.Bold);
                    lbl.AutoSize = true;
                    lbl.Text = jsonConfig.Games[i].Text;

                    //add the label and picture to the panel and finally add the panel to the flow layout
                    p.Controls.Add(pb);
                    p.Controls.Add(lbl);
                    flowLayoutPanel1.Controls.Add(p);

                    //add the panel to the List<Panel> as well for access
                    panels.Add(p);
                }

                //Manually add a last panel for the options
                
                // create the panel
                Panel op = new Panel();

                op.Location = new Point(3, 3);
                op.Name = "panelOptions";
                op.Size = new Size((Screen.PrimaryScreen.WorkingArea.Width / jsonConfig.Misc.HorizontalCount) - 20, (Screen.PrimaryScreen.WorkingArea.Height / jsonConfig.Misc.VerticalCount) - 20);
                op.Margin = new Padding(5);

                //create the picture box
                PictureBox opb = new PictureBox();

                opb.Dock = DockStyle.Fill;
                opb.Location = new Point(0, 0);
                opb.Name = "pictureBoxOptions";
                opb.SizeMode = PictureBoxSizeMode.Zoom;

                // create the label
                Label olbl = new Label();

                olbl.AutoSize = true;
                olbl.Name = "labelOptions";
                olbl.Size = new Size(35, 250);
                olbl.Text = "Options";
                olbl.Dock = DockStyle.Bottom;
                olbl.Font = new Font("Arial", 20, FontStyle.Bold);

                //add the label and picture to the panel and finally add the panel to the flow layout
                op.Controls.Add(opb);
                op.Controls.Add(olbl);
                flowLayoutPanel1.Controls.Add(op);

                //add the panel to the List<Panel> as well for access
                panels.Add(op);

                //initialize all panels with a white background color
                foreach (Panel p in panels)
                {
                    p.BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.BoxColor);
                }
                //and initialize the one panel that's highlighted
                panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.HighlightColor);

                //calculate the spot for the mouse to sit and lock it there
                mouseXmid = Screen.PrimaryScreen.WorkingArea.Width / 2;
                mouseYmid = Screen.PrimaryScreen.WorkingArea.Height / 2;
                Cursor.Position = new Point(mouseXmid, mouseYmid);
                Cursor.Hide();
            }
            //if something goes wrong here, it's most probably the json file
            catch (Exception e)
            {
                #if DEBUG
                    throw e;
                #endif
                //so let's tell the user that the json had some mistakes
                Label lbl = new Label();
                lbl.Text = "A problem has been detected in the configuration file and GameLauncher.exe has been interrupted to prevent any unintended behavior." +
                           "\nYou may find details about the error below:\n\n" + e.Message + "\n\n" +
                           "Please check your configuration file and make sure it is correct.";
                lbl.Dock = DockStyle.Fill;
                lbl.Font = new Font("Arial", 24, FontStyle.Regular);
                lbl.ForeColor = Color.White;
                lbl.Padding = new Padding(15);

                this.BackColor = Color.Blue;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                Thread.Sleep(500);
                this.Controls.Add(lbl);
            }
        }

        //mouse move event
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            //read the movement threshhold from the json config
            int threshhold = jsonConfig.Misc.Threshold;

            //if the cursor moved far enough from the middle
            if (Cursor.Position.Y > mouseYmid + threshhold)
            {
                //reset it to the middle
                Cursor.Position = new Point(mouseXmid, mouseYmid);
                //and change the selected index
                if (selectedIndex < panels.Count - 1)
                {
                    //set the last panel to white and the current one to blue as a form of highlighting
                    panels[selectedIndex].BackColor =   ColorTranslator.FromHtml(jsonConfig.Misc.BoxColor);
                    panels[++selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.HighlightColor);
                }
                
            }
            //if the cursor moved far enough from the middle
            if (Cursor.Position.Y < mouseYmid - threshhold)
            {
                //reset it to the middle
                Cursor.Position = new Point(mouseXmid, mouseYmid);
                //and change the selected index
                if (selectedIndex > 0)
                {
                    //set the last panel to white and current to blue
                    panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.BoxColor);
                    panels[--selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.HighlightColor);
                }
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            //fuck switch case
            if (e.KeyValue == jsonConfig.Bindings.ExitKey)
            {
                Application.Exit();
            }
            else if (e.KeyValue == jsonConfig.Bindings.SelectKey)
            {
                panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.SelectedColor);

                if (selectedIndex == panels.Count - 1)
                {
                    Cursor.Show();

                    Options o = new Options(this);
                    o.ShowDialog();

                    System.IO.File.WriteAllText(Environment.GetCommandLineArgs()[1], JsonConvert.SerializeObject(jsonConfig));

                    Cursor.Hide();
                }
                else
                {
                    try
                    {
                        //do kind of an elaborate process spawn because I need to change the working directory
                        ProcessStartInfo proc = new ProcessStartInfo(jsonConfig.Games[selectedIndex].ExecutablePath);
                        proc.Arguments = jsonConfig.Games[selectedIndex].Parameters;

                        string path = jsonConfig.Games[selectedIndex].ExecutablePath;
                        proc.WorkingDirectory = path.Substring(0, path.LastIndexOf('\\'));

                        Process.Start(proc);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There was an error starting this game. Please check the executable path.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(e.KeyValue == jsonConfig.Bindings.ForwardsKey)
            {
                if (selectedIndex < panels.Count - 1)
                {
                    //set the last panel to white and the current one to blue as a form of highlighting
                    panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.BoxColor);
                    panels[++selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.HighlightColor);
                }
            }
            else if (e.KeyValue == jsonConfig.Bindings.ReverseKey)
            {
                if (selectedIndex > 0)
                {
                    //set the last panel to white and current to blue
                    panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.BoxColor);
                    panels[--selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig.Misc.HighlightColor);
                }
            }
        }
    }
}
