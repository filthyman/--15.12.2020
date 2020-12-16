
namespace BookStoreProject.View
{
    partial class BooksForm
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
            this.booksView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cangeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Описание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksView
            // 
            this.booksView.AllowUserToAddRows = false;
            this.booksView.AllowUserToDeleteRows = false;
            this.booksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Year,
            this.Описание,
            this.Author});
            this.booksView.Location = new System.Drawing.Point(12, 12);
            this.booksView.MultiSelect = false;
            this.booksView.Name = "booksView";
            this.booksView.ReadOnly = true;
            this.booksView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksView.Size = new System.Drawing.Size(776, 383);
            this.booksView.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(713, 415);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cangeButton
            // 
            this.cangeButton.Location = new System.Drawing.Point(632, 415);
            this.cangeButton.Name = "cangeButton";
            this.cangeButton.Size = new System.Drawing.Size(75, 23);
            this.cangeButton.TabIndex = 2;
            this.cangeButton.Text = "Изменить";
            this.cangeButton.UseVisualStyleBackColor = true;
            this.cangeButton.Click += new System.EventHandler(this.cangeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(551, 415);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Год издания";
            this.Year.Name = "Year";
            // 
            // Описание
            // 
            this.Описание.DataPropertyName = "Description";
            this.Описание.HeaderText = "Описание";
            this.Описание.Name = "Описание";
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cangeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.booksView);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cangeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Описание;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    }
}