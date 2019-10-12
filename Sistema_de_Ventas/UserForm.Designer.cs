namespace Sistema_de_Ventas
{
    partial class UserForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newPwd_input = new System.Windows.Forms.TextBox();
            this.reNewPwd_input = new System.Windows.Forms.TextBox();
            this.oldPwd_input = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actual Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nueva Contraseña";
            // 
            // newPwd_input
            // 
            this.newPwd_input.Location = new System.Drawing.Point(153, 81);
            this.newPwd_input.Name = "newPwd_input";
            this.newPwd_input.PasswordChar = '*';
            this.newPwd_input.Size = new System.Drawing.Size(233, 20);
            this.newPwd_input.TabIndex = 5;
            // 
            // reNewPwd_input
            // 
            this.reNewPwd_input.Location = new System.Drawing.Point(153, 116);
            this.reNewPwd_input.Name = "reNewPwd_input";
            this.reNewPwd_input.PasswordChar = '*';
            this.reNewPwd_input.Size = new System.Drawing.Size(233, 20);
            this.reNewPwd_input.TabIndex = 6;
            // 
            // oldPwd_input
            // 
            this.oldPwd_input.Location = new System.Drawing.Point(153, 30);
            this.oldPwd_input.Name = "oldPwd_input";
            this.oldPwd_input.PasswordChar = '*';
            this.oldPwd_input.Size = new System.Drawing.Size(233, 20);
            this.oldPwd_input.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(268, 162);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(13, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 2);
            this.label8.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 46);
            this.label5.TabIndex = 42;
            this.label5.Text = "* la contraseña solo puede contener valores alfanumerios (A..Z)(0..9)";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.oldPwd_input);
            this.Controls.Add(this.reNewPwd_input);
            this.Controls.Add(this.newPwd_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UserForm";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPwd_input;
        private System.Windows.Forms.TextBox reNewPwd_input;
        private System.Windows.Forms.TextBox oldPwd_input;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}