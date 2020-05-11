namespace InventoryManager
{
    partial class Main
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
            this.pdli = new System.Windows.Forms.ListView();
            this.idcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pricecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantitycol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btninfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnremove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnabout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdli
            // 
            this.pdli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcol,
            this.namecol,
            this.pricecol,
            this.quantitycol});
            this.pdli.HideSelection = false;
            this.pdli.Location = new System.Drawing.Point(10, 51);
            this.pdli.Name = "pdli";
            this.pdli.Size = new System.Drawing.Size(399, 333);
            this.pdli.TabIndex = 0;
            this.pdli.UseCompatibleStateImageBehavior = false;
            this.pdli.View = System.Windows.Forms.View.Details;
            // 
            // idcol
            // 
            this.idcol.Text = "ID";
            this.idcol.Width = 50;
            // 
            // namecol
            // 
            this.namecol.Text = "Name";
            this.namecol.Width = 110;
            // 
            // pricecol
            // 
            this.pricecol.Text = "Price";
            this.pricecol.Width = 80;
            // 
            // quantitycol
            // 
            this.quantitycol.Text = "Quantity";
            this.quantitycol.Width = 85;
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfo.Location = new System.Drawing.Point(835, 283);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(182, 52);
            this.btninfo.TabIndex = 2;
            this.btninfo.Text = "Calculate Info";
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(854, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 54);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(113, 154);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(142, 22);
            this.namebox.TabIndex = 4;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(113, 220);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(142, 22);
            this.pricebox.TabIndex = 5;
            this.pricebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricebox_KeyPress_1);
            // 
            // quantitybox
            // 
            this.quantitybox.Location = new System.Drawing.Point(113, 289);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(142, 22);
            this.quantitybox.TabIndex = 6;
            this.quantitybox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitybox_KeyPress_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnhint);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.quantitybox);
            this.panel1.Controls.Add(this.pricebox);
            this.panel1.Controls.Add(this.namebox);
            this.panel1.Location = new System.Drawing.Point(445, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 400);
            this.panel1.TabIndex = 7;
            // 
            // btnhint
            // 
            this.btnhint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhint.Location = new System.Drawing.Point(147, 104);
            this.btnhint.Name = "btnhint";
            this.btnhint.Size = new System.Drawing.Size(75, 23);
            this.btnhint.TabIndex = 12;
            this.btnhint.Text = "Hint";
            this.btnhint.UseVisualStyleBackColor = false;
            this.btnhint.Click += new System.EventHandler(this.btnhint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add product";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(147, 329);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(77, 29);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pdli);
            this.panel2.Location = new System.Drawing.Point(12, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 400);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product List";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnremove);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(780, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 177);
            this.panel3.TabIndex = 9;
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.Red;
            this.btnremove.Location = new System.Drawing.Point(82, 125);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(119, 38);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Please choose item in product list \r\nand click the remove button :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Remove Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 55);
            this.label8.TabIndex = 10;
            this.label8.Text = "Main Menu";
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnabout.Location = new System.Drawing.Point(960, 9);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(125, 40);
            this.btnabout.TabIndex = 11;
            this.btnabout.Text = "About us";
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 493);
            this.Controls.Add(this.btnabout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btninfo);
            this.Name = "Main";
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView pdli;
        private System.Windows.Forms.ColumnHeader idcol;
        private System.Windows.Forms.ColumnHeader namecol;
        private System.Windows.Forms.ColumnHeader quantitycol;
        private System.Windows.Forms.ColumnHeader pricecol;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnhint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnabout;
    }
}

