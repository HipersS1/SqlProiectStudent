
namespace SqlProiectStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.labelCauta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonMaterie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMaterie);
            this.panel1.Controls.Add(this.buttonAdauga);
            this.panel1.Controls.Add(this.buttonStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 55);
            this.panel1.TabIndex = 0;
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStudent.Location = new System.Drawing.Point(0, 0);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(439, 55);
            this.buttonStudent.TabIndex = 0;
            this.buttonStudent.Text = "Student";
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdauga.Location = new System.Drawing.Point(439, 0);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(369, 55);
            this.buttonAdauga.TabIndex = 1;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // dataGridTable
            // 
            this.dataGridTable.AllowUserToAddRows = false;
            this.dataGridTable.AllowUserToDeleteRows = false;
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridTable.Location = new System.Drawing.Point(0, 147);
            this.dataGridTable.MultiSelect = false;
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.ReadOnly = true;
            this.dataGridTable.RowHeadersWidth = 51;
            this.dataGridTable.RowTemplate.Height = 24;
            this.dataGridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTable.Size = new System.Drawing.Size(1248, 377);
            this.dataGridTable.TabIndex = 1;
            this.dataGridTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTable_CellDoubleClick);
            // 
            // labelCauta
            // 
            this.labelCauta.AutoSize = true;
            this.labelCauta.Location = new System.Drawing.Point(546, 102);
            this.labelCauta.Name = "labelCauta";
            this.labelCauta.Size = new System.Drawing.Size(21, 17);
            this.labelCauta.TabIndex = 2;
            this.labelCauta.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 3;
            // 
            // buttonMaterie
            // 
            this.buttonMaterie.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMaterie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMaterie.Location = new System.Drawing.Point(808, 0);
            this.buttonMaterie.Name = "buttonMaterie";
            this.buttonMaterie.Size = new System.Drawing.Size(439, 55);
            this.buttonMaterie.TabIndex = 2;
            this.buttonMaterie.Text = "Materie";
            this.buttonMaterie.UseVisualStyleBackColor = true;
            this.buttonMaterie.Click += new System.EventHandler(this.buttonMaterie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 524);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCauta);
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.Label labelCauta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonMaterie;
    }
}

