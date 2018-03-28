namespace Scott_Week6_Project1
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
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.btnReturnValue = new System.Windows.Forms.Button();
            this.btnVoid1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVoid2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(161, 58);
            this.tbNum2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(78, 20);
            this.tbNum2.TabIndex = 0;
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(161, 19);
            this.tbNum1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(78, 20);
            this.tbNum1.TabIndex = 1;
            // 
            // btnReturnValue
            // 
            this.btnReturnValue.AutoSize = true;
            this.btnReturnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnValue.Location = new System.Drawing.Point(17, 131);
            this.btnReturnValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturnValue.Name = "btnReturnValue";
            this.btnReturnValue.Size = new System.Drawing.Size(152, 25);
            this.btnReturnValue.TabIndex = 2;
            this.btnReturnValue.Text = "Return Value Method";
            this.btnReturnValue.UseVisualStyleBackColor = true;
            this.btnReturnValue.Click += new System.EventHandler(this.btnReturnValue_Click);
            // 
            // btnVoid1
            // 
            this.btnVoid1.AutoSize = true;
            this.btnVoid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid1.Location = new System.Drawing.Point(17, 164);
            this.btnVoid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoid1.Name = "btnVoid1";
            this.btnVoid1.Size = new System.Drawing.Size(109, 25);
            this.btnVoid1.TabIndex = 3;
            this.btnVoid1.Text = "Void Method 1";
            this.btnVoid1.UseVisualStyleBackColor = true;
            this.btnVoid1.Click += new System.EventHandler(this.btnVoid1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(183, 132);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVoid2
            // 
            this.btnVoid2.AutoSize = true;
            this.btnVoid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid2.Location = new System.Drawing.Point(130, 164);
            this.btnVoid2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoid2.Name = "btnVoid2";
            this.btnVoid2.Size = new System.Drawing.Size(109, 25);
            this.btnVoid2.TabIndex = 5;
            this.btnVoid2.Text = "Void Method 2";
            this.btnVoid2.UseVisualStyleBackColor = true;
            this.btnVoid2.Click += new System.EventHandler(this.btnVoid2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(161, 94);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(78, 19);
            this.lblResult.TabIndex = 9;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 215);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoid2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVoid1);
            this.Controls.Add(this.btnReturnValue);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.tbNum2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Button btnReturnValue;
        private System.Windows.Forms.Button btnVoid1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnVoid2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
    }
}

