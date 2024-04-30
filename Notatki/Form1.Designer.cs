namespace Notatki
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
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownPenWidth = new System.Windows.Forms.NumericUpDown();
            this.buttonPenColor = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenWidth)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxPage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPages, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 790);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPage.Location = new System.Drawing.Point(357, 77);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(893, 707);
            this.pictureBoxPage.TabIndex = 0;
            this.pictureBoxPage.TabStop = false;
            this.pictureBoxPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPage_MouseDown);
            this.pictureBoxPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPage_MouseMove);
            this.pictureBoxPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPage_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownPenWidth);
            this.panel1.Controls.Add(this.buttonPenColor);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(357, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 59);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDownPenWidth
            // 
            this.numericUpDownPenWidth.Location = new System.Drawing.Point(740, 18);
            this.numericUpDownPenWidth.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownPenWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPenWidth.Name = "numericUpDownPenWidth";
            this.numericUpDownPenWidth.Size = new System.Drawing.Size(123, 29);
            this.numericUpDownPenWidth.TabIndex = 2;
            this.numericUpDownPenWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonPenColor
            // 
            this.buttonPenColor.BackColor = System.Drawing.Color.Black;
            this.buttonPenColor.Location = new System.Drawing.Point(590, 18);
            this.buttonPenColor.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPenColor.Name = "buttonPenColor";
            this.buttonPenColor.Size = new System.Drawing.Size(138, 31);
            this.buttonPenColor.TabIndex = 1;
            this.buttonPenColor.UseVisualStyleBackColor = false;
            this.buttonPenColor.Click += new System.EventHandler(this.buttonPenColor_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(6, 20);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(569, 29);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 65);
            this.panel2.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(174, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(165, 59);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(165, 59);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxPages
            // 
            this.listBoxPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 24;
            this.listBoxPages.Location = new System.Drawing.Point(3, 74);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(345, 713);
            this.listBoxPages.TabIndex = 3;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 790);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1272, 829);
            this.Name = "Form1";
            this.Text = "Notatki";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenWidth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownPenWidth;
        private System.Windows.Forms.Button buttonPenColor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Button buttonDelete;
    }
}

