namespace EZCorsshair
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_draw = new System.Windows.Forms.Button();
            this.button_hide = new System.Windows.Forms.Button();
            this.linkLabel_version = new System.Windows.Forms.LinkLabel();
            this.linkLabel_github = new System.Windows.Forms.LinkLabel();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.groupBox_actions = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_options.SuspendLayout();
            this.groupBox_actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_draw
            // 
            this.button_draw.Location = new System.Drawing.Point(6, 19);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(94, 23);
            this.button_draw.TabIndex = 0;
            this.button_draw.Text = "Draw corsshair";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // button_hide
            // 
            this.button_hide.Location = new System.Drawing.Point(6, 46);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(94, 23);
            this.button_hide.TabIndex = 1;
            this.button_hide.Text = "Hide corsshair";
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // linkLabel_version
            // 
            this.linkLabel_version.AutoSize = true;
            this.linkLabel_version.Location = new System.Drawing.Point(40, 85);
            this.linkLabel_version.Name = "linkLabel_version";
            this.linkLabel_version.Size = new System.Drawing.Size(60, 13);
            this.linkLabel_version.TabIndex = 2;
            this.linkLabel_version.TabStop = true;
            this.linkLabel_version.Text = "Version 0.5";
            this.linkLabel_version.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_version_LinkClicked);
            // 
            // linkLabel_github
            // 
            this.linkLabel_github.AutoSize = true;
            this.linkLabel_github.Location = new System.Drawing.Point(45, 72);
            this.linkLabel_github.Name = "linkLabel_github";
            this.linkLabel_github.Size = new System.Drawing.Size(55, 13);
            this.linkLabel_github.TabIndex = 3;
            this.linkLabel_github.TabStop = true;
            this.linkLabel_github.Text = "My Github";
            this.linkLabel_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_github_LinkClicked);
            // 
            // comboBox_color
            // 
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Items.AddRange(new object[] {
            "Red",
            "Purple",
            "Green",
            "Blue",
            "White",
            "Black"});
            this.comboBox_color.Location = new System.Drawing.Point(5, 32);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(121, 21);
            this.comboBox_color.TabIndex = 4;
            this.comboBox_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_color_SelectedIndexChanged);
            this.comboBox_color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_color_KeyPress);
            // 
            // comboBox_size
            // 
            this.comboBox_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.comboBox_size.Location = new System.Drawing.Point(5, 72);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(121, 21);
            this.comboBox_size.TabIndex = 5;
            this.comboBox_size.SelectedIndexChanged += new System.EventHandler(this.comboBox_size_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select the crosshair color here...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select the crosshair size here...";
            // 
            // groupBox_options
            // 
            this.groupBox_options.Controls.Add(this.label1);
            this.groupBox_options.Controls.Add(this.comboBox_color);
            this.groupBox_options.Controls.Add(this.label2);
            this.groupBox_options.Controls.Add(this.comboBox_size);
            this.groupBox_options.Location = new System.Drawing.Point(10, -1);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.Size = new System.Drawing.Size(172, 103);
            this.groupBox_options.TabIndex = 8;
            this.groupBox_options.TabStop = false;
            this.groupBox_options.Text = "Options";
            // 
            // groupBox_actions
            // 
            this.groupBox_actions.Controls.Add(this.pictureBox1);
            this.groupBox_actions.Controls.Add(this.button_draw);
            this.groupBox_actions.Controls.Add(this.button_hide);
            this.groupBox_actions.Controls.Add(this.linkLabel_version);
            this.groupBox_actions.Controls.Add(this.linkLabel_github);
            this.groupBox_actions.Location = new System.Drawing.Point(188, -1);
            this.groupBox_actions.Name = "groupBox_actions";
            this.groupBox_actions.Size = new System.Drawing.Size(106, 103);
            this.groupBox_actions.TabIndex = 9;
            this.groupBox_actions.TabStop = false;
            this.groupBox_actions.Text = "Actions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 110);
            this.Controls.Add(this.groupBox_actions);
            this.Controls.Add(this.groupBox_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EZCrosshair";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_options.ResumeLayout(false);
            this.groupBox_options.PerformLayout();
            this.groupBox_actions.ResumeLayout(false);
            this.groupBox_actions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.LinkLabel linkLabel_version;
        private System.Windows.Forms.LinkLabel linkLabel_github;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.GroupBox groupBox_actions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

