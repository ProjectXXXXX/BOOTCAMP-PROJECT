
namespace CALC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblnamemenu = new System.Windows.Forms.Label();
            this.lblcalc = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblnamemenu
            // 
            this.lblnamemenu.AutoSize = true;
            this.lblnamemenu.BackColor = System.Drawing.Color.Transparent;
            this.lblnamemenu.Font = new System.Drawing.Font("Verdana", 37F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamemenu.Location = new System.Drawing.Point(241, 21);
            this.lblnamemenu.Name = "lblnamemenu";
            this.lblnamemenu.Size = new System.Drawing.Size(596, 180);
            this.lblnamemenu.TabIndex = 0;
            this.lblnamemenu.Text = "Добро Пожаловать!\r\n\r\n  В Россию!\r\n";
            // 
            // lblcalc
            // 
            this.lblcalc.ActiveLinkColor = System.Drawing.Color.Gold;
            this.lblcalc.AutoSize = true;
            this.lblcalc.BackColor = System.Drawing.Color.Transparent;
            this.lblcalc.Font = new System.Drawing.Font("Verdana", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalc.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lblcalc.Location = new System.Drawing.Point(340, 380);
            this.lblcalc.Name = "lblcalc";
            this.lblcalc.Size = new System.Drawing.Size(303, 46);
            this.lblcalc.TabIndex = 1;
            this.lblcalc.TabStop = true;
            this.lblcalc.Text = "Калькулятор";
            this.lblcalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblcalc_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImage = global::CALC.Properties.Resources._000_32dj2pv_2_e1656594531146;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.lblcalc);
            this.Controls.Add(this.lblnamemenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnamemenu;
        private System.Windows.Forms.LinkLabel lblcalc;
    }
}

