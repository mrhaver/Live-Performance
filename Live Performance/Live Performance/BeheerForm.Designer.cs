namespace Live_Performance
{
    partial class BeheerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMissieBeheer = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbMissies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMissieProfielen = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMissieProfielBemanning = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpMissieBeheer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMissieBeheer);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1346, 694);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMissieBeheer
            // 
            this.tpMissieBeheer.Controls.Add(this.label3);
            this.tpMissieBeheer.Controls.Add(this.lbMissieProfielBemanning);
            this.tpMissieBeheer.Controls.Add(this.label2);
            this.tpMissieBeheer.Controls.Add(this.lbMissieProfielen);
            this.tpMissieBeheer.Controls.Add(this.label1);
            this.tpMissieBeheer.Controls.Add(this.lbMissies);
            this.tpMissieBeheer.Location = new System.Drawing.Point(4, 25);
            this.tpMissieBeheer.Name = "tpMissieBeheer";
            this.tpMissieBeheer.Padding = new System.Windows.Forms.Padding(3);
            this.tpMissieBeheer.Size = new System.Drawing.Size(1338, 665);
            this.tpMissieBeheer.TabIndex = 1;
            this.tpMissieBeheer.Text = "Missie Beheer";
            this.tpMissieBeheer.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1338, 665);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbMissies
            // 
            this.lbMissies.FormattingEnabled = true;
            this.lbMissies.ItemHeight = 16;
            this.lbMissies.Location = new System.Drawing.Point(6, 235);
            this.lbMissies.Name = "lbMissies";
            this.lbMissies.Size = new System.Drawing.Size(452, 148);
            this.lbMissies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Missies";
            // 
            // lbMissieProfielen
            // 
            this.lbMissieProfielen.FormattingEnabled = true;
            this.lbMissieProfielen.ItemHeight = 16;
            this.lbMissieProfielen.Location = new System.Drawing.Point(6, 45);
            this.lbMissieProfielen.Name = "lbMissieProfielen";
            this.lbMissieProfielen.Size = new System.Drawing.Size(450, 148);
            this.lbMissieProfielen.TabIndex = 1;
            this.lbMissieProfielen.SelectedIndexChanged += new System.EventHandler(this.lbMissieProfielen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "MissieProfielen";
            // 
            // lbMissieProfielBemanning
            // 
            this.lbMissieProfielBemanning.FormattingEnabled = true;
            this.lbMissieProfielBemanning.ItemHeight = 16;
            this.lbMissieProfielBemanning.Location = new System.Drawing.Point(462, 45);
            this.lbMissieProfielBemanning.Name = "lbMissieProfielBemanning";
            this.lbMissieProfielBemanning.Size = new System.Drawing.Size(450, 148);
            this.lbMissieProfielBemanning.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "MissieProfielBemanning";
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 698);
            this.Controls.Add(this.tabControl1);
            this.Name = "BeheerForm";
            this.Text = "BeheerForm";
            this.tabControl1.ResumeLayout(false);
            this.tpMissieBeheer.ResumeLayout(false);
            this.tpMissieBeheer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMissieBeheer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMissies;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbMissieProfielBemanning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbMissieProfielen;

    }
}