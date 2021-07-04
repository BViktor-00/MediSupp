
namespace MediSupp
{
    partial class BetegekPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.betegadatfrissites_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.betegadatmodositas_bt = new System.Windows.Forms.Button();
            this.betegtorles_bt = new System.Windows.Forms.Button();
            this.BetegDataList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betegnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szulhely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szulido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tajszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetegDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BetegDataList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.67359F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.341246F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 674);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logó szöveg vagy valami";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.betegadatfrissites_bt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.betegadatmodositas_bt, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.betegtorles_bt, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 643);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // betegadatfrissites_bt
            // 
            this.betegadatfrissites_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.betegadatfrissites_bt.Location = new System.Drawing.Point(192, 3);
            this.betegadatfrissites_bt.Name = "betegadatfrissites_bt";
            this.betegadatfrissites_bt.Size = new System.Drawing.Size(183, 22);
            this.betegadatfrissites_bt.TabIndex = 3;
            this.betegadatfrissites_bt.Text = "Adatok frissítése";
            this.betegadatfrissites_bt.UseVisualStyleBackColor = true;
            this.betegadatfrissites_bt.Click += new System.EventHandler(this.betegadatfrissites_bt_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Új Beteg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // betegadatmodositas_bt
            // 
            this.betegadatmodositas_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.betegadatmodositas_bt.Location = new System.Drawing.Point(381, 3);
            this.betegadatmodositas_bt.Name = "betegadatmodositas_bt";
            this.betegadatmodositas_bt.Size = new System.Drawing.Size(183, 22);
            this.betegadatmodositas_bt.TabIndex = 1;
            this.betegadatmodositas_bt.Text = "Módosítás";
            this.betegadatmodositas_bt.UseVisualStyleBackColor = true;
            this.betegadatmodositas_bt.Click += new System.EventHandler(this.betegadatmodositas_bt_Click);
            // 
            // betegtorles_bt
            // 
            this.betegtorles_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.betegtorles_bt.Location = new System.Drawing.Point(570, 3);
            this.betegtorles_bt.Name = "betegtorles_bt";
            this.betegtorles_bt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.betegtorles_bt.Size = new System.Drawing.Size(183, 22);
            this.betegtorles_bt.TabIndex = 2;
            this.betegtorles_bt.Text = "Beteg törlése";
            this.betegtorles_bt.UseVisualStyleBackColor = true;
            this.betegtorles_bt.Click += new System.EventHandler(this.betegtorles_bt_Click);
            // 
            // BetegDataList
            // 
            this.BetegDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BetegDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.betegnev,
            this.szulhely,
            this.szulido,
            this.tajszam});
            this.BetegDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BetegDataList.Location = new System.Drawing.Point(3, 104);
            this.BetegDataList.Name = "BetegDataList";
            this.BetegDataList.Size = new System.Drawing.Size(756, 530);
            this.BetegDataList.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // betegnev
            // 
            this.betegnev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.betegnev.HeaderText = "Beteg neve";
            this.betegnev.Name = "betegnev";
            this.betegnev.ReadOnly = true;
            // 
            // szulhely
            // 
            this.szulhely.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szulhely.HeaderText = "Születési hely";
            this.szulhely.Name = "szulhely";
            this.szulhely.ReadOnly = true;
            // 
            // szulido
            // 
            this.szulido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szulido.HeaderText = "Születési idő";
            this.szulido.Name = "szulido";
            this.szulido.ReadOnly = true;
            // 
            // tajszam
            // 
            this.tajszam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tajszam.HeaderText = "Tajszám";
            this.tajszam.Name = "tajszam";
            this.tajszam.ReadOnly = true;
            // 
            // BetegekPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BetegekPanel";
            this.Size = new System.Drawing.Size(762, 674);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BetegDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button betegadatmodositas_bt;
        private System.Windows.Forms.Button betegtorles_bt;
        private System.Windows.Forms.DataGridView BetegDataList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn betegnev;
        private System.Windows.Forms.DataGridViewTextBoxColumn szulhely;
        private System.Windows.Forms.DataGridViewTextBoxColumn szulido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tajszam;
        private System.Windows.Forms.Button betegadatfrissites_bt;
    }
}
