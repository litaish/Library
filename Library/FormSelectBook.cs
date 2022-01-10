using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormSelectBook : Form
    {
        DataTable dataTableBorrowings;
        int selectedIndex;
        TextBox selectedTextBox;
        public FormSelectBook(DataSet ds, DataTable tableBorrowings, int index)
        {
            InitializeComponent();
            //IS THE PASSED TABLE
            dataTableBorrowings = tableBorrowings;
            //IS THE PASSED INDEX
            selectedIndex = index;
            advancedDataGridView_selectedBook.DataSource = ds.Tables["book"];
            HideBookColumns();
            ChangeBookHeaders();
        }
        public FormSelectBook(DataSet ds, DataTable tableBorrowings, TextBox textBox)
        {
            InitializeComponent();
            //IS THE PASSED TABLE
            dataTableBorrowings = tableBorrowings;
            //IS THE PASSED INDEX
            selectedTextBox = textBox;
            advancedDataGridView_selectedBook.DataSource = ds.Tables["book"];
            HideBookColumns();
            ChangeBookHeaders();
        }
        public void HideBookColumns()
        {
            advancedDataGridView_selectedBook.Columns["publish_date"].Visible = false;
            advancedDataGridView_selectedBook.Columns["id_publisher"].Visible = false;
            advancedDataGridView_selectedBook.Columns["id_language"].Visible = false;
            advancedDataGridView_selectedBook.Columns["id_genre"].Visible = false;
            advancedDataGridView_selectedBook.Columns["id_author"].Visible = false;
        }
        public void ChangeBookHeaders()
        {
            advancedDataGridView_selectedBook.Columns["id_book"].HeaderText = "Book #";
            advancedDataGridView_selectedBook.Columns["isbn"].HeaderText = "ISBN";
            advancedDataGridView_selectedBook.Columns["book_title"].HeaderText = "Title";
            advancedDataGridView_selectedBook.Columns["availability"].HeaderText = "Availability";
        }


        private void advancedDataGridView_selectedBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedTextBox != null)
            {
                int selectedRowIndex = e.RowIndex;
                if (selectedRowIndex >= 0) //iekļaujas dgv
                {
                    DataGridViewRow selectedRow = advancedDataGridView_selectedBook.Rows[selectedRowIndex];
                    //REPLACING THE SELECTED COLUMN CELL VALUE TO SELECTED THIS FORM VALUE 
                    selectedTextBox.Text = selectedRow.Cells[0].Value.ToString();
                }
            }
            else
            {
                //GETTING THE SELECTED ROW INDEX AGAIN
                int selectedRowIndex = e.RowIndex;
                if (selectedRowIndex >= 0) //check the cells that are populated
                {
                    DataGridViewRow selectedRow = advancedDataGridView_selectedBook.Rows[selectedRowIndex];

                    if (dataTableBorrowings.Rows.Count <= selectedIndex) //checking if selected index is greater than rows count so it adds a new row
                    {
                        DataRow drow;
                        drow = dataTableBorrowings.NewRow();
                        drow[1] = selectedRow.Cells[0].Value.ToString();
                        dataTableBorrowings.Rows.Add(drow);
                    }
                    else
                    {
                        dataTableBorrowings.Rows[selectedIndex].SetField(2, selectedRow.Cells[0].Value.ToString()); //2nd column id_book
                    }

                }
            }
            }

        private void advancedDataGridView_selectedBook_SortStringChanged(object sender, EventArgs e)
        {
            BindingSource bsSelectBook = new BindingSource();
            bsSelectBook.DataSource = advancedDataGridView_selectedBook.DataSource;
            bsSelectBook.Sort = advancedDataGridView_selectedBook.SortString;
        }

        private void advancedDataGridView_selectedBook_FilterStringChanged(object sender, EventArgs e)
        {
            BindingSource bsSelectBook = new BindingSource();
            bsSelectBook.DataSource = advancedDataGridView_selectedBook.DataSource;
            bsSelectBook.Filter = advancedDataGridView_selectedBook.FilterString;
        }
    }
    }

