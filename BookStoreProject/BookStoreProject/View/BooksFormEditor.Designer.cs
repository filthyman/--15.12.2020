
namespace BookStoreProject.View
{
    partial class BooksFormEditor
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.yearNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(209, 209);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(128, 209);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 46);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(272, 20);
            this.titleBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Год публикации";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 124);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(272, 20);
            this.descriptionBox.TabIndex = 5;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(12, 163);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(272, 20);
            this.authorBox.TabIndex = 6;
            // 
            // yearNumeric
            // 
            this.yearNumeric.Location = new System.Drawing.Point(12, 85);
            this.yearNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yearNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearNumeric.Name = "yearNumeric";
            this.yearNumeric.Size = new System.Drawing.Size(272, 20);
            this.yearNumeric.TabIndex = 7;
            this.yearNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Автор";
            // 
            // BooksFormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearNumeric);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "BooksFormEditor";
            this.Text = "BooksFormEditor";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.NumericUpDown yearNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}