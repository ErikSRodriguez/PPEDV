namespace ppedv.Personenverwaltung.UI.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            vornameTextBox = new TextBox();
            nachnameTextBox = new TextBox();
            stadtTextBox = new TextBox();
            gebDateTimePicker = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            button7 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.NavajoWhite;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1726, 48);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(216, 42);
            button1.TabIndex = 0;
            button1.Text = "Demodaten laden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(225, 3);
            button2.Name = "button2";
            button2.Size = new Size(234, 42);
            button2.TabIndex = 1;
            button2.Text = "Als XML speichern...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Location = new Point(465, 3);
            button3.Name = "button3";
            button3.Size = new Size(164, 42);
            button3.TabIndex = 2;
            button3.Text = "XML öffnen...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.Location = new Point(635, 3);
            button5.Name = "button5";
            button5.Size = new Size(245, 42);
            button5.TabIndex = 4;
            button5.Text = "Als JSON speichern...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.Location = new Point(886, 3);
            button4.Name = "button4";
            button4.Size = new Size(175, 42);
            button4.TabIndex = 3;
            button4.Text = "JSON öffnen...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.Location = new Point(1067, 3);
            button6.Name = "button6";
            button6.Size = new Size(166, 42);
            button6.TabIndex = 5;
            button6.Text = "Excel Export...";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.Lavender;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(575, 598);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 96);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1726, 598);
            splitContainer1.SplitterDistance = 575;
            splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AntiqueWhite;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(vornameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(nachnameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(stadtTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(gebDateTimePicker, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1147, 598);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(23, 6);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 0;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "Nachname";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(64, 96);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 2;
            label3.Text = "Stadt";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 141);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 3;
            label4.Text = "GebDatum";
            // 
            // vornameTextBox
            // 
            vornameTextBox.Dock = DockStyle.Fill;
            vornameTextBox.Location = new Point(138, 3);
            vornameTextBox.Name = "vornameTextBox";
            vornameTextBox.Size = new Size(1006, 39);
            vornameTextBox.TabIndex = 4;
            // 
            // nachnameTextBox
            // 
            nachnameTextBox.Dock = DockStyle.Fill;
            nachnameTextBox.Location = new Point(138, 48);
            nachnameTextBox.Name = "nachnameTextBox";
            nachnameTextBox.Size = new Size(1006, 39);
            nachnameTextBox.TabIndex = 5;
            // 
            // stadtTextBox
            // 
            stadtTextBox.Dock = DockStyle.Fill;
            stadtTextBox.Location = new Point(138, 93);
            stadtTextBox.Name = "stadtTextBox";
            stadtTextBox.Size = new Size(1006, 39);
            stadtTextBox.TabIndex = 6;
            // 
            // gebDateTimePicker
            // 
            gebDateTimePicker.Dock = DockStyle.Fill;
            gebDateTimePicker.Format = DateTimePickerFormat.Short;
            gebDateTimePicker.Location = new Point(138, 138);
            gebDateTimePicker.Name = "gebDateTimePicker";
            gebDateTimePicker.Size = new Size(1006, 39);
            gebDateTimePicker.TabIndex = 7;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(283, 42);
            button7.TabIndex = 6;
            button7.Text = "Personen aus DB landen";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = Color.PaleTurquoise;
            flowLayoutPanel2.Controls.Add(button7);
            flowLayoutPanel2.Controls.Add(button8);
            flowLayoutPanel2.Controls.Add(button9);
            flowLayoutPanel2.Controls.Add(button10);
            flowLayoutPanel2.Controls.Add(button11);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 48);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1726, 48);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.Location = new Point(292, 3);
            button8.Name = "button8";
            button8.Size = new Size(196, 42);
            button8.TabIndex = 7;
            button8.Text = "Add new Person";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button9.Location = new Point(494, 3);
            button9.Name = "button9";
            button9.Size = new Size(130, 42);
            button9.TabIndex = 8;
            button9.Text = "Speichern";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.AutoSize = true;
            button10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button10.Location = new Point(630, 3);
            button10.Name = "button10";
            button10.Size = new Size(267, 42);
            button10.TabIndex = 9;
            button10.Text = "Delete selected Person";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.AutoSize = true;
            button11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button11.Location = new Point(903, 3);
            button11.Name = "button11";
            button11.Size = new Size(235, 42);
            button11.TabIndex = 10;
            button11.Text = "Import Demo daten";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1726, 694);
            Controls.Add(splitContainer1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox vornameTextBox;
        private TextBox nachnameTextBox;
        private TextBox stadtTextBox;
        private DateTimePicker gebDateTimePicker;
        private BindingSource bindingSource1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}
