
using ADGV;
using System.Windows.Forms;

namespace Library
{
    partial class LibraryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_refreshData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_update = new System.Windows.Forms.ToolStripButton();
            this.tabEmail = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_bookBottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_book = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_genre = new System.Windows.Forms.DataGridView();
            this.dataGridView_language = new System.Windows.Forms.DataGridView();
            this.dataGridView_author = new System.Windows.Forms.DataGridView();
            this.panel_bookGroup = new System.Windows.Forms.Panel();
            this.groupBox_book = new System.Windows.Forms.GroupBox();
            this.comboBox_author = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_book = new System.Windows.Forms.DateTimePicker();
            this.button_addBook = new System.Windows.Forms.Button();
            this.button_clearBook = new System.Windows.Forms.Button();
            this.label_author = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.label_language = new System.Windows.Forms.Label();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.label_publisher = new System.Windows.Forms.Label();
            this.comboBox_publisher = new System.Windows.Forms.ComboBox();
            this.label_publishDate = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.panel_topBook = new System.Windows.Forms.Panel();
            this.splitContainer_book = new System.Windows.Forms.SplitContainer();
            this.treeView_genre = new System.Windows.Forms.TreeView();
            this.advancedDataGridView_book = new ADGV.AdvancedDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_cardNumber = new System.Windows.Forms.DataGridView();
            this.advancedDataGridView_member = new ADGV.AdvancedDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.textBox_memberID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_addMember = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_member = new System.Windows.Forms.DateTimePicker();
            this.button_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_addMember = new System.Windows.Forms.Button();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel_publisherContainer = new System.Windows.Forms.Panel();
            this.panel_publisherRight = new System.Windows.Forms.Panel();
            this.panel_publisherLeft = new System.Windows.Forms.Panel();
            this.groupBox_addPublisher = new System.Windows.Forms.GroupBox();
            this.button_addPublisher = new System.Windows.Forms.Button();
            this.button_clearPublisher = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_countryName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_publisherName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_country = new System.Windows.Forms.DataGridView();
            this.dataGridView_publisher = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_borrowings = new System.Windows.Forms.TableLayoutPanel();
            this.panel_borrowingsLeft = new System.Windows.Forms.Panel();
            this.groupBox_borrowingAdd = new System.Windows.Forms.GroupBox();
            this.textBox_borrowingBook = new System.Windows.Forms.TextBox();
            this.textBox_borrowingMember = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dateDue = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateBorrowed = new System.Windows.Forms.DateTimePicker();
            this.button_addBorrowing = new System.Windows.Forms.Button();
            this.button_clearBorrowing = new System.Windows.Forms.Button();
            this.label_dateDue = new System.Windows.Forms.Label();
            this.label_dateBorrowed = new System.Windows.Forms.Label();
            this.label_bookNumber = new System.Windows.Forms.Label();
            this.label_memberNumber = new System.Windows.Forms.Label();
            this.advancedDataGridView_borrowings = new ADGV.AdvancedDataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_membersForEmail = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_bookBottom.SuspendLayout();
            this.tableLayoutPanel_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_language)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_author)).BeginInit();
            this.panel_bookGroup.SuspendLayout();
            this.groupBox_book.SuspendLayout();
            this.panel_topBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_book)).BeginInit();
            this.splitContainer_book.Panel1.SuspendLayout();
            this.splitContainer_book.Panel2.SuspendLayout();
            this.splitContainer_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_book)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cardNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_member)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_addMember.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel_publisherContainer.SuspendLayout();
            this.panel_publisherLeft.SuspendLayout();
            this.groupBox_addPublisher.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_country)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_publisher)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel_borrowings.SuspendLayout();
            this.panel_borrowingsLeft.SuspendLayout();
            this.groupBox_borrowingAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_borrowings)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_membersForEmail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_refreshData,
            this.toolStripSeparator1,
            this.toolStripButton_update});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1273, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_refreshData
            // 
            this.toolStripButton_refreshData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_refreshData.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_refreshData.Image")));
            this.toolStripButton_refreshData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_refreshData.Name = "toolStripButton_refreshData";
            this.toolStripButton_refreshData.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton_refreshData.Text = "Refresh Data";
            this.toolStripButton_refreshData.Click += new System.EventHandler(this.toolStripButton_refreshData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_update
            // 
            this.toolStripButton_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_update.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_update.Image")));
            this.toolStripButton_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_update.Name = "toolStripButton_update";
            this.toolStripButton_update.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton_update.Text = "Update";
            this.toolStripButton_update.Click += new System.EventHandler(this.toolStripButton_update_Click);
            // 
            // tabEmail
            // 
            this.tabEmail.Controls.Add(this.tabPage1);
            this.tabEmail.Controls.Add(this.tabPage2);
            this.tabEmail.Controls.Add(this.tabPage4);
            this.tabEmail.Controls.Add(this.tabPage3);
            this.tabEmail.Controls.Add(this.tabPage5);
            this.tabEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmail.Location = new System.Drawing.Point(0, 25);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.SelectedIndex = 0;
            this.tabEmail.Size = new System.Drawing.Size(1273, 615);
            this.tabEmail.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.panel_bookBottom);
            this.tabPage1.Controls.Add(this.panel_topBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1265, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book information";
            // 
            // panel_bookBottom
            // 
            this.panel_bookBottom.Controls.Add(this.tableLayoutPanel_book);
            this.panel_bookBottom.Controls.Add(this.panel_bookGroup);
            this.panel_bookBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bookBottom.Location = new System.Drawing.Point(3, 253);
            this.panel_bookBottom.Name = "panel_bookBottom";
            this.panel_bookBottom.Size = new System.Drawing.Size(1259, 333);
            this.panel_bookBottom.TabIndex = 1;
            // 
            // tableLayoutPanel_book
            // 
            this.tableLayoutPanel_book.ColumnCount = 3;
            this.tableLayoutPanel_book.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.13636F));
            this.tableLayoutPanel_book.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.86364F));
            this.tableLayoutPanel_book.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel_book.Controls.Add(this.dataGridView_genre, 0, 0);
            this.tableLayoutPanel_book.Controls.Add(this.dataGridView_language, 1, 0);
            this.tableLayoutPanel_book.Controls.Add(this.dataGridView_author, 2, 0);
            this.tableLayoutPanel_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_book.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_book.Name = "tableLayoutPanel_book";
            this.tableLayoutPanel_book.RowCount = 1;
            this.tableLayoutPanel_book.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_book.Size = new System.Drawing.Size(520, 333);
            this.tableLayoutPanel_book.TabIndex = 1;
            // 
            // dataGridView_genre
            // 
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_genre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            this.dataGridView_genre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_genre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_genre.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_genre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_genre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_genre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dataGridView_genre.ColumnHeadersHeight = 30;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_genre.DefaultCellStyle = dataGridViewCellStyle57;
            this.dataGridView_genre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_genre.EnableHeadersVisualStyles = false;
            this.dataGridView_genre.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_genre.Name = "dataGridView_genre";
            this.dataGridView_genre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_genre.Size = new System.Drawing.Size(173, 327);
            this.dataGridView_genre.TabIndex = 0;
            // 
            // dataGridView_language
            // 
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_language.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle58;
            this.dataGridView_language.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_language.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_language.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_language.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_language.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_language.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dataGridView_language.ColumnHeadersHeight = 30;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_language.DefaultCellStyle = dataGridViewCellStyle60;
            this.dataGridView_language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_language.EnableHeadersVisualStyles = false;
            this.dataGridView_language.Location = new System.Drawing.Point(182, 3);
            this.dataGridView_language.Name = "dataGridView_language";
            this.dataGridView_language.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_language.Size = new System.Drawing.Size(166, 327);
            this.dataGridView_language.TabIndex = 1;
            // 
            // dataGridView_author
            // 
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_author.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.dataGridView_author.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_author.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_author.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_author.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_author.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_author.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.dataGridView_author.ColumnHeadersHeight = 30;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_author.DefaultCellStyle = dataGridViewCellStyle63;
            this.dataGridView_author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_author.EnableHeadersVisualStyles = false;
            this.dataGridView_author.Location = new System.Drawing.Point(354, 3);
            this.dataGridView_author.Name = "dataGridView_author";
            this.dataGridView_author.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_author.Size = new System.Drawing.Size(163, 327);
            this.dataGridView_author.TabIndex = 2;
            // 
            // panel_bookGroup
            // 
            this.panel_bookGroup.Controls.Add(this.groupBox_book);
            this.panel_bookGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_bookGroup.Location = new System.Drawing.Point(520, 0);
            this.panel_bookGroup.Name = "panel_bookGroup";
            this.panel_bookGroup.Padding = new System.Windows.Forms.Padding(15);
            this.panel_bookGroup.Size = new System.Drawing.Size(739, 333);
            this.panel_bookGroup.TabIndex = 0;
            // 
            // groupBox_book
            // 
            this.groupBox_book.Controls.Add(this.comboBox_author);
            this.groupBox_book.Controls.Add(this.dateTimePicker_book);
            this.groupBox_book.Controls.Add(this.button_addBook);
            this.groupBox_book.Controls.Add(this.button_clearBook);
            this.groupBox_book.Controls.Add(this.label_author);
            this.groupBox_book.Controls.Add(this.label_genre);
            this.groupBox_book.Controls.Add(this.comboBox_genre);
            this.groupBox_book.Controls.Add(this.label_language);
            this.groupBox_book.Controls.Add(this.comboBox_language);
            this.groupBox_book.Controls.Add(this.label_publisher);
            this.groupBox_book.Controls.Add(this.comboBox_publisher);
            this.groupBox_book.Controls.Add(this.label_publishDate);
            this.groupBox_book.Controls.Add(this.label_title);
            this.groupBox_book.Controls.Add(this.textBox_title);
            this.groupBox_book.Controls.Add(this.label_ISBN);
            this.groupBox_book.Controls.Add(this.textBox_isbn);
            this.groupBox_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_book.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_book.Location = new System.Drawing.Point(15, 15);
            this.groupBox_book.Name = "groupBox_book";
            this.groupBox_book.Size = new System.Drawing.Size(709, 303);
            this.groupBox_book.TabIndex = 0;
            this.groupBox_book.TabStop = false;
            this.groupBox_book.Text = "Add a new book";
            // 
            // comboBox_author
            // 
            this.comboBox_author.FormattingEnabled = true;
            this.comboBox_author.Location = new System.Drawing.Point(458, 169);
            this.comboBox_author.Name = "comboBox_author";
            this.comboBox_author.Size = new System.Drawing.Size(241, 25);
            this.comboBox_author.TabIndex = 19;
            // 
            // dateTimePicker_book
            // 
            this.dateTimePicker_book.Location = new System.Drawing.Point(91, 126);
            this.dateTimePicker_book.Name = "dateTimePicker_book";
            this.dateTimePicker_book.Size = new System.Drawing.Size(241, 25);
            this.dateTimePicker_book.TabIndex = 18;
            // 
            // button_addBook
            // 
            this.button_addBook.BackColor = System.Drawing.Color.BurlyWood;
            this.button_addBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addBook.Location = new System.Drawing.Point(599, 211);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(100, 32);
            this.button_addBook.TabIndex = 17;
            this.button_addBook.Text = "Add";
            this.button_addBook.UseVisualStyleBackColor = false;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // button_clearBook
            // 
            this.button_clearBook.BackColor = System.Drawing.Color.BurlyWood;
            this.button_clearBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearBook.Location = new System.Drawing.Point(458, 211);
            this.button_clearBook.Name = "button_clearBook";
            this.button_clearBook.Size = new System.Drawing.Size(100, 32);
            this.button_clearBook.TabIndex = 16;
            this.button_clearBook.Text = "Clear";
            this.button_clearBook.UseVisualStyleBackColor = false;
            this.button_clearBook.Click += new System.EventHandler(this.button_clearBook_Click);
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(405, 169);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(47, 17);
            this.label_author.TabIndex = 15;
            this.label_author.Text = "Author";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(409, 126);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(43, 17);
            this.label_genre.TabIndex = 13;
            this.label_genre.Text = "Genre";
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(458, 126);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(241, 25);
            this.comboBox_genre.TabIndex = 12;
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Location = new System.Drawing.Point(387, 81);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(65, 17);
            this.label_language.TabIndex = 11;
            this.label_language.Text = "Language";
            // 
            // comboBox_language
            // 
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Location = new System.Drawing.Point(458, 81);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(241, 25);
            this.comboBox_language.TabIndex = 10;
            // 
            // label_publisher
            // 
            this.label_publisher.AutoSize = true;
            this.label_publisher.Location = new System.Drawing.Point(391, 39);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(61, 17);
            this.label_publisher.TabIndex = 9;
            this.label_publisher.Text = "Publisher";
            // 
            // comboBox_publisher
            // 
            this.comboBox_publisher.FormattingEnabled = true;
            this.comboBox_publisher.Location = new System.Drawing.Point(458, 39);
            this.comboBox_publisher.Name = "comboBox_publisher";
            this.comboBox_publisher.Size = new System.Drawing.Size(241, 25);
            this.comboBox_publisher.TabIndex = 8;
            // 
            // label_publishDate
            // 
            this.label_publishDate.AutoSize = true;
            this.label_publishDate.Location = new System.Drawing.Point(6, 126);
            this.label_publishDate.Name = "label_publishDate";
            this.label_publishDate.Size = new System.Drawing.Size(79, 17);
            this.label_publishDate.TabIndex = 7;
            this.label_publishDate.Text = "Publish date";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(53, 81);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(32, 17);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Title";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(91, 81);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(241, 25);
            this.textBox_title.TabIndex = 2;
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Location = new System.Drawing.Point(50, 39);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(35, 17);
            this.label_ISBN.TabIndex = 1;
            this.label_ISBN.Text = "ISBN";
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Location = new System.Drawing.Point(91, 39);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(241, 25);
            this.textBox_isbn.TabIndex = 0;
            // 
            // panel_topBook
            // 
            this.panel_topBook.Controls.Add(this.splitContainer_book);
            this.panel_topBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topBook.Location = new System.Drawing.Point(3, 3);
            this.panel_topBook.Name = "panel_topBook";
            this.panel_topBook.Size = new System.Drawing.Size(1259, 250);
            this.panel_topBook.TabIndex = 0;
            // 
            // splitContainer_book
            // 
            this.splitContainer_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_book.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_book.Name = "splitContainer_book";
            // 
            // splitContainer_book.Panel1
            // 
            this.splitContainer_book.Panel1.Controls.Add(this.treeView_genre);
            // 
            // splitContainer_book.Panel2
            // 
            this.splitContainer_book.Panel2.Controls.Add(this.advancedDataGridView_book);
            this.splitContainer_book.Size = new System.Drawing.Size(1259, 250);
            this.splitContainer_book.SplitterDistance = 295;
            this.splitContainer_book.TabIndex = 0;
            // 
            // treeView_genre
            // 
            this.treeView_genre.BackColor = System.Drawing.Color.Bisque;
            this.treeView_genre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_genre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_genre.Location = new System.Drawing.Point(0, 0);
            this.treeView_genre.Name = "treeView_genre";
            this.treeView_genre.Size = new System.Drawing.Size(295, 250);
            this.treeView_genre.TabIndex = 0;
            this.treeView_genre.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_genre_AfterLabelEdit);
            this.treeView_genre.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_genre_NodeMouseClick);
            this.treeView_genre.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_genre_NodeMouseDoubleClick);
            // 
            // advancedDataGridView_book
            // 
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_book.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle64;
            this.advancedDataGridView_book.AutoGenerateContextFilters = true;
            this.advancedDataGridView_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_book.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_book.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_book.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_book.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.advancedDataGridView_book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.advancedDataGridView_book.ColumnHeadersHeight = 30;
            this.advancedDataGridView_book.DateWithTime = false;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle66.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_book.DefaultCellStyle = dataGridViewCellStyle66;
            this.advancedDataGridView_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView_book.EnableHeadersVisualStyles = false;
            this.advancedDataGridView_book.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView_book.Name = "advancedDataGridView_book";
            this.advancedDataGridView_book.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.advancedDataGridView_book.Size = new System.Drawing.Size(960, 250);
            this.advancedDataGridView_book.TabIndex = 0;
            this.advancedDataGridView_book.TimeFilter = false;
            this.advancedDataGridView_book.SortStringChanged += new System.EventHandler(this.advancedDataGridView_book_SortStringChanged);
            this.advancedDataGridView_book.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_book_FilterStringChanged);
            this.advancedDataGridView_book.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.advancedDataGridView_book_CellFormatting);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1265, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Member data";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.PeachPuff;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView_cardNumber);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.advancedDataGridView_member);
            this.splitContainer2.Size = new System.Drawing.Size(1259, 293);
            this.splitContainer2.SplitterDistance = 415;
            this.splitContainer2.TabIndex = 1;
            // 
            // dataGridView_cardNumber
            // 
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_cardNumber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle67;
            this.dataGridView_cardNumber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_cardNumber.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_cardNumber.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_cardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_cardNumber.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_cardNumber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_cardNumber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle68;
            this.dataGridView_cardNumber.ColumnHeadersHeight = 30;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle69.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle69.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_cardNumber.DefaultCellStyle = dataGridViewCellStyle69;
            this.dataGridView_cardNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_cardNumber.EnableHeadersVisualStyles = false;
            this.dataGridView_cardNumber.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_cardNumber.Name = "dataGridView_cardNumber";
            this.dataGridView_cardNumber.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_cardNumber.Size = new System.Drawing.Size(415, 293);
            this.dataGridView_cardNumber.TabIndex = 0;
            // 
            // advancedDataGridView_member
            // 
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_member.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle70;
            this.advancedDataGridView_member.AutoGenerateContextFilters = true;
            this.advancedDataGridView_member.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_member.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_member.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_member.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.advancedDataGridView_member.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_member.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.advancedDataGridView_member.ColumnHeadersHeight = 30;
            this.advancedDataGridView_member.DateWithTime = false;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle72.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_member.DefaultCellStyle = dataGridViewCellStyle72;
            this.advancedDataGridView_member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView_member.EnableHeadersVisualStyles = false;
            this.advancedDataGridView_member.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView_member.Name = "advancedDataGridView_member";
            this.advancedDataGridView_member.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.advancedDataGridView_member.Size = new System.Drawing.Size(840, 293);
            this.advancedDataGridView_member.TabIndex = 0;
            this.advancedDataGridView_member.TimeFilter = false;
            this.advancedDataGridView_member.SortStringChanged += new System.EventHandler(this.advancedDataGridView_member_SortStringChanged);
            this.advancedDataGridView_member.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_member_FilterStringChanged);
            this.advancedDataGridView_member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_member_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 290);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(482, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(777, 290);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_generate);
            this.groupBox1.Controls.Add(this.textBox_memberID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate a member report ";
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.BurlyWood;
            this.button_generate.Location = new System.Drawing.Point(252, 37);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(83, 25);
            this.button_generate.TabIndex = 2;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            this.button_generate.MouseHover += new System.EventHandler(this.button_generate_MouseHover);
            // 
            // textBox_memberID
            // 
            this.textBox_memberID.Location = new System.Drawing.Point(136, 38);
            this.textBox_memberID.Name = "textBox_memberID";
            this.textBox_memberID.Size = new System.Drawing.Size(100, 25);
            this.textBox_memberID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Member ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.groupBox_addMember);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(482, 290);
            this.panel2.TabIndex = 0;
            // 
            // groupBox_addMember
            // 
            this.groupBox_addMember.Controls.Add(this.dateTimePicker_member);
            this.groupBox_addMember.Controls.Add(this.button_clear);
            this.groupBox_addMember.Controls.Add(this.label5);
            this.groupBox_addMember.Controls.Add(this.label4);
            this.groupBox_addMember.Controls.Add(this.label3);
            this.groupBox_addMember.Controls.Add(this.label2);
            this.groupBox_addMember.Controls.Add(this.label1);
            this.groupBox_addMember.Controls.Add(this.button_addMember);
            this.groupBox_addMember.Controls.Add(this.textBox_address);
            this.groupBox_addMember.Controls.Add(this.textBox_email);
            this.groupBox_addMember.Controls.Add(this.textBox_phoneNumber);
            this.groupBox_addMember.Controls.Add(this.textBox_fullName);
            this.groupBox_addMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_addMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_addMember.Location = new System.Drawing.Point(15, 15);
            this.groupBox_addMember.Name = "groupBox_addMember";
            this.groupBox_addMember.Size = new System.Drawing.Size(452, 260);
            this.groupBox_addMember.TabIndex = 0;
            this.groupBox_addMember.TabStop = false;
            this.groupBox_addMember.Text = "Add a new member";
            // 
            // dateTimePicker_member
            // 
            this.dateTimePicker_member.Location = new System.Drawing.Point(107, 41);
            this.dateTimePicker_member.Name = "dateTimePicker_member";
            this.dateTimePicker_member.Size = new System.Drawing.Size(308, 25);
            this.dateTimePicker_member.TabIndex = 3;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.BurlyWood;
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_clear.Location = new System.Drawing.Point(191, 222);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 32);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Full name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date added";
            // 
            // button_addMember
            // 
            this.button_addMember.BackColor = System.Drawing.Color.BurlyWood;
            this.button_addMember.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addMember.Location = new System.Drawing.Point(318, 222);
            this.button_addMember.Name = "button_addMember";
            this.button_addMember.Size = new System.Drawing.Size(97, 32);
            this.button_addMember.TabIndex = 5;
            this.button_addMember.Text = "Add member";
            this.button_addMember.UseVisualStyleBackColor = false;
            this.button_addMember.Click += new System.EventHandler(this.button_addMember_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.AccessibleName = "addressInput";
            this.textBox_address.Location = new System.Drawing.Point(107, 187);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(308, 25);
            this.textBox_address.TabIndex = 4;
            // 
            // textBox_email
            // 
            this.textBox_email.AccessibleName = "emailInput";
            this.textBox_email.Location = new System.Drawing.Point(107, 150);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(308, 25);
            this.textBox_email.TabIndex = 3;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.AccessibleName = "phoneNumberInput";
            this.textBox_phoneNumber.Location = new System.Drawing.Point(107, 113);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(308, 25);
            this.textBox_phoneNumber.TabIndex = 2;
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.AccessibleName = "fullNameInput";
            this.textBox_fullName.Location = new System.Drawing.Point(107, 77);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(308, 25);
            this.textBox_fullName.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Bisque;
            this.tabPage4.Controls.Add(this.panel_publisherContainer);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1265, 589);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Publisher information";
            // 
            // panel_publisherContainer
            // 
            this.panel_publisherContainer.Controls.Add(this.panel_publisherRight);
            this.panel_publisherContainer.Controls.Add(this.panel_publisherLeft);
            this.panel_publisherContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_publisherContainer.Location = new System.Drawing.Point(0, 278);
            this.panel_publisherContainer.Name = "panel_publisherContainer";
            this.panel_publisherContainer.Size = new System.Drawing.Size(1265, 311);
            this.panel_publisherContainer.TabIndex = 1;
            // 
            // panel_publisherRight
            // 
            this.panel_publisherRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_publisherRight.Location = new System.Drawing.Point(475, 0);
            this.panel_publisherRight.Name = "panel_publisherRight";
            this.panel_publisherRight.Size = new System.Drawing.Size(790, 311);
            this.panel_publisherRight.TabIndex = 1;
            // 
            // panel_publisherLeft
            // 
            this.panel_publisherLeft.Controls.Add(this.groupBox_addPublisher);
            this.panel_publisherLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_publisherLeft.Location = new System.Drawing.Point(0, 0);
            this.panel_publisherLeft.Name = "panel_publisherLeft";
            this.panel_publisherLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panel_publisherLeft.Size = new System.Drawing.Size(475, 311);
            this.panel_publisherLeft.TabIndex = 0;
            // 
            // groupBox_addPublisher
            // 
            this.groupBox_addPublisher.Controls.Add(this.button_addPublisher);
            this.groupBox_addPublisher.Controls.Add(this.button_clearPublisher);
            this.groupBox_addPublisher.Controls.Add(this.label8);
            this.groupBox_addPublisher.Controls.Add(this.comboBox_countryName);
            this.groupBox_addPublisher.Controls.Add(this.label7);
            this.groupBox_addPublisher.Controls.Add(this.textBox_publisherName);
            this.groupBox_addPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_addPublisher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_addPublisher.Location = new System.Drawing.Point(15, 15);
            this.groupBox_addPublisher.Name = "groupBox_addPublisher";
            this.groupBox_addPublisher.Size = new System.Drawing.Size(445, 281);
            this.groupBox_addPublisher.TabIndex = 0;
            this.groupBox_addPublisher.TabStop = false;
            this.groupBox_addPublisher.Text = "Add a new publisher";
            // 
            // button_addPublisher
            // 
            this.button_addPublisher.BackColor = System.Drawing.Color.BurlyWood;
            this.button_addPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addPublisher.Location = new System.Drawing.Point(295, 149);
            this.button_addPublisher.Name = "button_addPublisher";
            this.button_addPublisher.Size = new System.Drawing.Size(100, 32);
            this.button_addPublisher.TabIndex = 4;
            this.button_addPublisher.Text = "Add";
            this.button_addPublisher.UseVisualStyleBackColor = false;
            this.button_addPublisher.Click += new System.EventHandler(this.button_addPublisher_Click);
            // 
            // button_clearPublisher
            // 
            this.button_clearPublisher.BackColor = System.Drawing.Color.BurlyWood;
            this.button_clearPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearPublisher.Location = new System.Drawing.Point(177, 149);
            this.button_clearPublisher.Name = "button_clearPublisher";
            this.button_clearPublisher.Size = new System.Drawing.Size(100, 32);
            this.button_clearPublisher.TabIndex = 0;
            this.button_clearPublisher.Text = "Clear";
            this.button_clearPublisher.UseVisualStyleBackColor = false;
            this.button_clearPublisher.Click += new System.EventHandler(this.button_clearPublisher_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Country";
            // 
            // comboBox_countryName
            // 
            this.comboBox_countryName.FormattingEnabled = true;
            this.comboBox_countryName.Location = new System.Drawing.Point(127, 101);
            this.comboBox_countryName.Name = "comboBox_countryName";
            this.comboBox_countryName.Size = new System.Drawing.Size(268, 25);
            this.comboBox_countryName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Publisher name";
            // 
            // textBox_publisherName
            // 
            this.textBox_publisherName.Location = new System.Drawing.Point(127, 55);
            this.textBox_publisherName.Name = "textBox_publisherName";
            this.textBox_publisherName.Size = new System.Drawing.Size(268, 25);
            this.textBox_publisherName.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1265, 278);
            this.panel4.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_country);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_publisher);
            this.splitContainer1.Size = new System.Drawing.Size(1265, 278);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView_country
            // 
            dataGridViewCellStyle73.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_country.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle73;
            this.dataGridView_country.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_country.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_country.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_country.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_country.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle74.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle74.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle74.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_country.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle74;
            this.dataGridView_country.ColumnHeadersHeight = 30;
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle75.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle75.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle75.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle75.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle75.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_country.DefaultCellStyle = dataGridViewCellStyle75;
            this.dataGridView_country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_country.EnableHeadersVisualStyles = false;
            this.dataGridView_country.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_country.MultiSelect = false;
            this.dataGridView_country.Name = "dataGridView_country";
            this.dataGridView_country.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_country.Size = new System.Drawing.Size(418, 278);
            this.dataGridView_country.TabIndex = 0;
            // 
            // dataGridView_publisher
            // 
            dataGridViewCellStyle76.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_publisher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle76;
            this.dataGridView_publisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_publisher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_publisher.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_publisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_publisher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_publisher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle77.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle77.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle77.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_publisher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle77;
            this.dataGridView_publisher.ColumnHeadersHeight = 30;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle78.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_publisher.DefaultCellStyle = dataGridViewCellStyle78;
            this.dataGridView_publisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_publisher.EnableHeadersVisualStyles = false;
            this.dataGridView_publisher.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_publisher.Name = "dataGridView_publisher";
            this.dataGridView_publisher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_publisher.Size = new System.Drawing.Size(843, 278);
            this.dataGridView_publisher.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Bisque;
            this.tabPage3.Controls.Add(this.tableLayoutPanel_borrowings);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1265, 589);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Borrowed books";
            // 
            // tableLayoutPanel_borrowings
            // 
            this.tableLayoutPanel_borrowings.ColumnCount = 1;
            this.tableLayoutPanel_borrowings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_borrowings.Controls.Add(this.panel_borrowingsLeft, 0, 1);
            this.tableLayoutPanel_borrowings.Controls.Add(this.advancedDataGridView_borrowings, 0, 0);
            this.tableLayoutPanel_borrowings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_borrowings.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_borrowings.Name = "tableLayoutPanel_borrowings";
            this.tableLayoutPanel_borrowings.RowCount = 2;
            this.tableLayoutPanel_borrowings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.42105F));
            this.tableLayoutPanel_borrowings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.57895F));
            this.tableLayoutPanel_borrowings.Size = new System.Drawing.Size(1265, 589);
            this.tableLayoutPanel_borrowings.TabIndex = 0;
            // 
            // panel_borrowingsLeft
            // 
            this.panel_borrowingsLeft.Controls.Add(this.groupBox_borrowingAdd);
            this.panel_borrowingsLeft.Location = new System.Drawing.Point(3, 288);
            this.panel_borrowingsLeft.Name = "panel_borrowingsLeft";
            this.panel_borrowingsLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panel_borrowingsLeft.Size = new System.Drawing.Size(518, 298);
            this.panel_borrowingsLeft.TabIndex = 1;
            // 
            // groupBox_borrowingAdd
            // 
            this.groupBox_borrowingAdd.Controls.Add(this.textBox_borrowingBook);
            this.groupBox_borrowingAdd.Controls.Add(this.textBox_borrowingMember);
            this.groupBox_borrowingAdd.Controls.Add(this.dateTimePicker_dateDue);
            this.groupBox_borrowingAdd.Controls.Add(this.dateTimePicker_dateBorrowed);
            this.groupBox_borrowingAdd.Controls.Add(this.button_addBorrowing);
            this.groupBox_borrowingAdd.Controls.Add(this.button_clearBorrowing);
            this.groupBox_borrowingAdd.Controls.Add(this.label_dateDue);
            this.groupBox_borrowingAdd.Controls.Add(this.label_dateBorrowed);
            this.groupBox_borrowingAdd.Controls.Add(this.label_bookNumber);
            this.groupBox_borrowingAdd.Controls.Add(this.label_memberNumber);
            this.groupBox_borrowingAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_borrowingAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_borrowingAdd.Location = new System.Drawing.Point(15, 15);
            this.groupBox_borrowingAdd.Name = "groupBox_borrowingAdd";
            this.groupBox_borrowingAdd.Size = new System.Drawing.Size(488, 268);
            this.groupBox_borrowingAdd.TabIndex = 0;
            this.groupBox_borrowingAdd.TabStop = false;
            this.groupBox_borrowingAdd.Text = "Register a borrowed book";
            // 
            // textBox_borrowingBook
            // 
            this.textBox_borrowingBook.Location = new System.Drawing.Point(152, 81);
            this.textBox_borrowingBook.Name = "textBox_borrowingBook";
            this.textBox_borrowingBook.Size = new System.Drawing.Size(250, 25);
            this.textBox_borrowingBook.TabIndex = 13;
            this.textBox_borrowingBook.DoubleClick += new System.EventHandler(this.textBox_borrowingBook_DoubleClick);
            // 
            // textBox_borrowingMember
            // 
            this.textBox_borrowingMember.Location = new System.Drawing.Point(152, 38);
            this.textBox_borrowingMember.Name = "textBox_borrowingMember";
            this.textBox_borrowingMember.Size = new System.Drawing.Size(250, 25);
            this.textBox_borrowingMember.TabIndex = 12;
            this.textBox_borrowingMember.DoubleClick += new System.EventHandler(this.textBox_borrowingMember_DoubleClick);
            // 
            // dateTimePicker_dateDue
            // 
            this.dateTimePicker_dateDue.Location = new System.Drawing.Point(152, 170);
            this.dateTimePicker_dateDue.Name = "dateTimePicker_dateDue";
            this.dateTimePicker_dateDue.Size = new System.Drawing.Size(250, 25);
            this.dateTimePicker_dateDue.TabIndex = 11;
            // 
            // dateTimePicker_dateBorrowed
            // 
            this.dateTimePicker_dateBorrowed.Location = new System.Drawing.Point(152, 123);
            this.dateTimePicker_dateBorrowed.Name = "dateTimePicker_dateBorrowed";
            this.dateTimePicker_dateBorrowed.Size = new System.Drawing.Size(250, 25);
            this.dateTimePicker_dateBorrowed.TabIndex = 10;
            // 
            // button_addBorrowing
            // 
            this.button_addBorrowing.BackColor = System.Drawing.Color.BurlyWood;
            this.button_addBorrowing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addBorrowing.Location = new System.Drawing.Point(302, 217);
            this.button_addBorrowing.Name = "button_addBorrowing";
            this.button_addBorrowing.Size = new System.Drawing.Size(100, 32);
            this.button_addBorrowing.TabIndex = 9;
            this.button_addBorrowing.Text = "Add";
            this.button_addBorrowing.UseVisualStyleBackColor = false;
            this.button_addBorrowing.Click += new System.EventHandler(this.button_addBorrowing_Click);
            // 
            // button_clearBorrowing
            // 
            this.button_clearBorrowing.BackColor = System.Drawing.Color.BurlyWood;
            this.button_clearBorrowing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearBorrowing.Location = new System.Drawing.Point(180, 217);
            this.button_clearBorrowing.Name = "button_clearBorrowing";
            this.button_clearBorrowing.Size = new System.Drawing.Size(100, 32);
            this.button_clearBorrowing.TabIndex = 8;
            this.button_clearBorrowing.Text = "Clear";
            this.button_clearBorrowing.UseVisualStyleBackColor = false;
            this.button_clearBorrowing.Click += new System.EventHandler(this.button_clearBorrowing_Click);
            // 
            // label_dateDue
            // 
            this.label_dateDue.AutoSize = true;
            this.label_dateDue.Location = new System.Drawing.Point(85, 170);
            this.label_dateDue.Name = "label_dateDue";
            this.label_dateDue.Size = new System.Drawing.Size(61, 17);
            this.label_dateDue.TabIndex = 7;
            this.label_dateDue.Text = "Date due";
            // 
            // label_dateBorrowed
            // 
            this.label_dateBorrowed.AutoSize = true;
            this.label_dateBorrowed.Location = new System.Drawing.Point(49, 129);
            this.label_dateBorrowed.Name = "label_dateBorrowed";
            this.label_dateBorrowed.Size = new System.Drawing.Size(97, 17);
            this.label_dateBorrowed.TabIndex = 6;
            this.label_dateBorrowed.Text = "Date borrowed";
            // 
            // label_bookNumber
            // 
            this.label_bookNumber.AutoSize = true;
            this.label_bookNumber.Location = new System.Drawing.Point(97, 81);
            this.label_bookNumber.Name = "label_bookNumber";
            this.label_bookNumber.Size = new System.Drawing.Size(49, 17);
            this.label_bookNumber.TabIndex = 5;
            this.label_bookNumber.Text = "Book #";
            // 
            // label_memberNumber
            // 
            this.label_memberNumber.AutoSize = true;
            this.label_memberNumber.Location = new System.Drawing.Point(76, 38);
            this.label_memberNumber.Name = "label_memberNumber";
            this.label_memberNumber.Size = new System.Drawing.Size(70, 17);
            this.label_memberNumber.TabIndex = 4;
            this.label_memberNumber.Text = "Member #";
            // 
            // advancedDataGridView_borrowings
            // 
            dataGridViewCellStyle79.BackColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_borrowings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle79;
            this.advancedDataGridView_borrowings.AutoGenerateContextFilters = true;
            this.advancedDataGridView_borrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_borrowings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_borrowings.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_borrowings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_borrowings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.advancedDataGridView_borrowings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle80.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle80.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle80.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle80.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle80.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle80.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_borrowings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle80;
            this.advancedDataGridView_borrowings.ColumnHeadersHeight = 30;
            this.advancedDataGridView_borrowings.DateWithTime = false;
            dataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle81.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle81.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle81.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle81.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle81.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle81.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_borrowings.DefaultCellStyle = dataGridViewCellStyle81;
            this.advancedDataGridView_borrowings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView_borrowings.EnableHeadersVisualStyles = false;
            this.advancedDataGridView_borrowings.Location = new System.Drawing.Point(3, 3);
            this.advancedDataGridView_borrowings.Name = "advancedDataGridView_borrowings";
            this.advancedDataGridView_borrowings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.advancedDataGridView_borrowings.Size = new System.Drawing.Size(1259, 279);
            this.advancedDataGridView_borrowings.TabIndex = 2;
            this.advancedDataGridView_borrowings.TimeFilter = false;
            this.advancedDataGridView_borrowings.SortStringChanged += new System.EventHandler(this.advancedDataGridView_borrowings_SortStringChanged);
            this.advancedDataGridView_borrowings.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_borrowings_FilterStringChanged);
            this.advancedDataGridView_borrowings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_borrowings_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1265, 589);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "E-mail reminders";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 583);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53871F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.4613F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1253, 285);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "Overdue members";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_membersForEmail, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.33692F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.66309F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(314, 279);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridView_membersForEmail
            // 
            this.dataGridView_membersForEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_membersForEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_membersForEmail.Location = new System.Drawing.Point(3, 43);
            this.dataGridView_membersForEmail.Name = "dataGridView_membersForEmail";
            this.dataGridView_membersForEmail.Size = new System.Drawing.Size(308, 233);
            this.dataGridView_membersForEmail.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1253, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Check for ovedue books";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1273, 640);
            this.Controls.Add(this.tabEmail);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibraryForm";
            this.Text = "Library system";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabEmail.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_bookBottom.ResumeLayout(false);
            this.tableLayoutPanel_book.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_language)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_author)).EndInit();
            this.panel_bookGroup.ResumeLayout(false);
            this.groupBox_book.ResumeLayout(false);
            this.groupBox_book.PerformLayout();
            this.panel_topBook.ResumeLayout(false);
            this.splitContainer_book.Panel1.ResumeLayout(false);
            this.splitContainer_book.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_book)).EndInit();
            this.splitContainer_book.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_book)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cardNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_member)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox_addMember.ResumeLayout(false);
            this.groupBox_addMember.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel_publisherContainer.ResumeLayout(false);
            this.panel_publisherLeft.ResumeLayout(false);
            this.groupBox_addPublisher.ResumeLayout(false);
            this.groupBox_addPublisher.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_country)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_publisher)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel_borrowings.ResumeLayout(false);
            this.panel_borrowingsLeft.ResumeLayout(false);
            this.groupBox_borrowingAdd.ResumeLayout(false);
            this.groupBox_borrowingAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_borrowings)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_membersForEmail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_refreshData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_update;
        private System.Windows.Forms.TabControl tabEmail;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_cardNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox_addMember;
        private System.Windows.Forms.Button button_addMember;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox textBox_memberID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_country;
        private System.Windows.Forms.DataGridView dataGridView_publisher;
        private System.Windows.Forms.Panel panel_publisherContainer;
        private System.Windows.Forms.Panel panel_publisherRight;
        private System.Windows.Forms.Panel panel_publisherLeft;
        private System.Windows.Forms.GroupBox groupBox_addPublisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_countryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_publisherName;
        private System.Windows.Forms.Button button_clearPublisher;
        private System.Windows.Forms.Button button_addPublisher;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_borrowings;
        private Panel panel_topBook;
        private SplitContainer splitContainer_book;
        private TreeView treeView_genre;
        private Panel panel_bookBottom;
        private Panel panel_bookGroup;
        private TableLayoutPanel tableLayoutPanel_book;
        private DataGridView dataGridView_genre;
        private DataGridView dataGridView_language;
        private DataGridView dataGridView_author;
        private GroupBox groupBox_book;
        private Label label_ISBN;
        private TextBox textBox_isbn;
        private ComboBox comboBox_publisher;
        private Label label_publishDate;
        private Label label_title;
        private TextBox textBox_title;
        private Label label_author;
        private Label label_genre;
        private ComboBox comboBox_genre;
        private Label label_language;
        private ComboBox comboBox_language;
        private Label label_publisher;
        private Button button_addBook;
        private Button button_clearBook;
        private Panel panel_borrowingsLeft;
        private GroupBox groupBox_borrowingAdd;
        private Label label_dateDue;
        private Label label_dateBorrowed;
        private Label label_bookNumber;
        private Label label_memberNumber;
        private Button button_addBorrowing;
        private Button button_clearBorrowing;
        private ADGV.AdvancedDataGridView advancedDataGridView_borrowings;
        private ADGV.AdvancedDataGridView advancedDataGridView_member;
        private DateTimePicker dateTimePicker_member;
        private DateTimePicker dateTimePicker_dateDue;
        private DateTimePicker dateTimePicker_dateBorrowed;
        private DateTimePicker dateTimePicker_book;
        private TextBox textBox_borrowingMember;
        private TextBox textBox_borrowingBook;
        private AdvancedDataGridView advancedDataGridView_book;
        private ComboBox comboBox_author;
        private TabPage tabPage5;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView_membersForEmail;
        private GroupBox groupBox2;
        private Label label10;
    }
}

