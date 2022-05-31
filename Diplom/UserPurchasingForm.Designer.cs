namespace Diplom
{
    partial class UserPurchasingForm
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
            this.SelectAuthor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectTitle = new System.Windows.Forms.ComboBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectAuthor
            // 
            this.SelectAuthor.FormattingEnabled = true;
            this.SelectAuthor.Location = new System.Drawing.Point(106, 12);
            this.SelectAuthor.Name = "SelectAuthor";
            this.SelectAuthor.Size = new System.Drawing.Size(223, 24);
            this.SelectAuthor.TabIndex = 0;
            this.SelectAuthor.Text = "Александр Сергеевич";
            this.SelectAuthor.SelectedIndexChanged += new System.EventHandler(this.SelectAuthor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Навание";
            // 
            // SelectTitle
            // 
            this.SelectTitle.FormattingEnabled = true;
            this.SelectTitle.Location = new System.Drawing.Point(106, 42);
            this.SelectTitle.Name = "SelectTitle";
            this.SelectTitle.Size = new System.Drawing.Size(223, 24);
            this.SelectTitle.TabIndex = 2;
            this.SelectTitle.Text = "Диплом";
            this.SelectTitle.SelectedIndexChanged += new System.EventHandler(this.SelectTitle_SelectedIndexChanged);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(150, 69);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(95, 17);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Вы уверены?";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(222, 164);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(96, 17);
            this.BalanceLabel.TabIndex = 5;
            this.BalanceLabel.Text = "Баланс: 1000";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(136, 117);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(132, 28);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Приобрести";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // UserPurchasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 190);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectAuthor);
            this.Name = "UserPurchasingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectTitle;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Button ConfirmButton;
    }
}