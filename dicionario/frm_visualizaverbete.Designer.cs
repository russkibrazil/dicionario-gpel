﻿namespace dicionario
{
    partial class frm_visualizaverbete
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblLema = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.TrvPalavra = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Busca";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(151, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Contato";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(254, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ajuda";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblLema
            // 
            this.lblLema.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLema.Location = new System.Drawing.Point(39, 87);
            this.lblLema.Name = "lblLema";
            this.lblLema.Size = new System.Drawing.Size(248, 53);
            this.lblLema.TabIndex = 6;
            this.lblLema.Text = "Palavra";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.Location = new System.Drawing.Point(630, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Edição";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TrvPalavra
            // 
            this.TrvPalavra.Location = new System.Drawing.Point(48, 143);
            this.TrvPalavra.Name = "TrvPalavra";
            this.TrvPalavra.Size = new System.Drawing.Size(679, 296);
            this.TrvPalavra.TabIndex = 9;
            // 
            // frm_visualizaverbete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 451);
            this.Controls.Add(this.TrvPalavra);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblLema);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frm_visualizaverbete";
            this.Text = "Visualização do Verbete";
            this.Load += new System.EventHandler(this.frm_visualizaverbete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblLema;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TreeView TrvPalavra;
    }
}