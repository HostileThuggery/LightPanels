namespace LightPanels
{
    partial class LightPanelsMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightPanelsMainForm));
            this.label_welcomemessage = new System.Windows.Forms.Label();
            this.btn_deletealllightpanels = new System.Windows.Forms.Button();
            this.colorDialog_lightpanel = new System.Windows.Forms.ColorDialog();
            this.btn_pickcolour = new System.Windows.Forms.Button();
            this.textbox_colourpreview = new System.Windows.Forms.TextBox();
            this.tooltip_copypanel = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_discomode = new System.Windows.Forms.Button();
            this.LightBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcomemessage
            // 
            this.label_welcomemessage.Location = new System.Drawing.Point(3, 2);
            this.label_welcomemessage.Name = "label_welcomemessage";
            this.label_welcomemessage.Size = new System.Drawing.Size(312, 43);
            this.label_welcomemessage.TabIndex = 2;
            this.label_welcomemessage.Text = "Welcome to light panels, a simple app to produce light from your spare monitors. " +
    "This could be used to light up you, or something else you want lit, enjoy!\r\n";
            // 
            // btn_deletealllightpanels
            // 
            this.btn_deletealllightpanels.Location = new System.Drawing.Point(6, 156);
            this.btn_deletealllightpanels.Name = "btn_deletealllightpanels";
            this.btn_deletealllightpanels.Size = new System.Drawing.Size(75, 23);
            this.btn_deletealllightpanels.TabIndex = 3;
            this.btn_deletealllightpanels.Text = "Delete All";
            this.btn_deletealllightpanels.UseVisualStyleBackColor = true;
            this.btn_deletealllightpanels.Click += new System.EventHandler(this.btn_deletealllightpanels_Click);
            // 
            // colorDialog_lightpanel
            // 
            this.colorDialog_lightpanel.AnyColor = true;
            // 
            // btn_pickcolour
            // 
            this.btn_pickcolour.Location = new System.Drawing.Point(240, 95);
            this.btn_pickcolour.Name = "btn_pickcolour";
            this.btn_pickcolour.Size = new System.Drawing.Size(75, 23);
            this.btn_pickcolour.TabIndex = 5;
            this.btn_pickcolour.Text = "Panel Colour";
            this.btn_pickcolour.UseVisualStyleBackColor = true;
            this.btn_pickcolour.Click += new System.EventHandler(this.btn_pickcolour_Click);
            // 
            // textbox_colourpreview
            // 
            this.textbox_colourpreview.Enabled = false;
            this.textbox_colourpreview.Location = new System.Drawing.Point(211, 124);
            this.textbox_colourpreview.Multiline = true;
            this.textbox_colourpreview.Name = "textbox_colourpreview";
            this.textbox_colourpreview.Size = new System.Drawing.Size(104, 55);
            this.textbox_colourpreview.TabIndex = 6;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // btn_discomode
            // 
            this.btn_discomode.Location = new System.Drawing.Point(240, 66);
            this.btn_discomode.Name = "btn_discomode";
            this.btn_discomode.Size = new System.Drawing.Size(75, 23);
            this.btn_discomode.TabIndex = 12;
            this.btn_discomode.Text = "Disco Mode";
            this.btn_discomode.UseVisualStyleBackColor = true;
            this.btn_discomode.Click += new System.EventHandler(this.discobutton_Click);
            // 
            // LightBoxes
            // 
            this.LightBoxes.Location = new System.Drawing.Point(6, 49);
            this.LightBoxes.Name = "LightBoxes";
            this.LightBoxes.Size = new System.Drawing.Size(200, 100);
            this.LightBoxes.TabIndex = 13;
            // 
            // btnNewPanel
            // 
            this.btnNewPanel.Location = new System.Drawing.Point(240, 37);
            this.btnNewPanel.Name = "btnNewPanel";
            this.btnNewPanel.Size = new System.Drawing.Size(75, 23);
            this.btnNewPanel.TabIndex = 12;
            this.btnNewPanel.Text = "New Panel";
            this.btnNewPanel.UseVisualStyleBackColor = true;
            this.btnNewPanel.Click += new System.EventHandler(this.btnNewPanel_Click);
            // 
            // LightPanelsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 182);
            this.Controls.Add(this.LightBoxes);
            this.Controls.Add(this.btnNewPanel);
            this.Controls.Add(this.btn_discomode);
            this.Controls.Add(this.textbox_colourpreview);
            this.Controls.Add(this.btn_pickcolour);
            this.Controls.Add(this.btn_deletealllightpanels);
            this.Controls.Add(this.label_welcomemessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(329, 221);
            this.MinimumSize = new System.Drawing.Size(329, 221);
            this.Name = "LightPanelsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightPanels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_welcomemessage;
        private System.Windows.Forms.Button btn_deletealllightpanels;
        private System.Windows.Forms.ColorDialog colorDialog_lightpanel;
        private System.Windows.Forms.Button btn_pickcolour;
        private System.Windows.Forms.TextBox textbox_colourpreview;
        private System.Windows.Forms.ToolTip tooltip_copypanel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btn_discomode;
        private System.Windows.Forms.FlowLayoutPanel LightBoxes;
        private System.Windows.Forms.Button btnNewPanel;
    }
}

