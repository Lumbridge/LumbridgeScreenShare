namespace LumbridgeScreenShare
{
    partial class MainForm
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
            this.tabControl_MainForm = new MetroFramework.Controls.MetroTabControl();
            this.page_PartnerView = new MetroFramework.Controls.MetroTabPage();
            this.page_Settings = new MetroFramework.Controls.MetroTabPage();
            this.button_StartServer = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textbox_LocalIP = new MetroFramework.Controls.MetroTextBox();
            this.button_ConnectToPartner = new MetroFramework.Controls.MetroButton();
            this.label_partnerIpAddress = new MetroFramework.Controls.MetroLabel();
            this.textbox_partnerIP = new MetroFramework.Controls.MetroTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl_MainForm.SuspendLayout();
            this.page_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_MainForm
            // 
            this.tabControl_MainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_MainForm.Controls.Add(this.page_PartnerView);
            this.tabControl_MainForm.Controls.Add(this.page_Settings);
            this.tabControl_MainForm.Location = new System.Drawing.Point(23, 63);
            this.tabControl_MainForm.Name = "tabControl_MainForm";
            this.tabControl_MainForm.SelectedIndex = 0;
            this.tabControl_MainForm.Size = new System.Drawing.Size(523, 340);
            this.tabControl_MainForm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_MainForm.TabIndex = 0;
            this.tabControl_MainForm.UseSelectable = true;
            // 
            // page_PartnerView
            // 
            this.page_PartnerView.HorizontalScrollbarBarColor = true;
            this.page_PartnerView.HorizontalScrollbarHighlightOnWheel = false;
            this.page_PartnerView.HorizontalScrollbarSize = 10;
            this.page_PartnerView.Location = new System.Drawing.Point(4, 38);
            this.page_PartnerView.Name = "page_PartnerView";
            this.page_PartnerView.Size = new System.Drawing.Size(515, 298);
            this.page_PartnerView.TabIndex = 0;
            this.page_PartnerView.Text = "Partner View";
            this.page_PartnerView.VerticalScrollbarBarColor = true;
            this.page_PartnerView.VerticalScrollbarHighlightOnWheel = false;
            this.page_PartnerView.VerticalScrollbarSize = 10;
            // 
            // page_Settings
            // 
            this.page_Settings.Controls.Add(this.textBox2);
            this.page_Settings.Controls.Add(this.button4);
            this.page_Settings.Controls.Add(this.button3);
            this.page_Settings.Controls.Add(this.button2);
            this.page_Settings.Controls.Add(this.textBox1);
            this.page_Settings.Controls.Add(this.button1);
            this.page_Settings.Controls.Add(this.button_StartServer);
            this.page_Settings.Controls.Add(this.metroLabel1);
            this.page_Settings.Controls.Add(this.textbox_LocalIP);
            this.page_Settings.Controls.Add(this.button_ConnectToPartner);
            this.page_Settings.Controls.Add(this.label_partnerIpAddress);
            this.page_Settings.Controls.Add(this.textbox_partnerIP);
            this.page_Settings.HorizontalScrollbarBarColor = true;
            this.page_Settings.HorizontalScrollbarHighlightOnWheel = false;
            this.page_Settings.HorizontalScrollbarSize = 10;
            this.page_Settings.Location = new System.Drawing.Point(4, 38);
            this.page_Settings.Name = "page_Settings";
            this.page_Settings.Size = new System.Drawing.Size(515, 298);
            this.page_Settings.TabIndex = 1;
            this.page_Settings.Text = "Settings";
            this.page_Settings.VerticalScrollbarBarColor = true;
            this.page_Settings.VerticalScrollbarHighlightOnWheel = false;
            this.page_Settings.VerticalScrollbarSize = 10;
            // 
            // button_StartServer
            // 
            this.button_StartServer.Location = new System.Drawing.Point(290, 131);
            this.button_StartServer.Name = "button_StartServer";
            this.button_StartServer.Size = new System.Drawing.Size(75, 23);
            this.button_StartServer.TabIndex = 7;
            this.button_StartServer.Text = "Start Server";
            this.button_StartServer.UseSelectable = true;
            this.button_StartServer.Click += new System.EventHandler(this.button_StartServer_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(129, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Local IP Address";
            // 
            // textbox_LocalIP
            // 
            // 
            // 
            // 
            this.textbox_LocalIP.CustomButton.Image = null;
            this.textbox_LocalIP.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.textbox_LocalIP.CustomButton.Name = "";
            this.textbox_LocalIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_LocalIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_LocalIP.CustomButton.TabIndex = 1;
            this.textbox_LocalIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_LocalIP.CustomButton.UseSelectable = true;
            this.textbox_LocalIP.CustomButton.Visible = false;
            this.textbox_LocalIP.Lines = new string[0];
            this.textbox_LocalIP.Location = new System.Drawing.Point(129, 131);
            this.textbox_LocalIP.MaxLength = 32767;
            this.textbox_LocalIP.Name = "textbox_LocalIP";
            this.textbox_LocalIP.PasswordChar = '\0';
            this.textbox_LocalIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_LocalIP.SelectedText = "";
            this.textbox_LocalIP.SelectionLength = 0;
            this.textbox_LocalIP.SelectionStart = 0;
            this.textbox_LocalIP.ShortcutsEnabled = true;
            this.textbox_LocalIP.Size = new System.Drawing.Size(155, 23);
            this.textbox_LocalIP.TabIndex = 5;
            this.textbox_LocalIP.UseSelectable = true;
            this.textbox_LocalIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_LocalIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_LocalIP.TextChanged += new System.EventHandler(this.textbox_LocalIP_TextChanged);
            // 
            // button_ConnectToPartner
            // 
            this.button_ConnectToPartner.Location = new System.Drawing.Point(290, 72);
            this.button_ConnectToPartner.Name = "button_ConnectToPartner";
            this.button_ConnectToPartner.Size = new System.Drawing.Size(75, 23);
            this.button_ConnectToPartner.TabIndex = 4;
            this.button_ConnectToPartner.Text = "Connect";
            this.button_ConnectToPartner.UseSelectable = true;
            this.button_ConnectToPartner.Click += new System.EventHandler(this.button_ConnectToPartner_Click);
            // 
            // label_partnerIpAddress
            // 
            this.label_partnerIpAddress.AutoSize = true;
            this.label_partnerIpAddress.Location = new System.Drawing.Point(129, 50);
            this.label_partnerIpAddress.Name = "label_partnerIpAddress";
            this.label_partnerIpAddress.Size = new System.Drawing.Size(118, 19);
            this.label_partnerIpAddress.TabIndex = 3;
            this.label_partnerIpAddress.Text = "Partner IP Address";
            // 
            // textbox_partnerIP
            // 
            // 
            // 
            // 
            this.textbox_partnerIP.CustomButton.Image = null;
            this.textbox_partnerIP.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.textbox_partnerIP.CustomButton.Name = "";
            this.textbox_partnerIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_partnerIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_partnerIP.CustomButton.TabIndex = 1;
            this.textbox_partnerIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_partnerIP.CustomButton.UseSelectable = true;
            this.textbox_partnerIP.CustomButton.Visible = false;
            this.textbox_partnerIP.Lines = new string[0];
            this.textbox_partnerIP.Location = new System.Drawing.Point(129, 72);
            this.textbox_partnerIP.MaxLength = 32767;
            this.textbox_partnerIP.Name = "textbox_partnerIP";
            this.textbox_partnerIP.PasswordChar = '\0';
            this.textbox_partnerIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_partnerIP.SelectedText = "";
            this.textbox_partnerIP.SelectionLength = 0;
            this.textbox_partnerIP.SelectionStart = 0;
            this.textbox_partnerIP.ShortcutsEnabled = true;
            this.textbox_partnerIP.Size = new System.Drawing.Size(155, 23);
            this.textbox_partnerIP.TabIndex = 2;
            this.textbox_partnerIP.UseSelectable = true;
            this.textbox_partnerIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_partnerIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_partnerIP.TextChanged += new System.EventHandler(this.textbox_partnerIP_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 20);
            this.textBox2.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Save File Location";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Start Server #2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 425);
            this.Controls.Add(this.tabControl_MainForm);
            this.Name = "MainForm";
            this.Text = "Lumbridge Screen Share v0.0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl_MainForm.ResumeLayout(false);
            this.page_Settings.ResumeLayout(false);
            this.page_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl_MainForm;
        private MetroFramework.Controls.MetroTabPage page_PartnerView;
        private MetroFramework.Controls.MetroTabPage page_Settings;
        private MetroFramework.Controls.MetroButton button_ConnectToPartner;
        private MetroFramework.Controls.MetroLabel label_partnerIpAddress;
        private MetroFramework.Controls.MetroTextBox textbox_partnerIP;
        private MetroFramework.Controls.MetroButton button_StartServer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textbox_LocalIP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

