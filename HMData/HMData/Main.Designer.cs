namespace HMData
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gen_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.uic_textbox = new System.Windows.Forms.TextBox();
            this.end_calendar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.start_calendar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.currency_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.ticker_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.log_textbox = new System.Windows.Forms.TextBox();
            this.clear_linklabel = new System.Windows.Forms.LinkLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1243, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add_Data";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gen_button);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.uic_textbox);
            this.groupBox1.Controls.Add(this.end_calendar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.start_calendar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.type_combobox);
            this.groupBox1.Controls.Add(this.currency_textbox);
            this.groupBox1.Controls.Add(this.name_textbox);
            this.groupBox1.Controls.Add(this.ticker_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Underlying";
            // 
            // gen_button
            // 
            this.gen_button.Location = new System.Drawing.Point(222, 25);
            this.gen_button.Name = "gen_button";
            this.gen_button.Size = new System.Drawing.Size(80, 23);
            this.gen_button.TabIndex = 15;
            this.gen_button.Text = "Generate";
            this.gen_button.UseVisualStyleBackColor = true;
            this.gen_button.Click += new System.EventHandler(this.gen_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "UIC";
            // 
            // uic_textbox
            // 
            this.uic_textbox.Location = new System.Drawing.Point(96, 25);
            this.uic_textbox.Name = "uic_textbox";
            this.uic_textbox.Size = new System.Drawing.Size(120, 20);
            this.uic_textbox.TabIndex = 13;
            // 
            // end_calendar
            // 
            this.end_calendar.CustomFormat = "MM-dd-yyyy";
            this.end_calendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_calendar.Location = new System.Drawing.Point(96, 225);
            this.end_calendar.Name = "end_calendar";
            this.end_calendar.Size = new System.Drawing.Size(120, 20);
            this.end_calendar.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Date";
            // 
            // start_calendar
            // 
            this.start_calendar.CustomFormat = "MM-dd-yyyy";
            this.start_calendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_calendar.Location = new System.Drawing.Point(96, 185);
            this.start_calendar.Name = "start_calendar";
            this.start_calendar.Size = new System.Drawing.Size(120, 20);
            this.start_calendar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Start Date";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(96, 260);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(120, 28);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add Ticker";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // type_combobox
            // 
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Location = new System.Drawing.Point(96, 145);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(120, 21);
            this.type_combobox.TabIndex = 7;
            // 
            // currency_textbox
            // 
            this.currency_textbox.Location = new System.Drawing.Point(96, 115);
            this.currency_textbox.Name = "currency_textbox";
            this.currency_textbox.Size = new System.Drawing.Size(120, 20);
            this.currency_textbox.TabIndex = 6;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(96, 85);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(120, 20);
            this.name_textbox.TabIndex = 5;
            // 
            // ticker_textbox
            // 
            this.ticker_textbox.Location = new System.Drawing.Point(96, 55);
            this.ticker_textbox.Name = "ticker_textbox";
            this.ticker_textbox.Size = new System.Drawing.Size(120, 20);
            this.ticker_textbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1243, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Get_Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gray;
            this.tabPage3.Controls.Add(this.log_textbox);
            this.tabPage3.Controls.Add(this.clear_linklabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1247, 208);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Messages";
            // 
            // log_textbox
            // 
            this.log_textbox.BackColor = System.Drawing.Color.DarkGray;
            this.log_textbox.Location = new System.Drawing.Point(10, 20);
            this.log_textbox.Multiline = true;
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.Size = new System.Drawing.Size(1199, 182);
            this.log_textbox.TabIndex = 1;
            // 
            // clear_linklabel
            // 
            this.clear_linklabel.AutoSize = true;
            this.clear_linklabel.Location = new System.Drawing.Point(7, 4);
            this.clear_linklabel.Name = "clear_linklabel";
            this.clear_linklabel.Size = new System.Drawing.Size(31, 13);
            this.clear_linklabel.TabIndex = 0;
            this.clear_linklabel.TabStop = true;
            this.clear_linklabel.Text = "Clear";
            this.clear_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clear_linklabel_LinkClicked);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(4, 503);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1255, 234);
            this.tabControl2.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1263, 740);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "HMData - Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.TextBox currency_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox ticker_textbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DateTimePicker end_calendar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker start_calendar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox log_textbox;
        private System.Windows.Forms.LinkLabel clear_linklabel;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button gen_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uic_textbox;
    }
}

