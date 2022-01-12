using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADGV;

namespace Library
{
    public partial class FormSelectMember : Form
    {
        DataTable dataTableBorrowings;
        int selectedIndex;
        TextBox selectedTextBox;
        public FormSelectMember(DataSet ds, DataTable tableBorrowings, int index)
        {
            InitializeComponent();
            //IS THE PASSED TABLE
            dataTableBorrowings = tableBorrowings;
            //IS THE PASSED INDEX
            selectedIndex = index;
            advancedDataGridView_selectMember.DataSource = ds.Tables["member"];
            HideMemberColumns();
            ChangeMemberHeaders();
        }
        public void HideMemberColumns()
        {
            advancedDataGridView_selectMember.Columns["phone_number"].Visible = false;
            advancedDataGridView_selectMember.Columns["email"].Visible = false;
            advancedDataGridView_selectMember.Columns["address"].Visible = false;
            advancedDataGridView_selectMember.Columns["card_number"].Visible = false;
        }
        public void ChangeMemberHeaders()
        {
            advancedDataGridView_selectMember.Columns["id_member"].HeaderText = "Member #";
            advancedDataGridView_selectMember.Columns["full_name"].HeaderText = "Full Name";
        }

        public FormSelectMember(DataSet ds, DataTable tableBorrowings, TextBox textBox)
        {
            InitializeComponent();
            //IS THE PASSED TABLE
            dataTableBorrowings = tableBorrowings;
            selectedTextBox = textBox;
            advancedDataGridView_selectMember.DataSource = ds.Tables["member"];
            HideMemberColumns();
            ChangeMemberHeaders();
        }

        private void advancedDataGridView_selectMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //IF NOT NULL THEN ITS MAKING A CHANGE IN THE TEXTBOX
            if (selectedTextBox != null)
            {
                int selectedRowIndex = e.RowIndex;
                if (selectedRowIndex >= 0)
                {
                    DataGridViewRow selectedRow = advancedDataGridView_selectMember.Rows[selectedRowIndex];
                    //REPLACING THE SELECTED COLUMN CELL VALUE TO SELECTED THIS FORM VALUE 
                    selectedTextBox.Text = selectedRow.Cells[0].Value.ToString();
                }
            } else
            {
                //GETTING THE SELECTED ROW INDEX AGAIN
                int selectedRowIndex = e.RowIndex;
                if (selectedRowIndex >= 0) //check the cells that are populated
                {
                    DataGridViewRow selectedRow = advancedDataGridView_selectMember.Rows[selectedRowIndex];
                    
                    if(dataTableBorrowings.Rows.Count <= selectedIndex) //checking if selected index is greater than rows count so it adds a new row
                    {
                        DataRow drow;
                        drow = dataTableBorrowings.NewRow();
                        drow[1] = selectedRow.Cells[0].Value.ToString();
                        dataTableBorrowings.Rows.Add(drow);
                    } else
                    {
                        dataTableBorrowings.Rows[selectedIndex].SetField(1, selectedRow.Cells[0].Value.ToString());
                    }

                }
            }
        }

        private void advancedDataGridView_selectMember_SortStringChanged(object sender, EventArgs e)
        {
            BindingSource bsSelectMember = new BindingSource();
            bsSelectMember.DataSource = advancedDataGridView_selectMember.DataSource;
            bsSelectMember.Sort = advancedDataGridView_selectMember.SortString;
        }

        private void advancedDataGridView_selectMember_FilterStringChanged(object sender, EventArgs e)
        {
            BindingSource bsSelectMember = new BindingSource();
            bsSelectMember.DataSource = advancedDataGridView_selectMember.DataSource;
            bsSelectMember.Filter = advancedDataGridView_selectMember.FilterString;
        }

    }
}
