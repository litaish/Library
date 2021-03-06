
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle181 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle182 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle183 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle184 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle185 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle186 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle187 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle188 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle189 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle190 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle191 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle192 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle193 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle194 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle195 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle196 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle197 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle198 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle199 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle200 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle201 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle202 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle203 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle204 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle205 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle206 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle207 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle208 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle209 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle210 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_refreshData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_update = new System.Windows.Forms.ToolStripButton();
            this.tabStatistics = new System.Windows.Forms.TabControl();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_membersForEmail = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox_emailLogs = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label_overdueWarning = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button_clearLogs = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button_sendEmails = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_checkOverdue = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_bookStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label_totalBooks = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_showStatistics = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button_exportToPDF = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.adgv_memberFines = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.advancedDataGridView_memberFines = new ADGV.AdvancedDataGridView();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_exportFinesToPDF = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button_showFines = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_submitFine = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.button_clearFine = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.checkBox_lost = new System.Windows.Forms.CheckBox();
            this.checkBox_damaged = new System.Windows.Forms.CheckBox();
            this.checkBox_OverdueFine = new System.Windows.Forms.CheckBox();
            this.numericUpDown_fineAmount = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_selectedMemberData = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button_openFile = new System.Windows.Forms.Button();
            this.pictureBox_barCode = new System.Windows.Forms.PictureBox();
            this.textBox_barCode = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label_45 = new System.Windows.Forms.Label();
            this.dataGridView_barcodeResult = new System.Windows.Forms.DataGridView();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox_captureChoice = new System.Windows.Forms.ComboBox();
            this.pictureBox_video = new System.Windows.Forms.PictureBox();
            this.label31 = new System.Windows.Forms.Label();
            this.button_startStopRecord = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox_barcodeVideo = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.dataGridView_videoBook = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.button_stopRecording = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabStatistics.SuspendLayout();
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
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bookStatistics)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.adgv_memberFines.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_memberFines)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fineAmount)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barcodeResult)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_videoBook)).BeginInit();
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
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.tabPage1);
            this.tabStatistics.Controls.Add(this.tabPage2);
            this.tabStatistics.Controls.Add(this.tabPage4);
            this.tabStatistics.Controls.Add(this.tabPage3);
            this.tabStatistics.Controls.Add(this.tabPage5);
            this.tabStatistics.Controls.Add(this.tabPage6);
            this.tabStatistics.Controls.Add(this.tabPage7);
            this.tabStatistics.Controls.Add(this.tabPage8);
            this.tabStatistics.Controls.Add(this.tabPage9);
            this.tabStatistics.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStatistics.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatistics.Location = new System.Drawing.Point(0, 25);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.SelectedIndex = 0;
            this.tabStatistics.Size = new System.Drawing.Size(1273, 615);
            this.tabStatistics.TabIndex = 2;
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
            this.tableLayoutPanel_book.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
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
            dataGridViewCellStyle181.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_genre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle181;
            this.dataGridView_genre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_genre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_genre.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_genre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_genre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle182.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle182.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle182.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle182.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle182.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle182.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle182.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_genre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle182;
            this.dataGridView_genre.ColumnHeadersHeight = 30;
            dataGridViewCellStyle183.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle183.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle183.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle183.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle183.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle183.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle183.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_genre.DefaultCellStyle = dataGridViewCellStyle183;
            this.dataGridView_genre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_genre.EnableHeadersVisualStyles = false;
            this.dataGridView_genre.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_genre.Name = "dataGridView_genre";
            this.dataGridView_genre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_genre.Size = new System.Drawing.Size(171, 327);
            this.dataGridView_genre.TabIndex = 0;
            // 
            // dataGridView_language
            // 
            dataGridViewCellStyle184.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_language.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle184;
            this.dataGridView_language.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_language.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_language.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_language.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_language.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle185.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle185.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle185.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle185.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle185.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle185.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle185.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_language.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle185;
            this.dataGridView_language.ColumnHeadersHeight = 30;
            dataGridViewCellStyle186.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle186.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle186.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle186.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle186.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle186.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle186.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_language.DefaultCellStyle = dataGridViewCellStyle186;
            this.dataGridView_language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_language.EnableHeadersVisualStyles = false;
            this.dataGridView_language.Location = new System.Drawing.Point(180, 3);
            this.dataGridView_language.Name = "dataGridView_language";
            this.dataGridView_language.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_language.Size = new System.Drawing.Size(163, 327);
            this.dataGridView_language.TabIndex = 1;
            // 
            // dataGridView_author
            // 
            dataGridViewCellStyle187.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_author.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle187;
            this.dataGridView_author.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_author.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_author.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_author.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_author.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle188.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle188.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle188.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle188.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle188.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle188.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle188.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_author.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle188;
            this.dataGridView_author.ColumnHeadersHeight = 30;
            dataGridViewCellStyle189.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle189.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle189.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle189.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle189.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle189.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle189.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_author.DefaultCellStyle = dataGridViewCellStyle189;
            this.dataGridView_author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_author.EnableHeadersVisualStyles = false;
            this.dataGridView_author.Location = new System.Drawing.Point(349, 3);
            this.dataGridView_author.Name = "dataGridView_author";
            this.dataGridView_author.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_author.Size = new System.Drawing.Size(168, 327);
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
            dataGridViewCellStyle190.BackColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_book.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle190;
            this.advancedDataGridView_book.AutoGenerateContextFilters = true;
            this.advancedDataGridView_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_book.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_book.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_book.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_book.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.advancedDataGridView_book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle191.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle191.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle191.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle191.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle191.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle191.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle191.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle191;
            this.advancedDataGridView_book.ColumnHeadersHeight = 30;
            this.advancedDataGridView_book.DateWithTime = false;
            dataGridViewCellStyle192.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle192.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle192.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle192.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle192.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle192.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle192.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_book.DefaultCellStyle = dataGridViewCellStyle192;
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
            dataGridViewCellStyle193.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_cardNumber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle193;
            this.dataGridView_cardNumber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_cardNumber.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_cardNumber.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_cardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_cardNumber.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_cardNumber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle194.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle194.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle194.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle194.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle194.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle194.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle194.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_cardNumber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle194;
            this.dataGridView_cardNumber.ColumnHeadersHeight = 30;
            dataGridViewCellStyle195.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle195.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle195.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle195.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle195.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle195.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle195.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_cardNumber.DefaultCellStyle = dataGridViewCellStyle195;
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
            dataGridViewCellStyle196.BackColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_member.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle196;
            this.advancedDataGridView_member.AutoGenerateContextFilters = true;
            this.advancedDataGridView_member.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_member.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_member.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_member.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.advancedDataGridView_member.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle197.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle197.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle197.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle197.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle197.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle197.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle197.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_member.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle197;
            this.advancedDataGridView_member.ColumnHeadersHeight = 30;
            this.advancedDataGridView_member.DateWithTime = false;
            dataGridViewCellStyle198.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle198.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle198.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle198.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle198.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle198.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle198.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_member.DefaultCellStyle = dataGridViewCellStyle198;
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
            dataGridViewCellStyle199.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_country.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle199;
            this.dataGridView_country.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_country.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_country.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_country.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_country.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle200.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle200.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle200.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle200.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle200.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle200.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle200.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_country.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle200;
            this.dataGridView_country.ColumnHeadersHeight = 30;
            dataGridViewCellStyle201.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle201.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle201.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle201.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle201.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle201.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle201.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_country.DefaultCellStyle = dataGridViewCellStyle201;
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
            dataGridViewCellStyle202.BackColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_publisher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle202;
            this.dataGridView_publisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_publisher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_publisher.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView_publisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_publisher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_publisher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle203.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle203.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle203.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle203.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle203.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle203.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle203.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_publisher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle203;
            this.dataGridView_publisher.ColumnHeadersHeight = 30;
            dataGridViewCellStyle204.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle204.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle204.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle204.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle204.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle204.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle204.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_publisher.DefaultCellStyle = dataGridViewCellStyle204;
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
            dataGridViewCellStyle205.BackColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_borrowings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle205;
            this.advancedDataGridView_borrowings.AutoGenerateContextFilters = true;
            this.advancedDataGridView_borrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_borrowings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_borrowings.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.advancedDataGridView_borrowings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_borrowings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.advancedDataGridView_borrowings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle206.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle206.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle206.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle206.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle206.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle206.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle206.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_borrowings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle206;
            this.advancedDataGridView_borrowings.ColumnHeadersHeight = 30;
            this.advancedDataGridView_borrowings.DateWithTime = false;
            dataGridViewCellStyle207.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle207.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle207.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle207.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle207.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle207.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle207.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_borrowings.DefaultCellStyle = dataGridViewCellStyle207;
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
            this.tabPage5.BackColor = System.Drawing.Color.Bisque;
            this.tabPage5.Controls.Add(this.tableLayoutPanel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1265, 589);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "E-mail reminders";
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
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1253, 285);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
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
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.33692F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.66309F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(313, 279);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "Overdue members";
            // 
            // dataGridView_membersForEmail
            // 
            this.dataGridView_membersForEmail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_membersForEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_membersForEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_membersForEmail.Location = new System.Drawing.Point(3, 40);
            this.dataGridView_membersForEmail.Name = "dataGridView_membersForEmail";
            this.dataGridView_membersForEmail.Size = new System.Drawing.Size(307, 215);
            this.dataGridView_membersForEmail.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.4181F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58189F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(322, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(928, 279);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.richTextBox_emailLogs, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(276, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.17949F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(649, 273);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(643, 34);
            this.label11.TabIndex = 0;
            this.label11.Text = "E-mail logs";
            // 
            // richTextBox_emailLogs
            // 
            this.richTextBox_emailLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_emailLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_emailLogs.Location = new System.Drawing.Point(3, 37);
            this.richTextBox_emailLogs.Name = "richTextBox_emailLogs";
            this.richTextBox_emailLogs.Size = new System.Drawing.Size(643, 233);
            this.richTextBox_emailLogs.TabIndex = 1;
            this.richTextBox_emailLogs.Text = "";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label_overdueWarning, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.50183F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.49817F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(267, 273);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label_overdueWarning
            // 
            this.label_overdueWarning.AutoSize = true;
            this.label_overdueWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_overdueWarning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_overdueWarning.Location = new System.Drawing.Point(3, 64);
            this.label_overdueWarning.Name = "label_overdueWarning";
            this.label_overdueWarning.Size = new System.Drawing.Size(261, 21);
            this.label_overdueWarning.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button_clearLogs);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button_sendEmails);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button_checkOverdue);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 301);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1239, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(594, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "Clear e-mail logs";
            // 
            // button_clearLogs
            // 
            this.button_clearLogs.BackColor = System.Drawing.Color.BurlyWood;
            this.button_clearLogs.Location = new System.Drawing.Point(598, 157);
            this.button_clearLogs.Name = "button_clearLogs";
            this.button_clearLogs.Size = new System.Drawing.Size(100, 32);
            this.button_clearLogs.TabIndex = 5;
            this.button_clearLogs.Text = "Clear";
            this.button_clearLogs.UseVisualStyleBackColor = false;
            this.button_clearLogs.Click += new System.EventHandler(this.button_clearLogs_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(594, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Send reminder e-mails";
            // 
            // button_sendEmails
            // 
            this.button_sendEmails.BackColor = System.Drawing.Color.BurlyWood;
            this.button_sendEmails.Location = new System.Drawing.Point(598, 67);
            this.button_sendEmails.Name = "button_sendEmails";
            this.button_sendEmails.Size = new System.Drawing.Size(100, 32);
            this.button_sendEmails.TabIndex = 3;
            this.button_sendEmails.Text = "Send";
            this.button_sendEmails.UseVisualStyleBackColor = false;
            this.button_sendEmails.Click += new System.EventHandler(this.button_sendEmails_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Check for ovedue books";
            // 
            // button_checkOverdue
            // 
            this.button_checkOverdue.BackColor = System.Drawing.Color.BurlyWood;
            this.button_checkOverdue.Location = new System.Drawing.Point(10, 67);
            this.button_checkOverdue.Name = "button_checkOverdue";
            this.button_checkOverdue.Size = new System.Drawing.Size(100, 32);
            this.button_checkOverdue.TabIndex = 2;
            this.button_checkOverdue.Text = "Check";
            this.button_checkOverdue.UseVisualStyleBackColor = false;
            this.button_checkOverdue.Click += new System.EventHandler(this.button_checkOverdue_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Bisque;
            this.tabPage6.Controls.Add(this.tableLayoutPanel7);
            this.tabPage6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1265, 589);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Statistics for books";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.32767F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.67233F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1265, 589);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.95075F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.04925F));
            this.tableLayoutPanel8.Controls.Add(this.chart_bookStatistics, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 366F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1259, 366);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // chart_bookStatistics
            // 
            this.chart_bookStatistics.BorderlineWidth = 3;
            chartArea7.Name = "ChartArea1";
            this.chart_bookStatistics.ChartAreas.Add(chartArea7);
            this.chart_bookStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.chart_bookStatistics.Legends.Add(legend7);
            this.chart_bookStatistics.Location = new System.Drawing.Point(228, 3);
            this.chart_bookStatistics.Name = "chart_bookStatistics";
            series13.BackImageTransparentColor = System.Drawing.Color.White;
            series13.BackSecondaryColor = System.Drawing.Color.White;
            series13.ChartArea = "ChartArea1";
            series13.Color = System.Drawing.Color.SandyBrown;
            series13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series13.Legend = "Legend1";
            series13.Name = "Available books";
            series14.ChartArea = "ChartArea1";
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.Legend = "Legend1";
            series14.Name = "Borrowed books";
            this.chart_bookStatistics.Series.Add(series13);
            this.chart_bookStatistics.Series.Add(series14);
            this.chart_bookStatistics.Size = new System.Drawing.Size(1028, 360);
            this.chart_bookStatistics.TabIndex = 0;
            this.chart_bookStatistics.Text = "chart1";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label_totalBooks, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.93075F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.06925F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(219, 360);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // label_totalBooks
            // 
            this.label_totalBooks.AutoSize = true;
            this.label_totalBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_totalBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalBooks.Location = new System.Drawing.Point(3, 68);
            this.label_totalBooks.Name = "label_totalBooks";
            this.label_totalBooks.Size = new System.Drawing.Size(213, 21);
            this.label_totalBooks.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_showStatistics);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.button_exportToPDF);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 382);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1245, 197);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options for statistics";
            // 
            // button_showStatistics
            // 
            this.button_showStatistics.BackColor = System.Drawing.Color.BurlyWood;
            this.button_showStatistics.Location = new System.Drawing.Point(10, 65);
            this.button_showStatistics.Name = "button_showStatistics";
            this.button_showStatistics.Size = new System.Drawing.Size(100, 32);
            this.button_showStatistics.TabIndex = 3;
            this.button_showStatistics.Text = "Show";
            this.button_showStatistics.UseVisualStyleBackColor = false;
            this.button_showStatistics.Click += new System.EventHandler(this.button_showStatistics_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Show book statistics";
            // 
            // button_exportToPDF
            // 
            this.button_exportToPDF.BackColor = System.Drawing.Color.BurlyWood;
            this.button_exportToPDF.ForeColor = System.Drawing.Color.Black;
            this.button_exportToPDF.Location = new System.Drawing.Point(10, 143);
            this.button_exportToPDF.Name = "button_exportToPDF";
            this.button_exportToPDF.Size = new System.Drawing.Size(100, 32);
            this.button_exportToPDF.TabIndex = 1;
            this.button_exportToPDF.Text = "Export";
            this.button_exportToPDF.UseVisualStyleBackColor = false;
            this.button_exportToPDF.Click += new System.EventHandler(this.button_exportToPDF_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(219, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Export book statistics to PDF";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Bisque;
            this.tabPage7.Controls.Add(this.adgv_memberFines);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1265, 589);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Fine handling";
            // 
            // adgv_memberFines
            // 
            this.adgv_memberFines.ColumnCount = 1;
            this.adgv_memberFines.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adgv_memberFines.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.adgv_memberFines.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.adgv_memberFines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adgv_memberFines.Location = new System.Drawing.Point(0, 0);
            this.adgv_memberFines.Name = "adgv_memberFines";
            this.adgv_memberFines.RowCount = 2;
            this.adgv_memberFines.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.19695F));
            this.adgv_memberFines.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.80305F));
            this.adgv_memberFines.Size = new System.Drawing.Size(1265, 589);
            this.adgv_memberFines.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.69182F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.30818F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.advancedDataGridView_memberFines, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1259, 325);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.61442F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.38558F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(393, 319);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(97, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 30);
            this.label16.TabIndex = 0;
            this.label16.Text = "Fining information";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 4;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(387, 261);
            this.tableLayoutPanel13.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(203, 30);
            this.label17.TabIndex = 0;
            this.label17.Text = "Overdue book - 10$";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(214, 30);
            this.label19.TabIndex = 1;
            this.label19.Text = "Damaged book - 10$";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 165);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(165, 30);
            this.label20.TabIndex = 2;
            this.label20.Text = "Lost book - 20$";
            // 
            // advancedDataGridView_memberFines
            // 
            dataGridViewCellStyle208.BackColor = System.Drawing.Color.WhiteSmoke;
            this.advancedDataGridView_memberFines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle208;
            this.advancedDataGridView_memberFines.AutoGenerateContextFilters = true;
            this.advancedDataGridView_memberFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView_memberFines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_memberFines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView_memberFines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle209.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle209.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle209.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle209.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle209.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle209.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle209.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_memberFines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle209;
            this.advancedDataGridView_memberFines.ColumnHeadersHeight = 30;
            this.advancedDataGridView_memberFines.DateWithTime = false;
            dataGridViewCellStyle210.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle210.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle210.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle210.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle210.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle210.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle210.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView_memberFines.DefaultCellStyle = dataGridViewCellStyle210;
            this.advancedDataGridView_memberFines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView_memberFines.EnableHeadersVisualStyles = false;
            this.advancedDataGridView_memberFines.Location = new System.Drawing.Point(402, 3);
            this.advancedDataGridView_memberFines.Name = "advancedDataGridView_memberFines";
            this.advancedDataGridView_memberFines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.advancedDataGridView_memberFines.Size = new System.Drawing.Size(854, 319);
            this.advancedDataGridView_memberFines.TabIndex = 1;
            this.advancedDataGridView_memberFines.TimeFilter = false;
            this.advancedDataGridView_memberFines.SortStringChanged += new System.EventHandler(this.advancedDataGridView_memberFines_SortStringChanged);
            this.advancedDataGridView_memberFines.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_memberFines_FilterStringChanged);
            this.advancedDataGridView_memberFines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_memberFines_CellClick);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.15806F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.84194F));
            this.tableLayoutPanel10.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 334);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1259, 252);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_exportFinesToPDF);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.button_showFines);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(472, 232);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Basic controls";
            // 
            // button_exportFinesToPDF
            // 
            this.button_exportFinesToPDF.BackColor = System.Drawing.Color.BurlyWood;
            this.button_exportFinesToPDF.Location = new System.Drawing.Point(12, 151);
            this.button_exportFinesToPDF.Name = "button_exportFinesToPDF";
            this.button_exportFinesToPDF.Size = new System.Drawing.Size(100, 32);
            this.button_exportFinesToPDF.TabIndex = 3;
            this.button_exportFinesToPDF.Text = "Export";
            this.button_exportFinesToPDF.UseVisualStyleBackColor = false;
            this.button_exportFinesToPDF.Click += new System.EventHandler(this.button_exportFinesToPDF_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 127);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 21);
            this.label21.TabIndex = 2;
            this.label21.Text = "Export report to PDF";
            // 
            // button_showFines
            // 
            this.button_showFines.BackColor = System.Drawing.Color.BurlyWood;
            this.button_showFines.Location = new System.Drawing.Point(12, 73);
            this.button_showFines.Name = "button_showFines";
            this.button_showFines.Size = new System.Drawing.Size(100, 32);
            this.button_showFines.TabIndex = 1;
            this.button_showFines.Text = "Show";
            this.button_showFines.UseVisualStyleBackColor = false;
            this.button_showFines.Click += new System.EventHandler(this.button_showFines_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(191, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Show member fines data";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_submitFine);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.button_clearFine);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.checkBox_lost);
            this.groupBox5.Controls.Add(this.checkBox_damaged);
            this.groupBox5.Controls.Add(this.checkBox_OverdueFine);
            this.groupBox5.Controls.Add(this.numericUpDown_fineAmount);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.textBox_selectedMemberData);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(502, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(747, 232);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fine management";
            // 
            // button_submitFine
            // 
            this.button_submitFine.BackColor = System.Drawing.Color.BurlyWood;
            this.button_submitFine.Location = new System.Drawing.Point(577, 151);
            this.button_submitFine.Name = "button_submitFine";
            this.button_submitFine.Size = new System.Drawing.Size(100, 32);
            this.button_submitFine.TabIndex = 11;
            this.button_submitFine.Text = "Submit";
            this.button_submitFine.UseVisualStyleBackColor = false;
            this.button_submitFine.Click += new System.EventHandler(this.button_submitFine_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(573, 127);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(158, 21);
            this.label25.TabIndex = 10;
            this.label25.Text = "Submit fine changes";
            // 
            // button_clearFine
            // 
            this.button_clearFine.BackColor = System.Drawing.Color.BurlyWood;
            this.button_clearFine.Location = new System.Drawing.Point(577, 73);
            this.button_clearFine.Name = "button_clearFine";
            this.button_clearFine.Size = new System.Drawing.Size(100, 32);
            this.button_clearFine.TabIndex = 9;
            this.button_clearFine.Text = "Clear";
            this.button_clearFine.UseVisualStyleBackColor = false;
            this.button_clearFine.Click += new System.EventHandler(this.button_clearFine_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(573, 49);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 21);
            this.label24.TabIndex = 8;
            this.label24.Text = "Clear fine";
            // 
            // checkBox_lost
            // 
            this.checkBox_lost.AutoSize = true;
            this.checkBox_lost.Location = new System.Drawing.Point(293, 207);
            this.checkBox_lost.Name = "checkBox_lost";
            this.checkBox_lost.Size = new System.Drawing.Size(58, 25);
            this.checkBox_lost.TabIndex = 7;
            this.checkBox_lost.Text = "Lost";
            this.checkBox_lost.UseVisualStyleBackColor = true;
            this.checkBox_lost.Click += new System.EventHandler(this.checkBox_lost_Click);
            // 
            // checkBox_damaged
            // 
            this.checkBox_damaged.AutoSize = true;
            this.checkBox_damaged.Location = new System.Drawing.Point(293, 165);
            this.checkBox_damaged.Name = "checkBox_damaged";
            this.checkBox_damaged.Size = new System.Drawing.Size(96, 25);
            this.checkBox_damaged.TabIndex = 6;
            this.checkBox_damaged.Text = "Damaged";
            this.checkBox_damaged.UseVisualStyleBackColor = true;
            this.checkBox_damaged.Click += new System.EventHandler(this.checkBox_damaged_Click);
            // 
            // checkBox_OverdueFine
            // 
            this.checkBox_OverdueFine.AutoSize = true;
            this.checkBox_OverdueFine.Location = new System.Drawing.Point(293, 123);
            this.checkBox_OverdueFine.Name = "checkBox_OverdueFine";
            this.checkBox_OverdueFine.Size = new System.Drawing.Size(89, 25);
            this.checkBox_OverdueFine.TabIndex = 5;
            this.checkBox_OverdueFine.Text = "Overdue";
            this.checkBox_OverdueFine.UseVisualStyleBackColor = true;
            this.checkBox_OverdueFine.Click += new System.EventHandler(this.checkBox_OverdueFine_Click);
            // 
            // numericUpDown_fineAmount
            // 
            this.numericUpDown_fineAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_fineAmount.ForeColor = System.Drawing.Color.Red;
            this.numericUpDown_fineAmount.Location = new System.Drawing.Point(293, 73);
            this.numericUpDown_fineAmount.Name = "numericUpDown_fineAmount";
            this.numericUpDown_fineAmount.Size = new System.Drawing.Size(172, 29);
            this.numericUpDown_fineAmount.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(289, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 21);
            this.label23.TabIndex = 2;
            this.label23.Text = "Total fine amount";
            // 
            // textBox_selectedMemberData
            // 
            this.textBox_selectedMemberData.Location = new System.Drawing.Point(12, 73);
            this.textBox_selectedMemberData.Name = "textBox_selectedMemberData";
            this.textBox_selectedMemberData.Size = new System.Drawing.Size(172, 29);
            this.textBox_selectedMemberData.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(176, 21);
            this.label22.TabIndex = 0;
            this.label22.Text = "Selected member data";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Bisque;
            this.tabPage8.Controls.Add(this.label29);
            this.tabPage8.Controls.Add(this.dataGridView_barcodeResult);
            this.tabPage8.Controls.Add(this.label_45);
            this.tabPage8.Controls.Add(this.label28);
            this.tabPage8.Controls.Add(this.label27);
            this.tabPage8.Controls.Add(this.label26);
            this.tabPage8.Controls.Add(this.textBox_barCode);
            this.tabPage8.Controls.Add(this.pictureBox_barCode);
            this.tabPage8.Controls.Add(this.button_openFile);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1265, 589);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Barcode scanning (via image)";
            // 
            // button_openFile
            // 
            this.button_openFile.BackColor = System.Drawing.Color.BurlyWood;
            this.button_openFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openFile.Location = new System.Drawing.Point(419, 459);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(100, 32);
            this.button_openFile.TabIndex = 0;
            this.button_openFile.Text = "Open";
            this.button_openFile.UseVisualStyleBackColor = false;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // pictureBox_barCode
            // 
            this.pictureBox_barCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_barCode.Location = new System.Drawing.Point(30, 85);
            this.pictureBox_barCode.Name = "pictureBox_barCode";
            this.pictureBox_barCode.Size = new System.Drawing.Size(489, 299);
            this.pictureBox_barCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_barCode.TabIndex = 1;
            this.pictureBox_barCode.TabStop = false;
            // 
            // textBox_barCode
            // 
            this.textBox_barCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_barCode.Location = new System.Drawing.Point(110, 522);
            this.textBox_barCode.Name = "textBox_barCode";
            this.textBox_barCode.ReadOnly = true;
            this.textBox_barCode.Size = new System.Drawing.Size(409, 35);
            this.textBox_barCode.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(26, 522);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 21);
            this.label26.TabIndex = 3;
            this.label26.Text = "Barcode:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(285, 435);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(234, 21);
            this.label27.TabIndex = 4;
            this.label27.Text = "Open file from a location (.jpg)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(26, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(161, 21);
            this.label28.TabIndex = 5;
            this.label28.Text = "Your barcode image:";
            // 
            // label_45
            // 
            this.label_45.AutoSize = true;
            this.label_45.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_45.Location = new System.Drawing.Point(561, 47);
            this.label_45.Name = "label_45";
            this.label_45.Size = new System.Drawing.Size(88, 21);
            this.label_45.TabIndex = 6;
            this.label_45.Text = "Book data:";
            // 
            // dataGridView_barcodeResult
            // 
            this.dataGridView_barcodeResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_barcodeResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barcodeResult.Location = new System.Drawing.Point(565, 85);
            this.dataGridView_barcodeResult.Name = "dataGridView_barcodeResult";
            this.dataGridView_barcodeResult.ReadOnly = true;
            this.dataGridView_barcodeResult.Size = new System.Drawing.Size(666, 65);
            this.dataGridView_barcodeResult.TabIndex = 7;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(655, 47);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 21);
            this.label29.TabIndex = 8;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.Bisque;
            this.tabPage9.Controls.Add(this.label36);
            this.tabPage9.Controls.Add(this.button2);
            this.tabPage9.Controls.Add(this.button1);
            this.tabPage9.Controls.Add(this.label34);
            this.tabPage9.Controls.Add(this.button_stopRecording);
            this.tabPage9.Controls.Add(this.label32);
            this.tabPage9.Controls.Add(this.dataGridView_videoBook);
            this.tabPage9.Controls.Add(this.label35);
            this.tabPage9.Controls.Add(this.textBox_barcodeVideo);
            this.tabPage9.Controls.Add(this.label33);
            this.tabPage9.Controls.Add(this.button_startStopRecord);
            this.tabPage9.Controls.Add(this.label31);
            this.tabPage9.Controls.Add(this.pictureBox_video);
            this.tabPage9.Controls.Add(this.comboBox_captureChoice);
            this.tabPage9.Controls.Add(this.label30);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1265, 589);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Barcode scanning (via camera)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(52, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(124, 21);
            this.label30.TabIndex = 0;
            this.label30.Text = "Capture device:";
            // 
            // comboBox_captureChoice
            // 
            this.comboBox_captureChoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_captureChoice.FormattingEnabled = true;
            this.comboBox_captureChoice.Location = new System.Drawing.Point(182, 35);
            this.comboBox_captureChoice.Name = "comboBox_captureChoice";
            this.comboBox_captureChoice.Size = new System.Drawing.Size(428, 29);
            this.comboBox_captureChoice.TabIndex = 1;
            // 
            // pictureBox_video
            // 
            this.pictureBox_video.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_video.Location = new System.Drawing.Point(56, 81);
            this.pictureBox_video.Name = "pictureBox_video";
            this.pictureBox_video.Size = new System.Drawing.Size(554, 281);
            this.pictureBox_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_video.TabIndex = 2;
            this.pictureBox_video.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(52, 386);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(164, 21);
            this.label31.TabIndex = 3;
            this.label31.Text = "Start capturing video";
            // 
            // button_startStopRecord
            // 
            this.button_startStopRecord.BackColor = System.Drawing.Color.BurlyWood;
            this.button_startStopRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startStopRecord.Location = new System.Drawing.Point(56, 410);
            this.button_startStopRecord.Name = "button_startStopRecord";
            this.button_startStopRecord.Size = new System.Drawing.Size(100, 32);
            this.button_startStopRecord.TabIndex = 4;
            this.button_startStopRecord.Text = "Start ";
            this.button_startStopRecord.UseVisualStyleBackColor = false;
            this.button_startStopRecord.Click += new System.EventHandler(this.button_startStopRecord_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(673, 35);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(75, 21);
            this.label33.TabIndex = 6;
            this.label33.Text = "Barcode:";
            // 
            // textBox_barcodeVideo
            // 
            this.textBox_barcodeVideo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_barcodeVideo.Location = new System.Drawing.Point(754, 32);
            this.textBox_barcodeVideo.Name = "textBox_barcodeVideo";
            this.textBox_barcodeVideo.ReadOnly = true;
            this.textBox_barcodeVideo.Size = new System.Drawing.Size(367, 29);
            this.textBox_barcodeVideo.TabIndex = 7;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(56, 468);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(88, 21);
            this.label35.TabIndex = 9;
            this.label35.Text = "Book data:";
            // 
            // dataGridView_videoBook
            // 
            this.dataGridView_videoBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_videoBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_videoBook.Location = new System.Drawing.Point(56, 492);
            this.dataGridView_videoBook.Name = "dataGridView_videoBook";
            this.dataGridView_videoBook.ReadOnly = true;
            this.dataGridView_videoBook.Size = new System.Drawing.Size(1065, 56);
            this.dataGridView_videoBook.TabIndex = 10;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(268, 386);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(164, 21);
            this.label32.TabIndex = 11;
            this.label32.Text = "Stop capturing video";
            // 
            // button_stopRecording
            // 
            this.button_stopRecording.BackColor = System.Drawing.Color.BurlyWood;
            this.button_stopRecording.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopRecording.Location = new System.Drawing.Point(272, 410);
            this.button_stopRecording.Name = "button_stopRecording";
            this.button_stopRecording.Size = new System.Drawing.Size(100, 32);
            this.button_stopRecording.TabIndex = 12;
            this.button_stopRecording.Text = "Stop";
            this.button_stopRecording.UseVisualStyleBackColor = false;
            this.button_stopRecording.Click += new System.EventHandler(this.button_stopRecording_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(496, 386);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(114, 21);
            this.label34.TabIndex = 13;
            this.label34.Text = "Get book data";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(500, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Retrieve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(754, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear box";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(754, 81);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(144, 21);
            this.label36.TabIndex = 16;
            this.label36.Text = "Clear textbox data";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1273, 640);
            this.Controls.Add(this.tabStatistics);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibraryForm";
            this.Text = "Library system";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibraryForm_FormClosing);
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
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
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_bookStatistics)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.adgv_memberFines.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_memberFines)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fineAmount)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barcodeResult)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_videoBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_refreshData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_update;
        private System.Windows.Forms.TabControl tabStatistics;
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
        private Button button_checkOverdue;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label11;
        private RichTextBox richTextBox_emailLogs;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label_overdueWarning;
        private Label label13;
        private Button button_clearLogs;
        private Label label12;
        private Button button_sendEmails;
        private TabPage tabPage6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bookStatistics;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label_totalBooks;
        private GroupBox groupBox3;
        private Button button_exportToPDF;
        private Label label14;
        private Button button_showStatistics;
        private Label label15;
        private TabPage tabPage7;
        private TableLayoutPanel adgv_memberFines;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label17;
        private Label label19;
        private Label label20;
        private AdvancedDataGridView advancedDataGridView_memberFines;
        private TableLayoutPanel tableLayoutPanel10;
        private GroupBox groupBox4;
        private Button button_showFines;
        private Label label18;
        private Button button_exportFinesToPDF;
        private Label label21;
        private GroupBox groupBox5;
        private TextBox textBox_selectedMemberData;
        private Label label22;
        private NumericUpDown numericUpDown_fineAmount;
        private Label label23;
        private Button button_clearFine;
        private Label label24;
        private CheckBox checkBox_lost;
        private CheckBox checkBox_damaged;
        private CheckBox checkBox_OverdueFine;
        private Button button_submitFine;
        private Label label25;
        private TabPage tabPage8;
        private TextBox textBox_barCode;
        private PictureBox pictureBox_barCode;
        private Button button_openFile;
        private Label label26;
        private Label label27;
        private Label label28;
        private DataGridView dataGridView_barcodeResult;
        private Label label_45;
        private Label label29;
        private TabPage tabPage9;
        private ComboBox comboBox_captureChoice;
        private Label label30;
        private PictureBox pictureBox_video;
        private Button button_startStopRecord;
        private Label label31;
        private TextBox textBox_barcodeVideo;
        private Label label33;
        private DataGridView dataGridView_videoBook;
        private Label label35;
        private Label label32;
        private Button button_stopRecording;
        private Button button1;
        private Label label34;
        private Label label36;
        private Button button2;
    }
}

