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
using Library.Utils;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ZXing;

namespace Library
{
    public partial class LibraryForm : Form
    {
        NpgsqlDataAdapter bookAdapter = Adapters.Instance.BookAdapter;
        NpgsqlDataAdapter countryAdapter = Adapters.Instance.CountryAdapter;
        NpgsqlDataAdapter publisherAdapter = Adapters.Instance.PublisherAdapter;
        NpgsqlDataAdapter authorAdapter = Adapters.Instance.AuthorAdapter;
        NpgsqlDataAdapter languageAdapter = Adapters.Instance.LanguageAdapter;
        NpgsqlDataAdapter genreAdapter = Adapters.Instance.GenreAdapter;
        NpgsqlDataAdapter borrowingsAdapter = Adapters.Instance.BorrowingsAdapter;
        NpgsqlDataAdapter memberAdapter = Adapters.Instance.MemberAdapter;
        NpgsqlDataAdapter cardAdapter = Adapters.Instance.CardAdapter;
        DataSet ds;
        DataTable bookTable;
        DataTable countryTable;
        DataTable publisherTable;
        DataTable authorTable;
        DataTable languageTable;
        DataTable genreTable;
        DataTable borrowingsTable;
        DataTable memberTable;
        DataTable cardTable;
        public LibraryForm()
        {
            InitializeComponent();
            //CAN EDIT TREEVIEW
            treeView_genre.LabelEdit = true;

            //SETTING CUSTOM TIME AND DATE FOR DATE PICKERS
            dateTimePicker_member.Format = DateTimePickerFormat.Custom;
            dateTimePicker_member.CustomFormat = "MM/dd/yyyy";
            dateTimePicker_dateBorrowed.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dateBorrowed.CustomFormat = "MM/dd/yyyy";
            dateTimePicker_dateDue.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dateDue.CustomFormat = "MM/dd/yyyy";
            dateTimePicker_book.Format = DateTimePickerFormat.Custom;
            dateTimePicker_book.CustomFormat = "MM/dd/yyyy";

            chart_bookStatistics.Hide();

            // Default values for Numeric Up Down control
            this.numericUpDown_fineAmount.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numericUpDown_fineAmount.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numericUpDown_fineAmount.Increment = new decimal(new int[] {5, 0, 0, 0});
        }

        public void SubLevel(int parentid, TreeNode parentNode)
        {
            NpgsqlCommand sel3 = new NpgsqlCommand("SELECT id_genre, genre_name FROM genre WHERE id_parent_genre = @id_parent_genre", Database.Instance.Conn);

            sel3.Parameters.Add("@id_parent_genre", NpgsqlTypes.NpgsqlDbType.Integer).Value = parentid;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sel3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (parentid == 0)
            {
                CreateNodes(dt, treeView_genre.Nodes);
            }
            else
            {
                CreateNodes(dt, parentNode.Nodes);
            }
        }
        public void CreateNodes(DataTable dt, TreeNodeCollection nodes)
        {

            foreach (DataRow dr1 in dt.Rows)
            {
                Console.Write(dr1);
                TreeNode tn = new TreeNode();
                tn.Text = dr1["genre_name"].ToString();
                tn.Name = dr1["id_genre"].ToString();
                nodes.Add(tn);
                SubLevel(Convert.ToInt32(tn.Name), tn);
            }
        }
        public void CreateDataSet()
        {
            ds = new DataSet();

            cardTable = new DataTable();
            ds.Tables.Add(cardTable);
            //ADDING TABLE NAMES SO IT DOES NOT ADD EMPTY TABLES TO THE DATASET
            cardTable.TableName = "library_card";

            memberTable = new DataTable();
            ds.Tables.Add(memberTable);
            memberTable.TableName = "member";

            countryTable = new DataTable();
            ds.Tables.Add(countryTable);
            countryTable.TableName = "country";

            publisherTable = new DataTable();
            ds.Tables.Add(publisherTable);
            publisherTable.TableName = "publisher";

            borrowingsTable = new DataTable();
            ds.Tables.Add(borrowingsTable);
            borrowingsTable.TableName = "borrowings";

            bookTable = new DataTable();
            ds.Tables.Add(bookTable);
            bookTable.TableName = "book";

            genreTable = new DataTable();
            ds.Tables.Add(genreTable);
            genreTable.TableName = "genre";

            authorTable = new DataTable();
            ds.Tables.Add(authorTable);
            authorTable.TableName = "author";

            languageTable = new DataTable();
            ds.Tables.Add(languageTable);
            languageTable.TableName = "language";
        }

        public void CreateRelations()
        {
            //RELATIONS
            ds.Relations.Add(new DataRelation("member_borrowings_rel", ds.Tables["member"].Columns["id_member"], ds.Tables["borrowings"].Columns["id_member"], false)); //name of relation, parent column, child column
            ds.Relations.Add(new DataRelation("book_borrowings_rel", ds.Tables["book"].Columns["id_book"], ds.Tables["borrowings"].Columns["id_book"], false));
            ds.Relations.Add(new DataRelation("country_publisher_rel", ds.Tables["country"].Columns["id_country"], ds.Tables["publisher"].Columns["id_country"], false));
            ds.Relations.Add(new DataRelation("librarycard_member_rel", ds.Tables["library_card"].Columns["card_number"], ds.Tables["member"].Columns["card_number"], false));
            ds.Relations.Add(new DataRelation("publisher_book_rel", ds.Tables["publisher"].Columns["id_publisher"], ds.Tables["book"].Columns["id_publisher"], false));
            ds.Relations.Add(new DataRelation("genre_book_rel", ds.Tables["genre"].Columns["id_genre"], ds.Tables["book"].Columns["id_genre"], false));
            ds.Relations.Add(new DataRelation("language_book_rel", ds.Tables["language"].Columns["id_language"], ds.Tables["book"].Columns["id_language"], false));
            ds.Relations.Add(new DataRelation("author_book_rel", ds.Tables["author"].Columns["id_author"], ds.Tables["book"].Columns["id_author"], false));
        }
        public void ClearMemberTextBoxFields()
        {
            textBox_fullName.Text = null;
            textBox_phoneNumber.Text = null;
            textBox_email.Text = null;
            textBox_address.Text = null;
        }
        public void FillMemberInfo()
        {
            cardAdapter.Fill(ds, "library_card");
            dataGridView_cardNumber.DataSource = ds.Tables["library_card"];
            dataGridView_cardNumber.Columns["card_number"].HeaderText = "Card #";
            dataGridView_cardNumber.Columns["date_issued"].HeaderText = "Date issued";

            memberAdapter.Fill(ds, "member");
            advancedDataGridView_member.DataSource = ds.Tables["member"];
            advancedDataGridView_member.Columns["full_name"].HeaderText = "Full name";
            advancedDataGridView_member.Columns["phone_number"].HeaderText = "Phone #";
            advancedDataGridView_member.Columns["email"].HeaderText = "E-mail";
            advancedDataGridView_member.Columns["address"].HeaderText = "Address";
            advancedDataGridView_member.Columns["id_member"].HeaderText = "Member #";

            CreateMemberTabListBoxes();

            advancedDataGridView_member.Columns["card_number"].Visible = false;
        }
        public void CreateMemberTabListBoxes()
        {
            DataGridViewComboBoxColumn cb_fk_cardnumb = new DataGridViewComboBoxColumn();
            cb_fk_cardnumb.DataSource = ds.Tables["library_card"];
            advancedDataGridView_member.Columns.Add(cb_fk_cardnumb);
            cb_fk_cardnumb.HeaderText = "Card #";
            cb_fk_cardnumb.DisplayMember = "card_number";
            cb_fk_cardnumb.DataPropertyName = "card_number";
            cb_fk_cardnumb.ValueMember = "card_number";
            cb_fk_cardnumb.FlatStyle = FlatStyle.Flat;
        }
        public void FillPublisherInfo()
        {
            countryAdapter.Fill(ds, "country");
            dataGridView_country.DataSource = ds.Tables["country"];
            dataGridView_country.Columns["country_name"].HeaderText = "Country";

            publisherAdapter.Fill(ds, "publisher");
            dataGridView_publisher.DataSource = ds.Tables["publisher"];
            dataGridView_publisher.Columns["publisher_name"].HeaderText = "Publisher";

            CreatePublisherTabComboBoxes();

            dataGridView_publisher.Columns["id_publisher"].Visible = false;
            dataGridView_publisher.Columns["id_country"].Visible = false;
            dataGridView_country.Columns["id_country"].Visible = false;

            BindPublisherListBoxes();
        }
        public void CreatePublisherTabComboBoxes()
        {
            //COMBO BOX COLUMN FOR TABLE PUBLISHER
            DataGridViewComboBoxColumn cb_fk_country = new DataGridViewComboBoxColumn();
            cb_fk_country.DataSource = ds.Tables["country"];
            dataGridView_publisher.Columns.Add(cb_fk_country);
            cb_fk_country.DisplayMember = "country_name";
            cb_fk_country.DataPropertyName = "id_country";
            cb_fk_country.ValueMember = "id_country";
            cb_fk_country.HeaderText = "Country";
            cb_fk_country.FlatStyle = FlatStyle.Flat;
        }
        public void BindPublisherListBoxes()
        {
            //COMBO BOX FOR ADDING PUBLISHER
            comboBox_countryName.DataSource = ds.Tables["country"];
            comboBox_countryName.DisplayMember = "country_name";
            comboBox_countryName.ValueMember = "id_country";
        }
        public void FillBorrowingsInfo()
        {
            borrowingsAdapter.Fill(ds, "borrowings");
            advancedDataGridView_borrowings.DataSource = ds.Tables["borrowings"];
            advancedDataGridView_borrowings.Columns["date_borrowed"].HeaderText = "Date borrowed";
            advancedDataGridView_borrowings.Columns["date_due"].HeaderText = "Date due";
            advancedDataGridView_borrowings.Columns["is_returned"].HeaderText = "Returned";
            advancedDataGridView_borrowings.Columns["id_member"].HeaderText = "Member #";
            advancedDataGridView_borrowings.Columns["id_book"].HeaderText = "Book #";

            //VISABILITY FOR FK AND PK COLUMNS
            advancedDataGridView_borrowings.Columns["id_borrowing_info"].Visible = false;

        }
        public void FillBookInfo()
        {
            bookAdapter.Fill(ds, "book");
            advancedDataGridView_book.DataSource = ds.Tables["book"];
            advancedDataGridView_book.Columns["id_book"].HeaderText = "Book #";
            advancedDataGridView_book.Columns["isbn"].HeaderText = "ISBN";
            advancedDataGridView_book.Columns["book_title"].HeaderText = "Title";
            advancedDataGridView_book.Columns["publish_date"].HeaderText = "Publish date";
            advancedDataGridView_book.Columns["availability"].HeaderText = "Availability";

            genreAdapter.Fill(ds, "genre");
            dataGridView_genre.DataSource = ds.Tables["genre"];
            dataGridView_genre.Columns["genre_name"].HeaderText = "Genre";
            dataGridView_genre.Columns["id_parent_genre"].HeaderText = "Parent Genre";

            authorAdapter.Fill(ds, "author");
            dataGridView_author.DataSource = ds.Tables["author"];
            dataGridView_author.Columns["full_name"].HeaderText = "Author";

            languageAdapter.Fill(ds, "language");
            dataGridView_language.DataSource = ds.Tables["language"];
            dataGridView_language.Columns["language"].HeaderText = "Language";

            CreateBookTabComboBoxes();

            //VISABILITY FOR PK AND FK COLUMNS
            advancedDataGridView_book.Columns["id_publisher"].Visible = false;
            advancedDataGridView_book.Columns["id_language"].Visible = false;
            advancedDataGridView_book.Columns["id_genre"].Visible = false;
            advancedDataGridView_book.Columns["id_author"].Visible = false;
            dataGridView_genre.Columns["id_genre"].Visible = false;
            dataGridView_language.Columns["id_language"].Visible = false;
            dataGridView_author.Columns["id_author"].Visible = false;

            //MOVING AVAILABILITY TO LAST POSITION OF DATAGRID
            advancedDataGridView_book.Columns["availability"].DisplayIndex = 12;

            BindBookListBoxes();
        }
        public void CreateBookTabComboBoxes()
        {
            DataGridViewComboBoxColumn cb_fk_publisher = new DataGridViewComboBoxColumn();
            cb_fk_publisher.DataSource = ds.Tables["publisher"];
            advancedDataGridView_book.Columns.Add(cb_fk_publisher);
            cb_fk_publisher.HeaderText = "Publisher";
            cb_fk_publisher.DisplayMember = "publisher_name";
            cb_fk_publisher.DataPropertyName = "id_publisher";
            cb_fk_publisher.ValueMember = "id_publisher";
            cb_fk_publisher.FlatStyle = FlatStyle.Flat;

            DataGridViewComboBoxColumn cb_fk_language = new DataGridViewComboBoxColumn();
            cb_fk_language.DataSource = ds.Tables["language"];
            advancedDataGridView_book.Columns.Add(cb_fk_language);
            cb_fk_language.HeaderText = "Language";
            cb_fk_language.DisplayMember = "language";
            cb_fk_language.DataPropertyName = "id_language";
            cb_fk_language.ValueMember = "id_language";
            cb_fk_language.FlatStyle = FlatStyle.Flat;

            DataGridViewComboBoxColumn cb_fk_genre = new DataGridViewComboBoxColumn();
            cb_fk_genre.DataSource = ds.Tables["genre"];
            advancedDataGridView_book.Columns.Add(cb_fk_genre);
            cb_fk_genre.HeaderText = "Genre";
            cb_fk_genre.DisplayMember = "genre_name";
            cb_fk_genre.DataPropertyName = "id_genre";
            cb_fk_genre.ValueMember = "id_genre";
            cb_fk_genre.FlatStyle = FlatStyle.Flat;

            DataGridViewComboBoxColumn cb_fk_author = new DataGridViewComboBoxColumn();
            cb_fk_author.DataSource = ds.Tables["author"];
            advancedDataGridView_book.Columns.Add(cb_fk_author);
            cb_fk_author.HeaderText = "Author";
            cb_fk_author.DisplayMember = "full_name";
            cb_fk_author.DataPropertyName = "id_author";
            cb_fk_author.ValueMember = "id_author";
            cb_fk_author.FlatStyle = FlatStyle.Flat;

            //DataGridViewComboBoxColumn cb_parentgenre = new DataGridViewComboBoxColumn();
            //cb_parentgenre.DataSource = ds.Tables["genre"];
            //dataGridView_genre.Columns.Add(cb_parentgenre);
            //cb_parentgenre.HeaderText = "Parent genre";
            //cb_parentgenre.DisplayMember = "genre_name";
            //cb_parentgenre.DataPropertyName = "id_parent_genre";
            //cb_parentgenre.ValueMember = "id_genre";
            //cb_parentgenre.FlatStyle = FlatStyle.Flat;
        }
        public void BindBookListBoxes()
        {
            //COMBO BOXES FOR ADDING A NEW BOOK
            comboBox_publisher.DataSource = ds.Tables["publisher"];
            comboBox_publisher.DisplayMember = "publisher_name";
            comboBox_publisher.ValueMember = "id_publisher";

            comboBox_language.DataSource = ds.Tables["language"];
            comboBox_language.DisplayMember = "language";
            comboBox_language.ValueMember = "id_language";

            comboBox_genre.DataSource = ds.Tables["genre"];
            comboBox_genre.DisplayMember = "genre_name";
            comboBox_genre.ValueMember = "id_genre";

            comboBox_author.DataSource = ds.Tables["author"];
            comboBox_author.DisplayMember = "full_name";
            comboBox_author.ValueMember = "id_author";
        }
        private void toolStripButton_refreshData_Click(object sender, EventArgs e)
        {
            try
            {
                ClearColumns();
                CreateDataSet();

                FillMemberInfo();
                FillPublisherInfo();
                FillBookInfo();
                FillBorrowingsInfo();

                CreateRelations();

                treeView_genre.Nodes.Clear();

                SubLevel(0, null);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Try again.");
            }
        }
        public void ClearColumns()
        {
            this.dataGridView_publisher.DataSource = null;
            this.dataGridView_publisher.Rows.Clear();
            this.dataGridView_country.DataSource = null;
            this.dataGridView_country.Rows.Clear();

            this.advancedDataGridView_member.DataSource = null;
            this.advancedDataGridView_member.Rows.Clear();
            this.dataGridView_cardNumber.DataSource = null;
            this.dataGridView_cardNumber.Rows.Clear();

            this.advancedDataGridView_borrowings.DataSource = null;
            this.advancedDataGridView_borrowings.Rows.Clear();

            this.advancedDataGridView_book.DataSource = null;
            this.advancedDataGridView_book.Rows.Clear();
        }
        private void toolStripButton_update_Click(object sender, EventArgs e)
        {
            try
            {
                cardAdapter.Update((DataTable)dataGridView_cardNumber.DataSource);
                memberAdapter.Update((DataTable)advancedDataGridView_member.DataSource);
                publisherAdapter.Update((DataTable)dataGridView_publisher.DataSource);
                countryAdapter.Update((DataTable)dataGridView_country.DataSource);
                borrowingsAdapter.Update((DataTable)advancedDataGridView_borrowings.DataSource);
                bookAdapter.Update((DataTable)advancedDataGridView_book.DataSource);
                genreAdapter.Update((DataTable)dataGridView_genre.DataSource);
                authorAdapter.Update((DataTable)dataGridView_author.DataSource);
                languageAdapter.Update((DataTable)dataGridView_language.DataSource);

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has occured. Try again.");
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearMemberTextBoxFields();
        }
        private void button_addMember_Click(object sender, EventArgs e)
        {
            bool state = false;
            foreach (Control control in groupBox_addMember.Controls)
            {
                if (state == false)
                {
                    //GETTING THE CONTROL TYPE IN THE ADD MEMBER GROUPBOX
                    //string controlType = control.GetType().ToString();
                    if (control.GetType() == typeof(TextBox))
                    {

                        TextBox txtBox = (TextBox)control;
                        if (string.IsNullOrEmpty(txtBox.Text))
                        {
                            state = true;
                            MessageBox.Show("Please fill the required fields");
                        }
                    }
                }
            }    
            if(state == false)
                AddMemberInDataBase();
                ClearMemberTextBoxFields();
                MessageBox.Show("New member added succesfully!");
        }
        private void AddMemberInDataBase() 
        {
            try
            {
                NpgsqlCommand insertCardDate = new NpgsqlCommand("INSERT INTO library_card VALUES (default, @date_issued) RETURNING card_number", Database.Instance.Conn);
                insertCardDate.Parameters.Add(new NpgsqlParameter("@date_issued", dateTimePicker_member.Value));
                Database.Instance.Conn.Open();
                //OBJECT RES CONTAINS PRIMARY KEY GENERATED FOR CARD NUMBER
                Object res = insertCardDate.ExecuteScalar();
                Database.Instance.Conn.Close();
                NpgsqlCommand insertMemberFields = new NpgsqlCommand("INSERT INTO member VALUES (default, @full_name, @phone_number, @email, @address, @card_number)", Database.Instance.Conn);
                insertMemberFields.Parameters.Add(new NpgsqlParameter("@full_name", textBox_fullName.Text));
                insertMemberFields.Parameters.Add(new NpgsqlParameter("@phone_number", textBox_phoneNumber.Text));
                insertMemberFields.Parameters.Add(new NpgsqlParameter("@email", textBox_email.Text));
                insertMemberFields.Parameters.Add(new NpgsqlParameter("@address", textBox_address.Text));
                insertMemberFields.Parameters.Add(new NpgsqlParameter("@card_number", res));
                Database.Instance.Conn.Open();
                insertMemberFields.ExecuteNonQuery();
                Database.Instance.Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured during member registration. Try again.");
            }
        }
        private void button_generate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button_generate, "Generate a report of borrowed books for selected member");
        }
        private void button_generate_Click(object sender, EventArgs e)
        {
            ReportForm rform = new ReportForm(textBox_memberID.Text, ds, Database.Instance.Conn);
            rform.BringToFront();
            rform.Activate();
            rform.Show();
            if (Application.OpenForms.OfType<ReportForm>().Count() > 1)
                Application.OpenForms.OfType<ReportForm>().First().Close();
        }
        public void ClearPublisherTextBoxFields()
        {
            textBox_publisherName.Text = null;
            comboBox_countryName.Text = null;
            comboBox_countryName.Text = null;
        }
        private void button_clearPublisher_Click(object sender, EventArgs e)
        {
            ClearPublisherTextBoxFields();
        }
        private void button_addPublisher_Click(object sender, EventArgs e)
        {
            publisherTable.Rows.Add(null, textBox_publisherName.Text, comboBox_countryName.SelectedValue);
            ClearPublisherTextBoxFields();
        }
        public void ClearBookTextBoxFields()
        {
            textBox_isbn.Text = null;
            textBox_title.Text = null;
            comboBox_publisher.Text = null;
            comboBox_language.Text = null;
            comboBox_genre.Text = null;
            comboBox_author.Text = null;
        }
        private void button_clearBook_Click(object sender, EventArgs e)
        {
            ClearBookTextBoxFields();
        }

        private void button_addBook_Click(object sender, EventArgs e)
        {
            bookTable.Rows.Add(null, textBox_isbn.Text, textBox_title.Text, dateTimePicker_book.Value, comboBox_publisher.SelectedValue, comboBox_language.SelectedValue, comboBox_genre.SelectedValue, comboBox_author.SelectedValue);
            ClearBookTextBoxFields();
        }
        public void ClearBorrowingsTextBoxFields()
        {
            textBox_borrowingMember.Text = null;
            textBox_borrowingBook.Text = null;
        }

        private void button_clearBorrowing_Click(object sender, EventArgs e)
        {
            ClearBorrowingsTextBoxFields();
        }

        private void button_addBorrowing_Click(object sender, EventArgs e)
        {
            borrowingsTable.Rows.Add(null, textBox_borrowingMember.Text, textBox_borrowingBook.Text, dateTimePicker_dateBorrowed.Value, dateTimePicker_dateDue.Value);
            ClearBorrowingsTextBoxFields();
        }

        private void advancedDataGridView_member_SortStringChanged(object sender, EventArgs e)
        {
            //SORTING MEMBERS
            BindingSource bsMember = new BindingSource();
            bsMember.DataSource = advancedDataGridView_member.DataSource;
            bsMember.Sort = advancedDataGridView_member.SortString;
        }

        private void advancedDataGridView_member_FilterStringChanged(object sender, EventArgs e)
        {
            BindingSource bsMember = new BindingSource();
            bsMember.DataSource = advancedDataGridView_member.DataSource;
            bsMember.Filter = advancedDataGridView_member.FilterString;
        }

        private void advancedDataGridView_borrowings_SortStringChanged(object sender, EventArgs e)
        {
            BindingSource bsBorrowings = new BindingSource();
            bsBorrowings.DataSource = advancedDataGridView_borrowings.DataSource;
            bsBorrowings.Sort = advancedDataGridView_borrowings.SortString;
        }

        private void advancedDataGridView_borrowings_FilterStringChanged(object sender, EventArgs e)
        {
            BindingSource bsBorrowings = new BindingSource();
            bsBorrowings.DataSource = advancedDataGridView_member.DataSource;
            bsBorrowings.Filter = advancedDataGridView_member.FilterString;
        }

        private void advancedDataGridView_member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SAVES CLICKED CELL ROW INDEX, AND DISPLAYS THE VALUE OF 0 COLUMN VALUE IN TB
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow selectedRow = advancedDataGridView_member.Rows[selectedRowIndex];
                textBox_memberID.Text = selectedRow.Cells[0].Value.ToString();
            }
        }
        private void treeView_genre_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //IF NODE NAME IS NOT EMPTY
            if (e.Node.Name != "")
            {
                TreeNode tn = new TreeNode();
                //A NEW NODE WITH TEXT NEW GETS ADDED ON DOUBLE CLICK
                tn.Text = "new";
                e.Node.Nodes.Add(tn);
            }
        }

        private void treeView_genre_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            Adapters.Instance.HandleTreeAdapters(e);
        }

        private void treeView_genre_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void advancedDataGridView_borrowings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //3RD COLUMN INDEX ID_MEMBER
            if (e.ColumnIndex == 1)
            {
                //passing dataset, row index is the selected index
                FormSelectMember memberSelectForm = new FormSelectMember(ds, borrowingsTable, e.RowIndex);
                memberSelectForm.BringToFront();
                memberSelectForm.Activate();
                memberSelectForm.Show();
                if (Application.OpenForms.OfType<FormSelectMember>().Count() > 1)
                    Application.OpenForms.OfType<FormSelectMember>().First().Close();
            }
            if (e.ColumnIndex == 2)
            {
                FormSelectBook bookSelectForm = new FormSelectBook(ds, borrowingsTable, e.RowIndex);
                bookSelectForm.BringToFront();
                bookSelectForm.Activate();
                bookSelectForm.Show();
                if (Application.OpenForms.OfType<FormSelectMember>().Count() > 1)
                    Application.OpenForms.OfType<FormSelectMember>().First().Close();
            }
        }

        private void textBox_borrowingMember_DoubleClick(object sender, EventArgs e)
        {
            FormSelectMember memberSelectForm = new FormSelectMember(ds, borrowingsTable, textBox_borrowingMember);
            memberSelectForm.BringToFront();
            memberSelectForm.Activate();
            memberSelectForm.Show();
            if (Application.OpenForms.OfType<FormSelectMember>().Count() > 1)
                Application.OpenForms.OfType<FormSelectMember>().First().Close();
        }

        private void textBox_borrowingBook_DoubleClick(object sender, EventArgs e)
        {
            FormSelectBook bookSelectForm = new FormSelectBook(ds, borrowingsTable, textBox_borrowingBook);
            bookSelectForm.BringToFront();
            bookSelectForm.Activate();
            bookSelectForm.Show();
            if (Application.OpenForms.OfType<FormSelectMember>().Count() > 1)
                Application.OpenForms.OfType<FormSelectMember>().First().Close();
        }

        private void advancedDataGridView_book_SortStringChanged(object sender, EventArgs e)
        {
            BindingSource bsBook = new BindingSource();
            bsBook.DataSource = advancedDataGridView_book.DataSource;
            bsBook.Sort = advancedDataGridView_book.SortString;
        }

        private void advancedDataGridView_book_FilterStringChanged(object sender, EventArgs e)
        {
            BindingSource bsBook = new BindingSource();
            bsBook.DataSource = advancedDataGridView_book.DataSource;
            bsBook.Filter = advancedDataGridView_book.FilterString;
        }

        private void advancedDataGridView_book_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            //CHECKS IF COLUMN IS AVAILABILITY IN BOOK DATAGRIDVIEW
            if (dgv.Columns[e.ColumnIndex].Name.Equals("availability"))
            {
                //IF CELL CONTENT IS NOT EMPTY AND IS "AVAILABLE"
                if (e.Value != null && e.Value.ToString().Trim() == "AVAILABLE")
                {
                    //THEN AVAILABILITY CELL TEXT COLOR IS GREEN
                    dgv.Rows[e.RowIndex].Cells["availability"].Style.ForeColor = Color.Green;
                }
                else
                {
                    //ELSE ITS RED
                    dgv.Rows[e.RowIndex].Cells["availability"].Style.ForeColor = Color.Red;
                }
            }
        }
        // Returns datatable of member IDs that book return date is overdue and returned is false
        public DataTable AddMembersForEmails()
        {
            // Initalizing a datatable that will save all member IDs that match the condition
            DataTable memberEmail = new DataTable();
            DataColumn memberColumn = new DataColumn();
            memberEmail.Columns.Add(memberColumn);
            memberColumn.ColumnName = "MemberID";

            DateTime dayToday = DateTime.Today;
            string s_today = dayToday.ToString("MM/dd/yyyy HH:mm");

            // Looping through all borrowings table due date column values.
            for (int i = 0; i < advancedDataGridView_borrowings.RowCount - 1; i++)
            {
                // Index of date_due = 4
                var cellValue = advancedDataGridView_borrowings.Rows[i].Cells[4].Value.ToString();
                // Changing cellvalue date format to mm/dd/yyy format

                DateTime convertedDate = Convert.ToDateTime(cellValue);
                string formattedConvertedDate = convertedDate.ToString("MM/dd/yyyy HH:mm");
                // Index of member_id = 1
                var memberID = advancedDataGridView_borrowings.Rows[i].Cells[1].Value;
                // Index of is_returned = 5
                var isReturned = advancedDataGridView_borrowings.Rows[i].Cells[5].Value.ToString();

                if (formattedConvertedDate.Trim() == s_today.ToString().Trim() && isReturned != "True")
                {
                    DataRow row = memberEmail.NewRow();
                    row["MemberID"] = memberID.ToString().Trim();
                    memberEmail.Rows.Add(row);
                }
            }
            // Returning a list of memberIDs to send email reminders to
            return memberEmail;
        }
        // Getting e-mails and full names that are corresponding to specific MemberID
        public DataTable GetEmailForMemberID()
        {
            DataTable memberInfo = new DataTable();
            memberInfo.Columns.Add("full_name");
            memberInfo.Columns.Add("email");
            memberInfo.Columns.Add("id_member");

            // Filling dictionary key with member ID datatable
            for (int i = 0; i < dataGridView_membersForEmail.Rows.Count -1 ; i++)
            {
                var memberId = dataGridView_membersForEmail.Rows[i].Cells[0].Value;
                string memberIdConverted = memberId.ToString().Trim();

                try
                {
                    //Database.Instance.Conn.Open();
                    NpgsqlCommand m_cmd = new NpgsqlCommand("SELECT full_name, email, id_member FROM member WHERE id_member = '" + memberIdConverted + "'", Database.Instance.Conn);
                    NpgsqlDataAdapter member_a = new NpgsqlDataAdapter();
                    member_a.SelectCommand = m_cmd;
                    DataTable tempDataTable = new DataTable();
                    member_a.Fill(tempDataTable);

                    for(int c = 0; c < tempDataTable.Rows.Count; c++)
                    {
                        memberInfo.ImportRow(tempDataTable.Rows[0]);
                        memberInfo.AcceptChanges();
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured during member to e-mail mapping. Please try again." + e);
                }
            }
            return memberInfo;
        }
        // Placing warning in label if overdue members are found
        public void DisplayOverdueWarning(DataTable dt)
        {
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    label_overdueWarning.Text = "Warning! Overdue members found! Please send out notification e-mails!";
                    label_overdueWarning.ForeColor = Color.Red;
                }
            }
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_checkOverdue_Click(object sender, EventArgs e)
        {
            DataTable dt_overdueMembers = new DataTable();
            dt_overdueMembers = AddMembersForEmails();
            dataGridView_membersForEmail.DataSource = dt_overdueMembers;

            DisplayOverdueWarning(dt_overdueMembers);
        }

        private void button_clearLogs_Click(object sender, EventArgs e)
        {
            richTextBox_emailLogs.Text = "";
        }

        private void button_sendEmails_Click(object sender, EventArgs e)
        {
            DataTable table = GetEmailForMemberID();

            // Checking if overdue members table is empty
            var isEmpty = table.Rows.Count == 0;
            if (isEmpty)
            {
                MessageBox.Show("No overdue members found!");
                return;
            }

            // Setting up client
            SmtpClient client = new SmtpClient()
            {
                // Client properties
                Host = "smtp.gmail.com", // SMTP server for e-mail
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false, // Use custom credentials

                // Credentials to send from
                Credentials = new NetworkCredential()
                {
                    UserName = "librarysystem.management32@gmail.com",
                    Password = "bnccutldmwzpthwq" // Only app can use
                }
            };

            // Setting up from e-mail address
            MailAddress fromEmail = new MailAddress("librarysystem.management32@gmail.com", "Library System");

            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                // Setting up reciever e-mail address
                MailAddress toEmail = new MailAddress(table.Rows[i].ItemArray[1].ToString().Trim(), table.Rows[i].ItemArray[0].ToString().Trim());

                // Setting up e-mail message details
                MailMessage msg = new MailMessage
                {
                    From = fromEmail,
                    // Title
                    Subject = "Overdue book!",
                    Body = "Hello " + table.Rows[i].ItemArray[0].ToString().Trim() + " member " + table.Rows[i].ItemArray[2].ToString().Trim() + "! You have exceeded your book return date for our library. Please return the book(s) as soon as possible!"

                };
                msg.To.Add(toEmail);

                try
                {
                    client.Send(msg);

                    // Displaying log messages in richtextbox
                    richTextBox_emailLogs.AppendText(Environment.NewLine);
                    richTextBox_emailLogs.AppendText(Environment.NewLine + "E-mail succesfully sent to member " + table.Rows[i].ItemArray[2].ToString().Trim() + " " + table.Rows[i].ItemArray[1].ToString().Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in sending reminder e-mails!");
                    richTextBox_emailLogs.AppendText(Environment.NewLine);
                    richTextBox_emailLogs.AppendText(Environment.NewLine + "Warning! Sending unsuccesful to " + table.Rows[i].ItemArray[2].ToString().Trim() + " " + table.Rows[i].ItemArray[1].ToString().Trim());
                }
            }

            MessageBox.Show("All e-mails sent succesfully!");
        }
        public string CountBooks()
        {
            string result = "";

            NpgsqlCommand countBooks_cmd = new NpgsqlCommand("SELECT COUNT(*) FROM book", Database.Instance.Conn);
            Database.Instance.Conn.Open();
            var bookCount = countBooks_cmd.ExecuteScalar().ToString();
            Database.Instance.Conn.Close();
            result = bookCount;

            return result;
        }
        
        public DataTable CountBookByGenreAll()
        {
            // Stores genre names and the count of books each genre has
            DataTable dt = new DataTable();

            NpgsqlDataAdapter countAll = Adapters.Instance.CountPerGenreAll;
            countAll.Fill(dt);

            return dt;
        }
        public DataTable CountBookByGenreUnavailable()
        {
            // Stores genre names and the count of books each genre has
            DataTable dt = new DataTable();

            NpgsqlDataAdapter countUnavailable = Adapters.Instance.CountPerGenreUnavailable;
            countUnavailable.Fill(dt);

            return dt;
        }
        private void button_showStatistics_Click(object sender, EventArgs e)
        {
            chart_bookStatistics.Show();
            // Prevents adding a new set of series on each button click
            this.chart_bookStatistics.Series[0].Points.Clear();
            this.chart_bookStatistics.Series[1].Points.Clear();

            DataTable countByGenreAll = CountBookByGenreAll();
            DataTable countByGenreUnavailable = CountBookByGenreUnavailable();

            string total = CountBooks();
            label_totalBooks.Text = "Total books in library: " + total;

            // Going through retrieved DataTable data and adding chart series points and values
            for (int i = 0; i < countByGenreAll.Rows.Count; i++)
            {
                string genreNameAll = countByGenreAll.Rows[i]["genre_name"].ToString();
                int bookCountAll = Convert.ToInt32(countByGenreAll.Rows[i]["count"]);

                this.chart_bookStatistics.Series["Available books"].Points.AddXY(genreNameAll, bookCountAll);
            }
            for (int i = 0; i < countByGenreUnavailable.Rows.Count; i++)
            {
                string genreNameUnavailable = countByGenreUnavailable.Rows[i]["genre_name"].ToString();
                int bookCountUnavailable = Convert.ToInt32(countByGenreUnavailable.Rows[i]["count"]);

                this.chart_bookStatistics.Series["Borrowed books"].Points.AddXY(genreNameUnavailable, bookCountUnavailable); // other bar (darker)
            }
            // Showing values on chart bars
            chart_bookStatistics.Series["Available books"].IsValueShownAsLabel = true;
            chart_bookStatistics.Series["Borrowed books"].IsValueShownAsLabel = true;
        }
        private void button_exportToPDF_Click(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            string total = CountBooks();

            // Create a new document with sizes
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream("C:\\temp\\Statistics.pdf", FileMode.Create));

            // Open document to write
            doc.Open();
            // First paragraph that contains general information
            Paragraph paragraph1 = new Paragraph("Statististics for each book genre in library on " + dateNow + "\n\n" + "Total books in library: " + total + "\n\n");
            doc.Add(paragraph1);

            var chartImage = new MemoryStream();
            // Generates an image and defines format (.png). 
            chart_bookStatistics.SaveImage(chartImage, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            // Image of chart
            iTextSharp.text.Image chart_image = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());
            // Scale to fit
            chart_image.ScalePercent(60);
            // Add image to document
            doc.Add(chart_image);

            doc.Close();
        }
        private void button_showFines_Click(object sender, EventArgs e)
        {
            DataTable dt_MemberFines = new DataTable();
            NpgsqlDataAdapter finesAdapter = Adapters.Instance.MembersFines;
            finesAdapter.Fill(dt_MemberFines);
            advancedDataGridView_memberFines.DataSource = dt_MemberFines;

            // Changing column name strings
            advancedDataGridView_memberFines.Columns["id_member"].HeaderText = "Member #";
            advancedDataGridView_memberFines.Columns["full_name"].HeaderText = "Full name";
            advancedDataGridView_memberFines.Columns["card_number"].HeaderText = "Card #";
            advancedDataGridView_memberFines.Columns["fine"].HeaderText = "Fine amount";
        }
        private void advancedDataGridView_memberFines_SortStringChanged(object sender, EventArgs e)
        {
            BindingSource bsMemberFines = new BindingSource();
            bsMemberFines.DataSource = advancedDataGridView_memberFines.DataSource;
            bsMemberFines.Sort = advancedDataGridView_memberFines.SortString;
        }

        private void advancedDataGridView_memberFines_FilterStringChanged(object sender, EventArgs e)
        {
            BindingSource bsMemberFines = new BindingSource();
            bsMemberFines.DataSource = advancedDataGridView_memberFines.DataSource;
            bsMemberFines.Filter = advancedDataGridView_memberFines.FilterString;
        }
        // Displaying selected datagridview cells member # and shows it in a textbox
        private void advancedDataGridView_memberFines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow selectedRow = advancedDataGridView_memberFines.Rows[selectedRowIndex];
                textBox_selectedMemberData.Text = selectedRow.Cells[0].Value.ToString();
            }
        }
        // Confirmation message box, ask - question asked, ifYes - message displayed if confirmed
        private void button_clearFine_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear fine?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.numericUpDown_fineAmount.Value = new decimal(new int[] { 0, 0, 0, 0 });
                MessageBox.Show("Fine cleared!");

                ClearCheckBoxes();
            }
            else
            {
                MessageBox.Show("Clear cancelled.");
            }
        }

        private void checkBox_OverdueFine_Click(object sender, EventArgs e)
        {
            // Overdue - 10$ fine
            if (checkBox_OverdueFine.Checked)
            {
                // Add 10 to value
                this.numericUpDown_fineAmount.Value += 10;
            }
            else
            {
                // Subtract 10 from value
                this.numericUpDown_fineAmount.Value -= 10;
            }
        }

        private void checkBox_damaged_Click(object sender, EventArgs e)
        {
            // Damaged - 10 $ fine
            if (checkBox_damaged.Checked)
            {
                // Add 10 to value
                this.numericUpDown_fineAmount.Value += 10;
            }
            else
            {
                // Subtract 10 from value
                this.numericUpDown_fineAmount.Value -= 10;
            }
        }

        private void checkBox_lost_Click(object sender, EventArgs e)
        {
            // Lost - 20$ fine
            if (checkBox_lost.Checked)
            {
                // Add 20 to value
                this.numericUpDown_fineAmount.Value += 20;
            }
            else
            {
                // Subtract 20 from value
                this.numericUpDown_fineAmount.Value -= 20;
            }
        }
        public void ClearCheckBoxes()
        {
            // On clear untick checkboxes
            checkBox_OverdueFine.Checked = false;
            checkBox_damaged.Checked = false;
            checkBox_lost.Checked = false;
        }
        private void button_submitFine_Click(object sender, EventArgs e)
        {
            // Get numeric up down value
            decimal fineVal = this.numericUpDown_fineAmount.Value;
            // Get member ID value
            string memberIDval = GetFineMemberID();

            var confirmResult = MessageBox.Show("Are you sure you want to add a fine for user " + memberIDval + "?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    NpgsqlCommand addVal_cmd = new NpgsqlCommand("UPDATE member SET fine = fine + " + fineVal + " WHERE id_member = '" + memberIDval + "'", Database.Instance.Conn);
                    Database.Instance.Conn.Open();
                    addVal_cmd.ExecuteNonQuery();
                    Database.Instance.Conn.Close();

                    // If a fine gets removed (0) value
                    if (fineVal == 0)
                    {
                        MessageBox.Show("Fine succesfully removed for member " + memberIDval + "!");
                    }
                    // If a fine has a value (> 0 )
                    else
                    {
                        MessageBox.Show("Fine succesfully added for member " + memberIDval + "! This member cannot borrow any more books till they pay their fine.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error has occured during updating fine value. Please try again.");
                }

                ClearCheckBoxes();
            }
            else
            {
                MessageBox.Show("Fine cancelled");
            }
        }
        public string GetFineMemberID()
        {
            string memberIDval = textBox_selectedMemberData.Text.Trim();

            return memberIDval;
        }
        // Gets list of penalties applied to a member. Values checked from checkboxes.
        public List<string> GetPenaltyList()
        {
            List<string> penalties = new List<string>();

            if (checkBox_damaged.Checked)
            {
                penalties.Add("Damaged book - 10$");
            }
            if (checkBox_lost.Checked)
            {
                penalties.Add("Lost book - 20$");
            }
            if (checkBox_OverdueFine.Checked)
            {
                penalties.Add("Overdue book - 10$");
            }

            return penalties;
        }
        private void button_exportFinesToPDF_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            // Create a new document with sizes
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream("C:\\temp\\Fine.pdf", FileMode.Create));

            // Open document to write
            doc.Open();
            // First paragraph that contains general information
            Paragraph paragraph1 = new Paragraph("Fine generated at " + now + "\n\n");
            doc.Add(paragraph1);

            // Recieving Member ID  from textbox
            string user = GetFineMemberID();
            Paragraph paragraph2 = new Paragraph("Penalty set for user " + user +  "\n\n");
            doc.Add(paragraph2);

            // Write DGV
            PdfPTable table = new PdfPTable(advancedDataGridView_memberFines.Columns.Count);
            // Add headers from DGV to table
            for (int i = 0; i < advancedDataGridView_memberFines.Columns.Count; i++)
            {
                table.AddCell(new Phrase(advancedDataGridView_memberFines.Columns[i].HeaderText));
            }
            // Flag first row as header
            table.HeaderRows = 1;

            // Add main data rows from DGV to table
            for (int j = 0; j < advancedDataGridView_memberFines.Rows.Count ; j++)
            {
                for (int k = 0; k < advancedDataGridView_memberFines.Columns.Count; k++)
                {
                    if (advancedDataGridView_memberFines[k, j].Value != null)
                    {
                        table.AddCell(new Phrase(advancedDataGridView_memberFines[k, j].Value.ToString()));
                    }
                }
            }
            // Add created table to document
            doc.Add(table);

            Paragraph paragraph3 = new Paragraph("Warning! All penalties must be paid before another book can be borrowed from the library! \n" + "Penalties set: \n");
            doc.Add(paragraph3);
            // Applied penalty list
            List<string> appliedPenalties = GetPenaltyList();
            // Creating an iTextSharp valid list
            List list = new List(List.ORDERED);
            foreach (string item in appliedPenalties)
            {
                list.Add(item);
            }
            doc.Add(list);

            // Total paragraph
            Paragraph paragraph4 = new Paragraph("Total = " + this.numericUpDown_fineAmount.Value.ToString() + "$");
            doc.Add(paragraph4);

            doc.Close();
        }
        // Takes scanned barcode result from textbox and gets book result that corresponds to this barcode
        public DataTable DisplayRecievedBarcodeData(string barcode)
        {
            DataTable barcodeBook = new DataTable();

            NpgsqlCommand s_barcodeResult_cmd = new NpgsqlCommand("SELECT * FROM book WHERE id_book = '" + barcode + "'",Database.Instance.Conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = s_barcodeResult_cmd;
            da.Fill(barcodeBook);

            return barcodeBook;
        }
        private void button_openFile_Click(object sender, EventArgs e)
        {
            // Using ZXING library that supports barcode processing
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg" })
            {
                // If user accepts to open
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Convert barcode images into strings
                    pictureBox_barCode.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    BarcodeReader barReader = new BarcodeReader();
                    // Result is saved in this variable
                    var result = barReader.Decode((Bitmap)pictureBox_barCode.Image); // Img converted to bitmap
                    // If result is not empty
                    if (result != null)
                    {
                        textBox_barCode.Text = result.ToString();
                    }
                    else
                    {
                        textBox_barCode.Text = "Error! Cannot read barcode!";
                    }
                }
            }
            //Get textbox string to pass in function
            string barcode = textBox_barCode.Text.Trim();
            // Show book in DGV
            DataTable dt = DisplayRecievedBarcodeData(barcode);
            dataGridView_barcodeResult.DataSource = dt;
        }
    }
}
