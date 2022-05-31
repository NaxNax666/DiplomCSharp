namespace Diplom
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
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.Show_Button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.Location = new System.Drawing.Point(46, 55);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(156, 29);
            this.Purchase_Button.TabIndex = 0;
            this.Purchase_Button.Text = "Купить Публикацию";
            this.Purchase_Button.UseVisualStyleBackColor = true;
            this.Purchase_Button.Click += new System.EventHandler(this.Purchase_Button_Click);
            // 
            // Show_Button
            // 
            this.Show_Button.Location = new System.Drawing.Point(46, 91);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(156, 48);
            this.Show_Button.TabIndex = 1;
            this.Show_Button.Text = "Показать список покупок";
            this.Show_Button.UseVisualStyleBackColor = true;
            this.Show_Button.Click += new System.EventHandler(this.Show_Button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(243, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(277, 366);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Перепродажа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(46, 182);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(46, 17);
            this.LName.TabIndex = 4;
            this.LName.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пользователь";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Show_Button);
            this.Controls.Add(this.Purchase_Button);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Purchase_Button;
        private System.Windows.Forms.Button Show_Button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label label2;
    }
}