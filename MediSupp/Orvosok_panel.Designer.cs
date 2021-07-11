
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.orvosadatfrissites_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.orvosadatmodositas_bt = new System.Windows.Forms.Button();
            this.orvostorles_bt = new System.Windows.Forms.Button();
            this.DataListOrvosok = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orvosneve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szakterulet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailcim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pecsetszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betegek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListOrvosok)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DataListOrvosok, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.67359F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.341246F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 674);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.orvosadatfrissites_bt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.orvosadatmodositas_bt, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.orvostorles_bt, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 643);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // orvosadatfrissites_bt
            // 
            this.orvosadatfrissites_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orvosadatfrissites_bt.Location = new System.Drawing.Point(192, 3);
            this.orvosadatfrissites_bt.Name = "orvosadatfrissites_bt";
            this.orvosadatfrissites_bt.Size = new System.Drawing.Size(183, 22);
            this.orvosadatfrissites_bt.TabIndex = 3;
            this.orvosadatfrissites_bt.Text = "Adatok frissítése";
            this.orvosadatfrissites_bt.UseVisualStyleBackColor = true;
            this.orvosadatfrissites_bt.Click += new System.EventHandler(this.orvosadatfrissites_bt_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Új Orvos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orvosadatmodositas_bt
            // 
            this.orvosadatmodositas_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orvosadatmodositas_bt.Location = new System.Drawing.Point(381, 3);
            this.orvosadatmodositas_bt.Name = "orvosadatmodositas_bt";
            this.orvosadatmodositas_bt.Size = new System.Drawing.Size(183, 22);
            this.orvosadatmodositas_bt.TabIndex = 1;
            this.orvosadatmodositas_bt.Text = "Módosítás";
            this.orvosadatmodositas_bt.UseVisualStyleBackColor = true;
            this.orvosadatmodositas_bt.Click += new System.EventHandler(this.orvosadatmodositas_bt_Click);
            // 
            // orvostorles_bt
            // 
            this.orvostorles_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orvostorles_bt.Location = new System.Drawing.Point(570, 3);
            this.orvostorles_bt.Name = "orvostorles_bt";
            this.orvostorles_bt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orvostorles_bt.Size = new System.Drawing.Size(183, 22);
            this.orvostorles_bt.TabIndex = 2;
            this.orvostorles_bt.Text = "Orvos törlése";
            this.orvostorles_bt.UseVisualStyleBackColor = true;
            this.orvostorles_bt.Click += new System.EventHandler(this.orvostorles_bt_Click);
            // 
            // DataListOrvosok
            // 
            this.DataListOrvosok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListOrvosok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.orvosneve,
            this.szakterulet,
            this.emailcim,
            this.pecsetszam,
            this.betegek});
            this.DataListOrvosok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataListOrvosok.Location = new System.Drawing.Point(3, 104);
            this.DataListOrvosok.Name = "DataListOrvosok";
            this.DataListOrvosok.Size = new System.Drawing.Size(756, 530);
            this.DataListOrvosok.TabIndex = 1;
            this.DataListOrvosok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListOrvosok_CellContentClick);
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
            // betegek
            // 
            this.betegek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.betegek.HeaderText = "Betegek";
            this.betegek.Name = "betegek";
            this.betegek.ReadOnly = true;
            // 
            // Orvosok_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Orvosok_panel";
            this.Size = new System.Drawing.Size(762, 674);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataListOrvosok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button orvosadatmodositas_bt;
        private System.Windows.Forms.Button orvostorles_bt;
        public System.Windows.Forms.DataGridView DataListOrvosok;
        private System.Windows.Forms.Button orvosadatfrissites_bt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orvosneve;
        private System.Windows.Forms.DataGridViewTextBoxColumn szakterulet;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcim;
        private System.Windows.Forms.DataGridViewTextBoxColumn pecsetszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn betegek;
    }
}
