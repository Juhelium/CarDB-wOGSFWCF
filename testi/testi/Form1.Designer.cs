namespace testi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.delbutton = new System.Windows.Forms.Button();
            this.pervbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.addstuff = new System.Windows.Forms.Button();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.fuelbox = new System.Windows.Forms.ComboBox();
            this.mallibox = new System.Windows.Forms.ComboBox();
            this.merkkibox = new System.Windows.Forms.ComboBox();
            this.hintabox = new System.Windows.Forms.TextBox();
            this.motilabox = new System.Windows.Forms.TextBox();
            this.mittariluksbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pvmBox = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(342, 544);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(324, 121);
            this.delbutton.TabIndex = 23;
            this.delbutton.Text = "poista";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // pervbutton
            // 
            this.pervbutton.Location = new System.Drawing.Point(341, 799);
            this.pervbutton.Name = "pervbutton";
            this.pervbutton.Size = new System.Drawing.Size(324, 121);
            this.pervbutton.TabIndex = 22;
            this.pervbutton.Text = "edellinen";
            this.pervbutton.UseVisualStyleBackColor = true;
            this.pervbutton.Click += new System.EventHandler(this.pervbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(342, 672);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(324, 121);
            this.nextbutton.TabIndex = 21;
            this.nextbutton.Text = "seuraava";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(11, 672);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(324, 121);
            this.savebutton.TabIndex = 20;
            this.savebutton.Text = "tallenna";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.addstuff_Click);
            // 
            // addstuff
            // 
            this.addstuff.Location = new System.Drawing.Point(12, 544);
            this.addstuff.Name = "addstuff";
            this.addstuff.Size = new System.Drawing.Size(324, 121);
            this.addstuff.TabIndex = 19;
            this.addstuff.Text = "lisää";
            this.addstuff.UseVisualStyleBackColor = true;
            // 
            // colorbox
            // 
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Location = new System.Drawing.Point(143, 440);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(326, 37);
            this.colorbox.TabIndex = 18;
            this.colorbox.Text = "väri";
            // 
            // fuelbox
            // 
            this.fuelbox.FormattingEnabled = true;
            this.fuelbox.Location = new System.Drawing.Point(142, 395);
            this.fuelbox.Name = "fuelbox";
            this.fuelbox.Size = new System.Drawing.Size(326, 37);
            this.fuelbox.TabIndex = 17;
            this.fuelbox.Text = "polttoaine";
            // 
            // mallibox
            // 
            this.mallibox.FormattingEnabled = true;
            this.mallibox.Location = new System.Drawing.Point(142, 350);
            this.mallibox.Name = "mallibox";
            this.mallibox.Size = new System.Drawing.Size(326, 37);
            this.mallibox.TabIndex = 16;
            this.mallibox.Text = "malli";
            // 
            // merkkibox
            // 
            this.merkkibox.FormattingEnabled = true;
            this.merkkibox.Location = new System.Drawing.Point(142, 304);
            this.merkkibox.Name = "merkkibox";
            this.merkkibox.Size = new System.Drawing.Size(326, 37);
            this.merkkibox.TabIndex = 15;
            this.merkkibox.Text = "merkki";
            this.merkkibox.SelectedIndexChanged += new System.EventHandler(this.merkkibox_SelectedIndexChanged);
            // 
            // hintabox
            // 
            this.hintabox.Location = new System.Drawing.Point(138, 219);
            this.hintabox.Name = "hintabox";
            this.hintabox.Size = new System.Drawing.Size(326, 37);
            this.hintabox.TabIndex = 14;
            this.hintabox.Text = "hinta";
            // 
            // motilabox
            // 
            this.motilabox.Location = new System.Drawing.Point(138, 145);
            this.motilabox.Name = "motilabox";
            this.motilabox.Size = new System.Drawing.Size(326, 37);
            this.motilabox.TabIndex = 13;
            this.motilabox.Text = "moottorin tilavuus";
            // 
            // mittariluksbox
            // 
            this.mittariluksbox.Location = new System.Drawing.Point(138, 70);
            this.mittariluksbox.Name = "mittariluksbox";
            this.mittariluksbox.Size = new System.Drawing.Size(326, 37);
            this.mittariluksbox.TabIndex = 12;
            this.mittariluksbox.Text = "mittarilukema";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 40);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 38);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(156, 38);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // pvmBox
            // 
            this.pvmBox.Location = new System.Drawing.Point(140, 485);
            this.pvmBox.Name = "pvmBox";
            this.pvmBox.Size = new System.Drawing.Size(325, 37);
            this.pvmBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 1020);
            this.Controls.Add(this.pvmBox);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.pervbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.addstuff);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.fuelbox);
            this.Controls.Add(this.mallibox);
            this.Controls.Add(this.merkkibox);
            this.Controls.Add(this.hintabox);
            this.Controls.Add(this.motilabox);
            this.Controls.Add(this.mittariluksbox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button pervbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button addstuff;
        private System.Windows.Forms.ComboBox colorbox;
        private System.Windows.Forms.ComboBox fuelbox;
        private System.Windows.Forms.ComboBox mallibox;
        private System.Windows.Forms.ComboBox merkkibox;
        private System.Windows.Forms.TextBox hintabox;
        private System.Windows.Forms.TextBox motilabox;
        private System.Windows.Forms.TextBox mittariluksbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker pvmBox;
    }
}

