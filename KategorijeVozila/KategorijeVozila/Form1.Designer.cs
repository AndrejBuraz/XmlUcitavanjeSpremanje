namespace KategorijeVozila
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
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxBrojKot = new System.Windows.Forms.TextBox();
            this.textBoxGod = new System.Windows.Forms.TextBox();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.buttonObrada = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.velikiBox = new System.Windows.Forms.RichTextBox();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(30, 39);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 0;
            // 
            // textBoxBrojKot
            // 
            this.textBoxBrojKot.Location = new System.Drawing.Point(30, 140);
            this.textBoxBrojKot.Name = "textBoxBrojKot";
            this.textBoxBrojKot.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrojKot.TabIndex = 1;
            // 
            // textBoxGod
            // 
            this.textBoxGod.Location = new System.Drawing.Point(30, 91);
            this.textBoxGod.Name = "textBoxGod";
            this.textBoxGod.Size = new System.Drawing.Size(100, 20);
            this.textBoxGod.TabIndex = 2;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(200, 39);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(75, 23);
            this.buttonUnos.TabIndex = 3;
            this.buttonUnos.Text = "Otvori";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // buttonObrada
            // 
            this.buttonObrada.Location = new System.Drawing.Point(200, 88);
            this.buttonObrada.Name = "buttonObrada";
            this.buttonObrada.Size = new System.Drawing.Size(75, 23);
            this.buttonObrada.TabIndex = 4;
            this.buttonObrada.Text = "Obradi";
            this.buttonObrada.UseVisualStyleBackColor = true;
            this.buttonObrada.Click += new System.EventHandler(this.buttonObrada_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Location = new System.Drawing.Point(200, 140);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(75, 23);
            this.buttonIspis.TabIndex = 5;
            this.buttonIspis.Text = "Ispiši";
            this.buttonIspis.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(33, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Broj kotača";
            // 
            // velikiBox
            // 
            this.velikiBox.Location = new System.Drawing.Point(341, 39);
            this.velikiBox.Name = "velikiBox";
            this.velikiBox.Size = new System.Drawing.Size(424, 170);
            this.velikiBox.TabIndex = 10;
            this.velikiBox.Text = "";
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(200, 189);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremi.TabIndex = 11;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 256);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.velikiBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonObrada);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.textBoxGod);
            this.Controls.Add(this.textBoxBrojKot);
            this.Controls.Add(this.textBoxModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxBrojKot;
        private System.Windows.Forms.TextBox textBoxGod;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Button buttonObrada;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox velikiBox;
        private System.Windows.Forms.Button buttonSpremi;
    }
}

