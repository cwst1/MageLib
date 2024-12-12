namespace GraLINQ
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
            allMagesButton = new Button();
            richTextBoxResults = new RichTextBox();
            btnGetExperiencedMages = new Button();
            txtLevel = new TextBox();
            btnGetTalentedMages = new Button();
            txtMaxLevel = new TextBox();
            btnGetTotalBattlePotential = new Button();
            btnGetMagesWithArsenal = new Button();
            txtMinSpells = new TextBox();
            btnGetVersatileMages = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            btnGetUniqueSpells = new Button();
            btnCheckIfAnyoneLostConsciousness = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // allMagesButton
            // 
            allMagesButton.Location = new Point(323, 406);
            allMagesButton.Name = "allMagesButton";
            allMagesButton.Size = new Size(398, 29);
            allMagesButton.TabIndex = 1;
            allMagesButton.Text = " ALL";
            allMagesButton.UseVisualStyleBackColor = true;
            allMagesButton.Click += allMagesButton_Click;
            // 
            // richTextBoxResults
            // 
            richTextBoxResults.BackColor = SystemColors.InfoText;
            richTextBoxResults.ForeColor = Color.Chartreuse;
            richTextBoxResults.Location = new Point(12, 12);
            richTextBoxResults.Name = "richTextBoxResults";
            richTextBoxResults.Size = new Size(1188, 218);
            richTextBoxResults.TabIndex = 3;
            richTextBoxResults.Text = "";
            // 
            // btnGetExperiencedMages
            // 
            btnGetExperiencedMages.Location = new Point(6, 17);
            btnGetExperiencedMages.Name = "btnGetExperiencedMages";
            btnGetExperiencedMages.Size = new Size(173, 29);
            btnGetExperiencedMages.TabIndex = 4;
            btnGetExperiencedMages.Text = "EXPIRIENCED MAGES";
            btnGetExperiencedMages.UseVisualStyleBackColor = true;
            btnGetExperiencedMages.Click += btnGetExperiencedMages_Click;
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(185, 17);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(35, 27);
            txtLevel.TabIndex = 5;
            txtLevel.Text = "7";
            // 
            // btnGetTalentedMages
            // 
            btnGetTalentedMages.Location = new Point(6, 25);
            btnGetTalentedMages.Name = "btnGetTalentedMages";
            btnGetTalentedMages.Size = new Size(173, 29);
            btnGetTalentedMages.TabIndex = 6;
            btnGetTalentedMages.Text = "TALENTED MAGES";
            btnGetTalentedMages.UseVisualStyleBackColor = true;
            btnGetTalentedMages.Click += btnGetTalentedMages_Click;
            // 
            // txtMaxLevel
            // 
            txtMaxLevel.Location = new Point(185, 27);
            txtMaxLevel.Name = "txtMaxLevel";
            txtMaxLevel.Size = new Size(35, 27);
            txtMaxLevel.TabIndex = 7;
            txtMaxLevel.Text = "6";
            // 
            // btnGetTotalBattlePotential
            // 
            btnGetTotalBattlePotential.Location = new Point(323, 336);
            btnGetTotalBattlePotential.Name = "btnGetTotalBattlePotential";
            btnGetTotalBattlePotential.Size = new Size(196, 29);
            btnGetTotalBattlePotential.TabIndex = 8;
            btnGetTotalBattlePotential.Text = "BATTLE POTENTIAL";
            btnGetTotalBattlePotential.UseVisualStyleBackColor = true;
            btnGetTotalBattlePotential.Click += btnGetTotalBattlePotential_Click;
            // 
            // btnGetMagesWithArsenal
            // 
            btnGetMagesWithArsenal.Location = new Point(6, 20);
            btnGetMagesWithArsenal.Name = "btnGetMagesWithArsenal";
            btnGetMagesWithArsenal.Size = new Size(173, 29);
            btnGetMagesWithArsenal.TabIndex = 9;
            btnGetMagesWithArsenal.Text = "BIG ARSENAL";
            btnGetMagesWithArsenal.UseVisualStyleBackColor = true;
            btnGetMagesWithArsenal.Click += btnGetMagesWithArsenal_Click;
            // 
            // txtMinSpells
            // 
            txtMinSpells.BackColor = SystemColors.Window;
            txtMinSpells.Location = new Point(185, 20);
            txtMinSpells.Name = "txtMinSpells";
            txtMinSpells.Size = new Size(35, 27);
            txtMinSpells.TabIndex = 10;
            txtMinSpells.Text = "3";
            // 
            // btnGetVersatileMages
            // 
            btnGetVersatileMages.Location = new Point(323, 275);
            btnGetVersatileMages.Name = "btnGetVersatileMages";
            btnGetVersatileMages.Size = new Size(196, 29);
            btnGetVersatileMages.TabIndex = 11;
            btnGetVersatileMages.Text = "AVR GOOD";
            btnGetVersatileMages.UseVisualStyleBackColor = true;
            btnGetVersatileMages.Click += btnGetVersatileMages_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 213);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnGetTalentedMages);
            groupBox4.Controls.Add(txtMaxLevel);
            groupBox4.Location = new Point(6, 145);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(234, 62);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGetExperiencedMages);
            groupBox3.Controls.Add(txtLevel);
            groupBox3.Location = new Point(6, 85);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 54);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMinSpells);
            groupBox2.Controls.Add(btnGetMagesWithArsenal);
            groupBox2.Location = new Point(6, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 58);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnGetUniqueSpells
            // 
            btnGetUniqueSpells.Location = new Point(525, 275);
            btnGetUniqueSpells.Name = "btnGetUniqueSpells";
            btnGetUniqueSpells.Size = new Size(196, 29);
            btnGetUniqueSpells.TabIndex = 13;
            btnGetUniqueSpells.Text = "UNIQUE SPELLS";
            btnGetUniqueSpells.UseVisualStyleBackColor = true;
            btnGetUniqueSpells.Click += btnGetUniqueSpells_Click;
            // 
            // btnCheckIfAnyoneLostConsciousness
            // 
            btnCheckIfAnyoneLostConsciousness.Location = new Point(525, 336);
            btnCheckIfAnyoneLostConsciousness.Name = "btnCheckIfAnyoneLostConsciousness";
            btnCheckIfAnyoneLostConsciousness.Size = new Size(196, 29);
            btnCheckIfAnyoneLostConsciousness.TabIndex = 14;
            btnCheckIfAnyoneLostConsciousness.Text = "AM I OK?";
            btnCheckIfAnyoneLostConsciousness.UseVisualStyleBackColor = true;
            btnCheckIfAnyoneLostConsciousness.Click += btnCheckIfAnyoneLostConsciousness_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 25, 10);
            ClientSize = new Size(1218, 450);
            Controls.Add(btnCheckIfAnyoneLostConsciousness);
            Controls.Add(btnGetUniqueSpells);
            Controls.Add(groupBox1);
            Controls.Add(btnGetVersatileMages);
            Controls.Add(btnGetTotalBattlePotential);
            Controls.Add(richTextBoxResults);
            Controls.Add(allMagesButton);
            ForeColor = SystemColors.WindowText;
            Name = "Form1";
            Text = "Siszarpowo";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button allMagesButton;
        private RichTextBox richTextBoxResults;
        private Button btnGetExperiencedMages;
        private TextBox txtLevel;
        private Button btnGetTalentedMages;
        private TextBox txtMaxLevel;
        private Button btnGetTotalBattlePotential;
        private Button btnGetMagesWithArsenal;
        private TextBox txtMinSpells;
        private Button btnGetVersatileMages;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnGetUniqueSpells;
        private Button btnCheckIfAnyoneLostConsciousness;
    }
}
