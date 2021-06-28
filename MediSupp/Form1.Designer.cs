
namespace MediSupp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.felh_nev = new System.Windows.Forms.Label();
            this.jelszo_lb = new System.Windows.Forms.Label();
            this.felhasznalonev_txb = new System.Windows.Forms.TextBox();
            this.jelszo_txb = new System.Windows.Forms.TextBox();
            this.belepes_bt = new System.Windows.Forms.Button();
            this.regisztracio_bt = new System.Windows.Forms.Button();
            this.kilep_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 164);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.87013F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.12987F));
            this.tableLayoutPanel2.Controls.Add(this.felh_nev, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.jelszo_lb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.felhasznalonev_txb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.jelszo_txb, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 125);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.belepes_bt, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.regisztracio_bt, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.kilep_bt, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 134);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(389, 27);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // felh_nev
            // 
            this.felh_nev.AutoSize = true;
            this.felh_nev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.felh_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felh_nev.Location = new System.Drawing.Point(3, 46);
            this.felh_nev.Name = "felh_nev";
            this.felh_nev.Size = new System.Drawing.Size(110, 16);
            this.felh_nev.TabIndex = 0;
            this.felh_nev.Text = "Felhasználónév:";
            // 
            // jelszo_lb
            // 
            this.jelszo_lb.AutoSize = true;
            this.jelszo_lb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jelszo_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jelszo_lb.Location = new System.Drawing.Point(3, 109);
            this.jelszo_lb.Name = "jelszo_lb";
            this.jelszo_lb.Size = new System.Drawing.Size(110, 16);
            this.jelszo_lb.TabIndex = 1;
            this.jelszo_lb.Text = "Jelszó:";
            // 
            // felhasznalonev_txb
            // 
            this.felhasznalonev_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.felhasznalonev_txb.Location = new System.Drawing.Point(119, 39);
            this.felhasznalonev_txb.Name = "felhasznalonev_txb";
            this.felhasznalonev_txb.Size = new System.Drawing.Size(267, 20);
            this.felhasznalonev_txb.TabIndex = 2;
            // 
            // jelszo_txb
            // 
            this.jelszo_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.jelszo_txb.Location = new System.Drawing.Point(119, 102);
            this.jelszo_txb.Name = "jelszo_txb";
            this.jelszo_txb.Size = new System.Drawing.Size(267, 20);
            this.jelszo_txb.TabIndex = 3;
            // 
            // belepes_bt
            // 
            this.belepes_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.belepes_bt.Location = new System.Drawing.Point(3, 3);
            this.belepes_bt.Name = "belepes_bt";
            this.belepes_bt.Size = new System.Drawing.Size(123, 21);
            this.belepes_bt.TabIndex = 0;
            this.belepes_bt.Text = "Belépés";
            this.belepes_bt.UseVisualStyleBackColor = true;
            this.belepes_bt.Click += new System.EventHandler(this.belepes_bt_Click);
            // 
            // regisztracio_bt
            // 
            this.regisztracio_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regisztracio_bt.Location = new System.Drawing.Point(132, 3);
            this.regisztracio_bt.Name = "regisztracio_bt";
            this.regisztracio_bt.Size = new System.Drawing.Size(123, 21);
            this.regisztracio_bt.TabIndex = 1;
            this.regisztracio_bt.Text = "Regisztráció";
            this.regisztracio_bt.UseVisualStyleBackColor = true;
            // 
            // kilep_bt
            // 
            this.kilep_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kilep_bt.Location = new System.Drawing.Point(261, 3);
            this.kilep_bt.Name = "kilep_bt";
            this.kilep_bt.Size = new System.Drawing.Size(125, 21);
            this.kilep_bt.TabIndex = 2;
            this.kilep_bt.Text = "Kilép";
            this.kilep_bt.UseVisualStyleBackColor = true;
            this.kilep_bt.Click += new System.EventHandler(this.kilep_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 164);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label felh_nev;
        private System.Windows.Forms.Label jelszo_lb;
        private System.Windows.Forms.TextBox felhasznalonev_txb;
        private System.Windows.Forms.TextBox jelszo_txb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button belepes_bt;
        private System.Windows.Forms.Button regisztracio_bt;
        private System.Windows.Forms.Button kilep_bt;
    }
}

