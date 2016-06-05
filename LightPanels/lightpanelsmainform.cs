using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightPanels
{
    public partial class LightPanelsMainForm : Form
    {
        Timer tmr;
        bool discoenabled = false;
        public static Color selectedcolour;
        LightPanel panel1, panel2, panel3;
        Random r = new Random();

        public LightPanelsMainForm()
        {
            InitializeComponent();
        }

        private void btn_createlightpanel_Click(object sender, EventArgs e)
        {
            if (panel1 == null || panel1.IsDisposed)
            {
                panel1 = new LightPanel();
            }

            panel1.BackColor = selectedcolour;
            panel1.Text = "Panel 1";
            panel1.Show();
            btn_copypanel1colour.BackColor = panel1.BackColor;
        }

        private void btn_createlightpanel2_Click(object sender, EventArgs e)
        {
            if (panel2 == null || panel2.IsDisposed)
            {
                panel2 = new LightPanel();
            }

            panel2.BackColor = selectedcolour;
            panel2.Text = "Panel 2";
            panel2.Show();
            btn_copylabel2colour.BackColor = panel2.BackColor;
        }

        private void btn_createlightpanel3_Click(object sender, EventArgs e)
        {
            if (panel3 == null || panel3.IsDisposed)
            {
                panel3 = new LightPanel();
            }

            panel3.BackColor = selectedcolour;
            panel3.Text = "Panel 3";
            panel3.Show();
            btn_copylabel3colour.BackColor = panel3.BackColor;
        }

        private void btn_pickcolour_Click(object sender, EventArgs e)
        {
            ColorDialog lightpanelcolourpicker = new ColorDialog();
            lightpanelcolourpicker.FullOpen = true;
            if (lightpanelcolourpicker.ShowDialog() == DialogResult.OK)
            {
                selectedcolour = lightpanelcolourpicker.Color;
                textbox_colourpreview.BackColor = lightpanelcolourpicker.Color;
            }
        }

        private void btn_deletealllightpanels_Click(object sender, EventArgs e)
        {
            panel1?.Close();
            panel2?.Close();
            panel3?.Close();
        }

        private void btn_copypanel1colour_Click(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                selectedcolour = panel1.BackColor;
                textbox_colourpreview.BackColor = selectedcolour;
            }
            else
            {
                MessageBox.Show("No colour selected yet for this lightpanel");
            }
        }

        private void discobutton_Click(object sender, EventArgs e)
        {
            if (discoenabled == false)
            {
                if (MessageBox.Show("This button flashes lights very quickly, use at you your own risk", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    discoenabled = true;
                    

                    if (panel1 == null || panel1.IsDisposed)
                    {
                        panel1 = new LightPanel();
                    }
                    if (panel2 == null || panel2.IsDisposed)
                    {
                        panel2 = new LightPanel();
                    }
                    if (panel3 == null || panel3.IsDisposed)
                    {
                        panel3 = new LightPanel();
                    }

                    if (tmr == null)
                    {
                        // time created for disco mode button
                        tmr = new Timer();
                        tmr.Interval = 100;
                        tmr.Tick += (o, args) =>
                        {
                            var red = r.Next(0, 254);
                            var blue = r.Next(0, 254);
                            var green = r.Next(0, 254);
                            panel1.BackColor = Color.FromArgb(red, green, blue);
                            panel2.BackColor = Color.FromArgb(red, green, blue);
                            panel3.BackColor = Color.FromArgb(red, green, blue);
                            btn_discomode.BackColor = Color.FromArgb(red, green, blue);
                        };
                    }
                    tmr.Enabled = !tmr.Enabled;
                    panel1.Show();
                    panel2.Show();
                    panel3.Show();
                }
            }
            else
            {
                tmr.Enabled = !tmr.Enabled;
                discoenabled = false;
                return;
            }
        }

        private void btn_copylabel2colour_Click(object sender, EventArgs e)
        {
            if (panel2 != null)
            {
                selectedcolour = panel2.BackColor;
                textbox_colourpreview.BackColor = selectedcolour;
            }
            else
            {
                MessageBox.Show("No colour selected yet for this lightpanel");
            }

        }

        private void btn_copylabel3colour_Click(object sender, EventArgs e)
        {
            if (panel3 != null)
            {
                selectedcolour = panel3.BackColor;
                textbox_colourpreview.BackColor = selectedcolour;
            }
            else
            {
                MessageBox.Show("No colour selected yet for this lightpanel");
            }
        }

    }
}
