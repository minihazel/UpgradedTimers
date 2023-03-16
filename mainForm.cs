using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpgradedTimers
{
    public partial class mainForm : Form
    {
        string currentDir = Environment.CurrentDirectory;
        public string accessFile;

        public Color idleColor = Color.FromArgb(255, 35, 35, 40);
        public Color hoverColor = Color.FromArgb(255, 40, 40, 45);
        public Color selectColor = Color.FromArgb(255, 45, 45, 50);

        public string[] locations =
        {
            "Customs",
            "Factory Day",
            "Factory Night",
            "Interchange",
            "Labs",
            "Lighthouse",
            "Reserve",
            "Shoreline",
            "Streets",
            "Woods"
        };

        public string[] exfilTimes =
        {
            "Default",
            "60 minutes",
            "90 minutes",
            "120 minutes",
            "240 minutes"
        };

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            accessFile = Path.Combine(currentDir, "config\\config.json");
            bool exists = File.Exists(accessFile);

            if (exists)
            {
                clearUI();
                listLocations();
            }
        }

        private void clearUI()
        {
            // server box
            for (int i = groupLocations.Controls.Count - 1; i >= 0; i--)
            {
                Label selected = groupLocations.Controls[i] as Label;
                if (selected != null)
                {
                    try
                    {
                        groupLocations.Controls.RemoveAt(i);
                        selected.Dispose();
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine($"ERROR: {err.Message.ToString()}");
                        MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{err.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void listLocations()
        {
            for (int i = 0; i < locations.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = locations[i];
                lbl.AutoSize = false;
                lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Size = new Size(locationsPlaceholder.Size.Width, locationsPlaceholder.Size.Height);
                lbl.Location = new Point(locationsPlaceholder.Location.X, locationsPlaceholder.Location.Y + (i*30));
                lbl.Font = new Font("Bahnschrift Light", 9, FontStyle.Regular);
                lbl.BackColor = idleColor;
                lbl.ForeColor = Color.LightGray;
                lbl.Margin = new Padding(1, 1, 1, 1);
                lbl.Cursor = Cursors.Hand;
                lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                groupLocations.Controls.Add(lbl);
            }
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != selectColor)
                {
                    label.BackColor = hoverColor;
                }
            }
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != selectColor)
                {
                    label.BackColor = idleColor;
                }
            }
        }

        private void lbl_MouseDown(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)sender;

            if (lbl.Text != "")
            {
                foreach (Control component in groupLocations.Controls)
                {
                    if (component.Text.Contains("> "))
                    {
                        component.Text = component.Text.Remove(0, 2);
                    }

                    if (component is Label && component.Text != lbl.Text)
                    {
                        component.BackColor = idleColor;
                        component.ForeColor = Color.LightGray;  
                    }
                }
                lbl.BackColor = selectColor;

                groupActions.Text = $" Actions for {lbl.Text} ";
                listExtracts();

                string activeItem = lbl.Text;
                activeItem = "> " + activeItem;
                lbl.Text = activeItem;
                lbl.ForeColor = Color.DodgerBlue;

            }
        }

        private void lbl_MouseUp(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
            }
        }

        public void listExtracts()
        {
            for (int i = 0; i < exfilTimes.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = exfilTimes[i];
                lbl.AutoSize = false;
                lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Size = new Size(extractPlaceholder.Size.Width, extractPlaceholder.Size.Height);
                lbl.Location = new Point(extractPlaceholder.Location.X, extractPlaceholder.Location.Y + (i * 30));
                lbl.Font = new Font("Bahnschrift Light", 9, FontStyle.Regular);
                lbl.BackColor = idleColor;
                lbl.ForeColor = Color.LightGray;
                lbl.Margin = new Padding(1, 1, 1, 1);
                lbl.Cursor = Cursors.Hand;
                lbl.MouseEnter += new EventHandler(extract_MouseEnter);
                lbl.MouseLeave += new EventHandler(extract_MouseLeave);
                lbl.MouseDown += new MouseEventHandler(extract_MouseDown);
                lbl.MouseUp += new MouseEventHandler(extract_MouseUp);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                groupExtractTimes.Controls.Add(lbl);
            }
        }

        private void extract_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != selectColor)
                {
                    label.BackColor = hoverColor;
                }
            }
        }

        private void extract_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != selectColor)
                {
                    label.BackColor = idleColor;
                }
            }
        }

        private void extract_MouseDown(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)sender;

            if (lbl.Text != "")
            {
                foreach (Control component in groupLocations.Controls)
                {
                    if (component.Text.Contains("> "))
                    {
                        component.Text = component.Text.Remove(0, 2);
                    }

                    if (component is Label && component.Text != lbl.Text)
                    {
                        component.BackColor = idleColor;
                        component.ForeColor = Color.LightGray;
                    }
                }
                lbl.BackColor = selectColor;

                groupActions.Text = $" Actions for {lbl.Text} ";


                string activeItem = lbl.Text;
                activeItem = "> " + activeItem;
                lbl.Text = activeItem;
                lbl.ForeColor = Color.DodgerBlue;

            }
        }

        private void extract_MouseUp(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
            }
        }
    }
}
