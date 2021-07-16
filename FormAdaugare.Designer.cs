
namespace SqlProiectStudent
{
    partial class FormAdaugare
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
            this.panelStudent = new System.Windows.Forms.Panel();
            this.labelNume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPrenume = new System.Windows.Forms.TextBox();
            this.txtBoxNume = new System.Windows.Forms.TextBox();
            this.txtBoxCNP = new System.Windows.Forms.TextBox();
            this.txtBoxAn = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panelMaterie = new System.Windows.Forms.Panel();
            this.txtBoxSemestruMaterie = new System.Windows.Forms.TextBox();
            this.txtBoxNumeMaterie = new System.Windows.Forms.TextBox();
            this.txtBoxAnMaterie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelStudent.SuspendLayout();
            this.panelMaterie.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.txtBoxAn);
            this.panelStudent.Controls.Add(this.txtBoxCNP);
            this.panelStudent.Controls.Add(this.txtBoxNume);
            this.panelStudent.Controls.Add(this.txtBoxPrenume);
            this.panelStudent.Controls.Add(this.label3);
            this.panelStudent.Controls.Add(this.label2);
            this.panelStudent.Controls.Add(this.label1);
            this.panelStudent.Controls.Add(this.labelNume);
            this.panelStudent.Location = new System.Drawing.Point(345, 55);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(409, 176);
            this.panelStudent.TabIndex = 0;
            this.panelStudent.Visible = false;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(23, 27);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "An studiu";
            // 
            // txtBoxPrenume
            // 
            this.txtBoxPrenume.Location = new System.Drawing.Point(177, 52);
            this.txtBoxPrenume.Name = "txtBoxPrenume";
            this.txtBoxPrenume.Size = new System.Drawing.Size(180, 22);
            this.txtBoxPrenume.TabIndex = 2;
            // 
            // txtBoxNume
            // 
            this.txtBoxNume.Location = new System.Drawing.Point(177, 24);
            this.txtBoxNume.Name = "txtBoxNume";
            this.txtBoxNume.Size = new System.Drawing.Size(180, 22);
            this.txtBoxNume.TabIndex = 1;
            // 
            // txtBoxCNP
            // 
            this.txtBoxCNP.Location = new System.Drawing.Point(177, 80);
            this.txtBoxCNP.Name = "txtBoxCNP";
            this.txtBoxCNP.Size = new System.Drawing.Size(180, 22);
            this.txtBoxCNP.TabIndex = 3;
            // 
            // txtBoxAn
            // 
            this.txtBoxAn.Location = new System.Drawing.Point(177, 108);
            this.txtBoxAn.Name = "txtBoxAn";
            this.txtBoxAn.Size = new System.Drawing.Size(180, 22);
            this.txtBoxAn.TabIndex = 4;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(371, 272);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(108, 46);
            this.buttonAddStudent.TabIndex = 8;
            this.buttonAddStudent.Text = "ADD";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(485, 272);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(108, 46);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(599, 272);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(108, 46);
            this.buttonReturn.TabIndex = 10;
            this.buttonReturn.Text = "RETURN";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // panelMaterie
            // 
            this.panelMaterie.Controls.Add(this.txtBoxSemestruMaterie);
            this.panelMaterie.Controls.Add(this.txtBoxNumeMaterie);
            this.panelMaterie.Controls.Add(this.txtBoxAnMaterie);
            this.panelMaterie.Controls.Add(this.label5);
            this.panelMaterie.Controls.Add(this.label6);
            this.panelMaterie.Controls.Add(this.label7);
            this.panelMaterie.Location = new System.Drawing.Point(345, 52);
            this.panelMaterie.Name = "panelMaterie";
            this.panelMaterie.Size = new System.Drawing.Size(409, 176);
            this.panelMaterie.TabIndex = 11;
            this.panelMaterie.Visible = false;
            // 
            // txtBoxSemestruMaterie
            // 
            this.txtBoxSemestruMaterie.Location = new System.Drawing.Point(177, 101);
            this.txtBoxSemestruMaterie.Name = "txtBoxSemestruMaterie";
            this.txtBoxSemestruMaterie.Size = new System.Drawing.Size(180, 22);
            this.txtBoxSemestruMaterie.TabIndex = 10;
            // 
            // txtBoxNumeMaterie
            // 
            this.txtBoxNumeMaterie.Location = new System.Drawing.Point(177, 45);
            this.txtBoxNumeMaterie.Name = "txtBoxNumeMaterie";
            this.txtBoxNumeMaterie.Size = new System.Drawing.Size(180, 22);
            this.txtBoxNumeMaterie.TabIndex = 6;
            // 
            // txtBoxAnMaterie
            // 
            this.txtBoxAnMaterie.Location = new System.Drawing.Point(177, 73);
            this.txtBoxAnMaterie.Name = "txtBoxAnMaterie";
            this.txtBoxAnMaterie.Size = new System.Drawing.Size(180, 22);
            this.txtBoxAnMaterie.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Semestru";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "An";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nume";
            // 
            // FormAdaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 429);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.panelMaterie);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Name = "FormAdaugare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdaugare";
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelMaterie.ResumeLayout(false);
            this.panelMaterie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.TextBox txtBoxAn;
        private System.Windows.Forms.TextBox txtBoxCNP;
        private System.Windows.Forms.TextBox txtBoxNume;
        private System.Windows.Forms.TextBox txtBoxPrenume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Panel panelMaterie;
        private System.Windows.Forms.TextBox txtBoxSemestruMaterie;
        private System.Windows.Forms.TextBox txtBoxNumeMaterie;
        private System.Windows.Forms.TextBox txtBoxAnMaterie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}