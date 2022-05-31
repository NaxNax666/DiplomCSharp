namespace Diplom
{
    partial class CopyrighterForm
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
            this.ShowPublButton = new System.Windows.Forms.Button();
            this.AddPublButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowPublButton
            // 
            this.ShowPublButton.Location = new System.Drawing.Point(22, 21);
            this.ShowPublButton.Name = "ShowPublButton";
            this.ShowPublButton.Size = new System.Drawing.Size(242, 27);
            this.ShowPublButton.TabIndex = 0;
            this.ShowPublButton.Text = "Показать список публикаций";
            this.ShowPublButton.UseVisualStyleBackColor = true;
            this.ShowPublButton.Click += new System.EventHandler(this.ShowPublButton_Click);
            // 
            // AddPublButton
            // 
            this.AddPublButton.Location = new System.Drawing.Point(24, 55);
            this.AddPublButton.Name = "AddPublButton";
            this.AddPublButton.Size = new System.Drawing.Size(242, 29);
            this.AddPublButton.TabIndex = 1;
            this.AddPublButton.Text = "Добавить публикацию";
            this.AddPublButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(282, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 396);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(21, 199);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(152, 17);
            this.LName.TabIndex = 3;
            this.LName.Text = "Александр Сергеевич";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Автор";
            // 
            // CopyrighterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AddPublButton);
            this.Controls.Add(this.ShowPublButton);
            this.Name = "CopyrighterForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowPublButton;
        private System.Windows.Forms.Button AddPublButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label label1;
    }
}