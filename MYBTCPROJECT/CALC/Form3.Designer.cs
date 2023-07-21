
namespace CALC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.txtbNum1 = new System.Windows.Forms.TextBox();
            this.txtbNum2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstNum.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNum.ForeColor = System.Drawing.Color.Black;
            this.lblFirstNum.Location = new System.Drawing.Point(226, 39);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(197, 26);
            this.lblFirstNum.TabIndex = 0;
            this.lblFirstNum.Text = "Первое число:";
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondNum.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNum.Location = new System.Drawing.Point(226, 153);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(193, 26);
            this.lblSecondNum.TabIndex = 1;
            this.lblSecondNum.Text = "Второе число:";
            // 
            // txtbNum1
            // 
            this.txtbNum1.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNum1.Location = new System.Drawing.Point(231, 93);
            this.txtbNum1.Name = "txtbNum1";
            this.txtbNum1.Size = new System.Drawing.Size(188, 26);
            this.txtbNum1.TabIndex = 2;
            this.txtbNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_keyDown);
            this.txtbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtbNum2
            // 
            this.txtbNum2.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNum2.Location = new System.Drawing.Point(231, 222);
            this.txtbNum2.Name = "txtbNum2";
            this.txtbNum2.Size = new System.Drawing.Size(188, 26);
            this.txtbNum2.TabIndex = 3;
            this.txtbNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_keyDown);
            this.txtbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Black;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(40, 62);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 75);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Black;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(40, 202);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 75);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnClick);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Black;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(514, 62);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 75);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = ":";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnClick);
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.Black;
            this.btnIncrease.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrease.ForeColor = System.Drawing.Color.White;
            this.btnIncrease.Location = new System.Drawing.Point(514, 211);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(75, 75);
            this.btnIncrease.TabIndex = 7;
            this.btnIncrease.Text = "*";
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.btnClick);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Transparent;
            this.lblRes.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.Color.White;
            this.lblRes.Location = new System.Drawing.Point(249, 269);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(148, 26);
            this.lblRes.TabIndex = 9;
            this.lblRes.Text = "Результат:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(295, 316);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(34, 32);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "0";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Black;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(254, 370);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(143, 59);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CALC.Properties.Resources._183568;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtbNum2);
            this.Controls.Add(this.txtbNum1);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.lblFirstNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Я за тобой смотрю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblSecondNum;
        private System.Windows.Forms.TextBox txtbNum1;
        private System.Windows.Forms.TextBox txtbNum2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn_Exit;
    }
}