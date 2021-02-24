namespace Addition
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
            this.btn_remis = new System.Windows.Forms.Button();
            this.textBox_somme = new System.Windows.Forms.TextBox();
            this.textBox_nbr2 = new System.Windows.Forms.TextBox();
            this.txt_nbr1 = new System.Windows.Forms.Label();
            this.txt_nbr2 = new System.Windows.Forms.Label();
            this.txt_somme = new System.Windows.Forms.Label();
            this.txtbox_nbr1 = new System.Windows.Forms.TextBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_remis, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_somme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_nbr2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_nbr1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_nbr2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_somme, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtbox_nbr1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_quitter, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_remis
            // 
            this.btn_remis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_remis.Location = new System.Drawing.Point(162, 386);
            this.btn_remis.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_remis.Name = "btn_remis";
            this.btn_remis.Size = new System.Drawing.Size(75, 23);
            this.btn_remis.TabIndex = 7;
            this.btn_remis.Text = "Again";
            this.btn_remis.UseVisualStyleBackColor = true;
            this.btn_remis.Click += new System.EventHandler(this.btn_remis_Click);
            // 
            // textBox_somme
            // 
            this.textBox_somme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_somme.Enabled = false;
            this.textBox_somme.Location = new System.Drawing.Point(550, 274);
            this.textBox_somme.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.textBox_somme.Name = "textBox_somme";
            this.textBox_somme.Size = new System.Drawing.Size(100, 20);
            this.textBox_somme.TabIndex = 5;
            this.textBox_somme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_somme.TextChanged += new System.EventHandler(this.textBox_somme_TextChanged);
            // 
            // textBox_nbr2
            // 
            this.textBox_nbr2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_nbr2.Location = new System.Drawing.Point(550, 162);
            this.textBox_nbr2.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.textBox_nbr2.Name = "textBox_nbr2";
            this.textBox_nbr2.Size = new System.Drawing.Size(100, 20);
            this.textBox_nbr2.TabIndex = 4;
            this.textBox_nbr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_nbr2.TextChanged += new System.EventHandler(this.textBox_nbr2_TextChanged);
            // 
            // txt_nbr1
            // 
            this.txt_nbr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nbr1.AutoSize = true;
            this.txt_nbr1.Location = new System.Drawing.Point(3, 0);
            this.txt_nbr1.Name = "txt_nbr1";
            this.txt_nbr1.Size = new System.Drawing.Size(394, 112);
            this.txt_nbr1.TabIndex = 0;
            this.txt_nbr1.Text = "Numbre 1";
            this.txt_nbr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nbr2
            // 
            this.txt_nbr2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nbr2.AutoSize = true;
            this.txt_nbr2.Location = new System.Drawing.Point(3, 112);
            this.txt_nbr2.Name = "txt_nbr2";
            this.txt_nbr2.Size = new System.Drawing.Size(394, 112);
            this.txt_nbr2.TabIndex = 1;
            this.txt_nbr2.Text = "Numbre 2";
            this.txt_nbr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_somme
            // 
            this.txt_somme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_somme.AutoSize = true;
            this.txt_somme.Location = new System.Drawing.Point(3, 224);
            this.txt_somme.Name = "txt_somme";
            this.txt_somme.Size = new System.Drawing.Size(394, 112);
            this.txt_somme.TabIndex = 2;
            this.txt_somme.Text = "Sum";
            this.txt_somme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_nbr1
            // 
            this.txtbox_nbr1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbox_nbr1.HideSelection = false;
            this.txtbox_nbr1.Location = new System.Drawing.Point(550, 50);
            this.txtbox_nbr1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.txtbox_nbr1.Name = "txtbox_nbr1";
            this.txtbox_nbr1.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nbr1.TabIndex = 3;
            this.txtbox_nbr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_quitter.FlatAppearance.BorderSize = 3;
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.Location = new System.Drawing.Point(562, 386);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 6;
            this.btn_quitter.Text = "Close";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_remis;
        private System.Windows.Forms.TextBox textBox_somme;
        private System.Windows.Forms.TextBox textBox_nbr2;
        private System.Windows.Forms.Label txt_nbr1;
        private System.Windows.Forms.Label txt_nbr2;
        private System.Windows.Forms.Label txt_somme;
        private System.Windows.Forms.TextBox txtbox_nbr1;
        private System.Windows.Forms.Button btn_quitter;
    }
}

