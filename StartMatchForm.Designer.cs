
namespace QuakeApp
{
    partial class StartMatchForm
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
            this.opponentname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opponentchampion = new System.Windows.Forms.ComboBox();
            this.champion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.feelings = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opponentname
            // 
            this.opponentname.Location = new System.Drawing.Point(235, 67);
            this.opponentname.Name = "opponentname";
            this.opponentname.Size = new System.Drawing.Size(351, 23);
            this.opponentname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opponent Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opponent Champion";
            // 
            // opponentchampion
            // 
            this.opponentchampion.FormattingEnabled = true;
            this.opponentchampion.Items.AddRange(new object[] {
            "Anarki",
            "Athena",
            "B.J. Blazkowicz",
            "Clutch",
            "Death Knight",
            "Doom Slayer",
            "Eisen",
            "Galena",
            "Keel",
            "Nyx",
            "Ranger",
            "Scalebearer",
            "Slash",
            "Sorlag",
            "Strogg & Peeker",
            "Visor"});
            this.opponentchampion.Location = new System.Drawing.Point(235, 115);
            this.opponentchampion.Name = "opponentchampion";
            this.opponentchampion.Size = new System.Drawing.Size(351, 23);
            this.opponentchampion.TabIndex = 4;
            // 
            // champion
            // 
            this.champion.FormattingEnabled = true;
            this.champion.Items.AddRange(new object[] {
            "Anarki",
            "Athena",
            "B.J. Blazkowicz",
            "Clutch",
            "Death Knight",
            "Doom Slayer",
            "Eisen",
            "Galena",
            "Keel",
            "Nyx",
            "Ranger",
            "Scalebearer",
            "Slash",
            "Sorlag",
            "Strogg & Peeker",
            "Visor"});
            this.champion.Location = new System.Drawing.Point(235, 161);
            this.champion.Name = "champion";
            this.champion.Size = new System.Drawing.Size(351, 23);
            this.champion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your Champion";
            // 
            // feelings
            // 
            this.feelings.FormattingEnabled = true;
            this.feelings.Items.AddRange(new object[] {
            "Confident",
            "Tired",
            "Focused",
            "Unsure"});
            this.feelings.Location = new System.Drawing.Point(235, 237);
            this.feelings.Name = "feelings";
            this.feelings.Size = new System.Drawing.Size(351, 148);
            this.feelings.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "How do you feel going into this match?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // map
            // 
            this.map.FormattingEnabled = true;
            this.map.Items.AddRange(new object[] {
            "Awoken",
            "Molten Falls",
            "Corrupted Keep",
            "Bloor Run",
            "Deep Embrace",
            "Blood Covenant",
            "Vale of Pnath",
            "Ruins of Sarnath",
            "Exile",
            "Tower of Koth"});
            this.map.Location = new System.Drawing.Point(235, 203);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(351, 23);
            this.map.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Map";
            // 
            // StartMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.map);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.feelings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.champion);
            this.Controls.Add(this.opponentchampion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opponentname);
            this.Name = "StartMatchForm";
            this.Text = "Pre Match Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox opponentname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox opponentchampion;
        private System.Windows.Forms.ComboBox champion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox feelings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox map;
        private System.Windows.Forms.Label label5;
    }
}