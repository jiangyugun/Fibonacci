namespace Fibonacci
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnclickthis = new System.Windows.Forms.Button();
            this.fibonacciinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclickthis
            // 
            this.btnclickthis.Location = new System.Drawing.Point(406, 142);
            this.btnclickthis.Name = "btnclickthis";
            this.btnclickthis.Size = new System.Drawing.Size(75, 23);
            this.btnclickthis.TabIndex = 0;
            this.btnclickthis.Text = "確認";
            this.btnclickthis.UseVisualStyleBackColor = true;
            this.btnclickthis.Click += new System.EventHandler(this.Btnclickthis_Click);
            // 
            // fibonacciinput
            // 
            this.fibonacciinput.Location = new System.Drawing.Point(253, 143);
            this.fibonacciinput.Name = "fibonacciinput";
            this.fibonacciinput.Size = new System.Drawing.Size(123, 22);
            this.fibonacciinput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(251, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 166);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fibonacciinput);
            this.Controls.Add(this.btnclickthis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclickthis;
        private System.Windows.Forms.TextBox fibonacciinput;
        private System.Windows.Forms.Label label1;
    }
}

