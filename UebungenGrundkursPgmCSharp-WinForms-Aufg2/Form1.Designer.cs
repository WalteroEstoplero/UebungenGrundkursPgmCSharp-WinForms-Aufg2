namespace UebungenGrundkursPgmCSharp_WinForms_Aufg2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_left = new System.Windows.Forms.Button();
            this.Btn_right = new System.Windows.Forms.Button();
            this.Btn_top = new System.Windows.Forms.Button();
            this.Btn_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_left
            // 
            this.Btn_left.Location = new System.Drawing.Point(-2, 197);
            this.Btn_left.Name = "Btn_left";
            this.Btn_left.Size = new System.Drawing.Size(75, 23);
            this.Btn_left.TabIndex = 0;
            this.Btn_left.Text = "left";
            this.Btn_left.UseVisualStyleBackColor = true;
            this.Btn_left.Click += new System.EventHandler(this.Btn_left_Click);
            // 
            // Btn_right
            // 
            this.Btn_right.Location = new System.Drawing.Point(725, 197);
            this.Btn_right.Name = "Btn_right";
            this.Btn_right.Size = new System.Drawing.Size(75, 23);
            this.Btn_right.TabIndex = 1;
            this.Btn_right.Text = "right";
            this.Btn_right.UseVisualStyleBackColor = true;
            this.Btn_right.Click += new System.EventHandler(this.Btn_right_Click);
            // 
            // Btn_top
            // 
            this.Btn_top.Location = new System.Drawing.Point(370, -3);
            this.Btn_top.Name = "Btn_top";
            this.Btn_top.Size = new System.Drawing.Size(75, 23);
            this.Btn_top.TabIndex = 2;
            this.Btn_top.Text = "up";
            this.Btn_top.UseVisualStyleBackColor = true;
            this.Btn_top.Click += new System.EventHandler(this.Btn_top_Click);
            // 
            // Btn_down
            // 
            this.Btn_down.Location = new System.Drawing.Point(370, 391);
            this.Btn_down.Name = "Btn_down";
            this.Btn_down.Size = new System.Drawing.Size(75, 23);
            this.Btn_down.TabIndex = 3;
            this.Btn_down.Text = "down";
            this.Btn_down.UseVisualStyleBackColor = true;
            this.Btn_down.Click += new System.EventHandler(this.Btn_down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_down);
            this.Controls.Add(this.Btn_top);
            this.Controls.Add(this.Btn_right);
            this.Controls.Add(this.Btn_left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_left;
        private System.Windows.Forms.Button Btn_right;
        private System.Windows.Forms.Button Btn_top;
        private System.Windows.Forms.Button Btn_down;
    }
}

