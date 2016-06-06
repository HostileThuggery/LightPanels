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
        private LightBox selected;
        private ContextMenu lightBoxMenu = new ContextMenu();
        public LightPanelsMainForm()
        {
            InitializeComponent();

            lightBoxMenu.MenuItems.Add(new MenuItem("Get Colour", GetColour));
            lightBoxMenu.MenuItems.Add(new MenuItem("Set Colour", SetColour));
            lightBoxMenu.MenuItems.Add(new MenuItem("Disco?", Disco));
        }

        private void GetColour(object sender, EventArgs eventArgs)
        {
            selectedcolour = selected.Colour;
            textbox_colourpreview.BackColor = selectedcolour;
        }
        private void Disco(object sender, EventArgs eventArgs)
        {
            selected.ToggleDisco();
        }
        private void SetColour(object sender, EventArgs eventArgs)
        {
            selected.Colour = selectedcolour;
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
            
            foreach (var lightBox in LightBoxes.Controls)
            {
                ((LightBox) lightBox).Close();
            }
            LightBoxes.Controls.Clear();
            
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
                    foreach (var control in LightBoxes.Controls.Cast<object>().Where(control => control.GetType() == typeof (LightBox)))
                    {
                        ((LightBox)control).StartDisco();
                    }
                }
            }
            else
            {
                discoenabled = false;
                foreach (var control in LightBoxes.Controls.Cast<object>().Where(control => control.GetType() == typeof(LightBox)))
                {
                    ((LightBox)control).StopDisco();
                }
                return;
            }
        }

        private void btnNewPanel_Click(object sender, EventArgs e)
        {
            LightBox lb = new LightBox();
            lb.Colour = selectedcolour;
            lb.OnClick += LbOnOnClick;
            lb.RIP += Rip;
            LightBoxes.Controls.Add(lb);
        }

        private void Rip(object sender, EventArgs eventArgs)
        {
            selected = null;
            LightBoxes.Controls.Remove((LightBox)sender);
            ((LightBox)sender).Dispose();
        }

        private void LbOnOnClick(object sender)
        {
            selected = (LightBox) sender;
            lightBoxMenu.Show(selected,new Point(0,0));
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
