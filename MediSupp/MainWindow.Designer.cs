
namespace MediSupp
{
    partial class MainWindow
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
            this.orvosok_szerkesztese_bt = new System.Windows.Forms.Button();
            this.betegek_szerkesztese_bt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.foOldal1 = new MediSupp.FoOldal();
            this.betegekPanel1 = new MediSupp.BetegekPanel();
            this.orvosok1 = new MediSupp.Orvosok();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.7817F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.2183F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 671);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.orvosok_szerkesztese_bt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.betegek_szerkesztese_bt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button5, 0, 5);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(119, 665);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // orvosok_szerkesztese_bt
            // 
            this.orvosok_szerkesztese_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orvosok_szerkesztese_bt.Location = new System.Drawing.Point(3, 3);
            this.orvosok_szerkesztese_bt.Name = "orvosok_szerkesztese_bt";
            this.orvosok_szerkesztese_bt.Size = new System.Drawing.Size(113, 24);
            this.orvosok_szerkesztese_bt.TabIndex = 0;
            this.orvosok_szerkesztese_bt.Text = "Orvosok ";
            this.orvosok_szerkesztese_bt.UseVisualStyleBackColor = true;
            this.orvosok_szerkesztese_bt.Click += new System.EventHandler(this.orvosok_szerkesztese_bt_Click);
            // 
            // betegek_szerkesztese_bt
            // 
            this.betegek_szerkesztese_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betegek_szerkesztese_bt.Location = new System.Drawing.Point(3, 33);
            this.betegek_szerkesztese_bt.Name = "betegek_szerkesztese_bt";
            this.betegek_szerkesztese_bt.Size = new System.Drawing.Size(113, 24);
            this.betegek_szerkesztese_bt.TabIndex = 1;
            this.betegek_szerkesztese_bt.Text = "Betegek";
            this.betegek_szerkesztese_bt.UseVisualStyleBackColor = true;
            this.betegek_szerkesztese_bt.Click += new System.EventHandler(this.betegek_szerkesztese_bt_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 638);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "Kilépés";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.foOldal1);
            this.panel1.Controls.Add(this.betegekPanel1);
            this.panel1.Controls.Add(this.orvosok1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(128, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 665);
            this.panel1.TabIndex = 1;
            // 
            // foOldal1
            // 
            this.foOldal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foOldal1.Location = new System.Drawing.Point(0, 0);
            this.foOldal1.Name = "foOldal1";
            this.foOldal1.Size = new System.Drawing.Size(776, 665);
            this.foOldal1.TabIndex = 2;
            // 
            // betegekPanel1
            // 
            this.betegekPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betegekPanel1.Location = new System.Drawing.Point(0, 0);
            this.betegekPanel1.Name = "betegekPanel1";
            this.betegekPanel1.Size = new System.Drawing.Size(776, 665);
            this.betegekPanel1.TabIndex = 1;
            // 
            // orvosok1
            // 
            this.orvosok1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orvosok1.Location = new System.Drawing.Point(0, 0);
            this.orvosok1.Name = "orvosok1";
            this.orvosok1.Size = new System.Drawing.Size(776, 665);
            this.orvosok1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button orvosok_szerkesztese_bt;
        private System.Windows.Forms.Button betegek_szerkesztese_bt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private Orvosok orvosok1;
        private BetegekPanel betegekPanel1;
        private FoOldal foOldal1;
    }
}