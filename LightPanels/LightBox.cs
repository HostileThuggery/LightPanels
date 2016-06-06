using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LightPanels.Properties;

namespace LightPanels
{
    public partial class LightBox : UserControl
    {
        private Timer tmr;
        private Form lightWindow = new LightPanel();
        private Color _colour = DefaultBackColor;
        public delegate void OnClickHandler(object sender);
        public event OnClickHandler OnClick;
        public EventHandler RIP;
        #region Properties
        public Color Colour
        {
            get { return _colour; }
            set
            {
                _colour = value;
                lightWindow.BackColor = _colour;
                this.BackColor = _colour;
            }
        }

        public bool IsDisco => tmr?.Enabled ?? false;
        #endregion


        public LightBox()
        {
            InitializeComponent();
            lightWindow.Show();
            lightWindow.FormClosing += LightWindowOnFormClosing;
        }

        private void LightWindowOnFormClosing(object sender, FormClosingEventArgs formClosingEventArgs)
        {
            RIP?.Invoke(this, null);
        }

        private void LightBox_Click(object sender, EventArgs e)
        {
            OnClick?.Invoke(this);
        }

        public void StartDisco()
        {
            if (tmr == null)
            {
                tmr = new Timer { Interval = 100 };
                tmr.Tick += TmrOnTick;
            }
            tmr.Enabled = true;
        }

        public void StopDisco()
        {
            if (tmr == null)
                return;
            tmr.Enabled = false;
        }
        public void ToggleDisco()
        {
            if (tmr != null && tmr.Enabled == true)
            {
                StopDisco();
            }
            else
            {
                StartDisco();
            }
        }
        private void TmrOnTick(object sender, EventArgs eventArgs)
        {
            Colour = ColorExtention.Random();
        }


        public void Close()
        {
            RIP = null;
            lightWindow?.Close();
        }
    }
}
