
namespace MediSupp.Panels
{
    partial class AktivBetegekPanel
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.betegtajkeres_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.betegadatkereses_bt = new System.Windows.Forms.Button();
            this.BetegAdatModositas_bt = new System.Windows.Forms.Button();
            this.BetegAdatFrissites_bt = new System.Windows.Forms.Button();
            this.UjAktivBetegFelvetele_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AktivBetegDataGrid = new System.Windows.Forms.DataGridView();
            this.betegtajszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betegneve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezeloorvos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felvetelideje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AktivBetegDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.62989F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.37011F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel4.Controls.Add(this.betegtajkeres_txb, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.betegadatkereses_bt, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 11);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(751, 52);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // betegtajkeres_txb
            // 
            this.betegtajkeres_txb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.betegtajkeres_txb.Location = new System.Drawing.Point(191, 29);
            this.betegtajkeres_txb.Name = "betegtajkeres_txb";
            this.betegtajkeres_txb.Size = new System.Drawing.Size(365, 20);
            this.betegtajkeres_txb.TabIndex = 6;
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
            this.label5.Text = "Beteg tajszáma:";
            // 
            // betegadatkereses_bt
            // 
            this.betegadatkereses_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.betegadatkereses_bt.Location = new System.Drawing.Point(562, 29);
            this.betegadatkereses_bt.Name = "betegadatkereses_bt";
            this.betegadatkereses_bt.Size = new System.Drawing.Size(186, 20);
            this.betegadatkereses_bt.TabIndex = 7;
            this.betegadatkereses_bt.Text = "Keres";
            this.betegadatkereses_bt.UseVisualStyleBackColor = true;
            this.betegadatkereses_bt.Click += new System.EventHandler(this.betegadatkereses_bt_Click);
            // 
            // BetegAdatModositas_bt
            // 
            this.BetegAdatModositas_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BetegAdatModositas_bt.Location = new System.Drawing.Point(377, 6);
            this.BetegAdatModositas_bt.Name = "BetegAdatModositas_bt";
            this.BetegAdatModositas_bt.Size = new System.Drawing.Size(181, 22);
            this.BetegAdatModositas_bt.TabIndex = 5;
            this.BetegAdatModositas_bt.Text = "Módosítás";
            this.BetegAdatModositas_bt.UseVisualStyleBackColor = true;
            // 
            // BetegAdatFrissites_bt
            // 
            this.BetegAdatFrissites_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BetegAdatFrissites_bt.Location = new System.Drawing.Point(190, 6);
            this.BetegAdatFrissites_bt.Name = "BetegAdatFrissites_bt";
            this.BetegAdatFrissites_bt.Size = new System.Drawing.Size(181, 22);
            this.BetegAdatFrissites_bt.TabIndex = 4;
            this.BetegAdatFrissites_bt.Text = "Adatok frissítése";
            this.BetegAdatFrissites_bt.UseVisualStyleBackColor = true;
            this.BetegAdatFrissites_bt.Click += new System.EventHandler(this.BetegAdatFrissites_bt_Click);
            // 
            // UjAktivBetegFelvetele_bt
            // 
            this.UjAktivBetegFelvetele_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UjAktivBetegFelvetele_bt.Location = new System.Drawing.Point(3, 6);
            this.UjAktivBetegFelvetele_bt.Name = "UjAktivBetegFelvetele_bt";
            this.UjAktivBetegFelvetele_bt.Size = new System.Drawing.Size(181, 22);
            this.UjAktivBetegFelvetele_bt.TabIndex = 1;
            this.UjAktivBetegFelvetele_bt.Text = "Új beteg felvétele";
            this.UjAktivBetegFelvetele_bt.UseVisualStyleBackColor = true;
            this.UjAktivBetegFelvetele_bt.Click += new System.EventHandler(this.UjAktivBetegFelvetele_bt_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.BetegAdatModositas_bt, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BetegAdatFrissites_bt, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.UjAktivBetegFelvetele_bt, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(751, 31);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.21053F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.78947F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(757, 103);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AktivBetegDataGrid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32047F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.30564F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.522255F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 673);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AktivBetegDataGrid
            // 
            this.AktivBetegDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AktivBetegDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.betegtajszam,
            this.betegneve,
            this.kezeloorvos,
            this.felvetelideje});
            this.AktivBetegDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AktivBetegDataGrid.Location = new System.Drawing.Point(3, 112);
            this.AktivBetegDataGrid.Name = "AktivBetegDataGrid";
            this.AktivBetegDataGrid.Size = new System.Drawing.Size(757, 540);
            this.AktivBetegDataGrid.TabIndex = 1;
            // 
            // betegtajszam
            // 
            this.betegtajszam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.betegtajszam.HeaderText = "Beteg tajszáma";
            this.betegtajszam.Name = "betegtajszam";
            this.betegtajszam.ReadOnly = true;
            // 
            // betegneve
            // 
            this.betegneve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.betegneve.HeaderText = "Beteg neve";
            this.betegneve.Name = "betegneve";
            // 
            // kezeloorvos
            // 
            this.kezeloorvos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kezeloorvos.HeaderText = "Kezelő orvos";
            this.kezeloorvos.Name = "kezeloorvos";
            this.kezeloorvos.ReadOnly = true;
            // 
            // felvetelideje
            // 
            this.felvetelideje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.felvetelideje.HeaderText = "Felvétel ideje";
            this.felvetelideje.Name = "felvetelideje";
            this.felvetelideje.ReadOnly = true;
            // 
            // AktivBetegekPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AktivBetegekPanel";
            this.Size = new System.Drawing.Size(763, 673);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AktivBetegDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox betegtajkeres_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button betegadatkereses_bt;
        private System.Windows.Forms.Button BetegAdatModositas_bt;
        private System.Windows.Forms.Button BetegAdatFrissites_bt;
        private System.Windows.Forms.Button UjAktivBetegFelvetele_bt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView AktivBetegDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn betegtajszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn betegneve;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezeloorvos;
        private System.Windows.Forms.DataGridViewTextBoxColumn felvetelideje;
    }
}
