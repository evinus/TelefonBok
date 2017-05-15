namespace TelefonBok
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxNummer = new System.Windows.Forms.TextBox();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.läggTillPerson = new System.Windows.Forms.Button();
            this.btntabortNa = new System.Windows.Forms.Button();
            this.btnTabortNr = new System.Windows.Forms.Button();
            this.radioBåda = new System.Windows.Forms.RadioButton();
            this.tbxLista = new System.Windows.Forms.TextBox();
            this.btnSökNamn = new System.Windows.Forms.Button();
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.btnSökNr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxNummer);
            this.groupBox1.Controls.Add(this.tbxNamn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.läggTillPerson);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbxNummer
            // 
            this.tbxNummer.Location = new System.Drawing.Point(76, 76);
            this.tbxNummer.Name = "tbxNummer";
            this.tbxNummer.Size = new System.Drawing.Size(100, 20);
            this.tbxNummer.TabIndex = 4;
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(76, 38);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNamn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nummer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "namn";
            // 
            // läggTillPerson
            // 
            this.läggTillPerson.Location = new System.Drawing.Point(58, 122);
            this.läggTillPerson.Name = "läggTillPerson";
            this.läggTillPerson.Size = new System.Drawing.Size(75, 23);
            this.läggTillPerson.TabIndex = 0;
            this.läggTillPerson.Text = "Lägg Till";
            this.läggTillPerson.UseVisualStyleBackColor = true;
            this.läggTillPerson.Click += new System.EventHandler(this.läggTillPerson_Click);
            // 
            // btntabortNa
            // 
            this.btntabortNa.Location = new System.Drawing.Point(36, 254);
            this.btntabortNa.Name = "btntabortNa";
            this.btntabortNa.Size = new System.Drawing.Size(93, 23);
            this.btntabortNa.TabIndex = 2;
            this.btntabortNa.Text = "Ta bort namn";
            this.btntabortNa.UseVisualStyleBackColor = true;
            this.btntabortNa.Click += new System.EventHandler(this.btntabortNa_Click);
            // 
            // btnTabortNr
            // 
            this.btnTabortNr.Location = new System.Drawing.Point(135, 254);
            this.btnTabortNr.Name = "btnTabortNr";
            this.btnTabortNr.Size = new System.Drawing.Size(106, 23);
            this.btnTabortNr.TabIndex = 3;
            this.btnTabortNr.Text = "Ta bort Nummer";
            this.btnTabortNr.UseVisualStyleBackColor = true;
            this.btnTabortNr.Click += new System.EventHandler(this.btnTabortNr_Click);
            // 
            // radioBåda
            // 
            this.radioBåda.AutoSize = true;
            this.radioBåda.Location = new System.Drawing.Point(247, 257);
            this.radioBåda.Name = "radioBåda";
            this.radioBåda.Size = new System.Drawing.Size(50, 17);
            this.radioBåda.TabIndex = 4;
            this.radioBåda.TabStop = true;
            this.radioBåda.Text = "Båda";
            this.radioBåda.UseVisualStyleBackColor = true;
            // 
            // tbxLista
            // 
            this.tbxLista.Location = new System.Drawing.Point(247, 25);
            this.tbxLista.Multiline = true;
            this.tbxLista.Name = "tbxLista";
            this.tbxLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLista.Size = new System.Drawing.Size(243, 187);
            this.tbxLista.TabIndex = 5;
            // 
            // btnSökNamn
            // 
            this.btnSökNamn.Location = new System.Drawing.Point(36, 284);
            this.btnSökNamn.Name = "btnSökNamn";
            this.btnSökNamn.Size = new System.Drawing.Size(75, 23);
            this.btnSökNamn.TabIndex = 6;
            this.btnSökNamn.Text = "Sök namn";
            this.btnSökNamn.UseVisualStyleBackColor = true;
            this.btnSökNamn.Click += new System.EventHandler(this.btnSökNamn_Click);
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(428, 317);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(75, 23);
            this.btnUppdatera.TabIndex = 7;
            this.btnUppdatera.Text = "Uppdatera";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            this.btnUppdatera.Click += new System.EventHandler(this.btnUppdatera_Click);
            // 
            // btnSökNr
            // 
            this.btnSökNr.Location = new System.Drawing.Point(117, 284);
            this.btnSökNr.Name = "btnSökNr";
            this.btnSökNr.Size = new System.Drawing.Size(84, 23);
            this.btnSökNr.TabIndex = 8;
            this.btnSökNr.Text = "Sök Nummer";
            this.btnSökNr.UseVisualStyleBackColor = true;
            this.btnSökNr.Click += new System.EventHandler(this.btnSökNr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSökNr);
            this.Controls.Add(this.btnUppdatera);
            this.Controls.Add(this.btnSökNamn);
            this.Controls.Add(this.tbxLista);
            this.Controls.Add(this.radioBåda);
            this.Controls.Add(this.btnTabortNr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntabortNa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button läggTillPerson;
        private System.Windows.Forms.TextBox tbxNummer;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBåda;
        private System.Windows.Forms.Button btnTabortNr;
        private System.Windows.Forms.Button btntabortNa;
        private System.Windows.Forms.TextBox tbxLista;
        private System.Windows.Forms.Button btnSökNamn;
        private System.Windows.Forms.Button btnUppdatera;
        private System.Windows.Forms.Button btnSökNr;
        private System.Windows.Forms.Button button1;
    }
}

