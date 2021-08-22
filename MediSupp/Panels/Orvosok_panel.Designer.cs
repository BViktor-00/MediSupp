
namespace MediSupp
{
    partial class Orvosok_panel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataListOrvosok = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.keresettorvos_txb = new System.Windows.Forms.TextBox();
            this.orvoskeresvegrehajt_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.OrvosTorlese_bt = new System.Windows.Forms.Button();
            this.OrvosAdatModositas_bt = new System.Windows.Forms.Button();
            this.AdatokFrissitese_bt = new System.Windows.Forms.Button();
            this.UjOrvos_bt = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orvosneve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szakterulet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailcim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pecsetszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListOrvosok)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DataListOrvosok, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.46884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.30564F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.077151F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 674);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DataListOrvosok
            // 
            this.DataListOrvosok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListOrvosok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.orvosneve,
            this.szakterulet,
            this.emailcim,
            this.pecsetszam});
            this.DataListOrvosok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataListOrvosok.Location = new System.Drawing.Point(3, 114);
            this.DataListOrvosok.Name = "DataListOrvosok";
            this.DataListOrvosok.Size = new System.Drawing.Size(756, 542);
            this.DataListOrvosok.TabIndex = 1;
            this.DataListOrvosok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListOrvosok_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.21053F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.78947F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(756, 105);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.62989F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.37011F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.keresettorvos_txb, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.orvoskeresvegrehajt_bt, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(750, 52);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Keresett orvos pecsétszáma:";
            // 
            // keresettorvos_txb
            // 
            this.keresettorvos_txb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.keresettorvos_txb.Location = new System.Drawing.Point(191, 29);
            this.keresettorvos_txb.Name = "keresettorvos_txb";
            this.keresettorvos_txb.Size = new System.Drawing.Size(365, 20);
            this.keresettorvos_txb.TabIndex = 2;
            // 
            // orvoskeresvegrehajt_bt
            // 
            this.orvoskeresvegrehajt_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orvoskeresvegrehajt_bt.Location = new System.Drawing.Point(562, 29);
            this.orvoskeresvegrehajt_bt.Name = "orvoskeresvegrehajt_bt";
            this.orvoskeresvegrehajt_bt.Size = new System.Drawing.Size(185, 20);
            this.orvoskeresvegrehajt_bt.TabIndex = 3;
            this.orvoskeresvegrehajt_bt.Text = "Keres";
            this.orvoskeresvegrehajt_bt.UseVisualStyleBackColor = true;
            this.orvoskeresvegrehajt_bt.Click += new System.EventHandler(this.orvoskeresvegrehajt_bt_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.OrvosTorlese_bt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.OrvosAdatModositas_bt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.AdatokFrissitese_bt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.UjOrvos_bt, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(750, 32);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // OrvosTorlese_bt
            // 
            this.OrvosTorlese_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrvosTorlese_bt.Location = new System.Drawing.Point(377, 7);
            this.OrvosTorlese_bt.Name = "OrvosTorlese_bt";
            this.OrvosTorlese_bt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrvosTorlese_bt.Size = new System.Drawing.Size(181, 22);
            this.OrvosTorlese_bt.TabIndex = 6;
            this.OrvosTorlese_bt.Text = "Orvos törlése";
            this.OrvosTorlese_bt.UseVisualStyleBackColor = true;
            this.OrvosTorlese_bt.Click += new System.EventHandler(this.OrvosTorlese_bt_Click);
            // 
            // OrvosAdatModositas_bt
            // 
            this.OrvosAdatModositas_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrvosAdatModositas_bt.Location = new System.Drawing.Point(564, 7);
            this.OrvosAdatModositas_bt.Name = "OrvosAdatModositas_bt";
            this.OrvosAdatModositas_bt.Size = new System.Drawing.Size(183, 22);
            this.OrvosAdatModositas_bt.TabIndex = 5;
            this.OrvosAdatModositas_bt.Text = "Módosítás";
            this.OrvosAdatModositas_bt.UseVisualStyleBackColor = true;
            this.OrvosAdatModositas_bt.Click += new System.EventHandler(this.OrvosAdatModositas_bt_Click_1);
            // 
            // AdatokFrissitese_bt
            // 
            this.AdatokFrissitese_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdatokFrissitese_bt.Location = new System.Drawing.Point(3, 7);
            this.AdatokFrissitese_bt.Name = "AdatokFrissitese_bt";
            this.AdatokFrissitese_bt.Size = new System.Drawing.Size(181, 22);
            this.AdatokFrissitese_bt.TabIndex = 4;
            this.AdatokFrissitese_bt.Text = "Adatok frissítése";
            this.AdatokFrissitese_bt.UseVisualStyleBackColor = true;
            this.AdatokFrissitese_bt.Click += new System.EventHandler(this.AdatokFrissitese_bt_Click);
            // 
            // UjOrvos_bt
            // 
            this.UjOrvos_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UjOrvos_bt.Location = new System.Drawing.Point(190, 7);
            this.UjOrvos_bt.Name = "UjOrvos_bt";
            this.UjOrvos_bt.Size = new System.Drawing.Size(181, 22);
            this.UjOrvos_bt.TabIndex = 1;
            this.UjOrvos_bt.Text = "Új Orvos";
            this.UjOrvos_bt.UseVisualStyleBackColor = true;
            this.UjOrvos_bt.Click += new System.EventHandler(this.UjOrvos_bt_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // orvosneve
            // 
            this.orvosneve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orvosneve.HeaderText = "Orvos Neve";
            this.orvosneve.Name = "orvosneve";
            this.orvosneve.ReadOnly = true;
            // 
            // szakterulet
            // 
            this.szakterulet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szakterulet.HeaderText = "Szakterület";
            this.szakterulet.Name = "szakterulet";
            this.szakterulet.ReadOnly = true;
            // 
            // emailcim
            // 
            this.emailcim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailcim.HeaderText = "Email cím";
            this.emailcim.Name = "emailcim";
            this.emailcim.ReadOnly = true;
            // 
            // pecsetszam
            // 
            this.pecsetszam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pecsetszam.HeaderText = "Orvosi pecsétszám";
            this.pecsetszam.Name = "pecsetszam";
            this.pecsetszam.ReadOnly = true;
            // 
            // Orvosok_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Orvosok_panel";
            this.Size = new System.Drawing.Size(762, 674);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataListOrvosok)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView DataListOrvosok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button OrvosTorlese_bt;
        private System.Windows.Forms.Button OrvosAdatModositas_bt;
        private System.Windows.Forms.Button AdatokFrissitese_bt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keresettorvos_txb;
        private System.Windows.Forms.Button orvoskeresvegrehajt_bt;
        private System.Windows.Forms.Button UjOrvos_bt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orvosneve;
        private System.Windows.Forms.DataGridViewTextBoxColumn szakterulet;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcim;
        private System.Windows.Forms.DataGridViewTextBoxColumn pecsetszam;
    }
}
