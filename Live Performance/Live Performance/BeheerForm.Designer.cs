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
            this.tpMissieToevoegen = new System.Windows.Forms.TabPage();
            this.gbMissie = new System.Windows.Forms.GroupBox();
            this.rbtnSIN = new System.Windows.Forms.RadioButton();
            this.rbtnHOPE = new System.Windows.Forms.RadioButton();
            this.btnCancelMissieProfiel = new System.Windows.Forms.Button();
            this.btnSelecteerMissieProfiel = new System.Windows.Forms.Button();
            this.gbHOPE = new System.Windows.Forms.GroupBox();
            this.gbSIN = new System.Windows.Forms.GroupBox();
            this.lblDbBoot = new System.Windows.Forms.Label();
            this.btnDichtstBijzijndeBoot = new System.Windows.Forms.Button();
            this.nudYco = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudXco = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVerwijderGekozenMateriaal = new System.Windows.Forms.Button();
            this.btnKiesMateriaal = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbGekozenMateriaal = new System.Windows.Forms.ListBox();
            this.lbMateriaal = new System.Windows.Forms.ListBox();
            this.btnVerwijderGekozenPersoon = new System.Windows.Forms.Button();
            this.btnKiesPersoon = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbGekozenPersonen = new System.Windows.Forms.ListBox();
            this.lbPersonen = new System.Windows.Forms.ListBox();
            this.tbMissieSoort = new System.Windows.Forms.TextBox();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStartDatumTijd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDatum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMissieProfielMateriaal = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMissieProfielBemanning = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMissieProfielen = new System.Windows.Forms.ListBox();
            this.tpMissieBeheer = new System.Windows.Forms.TabPage();
            this.btnVerwijderMissie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMissies = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpMissieToevoegen.SuspendLayout();
            this.gbMissie.SuspendLayout();
            this.gbSIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXco)).BeginInit();
            this.tpMissieBeheer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMissieToevoegen);
            this.tabControl1.Controls.Add(this.tpMissieBeheer);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1346, 1001);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMissieToevoegen
            // 
            this.tpMissieToevoegen.Controls.Add(this.gbMissie);
            this.tpMissieToevoegen.Controls.Add(this.btnCancelMissieProfiel);
            this.tpMissieToevoegen.Controls.Add(this.btnSelecteerMissieProfiel);
            this.tpMissieToevoegen.Controls.Add(this.gbHOPE);
            this.tpMissieToevoegen.Controls.Add(this.gbSIN);
            this.tpMissieToevoegen.Controls.Add(this.label5);
            this.tpMissieToevoegen.Controls.Add(this.label4);
            this.tpMissieToevoegen.Controls.Add(this.lbMissieProfielMateriaal);
            this.tpMissieToevoegen.Controls.Add(this.label3);
            this.tpMissieToevoegen.Controls.Add(this.lbMissieProfielBemanning);
            this.tpMissieToevoegen.Controls.Add(this.label2);
            this.tpMissieToevoegen.Controls.Add(this.lbMissieProfielen);
            this.tpMissieToevoegen.Location = new System.Drawing.Point(4, 25);
            this.tpMissieToevoegen.Name = "tpMissieToevoegen";
            this.tpMissieToevoegen.Padding = new System.Windows.Forms.Padding(3);
            this.tpMissieToevoegen.Size = new System.Drawing.Size(1338, 972);
            this.tpMissieToevoegen.TabIndex = 2;
            this.tpMissieToevoegen.Text = "Missie Toevoegen";
            this.tpMissieToevoegen.UseVisualStyleBackColor = true;
            // 
            // gbMissie
            // 
            this.gbMissie.Controls.Add(this.rbtnSIN);
            this.gbMissie.Controls.Add(this.rbtnHOPE);
            this.gbMissie.Location = new System.Drawing.Point(410, 221);
            this.gbMissie.Name = "gbMissie";
            this.gbMissie.Size = new System.Drawing.Size(235, 44);
            this.gbMissie.TabIndex = 19;
            this.gbMissie.TabStop = false;
            this.gbMissie.Text = "Selecteer je missie";
            // 
            // rbtnSIN
            // 
            this.rbtnSIN.AutoSize = true;
            this.rbtnSIN.Location = new System.Drawing.Point(6, 18);
            this.rbtnSIN.Name = "rbtnSIN";
            this.rbtnSIN.Size = new System.Drawing.Size(94, 21);
            this.rbtnSIN.TabIndex = 1;
            this.rbtnSIN.TabStop = true;
            this.rbtnSIN.Text = "SIN Missie";
            this.rbtnSIN.UseVisualStyleBackColor = true;
            // 
            // rbtnHOPE
            // 
            this.rbtnHOPE.AutoSize = true;
            this.rbtnHOPE.Location = new System.Drawing.Point(106, 18);
            this.rbtnHOPE.Name = "rbtnHOPE";
            this.rbtnHOPE.Size = new System.Drawing.Size(111, 21);
            this.rbtnHOPE.TabIndex = 16;
            this.rbtnHOPE.TabStop = true;
            this.rbtnHOPE.Text = "HOPE Missie";
            this.rbtnHOPE.UseVisualStyleBackColor = true;
            // 
            // btnCancelMissieProfiel
            // 
            this.btnCancelMissieProfiel.Location = new System.Drawing.Point(553, 266);
            this.btnCancelMissieProfiel.Name = "btnCancelMissieProfiel";
            this.btnCancelMissieProfiel.Size = new System.Drawing.Size(124, 54);
            this.btnCancelMissieProfiel.TabIndex = 18;
            this.btnCancelMissieProfiel.Text = "Cancel MissieProfiel";
            this.btnCancelMissieProfiel.UseVisualStyleBackColor = true;
            this.btnCancelMissieProfiel.Click += new System.EventHandler(this.btnCancelMissieProfiel_Click);
            // 
            // btnSelecteerMissieProfiel
            // 
            this.btnSelecteerMissieProfiel.Location = new System.Drawing.Point(373, 266);
            this.btnSelecteerMissieProfiel.Name = "btnSelecteerMissieProfiel";
            this.btnSelecteerMissieProfiel.Size = new System.Drawing.Size(124, 54);
            this.btnSelecteerMissieProfiel.TabIndex = 17;
            this.btnSelecteerMissieProfiel.Text = "Selecteer MissieProfiel";
            this.btnSelecteerMissieProfiel.UseVisualStyleBackColor = true;
            this.btnSelecteerMissieProfiel.Click += new System.EventHandler(this.btnSelecteerMissieProfiel_Click);
            // 
            // gbHOPE
            // 
            this.gbHOPE.Location = new System.Drawing.Point(804, 316);
            this.gbHOPE.Name = "gbHOPE";
            this.gbHOPE.Size = new System.Drawing.Size(464, 340);
            this.gbHOPE.TabIndex = 15;
            this.gbHOPE.TabStop = false;
            this.gbHOPE.Text = "HOPE Missie";
            // 
            // gbSIN
            // 
            this.gbSIN.Controls.Add(this.lblDbBoot);
            this.gbSIN.Controls.Add(this.btnDichtstBijzijndeBoot);
            this.gbSIN.Controls.Add(this.nudYco);
            this.gbSIN.Controls.Add(this.label14);
            this.gbSIN.Controls.Add(this.nudXco);
            this.gbSIN.Controls.Add(this.label13);
            this.gbSIN.Controls.Add(this.btnVerwijderGekozenMateriaal);
            this.gbSIN.Controls.Add(this.btnKiesMateriaal);
            this.gbSIN.Controls.Add(this.label12);
            this.gbSIN.Controls.Add(this.label11);
            this.gbSIN.Controls.Add(this.lbGekozenMateriaal);
            this.gbSIN.Controls.Add(this.lbMateriaal);
            this.gbSIN.Controls.Add(this.btnVerwijderGekozenPersoon);
            this.gbSIN.Controls.Add(this.btnKiesPersoon);
            this.gbSIN.Controls.Add(this.label10);
            this.gbSIN.Controls.Add(this.label9);
            this.gbSIN.Controls.Add(this.lbGekozenPersonen);
            this.gbSIN.Controls.Add(this.lbPersonen);
            this.gbSIN.Controls.Add(this.tbMissieSoort);
            this.gbSIN.Controls.Add(this.tbBeschrijving);
            this.gbSIN.Controls.Add(this.label8);
            this.gbSIN.Controls.Add(this.label7);
            this.gbSIN.Controls.Add(this.dtpStartDatumTijd);
            this.gbSIN.Controls.Add(this.label6);
            this.gbSIN.Controls.Add(this.dtpStartDatum);
            this.gbSIN.Location = new System.Drawing.Point(56, 319);
            this.gbSIN.Name = "gbSIN";
            this.gbSIN.Size = new System.Drawing.Size(719, 541);
            this.gbSIN.TabIndex = 14;
            this.gbSIN.TabStop = false;
            this.gbSIN.Text = "SIN Missie";
            // 
            // lblDbBoot
            // 
            this.lblDbBoot.AutoSize = true;
            this.lblDbBoot.Location = new System.Drawing.Point(10, 177);
            this.lblDbBoot.Name = "lblDbBoot";
            this.lblDbBoot.Size = new System.Drawing.Size(45, 17);
            this.lblDbBoot.TabIndex = 24;
            this.lblDbBoot.Text = "Boot: ";
            // 
            // btnDichtstBijzijndeBoot
            // 
            this.btnDichtstBijzijndeBoot.Location = new System.Drawing.Point(401, 121);
            this.btnDichtstBijzijndeBoot.Name = "btnDichtstBijzijndeBoot";
            this.btnDichtstBijzijndeBoot.Size = new System.Drawing.Size(153, 52);
            this.btnDichtstBijzijndeBoot.TabIndex = 23;
            this.btnDichtstBijzijndeBoot.Text = "Zoek Dichtsbijzijnde Boot";
            this.btnDichtstBijzijndeBoot.UseVisualStyleBackColor = true;
            this.btnDichtstBijzijndeBoot.Click += new System.EventHandler(this.btnDichtstBijzijndeBoot_Click);
            // 
            // nudYco
            // 
            this.nudYco.Location = new System.Drawing.Point(301, 137);
            this.nudYco.Name = "nudYco";
            this.nudYco.Size = new System.Drawing.Size(71, 22);
            this.nudYco.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(209, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "x-coördinaat";
            // 
            // nudXco
            // 
            this.nudXco.Location = new System.Drawing.Point(114, 137);
            this.nudXco.Name = "nudXco";
            this.nudXco.Size = new System.Drawing.Size(71, 22);
            this.nudXco.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "x-coördinaat";
            // 
            // btnVerwijderGekozenMateriaal
            // 
            this.btnVerwijderGekozenMateriaal.Location = new System.Drawing.Point(390, 484);
            this.btnVerwijderGekozenMateriaal.Name = "btnVerwijderGekozenMateriaal";
            this.btnVerwijderGekozenMateriaal.Size = new System.Drawing.Size(131, 32);
            this.btnVerwijderGekozenMateriaal.TabIndex = 18;
            this.btnVerwijderGekozenMateriaal.Text = "Verwijder";
            this.btnVerwijderGekozenMateriaal.UseVisualStyleBackColor = true;
            // 
            // btnKiesMateriaal
            // 
            this.btnKiesMateriaal.Location = new System.Drawing.Point(13, 484);
            this.btnKiesMateriaal.Name = "btnKiesMateriaal";
            this.btnKiesMateriaal.Size = new System.Drawing.Size(93, 32);
            this.btnKiesMateriaal.TabIndex = 17;
            this.btnKiesMateriaal.Text = "Kies";
            this.btnKiesMateriaal.UseVisualStyleBackColor = true;
            this.btnKiesMateriaal.Click += new System.EventHandler(this.btnKiesMateriaal_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Gekozen Materiaal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Materiaal";
            // 
            // lbGekozenMateriaal
            // 
            this.lbGekozenMateriaal.FormattingEnabled = true;
            this.lbGekozenMateriaal.ItemHeight = 16;
            this.lbGekozenMateriaal.Location = new System.Drawing.Point(370, 394);
            this.lbGekozenMateriaal.Name = "lbGekozenMateriaal";
            this.lbGekozenMateriaal.Size = new System.Drawing.Size(346, 84);
            this.lbGekozenMateriaal.TabIndex = 14;
            // 
            // lbMateriaal
            // 
            this.lbMateriaal.FormattingEnabled = true;
            this.lbMateriaal.ItemHeight = 16;
            this.lbMateriaal.Location = new System.Drawing.Point(12, 394);
            this.lbMateriaal.Name = "lbMateriaal";
            this.lbMateriaal.Size = new System.Drawing.Size(316, 84);
            this.lbMateriaal.TabIndex = 13;
            // 
            // btnVerwijderGekozenPersoon
            // 
            this.btnVerwijderGekozenPersoon.Location = new System.Drawing.Point(431, 328);
            this.btnVerwijderGekozenPersoon.Name = "btnVerwijderGekozenPersoon";
            this.btnVerwijderGekozenPersoon.Size = new System.Drawing.Size(93, 32);
            this.btnVerwijderGekozenPersoon.TabIndex = 12;
            this.btnVerwijderGekozenPersoon.Text = "Verwijder";
            this.btnVerwijderGekozenPersoon.UseVisualStyleBackColor = true;
            // 
            // btnKiesPersoon
            // 
            this.btnKiesPersoon.Location = new System.Drawing.Point(13, 328);
            this.btnKiesPersoon.Name = "btnKiesPersoon";
            this.btnKiesPersoon.Size = new System.Drawing.Size(93, 32);
            this.btnKiesPersoon.TabIndex = 11;
            this.btnKiesPersoon.Text = "Kies";
            this.btnKiesPersoon.UseVisualStyleBackColor = true;
            this.btnKiesPersoon.Click += new System.EventHandler(this.btnKiesPersoon_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Gekozen Personen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Personen";
            // 
            // lbGekozenPersonen
            // 
            this.lbGekozenPersonen.FormattingEnabled = true;
            this.lbGekozenPersonen.ItemHeight = 16;
            this.lbGekozenPersonen.Location = new System.Drawing.Point(370, 238);
            this.lbGekozenPersonen.Name = "lbGekozenPersonen";
            this.lbGekozenPersonen.Size = new System.Drawing.Size(346, 84);
            this.lbGekozenPersonen.TabIndex = 8;
            // 
            // lbPersonen
            // 
            this.lbPersonen.FormattingEnabled = true;
            this.lbPersonen.ItemHeight = 16;
            this.lbPersonen.Location = new System.Drawing.Point(12, 238);
            this.lbPersonen.Name = "lbPersonen";
            this.lbPersonen.Size = new System.Drawing.Size(316, 84);
            this.lbPersonen.TabIndex = 7;
            // 
            // tbMissieSoort
            // 
            this.tbMissieSoort.Location = new System.Drawing.Point(114, 108);
            this.tbMissieSoort.Name = "tbMissieSoort";
            this.tbMissieSoort.Size = new System.Drawing.Size(100, 22);
            this.tbMissieSoort.TabIndex = 6;
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(114, 80);
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(367, 22);
            this.tbBeschrijving.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Missie Soort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Beschrijving";
            // 
            // dtpStartDatumTijd
            // 
            this.dtpStartDatumTijd.Location = new System.Drawing.Point(367, 52);
            this.dtpStartDatumTijd.Name = "dtpStartDatumTijd";
            this.dtpStartDatumTijd.Size = new System.Drawing.Size(114, 22);
            this.dtpStartDatumTijd.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Start Datum";
            // 
            // dtpStartDatum
            // 
            this.dtpStartDatum.Location = new System.Drawing.Point(114, 52);
            this.dtpStartDatum.Name = "dtpStartDatum";
            this.dtpStartDatum.Size = new System.Drawing.Size(246, 22);
            this.dtpStartDatum.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selecteer een missieprofiel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "MissieProfielMateriaal";
            // 
            // lbMissieProfielMateriaal
            // 
            this.lbMissieProfielMateriaal.FormattingEnabled = true;
            this.lbMissieProfielMateriaal.ItemHeight = 16;
            this.lbMissieProfielMateriaal.Location = new System.Drawing.Point(734, 67);
            this.lbMissieProfielMateriaal.Name = "lbMissieProfielMateriaal";
            this.lbMissieProfielMateriaal.Size = new System.Drawing.Size(371, 148);
            this.lbMissieProfielMateriaal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "MissieProfielBemanning";
            // 
            // lbMissieProfielBemanning
            // 
            this.lbMissieProfielBemanning.FormattingEnabled = true;
            this.lbMissieProfielBemanning.ItemHeight = 16;
            this.lbMissieProfielBemanning.Location = new System.Drawing.Point(357, 67);
            this.lbMissieProfielBemanning.Name = "lbMissieProfielBemanning";
            this.lbMissieProfielBemanning.Size = new System.Drawing.Size(371, 148);
            this.lbMissieProfielBemanning.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "MissieProfielen";
            // 
            // lbMissieProfielen
            // 
            this.lbMissieProfielen.FormattingEnabled = true;
            this.lbMissieProfielen.ItemHeight = 16;
            this.lbMissieProfielen.Location = new System.Drawing.Point(7, 67);
            this.lbMissieProfielen.Name = "lbMissieProfielen";
            this.lbMissieProfielen.Size = new System.Drawing.Size(344, 148);
            this.lbMissieProfielen.TabIndex = 7;
            this.lbMissieProfielen.SelectedIndexChanged += new System.EventHandler(this.lbMissieProfielen_SelectedIndexChanged_1);
            // 
            // tpMissieBeheer
            // 
            this.tpMissieBeheer.Controls.Add(this.btnVerwijderMissie);
            this.tpMissieBeheer.Controls.Add(this.label1);
            this.tpMissieBeheer.Controls.Add(this.lbMissies);
            this.tpMissieBeheer.Location = new System.Drawing.Point(4, 25);
            this.tpMissieBeheer.Name = "tpMissieBeheer";
            this.tpMissieBeheer.Padding = new System.Windows.Forms.Padding(3);
            this.tpMissieBeheer.Size = new System.Drawing.Size(1338, 972);
            this.tpMissieBeheer.TabIndex = 1;
            this.tpMissieBeheer.Text = "Missie Beheer";
            this.tpMissieBeheer.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderMissie
            // 
            this.btnVerwijderMissie.Location = new System.Drawing.Point(8, 179);
            this.btnVerwijderMissie.Name = "btnVerwijderMissie";
            this.btnVerwijderMissie.Size = new System.Drawing.Size(170, 42);
            this.btnVerwijderMissie.TabIndex = 2;
            this.btnVerwijderMissie.Text = "Verwijder";
            this.btnVerwijderMissie.UseVisualStyleBackColor = true;
            this.btnVerwijderMissie.Click += new System.EventHandler(this.btnVerwijderMissie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Missies";
            // 
            // lbMissies
            // 
            this.lbMissies.FormattingEnabled = true;
            this.lbMissies.ItemHeight = 16;
            this.lbMissies.Location = new System.Drawing.Point(8, 25);
            this.lbMissies.Name = "lbMissies";
            this.lbMissies.Size = new System.Drawing.Size(476, 148);
            this.lbMissies.TabIndex = 0;
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 1045);
            this.Controls.Add(this.tabControl1);
            this.Name = "BeheerForm";
            this.Text = "BeheerForm";
            this.tabControl1.ResumeLayout(false);
            this.tpMissieToevoegen.ResumeLayout(false);
            this.tpMissieToevoegen.PerformLayout();
            this.gbMissie.ResumeLayout(false);
            this.gbMissie.PerformLayout();
            this.gbSIN.ResumeLayout(false);
            this.gbSIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXco)).EndInit();
            this.tpMissieBeheer.ResumeLayout(false);
            this.tpMissieBeheer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMissieBeheer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMissies;
        private System.Windows.Forms.TabPage tpMissieToevoegen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbMissieProfielMateriaal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbMissieProfielBemanning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbMissieProfielen;
        private System.Windows.Forms.Button btnSelecteerMissieProfiel;
        private System.Windows.Forms.RadioButton rbtnHOPE;
        private System.Windows.Forms.RadioButton rbtnSIN;
        private System.Windows.Forms.GroupBox gbSIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerwijderMissie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDatum;
        private System.Windows.Forms.DateTimePicker dtpStartDatumTijd;
        private System.Windows.Forms.Button btnVerwijderGekozenPersoon;
        private System.Windows.Forms.Button btnKiesPersoon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbGekozenPersonen;
        private System.Windows.Forms.ListBox lbPersonen;
        private System.Windows.Forms.TextBox tbMissieSoort;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVerwijderGekozenMateriaal;
        private System.Windows.Forms.Button btnKiesMateriaal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbGekozenMateriaal;
        private System.Windows.Forms.ListBox lbMateriaal;
        private System.Windows.Forms.Button btnCancelMissieProfiel;
        private System.Windows.Forms.GroupBox gbMissie;
        private System.Windows.Forms.GroupBox gbHOPE;
        private System.Windows.Forms.NumericUpDown nudYco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudXco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDbBoot;
        private System.Windows.Forms.Button btnDichtstBijzijndeBoot;

    }
}