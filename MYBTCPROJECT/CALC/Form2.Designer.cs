
namespace CALC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnenter = new System.Windows.Forms.Button();
            this.txtbpsw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpassword.Font = new System.Drawing.Font("Verdana", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblpassword.Location = new System.Drawing.Point(129, 41);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(356, 48);
            this.lblpassword.TabIndex = 0;
            this.lblpassword.Text = "Введи пароль:";
            // 
            // btnenter
            // 
            this.btnenter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnenter.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.Location = new System.Drawing.Point(269, 333);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(80, 38);
            this.btnenter.TabIndex = 1;
            this.btnenter.Text = "Ввод";
            this.btnenter.UseVisualStyleBackColor = true;
            // 
            // txtbpsw
            // 
            this.txtbpsw.Location = new System.Drawing.Point(229, 241);
            this.txtbpsw.Name = "txtbpsw";
            this.txtbpsw.PasswordChar = '*';
            this.txtbpsw.Size = new System.Drawing.Size(152, 20);
            this.txtbpsw.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = global::CALC.Properties.Resources.yoCBYFm21E0;
            this.ClientSize = new System.Drawing.Size(585, 565);
            this.Controls.Add(this.txtbpsw);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.lblpassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.TextBox txtbpsw;
    }
}