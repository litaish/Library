
namespace Library
{
    partial class FormSelectBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectBook));
            this.advancedDataGridView_selectedBook = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_selectedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedDataGridView_selectedBook
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_selectedBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView_selectedBook.AutoGenerateContextFilters = true;
            this.advancedDataGridView_selectedBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_selectedBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_selectedBook.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_selectedBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_selectedBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.advancedDataGridView_selectedBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_selectedBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView_selectedBook.ColumnHeadersHeight = 30;
            this.advancedDataGridView_selectedBook.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_selectedBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.advancedDataGridView_selectedBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView_selectedBook.EnableHeadersVisualStyles = false;
            this.advancedDataGridView_selectedBook.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView_selectedBook.Name = "advancedDataGridView_selectedBook";
            this.advancedDataGridView_selectedBook.ReadOnly = true;
            this.advancedDataGridView_selectedBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.advancedDataGridView_selectedBook.Size = new System.Drawing.Size(584, 451);
            this.advancedDataGridView_selectedBook.TabIndex = 0;
            this.advancedDataGridView_selectedBook.TimeFilter = false;
            this.advancedDataGridView_selectedBook.SortStringChanged += new System.EventHandler(this.advancedDataGridView_selectedBook_SortStringChanged);
            this.advancedDataGridView_selectedBook.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_selectedBook_FilterStringChanged);
            this.advancedDataGridView_selectedBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_selectedBook_CellClick);
            // 
            // FormSelectBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.advancedDataGridView_selectedBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectBook";
            this.Text = "Select a book";
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_selectedBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ADGV.AdvancedDataGridView advancedDataGridView_selectedBook;
    }
}