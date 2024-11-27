namespace Caso_3Modelado
{
    partial class GameForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            VS = new Label();
            label1 = new Label();
            label2 = new Label();
            P1_ArteMarcial_1 = new Label();
            P1_ArteMarcial_2 = new Label();
            P1_ArteMarcial_3 = new Label();
            P2_ArteMarcial_1 = new Label();
            P2_ArteMarcial_2 = new Label();
            P2_ArteMarcial_3 = new Label();
            Atacar = new Button();
            button6 = new Button();
            button7 = new Button();
            ComboBoxArtesMarcialP1 = new ComboBox();
            lblVidaP1 = new Label();
            lblVidaP2 = new Label();
            Tecnicas1P1 = new ListBox();
            Tecnicas2P1 = new ListBox();
            Tecnicas3P1 = new ListBox();
            Tecnicas1P2 = new ListBox();
            Tecnicas2P2 = new ListBox();
            Tecnicas3P2 = new ListBox();
            BitacoraP1 = new ListBox();
            BitacoraP2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 255, 128);
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 530);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(128, 255, 128);
            pictureBox2.Location = new Point(775, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(610, 530);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // VS
            // 
            VS.AutoSize = true;
            VS.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VS.ForeColor = Color.FromArgb(61, 171, 78);
            VS.Location = new Point(662, 215);
            VS.Name = "VS";
            VS.Size = new Size(81, 60);
            VS.TabIndex = 2;
            VS.Text = "VS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 171, 78);
            label1.Location = new Point(229, 34);
            label1.Name = "label1";
            label1.Size = new Size(173, 44);
            label1.TabIndex = 3;
            label1.Text = "Player 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 128);
            label2.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 171, 78);
            label2.Location = new Point(982, 34);
            label2.Name = "label2";
            label2.Size = new Size(174, 44);
            label2.TabIndex = 4;
            label2.Text = "Player 2";
            // 
            // P1_ArteMarcial_1
            // 
            P1_ArteMarcial_1.AutoSize = true;
            P1_ArteMarcial_1.BackColor = Color.FromArgb(128, 255, 128);
            P1_ArteMarcial_1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1_ArteMarcial_1.ForeColor = Color.FromArgb(61, 171, 78);
            P1_ArteMarcial_1.Location = new Point(49, 99);
            P1_ArteMarcial_1.Name = "P1_ArteMarcial_1";
            P1_ArteMarcial_1.Size = new Size(162, 23);
            P1_ArteMarcial_1.TabIndex = 10;
            P1_ArteMarcial_1.Text = "Arte Marcial 1";
            P1_ArteMarcial_1.TextAlign = ContentAlignment.MiddleCenter;
            P1_ArteMarcial_1.Click += label3_Click;
            // 
            // P1_ArteMarcial_2
            // 
            P1_ArteMarcial_2.AutoSize = true;
            P1_ArteMarcial_2.BackColor = Color.FromArgb(128, 255, 128);
            P1_ArteMarcial_2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1_ArteMarcial_2.ForeColor = Color.FromArgb(61, 171, 78);
            P1_ArteMarcial_2.Location = new Point(240, 99);
            P1_ArteMarcial_2.Name = "P1_ArteMarcial_2";
            P1_ArteMarcial_2.Size = new Size(162, 23);
            P1_ArteMarcial_2.TabIndex = 11;
            P1_ArteMarcial_2.Text = "Arte Marcial 2";
            P1_ArteMarcial_2.TextAlign = ContentAlignment.MiddleCenter;
            P1_ArteMarcial_2.Click += P1_ArteMarcial_2_Click;
            // 
            // P1_ArteMarcial_3
            // 
            P1_ArteMarcial_3.Anchor = AnchorStyles.None;
            P1_ArteMarcial_3.AutoSize = true;
            P1_ArteMarcial_3.BackColor = Color.FromArgb(128, 255, 128);
            P1_ArteMarcial_3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1_ArteMarcial_3.ForeColor = Color.FromArgb(61, 171, 78);
            P1_ArteMarcial_3.Location = new Point(445, 99);
            P1_ArteMarcial_3.Name = "P1_ArteMarcial_3";
            P1_ArteMarcial_3.Size = new Size(162, 23);
            P1_ArteMarcial_3.TabIndex = 12;
            P1_ArteMarcial_3.Text = "Arte Marcial 3";
            P1_ArteMarcial_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // P2_ArteMarcial_1
            // 
            P2_ArteMarcial_1.AutoSize = true;
            P2_ArteMarcial_1.BackColor = Color.FromArgb(128, 255, 128);
            P2_ArteMarcial_1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P2_ArteMarcial_1.ForeColor = Color.FromArgb(61, 171, 78);
            P2_ArteMarcial_1.Location = new Point(806, 99);
            P2_ArteMarcial_1.Name = "P2_ArteMarcial_1";
            P2_ArteMarcial_1.Size = new Size(162, 23);
            P2_ArteMarcial_1.TabIndex = 13;
            P2_ArteMarcial_1.Text = "Arte Marcial 1";
            P2_ArteMarcial_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // P2_ArteMarcial_2
            // 
            P2_ArteMarcial_2.AutoSize = true;
            P2_ArteMarcial_2.BackColor = Color.FromArgb(128, 255, 128);
            P2_ArteMarcial_2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P2_ArteMarcial_2.ForeColor = Color.FromArgb(61, 171, 78);
            P2_ArteMarcial_2.Location = new Point(1003, 99);
            P2_ArteMarcial_2.Name = "P2_ArteMarcial_2";
            P2_ArteMarcial_2.Size = new Size(162, 23);
            P2_ArteMarcial_2.TabIndex = 14;
            P2_ArteMarcial_2.Text = "Arte Marcial 2";
            P2_ArteMarcial_2.TextAlign = ContentAlignment.MiddleCenter;
            P2_ArteMarcial_2.Click += P2_ArteMarcial_2_Click;
            // 
            // P2_ArteMarcial_3
            // 
            P2_ArteMarcial_3.AutoSize = true;
            P2_ArteMarcial_3.BackColor = Color.FromArgb(128, 255, 128);
            P2_ArteMarcial_3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P2_ArteMarcial_3.ForeColor = Color.FromArgb(61, 171, 78);
            P2_ArteMarcial_3.Location = new Point(1203, 99);
            P2_ArteMarcial_3.Name = "P2_ArteMarcial_3";
            P2_ArteMarcial_3.Size = new Size(162, 23);
            P2_ArteMarcial_3.TabIndex = 15;
            P2_ArteMarcial_3.Text = "Arte Marcial 3";
            P2_ArteMarcial_3.TextAlign = ContentAlignment.MiddleCenter;
            P2_ArteMarcial_3.Click += P2_ArteMarcial_3_Click;
            // 
            // Atacar
            // 
            Atacar.Location = new Point(645, 298);
            Atacar.Name = "Atacar";
            Atacar.Size = new Size(112, 61);
            Atacar.TabIndex = 24;
            Atacar.Text = "Atacar";
            Atacar.UseVisualStyleBackColor = true;
            Atacar.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(645, 387);
            button6.Name = "button6";
            button6.Size = new Size(112, 61);
            button6.TabIndex = 25;
            button6.Text = "J1 Re - Asignar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(645, 476);
            button7.Name = "button7";
            button7.Size = new Size(112, 61);
            button7.TabIndex = 26;
            button7.Text = "J2 Re - Asignar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // ComboBoxArtesMarcialP1
            // 
            ComboBoxArtesMarcialP1.FormattingEnabled = true;
            ComboBoxArtesMarcialP1.Location = new Point(30, 252);
            ComboBoxArtesMarcialP1.Name = "ComboBoxArtesMarcialP1";
            ComboBoxArtesMarcialP1.Size = new Size(121, 23);
            ComboBoxArtesMarcialP1.TabIndex = 0;
            ComboBoxArtesMarcialP1.SelectedIndexChanged += ComboBoxArtesMarcialP1_SelectedIndexChanged;
            // 
            // lblVidaP1
            // 
            lblVidaP1.AutoSize = true;
            lblVidaP1.BackColor = Color.FromArgb(201, 249, 187);
            lblVidaP1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidaP1.ForeColor = Color.FromArgb(61, 171, 78);
            lblVidaP1.Location = new Point(12, 741);
            lblVidaP1.Name = "lblVidaP1";
            lblVidaP1.Size = new Size(176, 23);
            lblVidaP1.TabIndex = 30;
            lblVidaP1.Text = "Vida 200 / 200";
            lblVidaP1.TextAlign = ContentAlignment.MiddleCenter;
            lblVidaP1.Click += label3_Click_1;
            // 
            // lblVidaP2
            // 
            lblVidaP2.AutoSize = true;
            lblVidaP2.BackColor = Color.FromArgb(201, 249, 187);
            lblVidaP2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidaP2.ForeColor = Color.FromArgb(61, 171, 78);
            lblVidaP2.Location = new Point(775, 741);
            lblVidaP2.Name = "lblVidaP2";
            lblVidaP2.Size = new Size(176, 23);
            lblVidaP2.TabIndex = 31;
            lblVidaP2.Text = "Vida 200 / 200";
            lblVidaP2.TextAlign = ContentAlignment.MiddleCenter;
            lblVidaP2.Click += label4_Click;
            // 
            // Tecnicas1P1
            // 
            Tecnicas1P1.FormattingEnabled = true;
            Tecnicas1P1.ItemHeight = 15;
            Tecnicas1P1.Location = new Point(30, 140);
            Tecnicas1P1.Name = "Tecnicas1P1";
            Tecnicas1P1.Size = new Size(181, 64);
            Tecnicas1P1.TabIndex = 32;
            // 
            // Tecnicas2P1
            // 
            Tecnicas2P1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tecnicas2P1.FormattingEnabled = true;
            Tecnicas2P1.ItemHeight = 15;
            Tecnicas2P1.Location = new Point(229, 140);
            Tecnicas2P1.Name = "Tecnicas2P1";
            Tecnicas2P1.Size = new Size(181, 64);
            Tecnicas2P1.TabIndex = 33;
            // 
            // Tecnicas3P1
            // 
            Tecnicas3P1.FormattingEnabled = true;
            Tecnicas3P1.ItemHeight = 15;
            Tecnicas3P1.Location = new Point(426, 140);
            Tecnicas3P1.Name = "Tecnicas3P1";
            Tecnicas3P1.Size = new Size(181, 64);
            Tecnicas3P1.TabIndex = 34;
            // 
            // Tecnicas1P2
            // 
            Tecnicas1P2.FormattingEnabled = true;
            Tecnicas1P2.ItemHeight = 15;
            Tecnicas1P2.Location = new Point(790, 140);
            Tecnicas1P2.Name = "Tecnicas1P2";
            Tecnicas1P2.Size = new Size(181, 64);
            Tecnicas1P2.TabIndex = 35;
            // 
            // Tecnicas2P2
            // 
            Tecnicas2P2.FormattingEnabled = true;
            Tecnicas2P2.ItemHeight = 15;
            Tecnicas2P2.Location = new Point(993, 140);
            Tecnicas2P2.Name = "Tecnicas2P2";
            Tecnicas2P2.Size = new Size(181, 64);
            Tecnicas2P2.TabIndex = 36;
            // 
            // Tecnicas3P2
            // 
            Tecnicas3P2.FormattingEnabled = true;
            Tecnicas3P2.ItemHeight = 15;
            Tecnicas3P2.Location = new Point(1193, 140);
            Tecnicas3P2.Name = "Tecnicas3P2";
            Tecnicas3P2.Size = new Size(181, 64);
            Tecnicas3P2.TabIndex = 37;
            // 
            // BitacoraP1
            // 
            BitacoraP1.FormattingEnabled = true;
            BitacoraP1.ItemHeight = 15;
            BitacoraP1.Location = new Point(12, 571);
            BitacoraP1.Name = "BitacoraP1";
            BitacoraP1.Size = new Size(615, 154);
            BitacoraP1.TabIndex = 38;
            BitacoraP1.SelectedIndexChanged += BitacoraP1_SelectedIndexChanged;
            // 
            // BitacoraP2
            // 
            BitacoraP2.FormattingEnabled = true;
            BitacoraP2.ItemHeight = 15;
            BitacoraP2.Location = new Point(775, 571);
            BitacoraP2.Name = "BitacoraP2";
            BitacoraP2.Size = new Size(610, 154);
            BitacoraP2.TabIndex = 39;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 249, 187);
            ClientSize = new Size(1397, 779);
            Controls.Add(BitacoraP2);
            Controls.Add(BitacoraP1);
            Controls.Add(Tecnicas3P2);
            Controls.Add(Tecnicas2P2);
            Controls.Add(Tecnicas1P2);
            Controls.Add(Tecnicas3P1);
            Controls.Add(Tecnicas2P1);
            Controls.Add(Tecnicas1P1);
            Controls.Add(lblVidaP2);
            Controls.Add(lblVidaP1);
            Controls.Add(ComboBoxArtesMarcialP1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(Atacar);
            Controls.Add(P2_ArteMarcial_3);
            Controls.Add(P2_ArteMarcial_2);
            Controls.Add(P2_ArteMarcial_1);
            Controls.Add(P1_ArteMarcial_3);
            Controls.Add(P1_ArteMarcial_2);
            Controls.Add(P1_ArteMarcial_1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(VS);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torneo Artes Marciales";
            Load += GameForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label VS;
        private Label label1;
        private Label label2;
        private Label P1_ArteMarcial_1;
        private Label P1_ArteMarcial_2;
        private Label P1_ArteMarcial_3;
        private Label P2_ArteMarcial_1;
        private Label P2_ArteMarcial_2;
        private Label P2_ArteMarcial_3;
        private Button Atacar;
        private Button button6;
        private Button button7;
        private ComboBox ComboBoxArtesMarcialP1;
        private Label lblVidaP1;
        private Label lblVidaP2;
        private ListBox Tecnicas2P1;
        private ListBox Tecnicas3P1;
        private ListBox Tecnicas1P2;
        private ListBox Tecnicas2P2;
        private ListBox Tecnicas3P2;
        public ListBox Tecnicas1P1;
        private ListBox BitacoraP1;
        private ListBox BitacoraP2;
    }
}
