
namespace Library
{
    partial class FormSelectMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectMember));
            this.advancedDataGridView_selectMember = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_selectMember)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedDataGridView_selectMember
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_selectMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView_selectMember.AutoGenerateContextFilters = true;
            this.advancedDataGridView_selectMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_selectMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_selectMember.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_selectMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_selectMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.advancedDataGridView_selectMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_selectMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView_selectMember.ColumnHeadersHeight = 30;
            this.advancedDataGridView_selectMember.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_selectMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.advancedDataGridView_selectMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView_selectMember.EnableHeadersVisualStyles = false;
            this.advancedDataGridView_selectMember.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView_selectMember.Name = "advancedDataGridView_selectMember";
            this.advancedDataGridView_selectMember.ReadOnly = true;
            this.advancedDataGridView_selectMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.advancedDataGridView_selectMember.Size = new System.Drawing.Size(584, 451);
            this.advancedDataGridView_selectMember.TabIndex = 0;
            this.advancedDataGridView_selectMember.TimeFilter = false;
            this.advancedDataGridView_selectMember.SortStringChanged += new System.EventHandler(this.advancedDataGridView_selectMember_SortStringChanged);
            this.advancedDataGridView_selectMember.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_selectMember_FilterStringChanged);
            this.advancedDataGridView_selectMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_selectMember_CellClick);
            // 
            // FormSelectMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.advancedDataGridView_selectMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectMember";
            this.Text = "Select a member";
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_selectMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ADGV.AdvancedDataGridView advancedDataGridView_selectMember;
    }
}