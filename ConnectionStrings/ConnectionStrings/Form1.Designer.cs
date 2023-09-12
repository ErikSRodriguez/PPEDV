namespace ConnectionStringsTests
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showConStringButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.conStringNamesComboBox = new System.Windows.Forms.ComboBox();
            this.getConStringByNameButton = new System.Windows.Forms.Button();
            this.saveConStringByNameButton = new System.Windows.Forms.Button();
            this.conStringByNameResultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.showConStringButton);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(668, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // showConStringButton
            // 
            this.showConStringButton.AutoSize = true;
            this.showConStringButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showConStringButton.Location = new System.Drawing.Point(3, 3);
            this.showConStringButton.Name = "showConStringButton";
            this.showConStringButton.Size = new System.Drawing.Size(277, 44);
            this.showConStringButton.TabIndex = 0;
            this.showConStringButton.Text = "Reload\r\nConfigurationManager.ConnectionStrings";
            this.showConStringButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(0, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get ConString by Name";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.conStringNamesComboBox);
            this.flowLayoutPanel2.Controls.Add(this.getConStringByNameButton);
            this.flowLayoutPanel2.Controls.Add(this.saveConStringByNameButton);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.conStringByNameResultTextBox);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1037, 78);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // conStringNamesComboBox
            // 
            this.conStringNamesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conStringNamesComboBox.FormattingEnabled = true;
            this.conStringNamesComboBox.Location = new System.Drawing.Point(54, 4);
            this.conStringNamesComboBox.Name = "conStringNamesComboBox";
            this.conStringNamesComboBox.Size = new System.Drawing.Size(196, 24);
            this.conStringNamesComboBox.TabIndex = 3;
            // 
            // getConStringByNameButton
            // 
            this.getConStringByNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getConStringByNameButton.AutoSize = true;
            this.getConStringByNameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getConStringByNameButton.Location = new System.Drawing.Point(256, 3);
            this.getConStringByNameButton.Name = "getConStringByNameButton";
            this.getConStringByNameButton.Size = new System.Drawing.Size(41, 27);
            this.getConStringByNameButton.TabIndex = 2;
            this.getConStringByNameButton.Text = "Get";
            this.getConStringByNameButton.UseVisualStyleBackColor = true;
            // 
            // saveConStringByNameButton
            // 
            this.saveConStringByNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveConStringByNameButton.AutoSize = true;
            this.saveConStringByNameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveConStringByNameButton.Location = new System.Drawing.Point(303, 3);
            this.saveConStringByNameButton.Name = "saveConStringByNameButton";
            this.saveConStringByNameButton.Size = new System.Drawing.Size(55, 27);
            this.saveConStringByNameButton.TabIndex = 5;
            this.saveConStringByNameButton.Text = "Save*";
            this.saveConStringByNameButton.UseVisualStyleBackColor = true;
            this.saveConStringByNameButton.Click += new System.EventHandler(this.saveConStringByNameButton_Click);
            // 
            // conStringByNameResultTextBox
            // 
            this.conStringByNameResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.SetFlowBreak(this.conStringByNameResultTextBox, true);
            this.conStringByNameResultTextBox.Location = new System.Drawing.Point(3, 36);
            this.conStringByNameResultTextBox.Name = "conStringByNameResultTextBox";
            this.conStringByNameResultTextBox.Size = new System.Drawing.Size(444, 22);
            this.conStringByNameResultTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "*Wenn mit VS gestartet, wird die Datei \'ConnectionStringsTests.vshost.exe.config\'" +
    " geändert";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.SetFlowBreak(this.button2, true);
            this.button2.Location = new System.Drawing.Point(364, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Crypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showConStringButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox conStringNamesComboBox;
        private System.Windows.Forms.Button getConStringByNameButton;
        private System.Windows.Forms.TextBox conStringByNameResultTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveConStringByNameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

