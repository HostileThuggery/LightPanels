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
            this.btn_createlightpanel1 = new System.Windows.Forms.Button();
            this.label_welcomemessage = new System.Windows.Forms.Label();
            this.btn_deletealllightpanels = new System.Windows.Forms.Button();
            this.colorDialog_lightpanel = new System.Windows.Forms.ColorDialog();
            this.btn_pickcolour = new System.Windows.Forms.Button();
            this.textbox_colourpreview = new System.Windows.Forms.TextBox();
            this.btn_createlightpanel2 = new System.Windows.Forms.Button();
            this.btn_createlightpanel3 = new System.Windows.Forms.Button();
            this.btn_copypanel1colour = new System.Windows.Forms.Button();
            this.btn_copylabel2colour = new System.Windows.Forms.Button();
            this.btn_copylabel3colour = new System.Windows.Forms.Button();
            this.tooltip_copypanel = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_discomode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_createlightpanel1
            // 
            this.btn_createlightpanel1.Location = new System.Drawing.Point(6, 60);
            this.btn_createlightpanel1.Name = "btn_createlightpanel1";
            this.btn_createlightpanel1.Size = new System.Drawing.Size(106, 23);
            this.btn_createlightpanel1.TabIndex = 0;
            this.btn_createlightpanel1.Text = "Create Panel 1";
            this.btn_createlightpanel1.UseVisualStyleBackColor = true;
            this.btn_createlightpanel1.Click += new System.EventHandler(this.btn_createlightpanel_Click);
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
            this.btn_pickcolour.Location = new System.Drawing.Point(233, 73);
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
            this.textbox_colourpreview.Location = new System.Drawing.Point(157, 102);
            this.textbox_colourpreview.Multiline = true;
            this.textbox_colourpreview.Name = "textbox_colourpreview";
            this.textbox_colourpreview.Size = new System.Drawing.Size(151, 77);
            this.textbox_colourpreview.TabIndex = 6;
            // 
            // btn_createlightpanel2
            // 
            this.btn_createlightpanel2.Location = new System.Drawing.Point(6, 90);
            this.btn_createlightpanel2.Name = "btn_createlightpanel2";
            this.btn_createlightpanel2.Size = new System.Drawing.Size(106, 23);
            this.btn_createlightpanel2.TabIndex = 7;
            this.btn_createlightpanel2.Text = "Create Panel 2";
            this.btn_createlightpanel2.UseVisualStyleBackColor = true;
            this.btn_createlightpanel2.Click += new System.EventHandler(this.btn_createlightpanel2_Click);
            // 
            // btn_createlightpanel3
            // 
            this.btn_createlightpanel3.Location = new System.Drawing.Point(6, 120);
            this.btn_createlightpanel3.Name = "btn_createlightpanel3";
            this.btn_createlightpanel3.Size = new System.Drawing.Size(106, 23);
            this.btn_createlightpanel3.TabIndex = 8;
            this.btn_createlightpanel3.Text = "Create Panel 3";
            this.btn_createlightpanel3.UseVisualStyleBackColor = true;
            this.btn_createlightpanel3.Click += new System.EventHandler(this.btn_createlightpanel3_Click);
            // 
            // btn_copypanel1colour
            // 
            this.btn_copypanel1colour.Location = new System.Drawing.Point(119, 60);
            this.btn_copypanel1colour.Name = "btn_copypanel1colour";
            this.btn_copypanel1colour.Size = new System.Drawing.Size(23, 23);
            this.btn_copypanel1colour.TabIndex = 9;
            this.tooltip_copypanel.SetToolTip(this.btn_copypanel1colour, "Copy this panels colour back to the panel colour area\r\n");
            this.btn_copypanel1colour.UseVisualStyleBackColor = true;
            this.btn_copypanel1colour.Click += new System.EventHandler(this.btn_copypanel1colour_Click);
            // 
            // btn_copylabel2colour
            // 
            this.btn_copylabel2colour.Location = new System.Drawing.Point(119, 90);
            this.btn_copylabel2colour.Name = "btn_copylabel2colour";
            this.btn_copylabel2colour.Size = new System.Drawing.Size(23, 23);
            this.btn_copylabel2colour.TabIndex = 10;
            this.tooltip_copypanel.SetToolTip(this.btn_copylabel2colour, "Copy this panels colour back to the panel colour area");
            this.btn_copylabel2colour.UseVisualStyleBackColor = true;
            this.btn_copylabel2colour.Click += new System.EventHandler(this.btn_copylabel2colour_Click);
            // 
            // btn_copylabel3colour
            // 
            this.btn_copylabel3colour.Location = new System.Drawing.Point(119, 120);
            this.btn_copylabel3colour.Name = "btn_copylabel3colour";
            this.btn_copylabel3colour.Size = new System.Drawing.Size(23, 23);
            this.btn_copylabel3colour.TabIndex = 11;
            this.tooltip_copypanel.SetToolTip(this.btn_copylabel3colour, "Copy this panels colour back to the panel colour area");
            this.btn_copylabel3colour.UseVisualStyleBackColor = true;
            this.btn_copylabel3colour.Click += new System.EventHandler(this.btn_copylabel3colour_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // btn_discomode
            // 
            this.btn_discomode.Location = new System.Drawing.Point(233, 48);
            this.btn_discomode.Name = "btn_discomode";
            this.btn_discomode.Size = new System.Drawing.Size(75, 23);
            this.btn_discomode.TabIndex = 12;
            this.btn_discomode.Text = "Disco Mode";
            this.btn_discomode.UseVisualStyleBackColor = true;
            this.btn_discomode.Click += new System.EventHandler(this.discobutton_Click);
            // 
            // LightPanelsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 182);
            this.Controls.Add(this.btn_discomode);
            this.Controls.Add(this.btn_copylabel3colour);
            this.Controls.Add(this.btn_copylabel2colour);
            this.Controls.Add(this.btn_copypanel1colour);
            this.Controls.Add(this.btn_createlightpanel3);
            this.Controls.Add(this.btn_createlightpanel2);
            this.Controls.Add(this.textbox_colourpreview);
            this.Controls.Add(this.btn_pickcolour);
            this.Controls.Add(this.btn_deletealllightpanels);
            this.Controls.Add(this.label_welcomemessage);
            this.Controls.Add(this.btn_createlightpanel1);
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

        private System.Windows.Forms.Button btn_createlightpanel1;
        private System.Windows.Forms.Label label_welcomemessage;
        private System.Windows.Forms.Button btn_deletealllightpanels;
        private System.Windows.Forms.ColorDialog colorDialog_lightpanel;
        private System.Windows.Forms.Button btn_pickcolour;
        private System.Windows.Forms.TextBox textbox_colourpreview;
        private System.Windows.Forms.Button btn_createlightpanel2;
        private System.Windows.Forms.Button btn_createlightpanel3;
        private System.Windows.Forms.Button btn_copypanel1colour;
        private System.Windows.Forms.Button btn_copylabel2colour;
        private System.Windows.Forms.Button btn_copylabel3colour;
        private System.Windows.Forms.ToolTip tooltip_copypanel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btn_discomode;
    }
}

