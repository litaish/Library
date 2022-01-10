using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Library
{
    
    public partial class ReportForm : Form
    {
        NpgsqlDataAdapter reportAdapter;
        DataTable reportTable;
        string idTrimmed;
        public ReportForm(string id, DataSet ds, NpgsqlConnection conn) //PASSED VALUES OF SELECTED ID, DS, CONNECTIONa
        {
            InitializeComponent();
            dataGridView_report.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView_report.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            idTrimmed = id.Trim();
            this.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.Dock = DockStyle.Fill;
            CreateReportAdapter(conn);
            CreateReportTable();
        }
        public void CreateReportAdapter(NpgsqlConnection conn)
        {
            NpgsqlCommand s_cmd_report = new NpgsqlCommand("SELECT br.id_book, b.book_title, b.isbn, br.date_borrowed, br.date_due, br.is_returned FROM borrowings as br, book as b WHERE br.id_book = b.id_book AND br.id_member LIKE @id_member",conn);
            s_cmd_report.Parameters.Add(new NpgsqlParameter("@id_member", string.Format("%{0}%", idTrimmed)));

            reportAdapter = new NpgsqlDataAdapter();
            reportAdapter.SelectCommand = s_cmd_report;
        }
        public void CreateReportTable()
        {
            reportTable = new DataTable();
            dataGridView_report.DataSource = reportTable;
            reportTable.TableName = "report";

            reportAdapter.Fill(reportTable);

            dataGridView_report.Columns["id_book"].HeaderText = "Book #";
            dataGridView_report.Columns["book_title"].HeaderText = "Title";
            dataGridView_report.Columns["isbn"].HeaderText = "ISBN";
            dataGridView_report.Columns["date_borrowed"].HeaderText = "Date borrowed";
            dataGridView_report.Columns["date_due"].HeaderText = "Date due";
            dataGridView_report.Columns["is_returned"].HeaderText = "Returned";
        }
    }
}
