namespace kurtadamsaldirisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pcbWolfMan = new System.Windows.Forms.PictureBox();
            this.lblHealt = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.cmbheytbe = new System.Windows.Forms.ComboBox();
            this.lblhumanhealt = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolfMan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Irk : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Branş : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Silah : ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(194, 31);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(177, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Location = new System.Drawing.Point(194, 124);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(177, 23);
            this.txtWeapon.TabIndex = 1;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbRace.Location = new System.Drawing.Point(-185, 207);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(176, 23);
            this.cmbRace.TabIndex = 2;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Archer",
            "Assasin"});
            this.cmbBranch.Location = new System.Drawing.Point(194, 89);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(176, 23);
            this.cmbBranch.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(411, 113);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(107, 34);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pcbWolfMan
            // 
            this.pcbWolfMan.Image = global::kurtadamsaldirisi.Properties.Resources.kurt;
            this.pcbWolfMan.Location = new System.Drawing.Point(509, 280);
            this.pcbWolfMan.Name = "pcbWolfMan";
            this.pcbWolfMan.Size = new System.Drawing.Size(250, 137);
            this.pcbWolfMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWolfMan.TabIndex = 4;
            this.pcbWolfMan.TabStop = false;
            this.pcbWolfMan.Visible = false;
            // 
            // lblHealt
            // 
            this.lblHealt.BackColor = System.Drawing.Color.DarkRed;
            this.lblHealt.Location = new System.Drawing.Point(509, 240);
            this.lblHealt.Name = "lblHealt";
            this.lblHealt.Size = new System.Drawing.Size(250, 15);
            this.lblHealt.TabIndex = 5;
            this.lblHealt.Visible = false;
            this.lblHealt.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(124, 281);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(247, 83);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "Saldır";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // cmbheytbe
            // 
            this.cmbheytbe.FormattingEnabled = true;
            this.cmbheytbe.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbheytbe.Location = new System.Drawing.Point(194, 60);
            this.cmbheytbe.Name = "cmbheytbe";
            this.cmbheytbe.Size = new System.Drawing.Size(176, 23);
            this.cmbheytbe.TabIndex = 2;
            // 
            // lblhumanhealt
            // 
            this.lblhumanhealt.BackColor = System.Drawing.Color.DarkRed;
            this.lblhumanhealt.Location = new System.Drawing.Point(124, 382);
            this.lblhumanhealt.Name = "lblhumanhealt";
            this.lblhumanhealt.Size = new System.Drawing.Size(250, 15);
            this.lblhumanhealt.TabIndex = 5;
            this.lblhumanhealt.Visible = false;
            this.lblhumanhealt.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(636, 29);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(123, 38);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.Text = "Yeni Oyun";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblhumanhealt);
            this.Controls.Add(this.lblHealt);
            this.Controls.Add(this.pcbWolfMan);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbheytbe);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolfMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUserName;
        private TextBox txtWeapon;
        private ComboBox cmbRace;
        private ComboBox cmbBranch;
        private Button btnSelect;
        private PictureBox pcbWolfMan;
        private Label lblHealt;
        private Button btnAttack;
        private ComboBox cmbheytbe;
        private Label lblhumanhealt;
        private Button btnNewGame;
    }
}