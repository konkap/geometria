namespace GeometriaObliczeniowa
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
            this.bialy = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wyniki = new System.Windows.Forms.ToolStripTextBox();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonTest = new System.Windows.Forms.Button();
            this.radioButtonTest4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTest3 = new System.Windows.Forms.RadioButton();
            this.radioButtonTest2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTest1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButtonPNOPb = new System.Windows.Forms.RadioButton();
            this.radioButtonPNOPf = new System.Windows.Forms.RadioButton();
            this.buttonPNOP = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButtonOtoczQ = new System.Windows.Forms.RadioButton();
            this.radioButtonOtoczB = new System.Windows.Forms.RadioButton();
            this.buttonOtoczka = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonPrzeciecia = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonTriangulacja = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.radioButtonWnetrzeW = new System.Windows.Forms.RadioButton();
            this.radioButtonWnetrzeZ = new System.Windows.Forms.RadioButton();
            this.buttonWnetrze = new System.Windows.Forms.Button();
            this.groupBoxOdcinki = new System.Windows.Forms.GroupBox();
            this.listBoxOdc1 = new System.Windows.Forms.ListBox();
            this.listBoxOdc2 = new System.Windows.Forms.ListBox();
            this.groupBoxPunkty = new System.Windows.Forms.GroupBox();
            this.listBoxPtkW = new System.Windows.Forms.ListBox();
            this.listBoxPtk = new System.Windows.Forms.ListBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonW = new System.Windows.Forms.RadioButton();
            this.radioButtonKropki = new System.Windows.Forms.RadioButton();
            this.radioButtonLinie = new System.Windows.Forms.RadioButton();
            this.textBoxWsp = new System.Windows.Forms.TextBox();
            this.trans = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bialy)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBoxOdcinki.SuspendLayout();
            this.groupBoxPunkty.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trans)).BeginInit();
            this.SuspendLayout();
            // 
            // bialy
            // 
            this.bialy.BackColor = System.Drawing.Color.White;
            this.bialy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bialy.Location = new System.Drawing.Point(0, 0);
            this.bialy.Name = "bialy";
            this.bialy.Size = new System.Drawing.Size(500, 500);
            this.bialy.TabIndex = 1;
            this.bialy.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyniki,
            this.resetToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 506);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(802, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wyniki
            // 
            this.wyniki.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.wyniki.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.wyniki.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.wyniki.Name = "wyniki";
            this.wyniki.ReadOnly = true;
            this.wyniki.Size = new System.Drawing.Size(300, 21);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.kolorToolStripMenuItem.Text = "Kolor";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(506, 304);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(289, 193);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage1.Controls.Add(this.buttonTest);
            this.tabPage1.Controls.Add(this.radioButtonTest4);
            this.tabPage1.Controls.Add(this.radioButtonTest3);
            this.tabPage1.Controls.Add(this.radioButtonTest2);
            this.tabPage1.Controls.Add(this.radioButtonTest1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Testy";
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTest.Location = new System.Drawing.Point(86, 87);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(104, 27);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Wykonaj test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // radioButtonTest4
            // 
            this.radioButtonTest4.AutoSize = true;
            this.radioButtonTest4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonTest4.Location = new System.Drawing.Point(151, 17);
            this.radioButtonTest4.Name = "radioButtonTest4";
            this.radioButtonTest4.Size = new System.Drawing.Size(104, 17);
            this.radioButtonTest4.TabIndex = 3;
            this.radioButtonTest4.Text = "Przec. odcinków";
            this.radioButtonTest4.UseVisualStyleBackColor = true;
            this.radioButtonTest4.CheckedChanged += new System.EventHandler(this.radioButtonTest4_CheckedChanged);
            // 
            // radioButtonTest3
            // 
            this.radioButtonTest3.AutoSize = true;
            this.radioButtonTest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonTest3.Location = new System.Drawing.Point(151, 40);
            this.radioButtonTest3.Name = "radioButtonTest3";
            this.radioButtonTest3.Size = new System.Drawing.Size(105, 17);
            this.radioButtonTest3.TabIndex = 2;
            this.radioButtonTest3.Text = "Przec. prost. ogr.";
            this.radioButtonTest3.UseVisualStyleBackColor = true;
            this.radioButtonTest3.CheckedChanged += new System.EventHandler(this.radioButtonTest3_CheckedChanged);
            // 
            // radioButtonTest2
            // 
            this.radioButtonTest2.AutoSize = true;
            this.radioButtonTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonTest2.Location = new System.Drawing.Point(13, 40);
            this.radioButtonTest2.Name = "radioButtonTest2";
            this.radioButtonTest2.Size = new System.Drawing.Size(110, 17);
            this.radioButtonTest2.TabIndex = 1;
            this.radioButtonTest2.Text = "Przyn. do odcinka";
            this.radioButtonTest2.UseVisualStyleBackColor = true;
            this.radioButtonTest2.CheckedChanged += new System.EventHandler(this.radioButtonTest2_CheckedChanged);
            // 
            // radioButtonTest1
            // 
            this.radioButtonTest1.AutoSize = true;
            this.radioButtonTest1.Checked = true;
            this.radioButtonTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonTest1.Location = new System.Drawing.Point(13, 17);
            this.radioButtonTest1.Name = "radioButtonTest1";
            this.radioButtonTest1.Size = new System.Drawing.Size(69, 17);
            this.radioButtonTest1.TabIndex = 0;
            this.radioButtonTest1.TabStop = true;
            this.radioButtonTest1.Text = "Orientacji";
            this.radioButtonTest1.UseVisualStyleBackColor = true;
            this.radioButtonTest1.CheckedChanged += new System.EventHandler(this.radioButtonTest1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.radioButtonPNOPb);
            this.tabPage2.Controls.Add(this.radioButtonPNOPf);
            this.tabPage2.Controls.Add(this.buttonPNOP);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(281, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "P.N.O.P.";
            // 
            // radioButtonPNOPb
            // 
            this.radioButtonPNOPb.AutoSize = true;
            this.radioButtonPNOPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPNOPb.Location = new System.Drawing.Point(174, 25);
            this.radioButtonPNOPb.Name = "radioButtonPNOPb";
            this.radioButtonPNOPb.Size = new System.Drawing.Size(56, 17);
            this.radioButtonPNOPb.TabIndex = 2;
            this.radioButtonPNOPb.Text = "Szybki";
            this.radioButtonPNOPb.UseVisualStyleBackColor = true;
            // 
            // radioButtonPNOPf
            // 
            this.radioButtonPNOPf.AutoSize = true;
            this.radioButtonPNOPf.Checked = true;
            this.radioButtonPNOPf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPNOPf.Location = new System.Drawing.Point(56, 25);
            this.radioButtonPNOPf.Name = "radioButtonPNOPf";
            this.radioButtonPNOPf.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPNOPf.TabIndex = 1;
            this.radioButtonPNOPf.TabStop = true;
            this.radioButtonPNOPf.Text = "Brutalny";
            this.radioButtonPNOPf.UseVisualStyleBackColor = true;
            // 
            // buttonPNOP
            // 
            this.buttonPNOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPNOP.Location = new System.Drawing.Point(94, 63);
            this.buttonPNOP.Name = "buttonPNOP";
            this.buttonPNOP.Size = new System.Drawing.Size(112, 27);
            this.buttonPNOP.TabIndex = 0;
            this.buttonPNOP.Text = "Znajdz P.N.O.P";
            this.buttonPNOP.UseVisualStyleBackColor = true;
            this.buttonPNOP.Click += new System.EventHandler(this.buttonPNOP_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioButtonOtoczQ);
            this.tabPage3.Controls.Add(this.radioButtonOtoczB);
            this.tabPage3.Controls.Add(this.buttonOtoczka);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(281, 149);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Otoczka wyp.";
            // 
            // radioButtonOtoczQ
            // 
            this.radioButtonOtoczQ.AutoSize = true;
            this.radioButtonOtoczQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonOtoczQ.Location = new System.Drawing.Point(157, 25);
            this.radioButtonOtoczQ.Name = "radioButtonOtoczQ";
            this.radioButtonOtoczQ.Size = new System.Drawing.Size(69, 17);
            this.radioButtonOtoczQ.TabIndex = 2;
            this.radioButtonOtoczQ.Text = "Quickhull";
            this.radioButtonOtoczQ.UseVisualStyleBackColor = true;
            // 
            // radioButtonOtoczB
            // 
            this.radioButtonOtoczB.AutoSize = true;
            this.radioButtonOtoczB.Checked = true;
            this.radioButtonOtoczB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonOtoczB.Location = new System.Drawing.Point(56, 25);
            this.radioButtonOtoczB.Name = "radioButtonOtoczB";
            this.radioButtonOtoczB.Size = new System.Drawing.Size(63, 17);
            this.radioButtonOtoczB.TabIndex = 1;
            this.radioButtonOtoczB.TabStop = true;
            this.radioButtonOtoczB.Text = "Brutalny";
            this.radioButtonOtoczB.UseVisualStyleBackColor = true;
            // 
            // buttonOtoczka
            // 
            this.buttonOtoczka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOtoczka.Location = new System.Drawing.Point(85, 71);
            this.buttonOtoczka.Name = "buttonOtoczka";
            this.buttonOtoczka.Size = new System.Drawing.Size(102, 27);
            this.buttonOtoczka.TabIndex = 0;
            this.buttonOtoczka.Text = "Otoczka";
            this.buttonOtoczka.UseVisualStyleBackColor = true;
            this.buttonOtoczka.Click += new System.EventHandler(this.buttonOtoczka_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonPrzeciecia);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(281, 149);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Przeciecia odc.";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonPrzeciecia
            // 
            this.buttonPrzeciecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrzeciecia.Location = new System.Drawing.Point(90, 60);
            this.buttonPrzeciecia.Name = "buttonPrzeciecia";
            this.buttonPrzeciecia.Size = new System.Drawing.Size(87, 27);
            this.buttonPrzeciecia.TabIndex = 3;
            this.buttonPrzeciecia.Text = "Przeciecia";
            this.buttonPrzeciecia.UseVisualStyleBackColor = true;
            this.buttonPrzeciecia.Click += new System.EventHandler(this.buttonPrzeciecia_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonTriangulacja);
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(281, 149);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Triangulacja";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonTriangulacja
            // 
            this.buttonTriangulacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTriangulacja.Location = new System.Drawing.Point(92, 58);
            this.buttonTriangulacja.Name = "buttonTriangulacja";
            this.buttonTriangulacja.Size = new System.Drawing.Size(84, 25);
            this.buttonTriangulacja.TabIndex = 0;
            this.buttonTriangulacja.Text = "Triangulacja";
            this.buttonTriangulacja.UseVisualStyleBackColor = true;
            this.buttonTriangulacja.Click += new System.EventHandler(this.buttonTriangulacja_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.radioButtonWnetrzeW);
            this.tabPage6.Controls.Add(this.radioButtonWnetrzeZ);
            this.tabPage6.Controls.Add(this.buttonWnetrze);
            this.tabPage6.Location = new System.Drawing.Point(4, 40);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(281, 149);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "We wnetrzu";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // radioButtonWnetrzeW
            // 
            this.radioButtonWnetrzeW.AutoSize = true;
            this.radioButtonWnetrzeW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonWnetrzeW.Location = new System.Drawing.Point(34, 48);
            this.radioButtonWnetrzeW.Name = "radioButtonWnetrzeW";
            this.radioButtonWnetrzeW.Size = new System.Drawing.Size(175, 17);
            this.radioButtonWnetrzeW.TabIndex = 2;
            this.radioButtonWnetrzeW.Text = "Wielkokat wypukly   -    O(log n)";
            this.radioButtonWnetrzeW.UseVisualStyleBackColor = true;
            // 
            // radioButtonWnetrzeZ
            // 
            this.radioButtonWnetrzeZ.AutoSize = true;
            this.radioButtonWnetrzeZ.Checked = true;
            this.radioButtonWnetrzeZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonWnetrzeZ.Location = new System.Drawing.Point(34, 25);
            this.radioButtonWnetrzeZ.Name = "radioButtonWnetrzeZ";
            this.radioButtonWnetrzeZ.Size = new System.Drawing.Size(157, 17);
            this.radioButtonWnetrzeZ.TabIndex = 1;
            this.radioButtonWnetrzeZ.TabStop = true;
            this.radioButtonWnetrzeZ.Text = "Wielkokat zwykly     -    O(n)";
            this.radioButtonWnetrzeZ.UseVisualStyleBackColor = true;
            // 
            // buttonWnetrze
            // 
            this.buttonWnetrze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWnetrze.Location = new System.Drawing.Point(88, 81);
            this.buttonWnetrze.Name = "buttonWnetrze";
            this.buttonWnetrze.Size = new System.Drawing.Size(105, 23);
            this.buttonWnetrze.TabIndex = 0;
            this.buttonWnetrze.Text = "We wnetrzu?";
            this.buttonWnetrze.UseVisualStyleBackColor = true;
            this.buttonWnetrze.Click += new System.EventHandler(this.buttonWnetrze_Click);
            // 
            // groupBoxOdcinki
            // 
            this.groupBoxOdcinki.Controls.Add(this.listBoxOdc1);
            this.groupBoxOdcinki.Controls.Add(this.listBoxOdc2);
            this.groupBoxOdcinki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxOdcinki.Location = new System.Drawing.Point(653, 68);
            this.groupBoxOdcinki.Name = "groupBoxOdcinki";
            this.groupBoxOdcinki.Size = new System.Drawing.Size(142, 230);
            this.groupBoxOdcinki.TabIndex = 4;
            this.groupBoxOdcinki.TabStop = false;
            this.groupBoxOdcinki.Text = "Odcinki";
            // 
            // listBoxOdc1
            // 
            this.listBoxOdc1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxOdc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxOdc1.FormattingEnabled = true;
            this.listBoxOdc1.Location = new System.Drawing.Point(14, 21);
            this.listBoxOdc1.Name = "listBoxOdc1";
            this.listBoxOdc1.Size = new System.Drawing.Size(113, 95);
            this.listBoxOdc1.TabIndex = 0;
            // 
            // listBoxOdc2
            // 
            this.listBoxOdc2.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxOdc2.Enabled = false;
            this.listBoxOdc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxOdc2.FormattingEnabled = true;
            this.listBoxOdc2.Location = new System.Drawing.Point(14, 122);
            this.listBoxOdc2.Name = "listBoxOdc2";
            this.listBoxOdc2.Size = new System.Drawing.Size(113, 95);
            this.listBoxOdc2.TabIndex = 1;
            // 
            // groupBoxPunkty
            // 
            this.groupBoxPunkty.Controls.Add(this.listBoxPtkW);
            this.groupBoxPunkty.Controls.Add(this.listBoxPtk);
            this.groupBoxPunkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPunkty.Location = new System.Drawing.Point(506, 68);
            this.groupBoxPunkty.Name = "groupBoxPunkty";
            this.groupBoxPunkty.Size = new System.Drawing.Size(134, 230);
            this.groupBoxPunkty.TabIndex = 5;
            this.groupBoxPunkty.TabStop = false;
            this.groupBoxPunkty.Text = "Punkty";
            // 
            // listBoxPtkW
            // 
            this.listBoxPtkW.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBoxPtkW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxPtkW.FormattingEnabled = true;
            this.listBoxPtkW.Location = new System.Drawing.Point(10, 122);
            this.listBoxPtkW.Name = "listBoxPtkW";
            this.listBoxPtkW.Size = new System.Drawing.Size(113, 95);
            this.listBoxPtkW.TabIndex = 3;
            // 
            // listBoxPtk
            // 
            this.listBoxPtk.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxPtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxPtk.FormattingEnabled = true;
            this.listBoxPtk.Location = new System.Drawing.Point(10, 21);
            this.listBoxPtk.Name = "listBoxPtk";
            this.listBoxPtk.Size = new System.Drawing.Size(113, 95);
            this.listBoxPtk.TabIndex = 2;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.radioButtonW);
            this.groupBoxInfo.Controls.Add(this.radioButtonKropki);
            this.groupBoxInfo.Controls.Add(this.radioButtonLinie);
            this.groupBoxInfo.Controls.Add(this.textBoxWsp);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxInfo.Location = new System.Drawing.Point(506, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(289, 50);
            this.groupBoxInfo.TabIndex = 6;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Rysowanie";
            // 
            // radioButtonW
            // 
            this.radioButtonW.AutoSize = true;
            this.radioButtonW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonW.Location = new System.Drawing.Point(216, 21);
            this.radioButtonW.Name = "radioButtonW";
            this.radioButtonW.Size = new System.Drawing.Size(67, 17);
            this.radioButtonW.TabIndex = 3;
            this.radioButtonW.TabStop = true;
            this.radioButtonW.Text = "Wielokat";
            this.radioButtonW.UseVisualStyleBackColor = true;
            // 
            // radioButtonKropki
            // 
            this.radioButtonKropki.AutoSize = true;
            this.radioButtonKropki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonKropki.Location = new System.Drawing.Point(155, 21);
            this.radioButtonKropki.Name = "radioButtonKropki";
            this.radioButtonKropki.Size = new System.Drawing.Size(55, 17);
            this.radioButtonKropki.TabIndex = 2;
            this.radioButtonKropki.Text = "Kropki";
            this.radioButtonKropki.UseVisualStyleBackColor = true;
            // 
            // radioButtonLinie
            // 
            this.radioButtonLinie.AutoSize = true;
            this.radioButtonLinie.Checked = true;
            this.radioButtonLinie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonLinie.Location = new System.Drawing.Point(105, 21);
            this.radioButtonLinie.Name = "radioButtonLinie";
            this.radioButtonLinie.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLinie.TabIndex = 1;
            this.radioButtonLinie.TabStop = true;
            this.radioButtonLinie.Text = "Linie";
            this.radioButtonLinie.UseVisualStyleBackColor = true;
            // 
            // textBoxWsp
            // 
            this.textBoxWsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWsp.Location = new System.Drawing.Point(6, 21);
            this.textBoxWsp.Name = "textBoxWsp";
            this.textBoxWsp.ReadOnly = true;
            this.textBoxWsp.Size = new System.Drawing.Size(93, 20);
            this.textBoxWsp.TabIndex = 0;
            this.textBoxWsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trans
            // 
            this.trans.BackColor = System.Drawing.Color.Transparent;
            this.trans.Location = new System.Drawing.Point(0, 0);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(500, 500);
            this.trans.TabIndex = 7;
            this.trans.TabStop = false;
            this.trans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trans_MouseDown);
            this.trans.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trans_MouseMove);
            this.trans.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trans_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(802, 531);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.bialy);
            this.Controls.Add(this.groupBoxPunkty);
            this.Controls.Add(this.groupBoxOdcinki);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometria Obliczeniowa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bialy)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBoxOdcinki.ResumeLayout(false);
            this.groupBoxPunkty.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bialy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxOdcinki;
        private System.Windows.Forms.ListBox listBoxOdc1;
        private System.Windows.Forms.ListBox listBoxOdc2;
        private System.Windows.Forms.GroupBox groupBoxPunkty;
        private System.Windows.Forms.ListBox listBoxPtk;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.RadioButton radioButtonTest4;
        private System.Windows.Forms.RadioButton radioButtonTest3;
        private System.Windows.Forms.RadioButton radioButtonTest2;
        private System.Windows.Forms.RadioButton radioButtonTest1;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxWsp;
        private System.Windows.Forms.RadioButton radioButtonKropki;
        private System.Windows.Forms.RadioButton radioButtonLinie;
        private System.Windows.Forms.PictureBox trans;
        private System.Windows.Forms.ToolStripTextBox wyniki;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Button buttonPNOP;
        private System.Windows.Forms.RadioButton radioButtonPNOPb;
        private System.Windows.Forms.RadioButton radioButtonPNOPf;
        private System.Windows.Forms.Button buttonOtoczka;
        private System.Windows.Forms.RadioButton radioButtonOtoczQ;
        private System.Windows.Forms.RadioButton radioButtonOtoczB;
        private System.Windows.Forms.Button buttonPrzeciecia;
        private System.Windows.Forms.RadioButton radioButtonW;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonTriangulacja;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button buttonWnetrze;
        private System.Windows.Forms.RadioButton radioButtonWnetrzeW;
        private System.Windows.Forms.RadioButton radioButtonWnetrzeZ;
        private System.Windows.Forms.ListBox listBoxPtkW;
    }
}

