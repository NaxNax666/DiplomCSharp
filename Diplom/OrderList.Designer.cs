namespace Diplom
{
    partial class OrderList
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
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderBox
            // 
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(12, 12);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(363, 24);
            this.orderBox.TabIndex = 0;
            this.orderBox.Text = "Диплом";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(97, 42);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(191, 23);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Подтвердить Запрос";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(97, 71);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(191, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 120);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.orderBox);
            this.Name = "OrderList";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ExitButton;
    }
}