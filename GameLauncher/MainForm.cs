using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Json;
using System;
using System.Diagnostics;

namespace GameLauncher
{

    public partial class Menu : Form
    {
        List<Panel> panels = new List<Panel>();
        int selectedIndex = 0;

        int mouseXmid;
        int mouseYmid;

        public JsonValue jsonConfig;

        public Menu()
        {
            //Read the json config file from the path specified in the arguments
            string t = System.IO.File.ReadAllText(Environment.GetCommandLineArgs()[1]);
            try
            {
                jsonConfig = JsonObject.Parse(t);

                //initialize auto generated components
                InitializeComponent();

                //Set the Main Form's background color
                flowLayoutPanel1.BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["backgroundcolor"]);

                //padding stuff
                flowLayoutPanel1.Padding = new Padding((Screen.PrimaryScreen.WorkingArea.Width / 6) - 20, 15, (Screen.PrimaryScreen.WorkingArea.Width / 6) - 20, 15);

                //iterate over all objects in the json file, create a container for each one
                for (int i = 0; i < jsonConfig["games"].Count; i++)
                {
                    // create the panel
                    Panel p = new Panel();

                    p.Location = new Point(3, 3);
                    p.Name = string.Format("panel{0}", i);
                    p.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 3, Screen.PrimaryScreen.WorkingArea.Height / 6);
                    p.Margin = new Padding(5, 10, 5, 10);

                    // create the picture box
                    PictureBox pb = new PictureBox();

                    pb.Dock = DockStyle.Fill;
                    pb.Location = new Point(0, 0);
                    pb.Name = string.Format("pictureBox{0}", i);
                    try
                    {
                        pb.Image = Image.FromFile(jsonConfig["games"][i]["icon"]);
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
                    lbl.Text = jsonConfig["games"][i]["text"];

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
                op.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width / 3, Screen.PrimaryScreen.WorkingArea.Height / 6);
                op.Margin = new Padding(5, 10, 5, 10);

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
                    p.BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["boxcolor"]);
                }
                //and initialize the one panel that's highlighted
                panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["highlightcolor"]);

                //calculate the spot for the mouse to sit and lock it there
                mouseXmid = Screen.PrimaryScreen.WorkingArea.Width / 2;
                mouseYmid = Screen.PrimaryScreen.WorkingArea.Height / 2;
                Cursor.Position = new Point(mouseXmid, mouseYmid);
                Cursor.Hide();
            }
            //if something goes wrong here, it's most probably the json file
            catch (Exception)
            {
                //so let's tell the user that the json had some mistakes
                Label lbl = new Label();
                lbl.Text = "Something went wrong while reading the configuration file :(";
                lbl.Dock = DockStyle.Fill;
                lbl.Font = new Font("Arial", 35, FontStyle.Bold);
                lbl.ForeColor = Color.White;
                lbl.Padding = new Padding(15);

                this.BackColor = Color.Blue;
                this.Controls.Add(lbl);
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //mouse move event
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            //read the movement threshhold from the json config
            int threshhold = jsonConfig["misc"]["threshhold"];

            //if the cursor moved far enough from the middle
            if (Cursor.Position.Y > mouseYmid + threshhold)
            {
                //reset it to the middle
                Cursor.Position = new Point(mouseXmid, mouseYmid);
                //and change the selected index
                if (selectedIndex < panels.Count - 1)
                {
                    //set the last panel to white and the current one to blue as a form of highlighting
                    panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["boxcolor"]);
                    panels[++selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["highlightcolor"]);
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
                    panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["boxcolor"]);
                    panels[--selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["highlightcolor"]);
                }
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            //fuck switch case
            if (e.KeyValue == jsonConfig["keybindings"]["exit"])
            {
                Application.Exit();
            }
            else if (e.KeyValue == jsonConfig["keybindings"]["select"])
            {
                panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["selectedcolor"]);

                if (selectedIndex == panels.Count - 1)
                {
                    Cursor.Show();

                    Options o = new Options(this);
                    o.ShowDialog();

                    System.IO.File.WriteAllText(Environment.GetCommandLineArgs()[1], jsonConfig.ToString());

                    Cursor.Hide();
                }
                else
                {
                    try
                    {
                        //do kind of an elaborate process spawn because I need to change the working directory
                        ProcessStartInfo proc = new ProcessStartInfo(jsonConfig["games"][selectedIndex]["executable"]);
                        proc.Arguments = jsonConfig["games"][selectedIndex]["parameters"];

                        string path = jsonConfig["games"][selectedIndex]["executable"];
                        proc.WorkingDirectory = path.Substring(0, path.LastIndexOf('\\'));

                        Process.Start(proc);
                    }
                    catch (Exception) { }
                }
            }
            else if(e.KeyValue == jsonConfig["keybindings"]["forwards"])
            {
                if (selectedIndex < panels.Count - 1)
                {
                    //set the last panel to white and the current one to blue as a form of highlighting
                    panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["boxcolor"]);
                    panels[++selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["highlightcolor"]);
                }
            }
            else if (e.KeyValue == jsonConfig["keybindings"]["reverse"])
            {
                if (selectedIndex > 0)
                {
                    //set the last panel to white and current to blue
                    panels[selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["boxcolor"]);
                    panels[--selectedIndex].BackColor = ColorTranslator.FromHtml(jsonConfig["misc"]["highlightcolor"]);
                }
            }
        }
    }
}
