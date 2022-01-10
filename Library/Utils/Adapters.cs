using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Library.Utils
{
    class Adapters
    {
        private static readonly Adapters instance = new Adapters();

        public static Adapters Instance
        {
            get
            {
                return instance;
            }
        }

        private NpgsqlDataAdapter bookAdapter, countryAdapter, publisherAdapter;
        private NpgsqlDataAdapter authorAdapter;
        private NpgsqlDataAdapter languageAdapter;
        private NpgsqlDataAdapter genreAdapter;
        private NpgsqlDataAdapter borrowingsAdapter;
        private NpgsqlDataAdapter memberAdapter;
        private NpgsqlDataAdapter cardAdapter;

        public NpgsqlDataAdapter BookAdapter { get => bookAdapter; set => bookAdapter = value; }
        public NpgsqlDataAdapter CountryAdapter { get => countryAdapter; set => countryAdapter = value; }
        public NpgsqlDataAdapter PublisherAdapter { get => publisherAdapter; set => publisherAdapter = value; }
        public NpgsqlDataAdapter AuthorAdapter { get => authorAdapter; set => authorAdapter = value; }
        public NpgsqlDataAdapter LanguageAdapter { get => languageAdapter; set => languageAdapter = value; }
        public NpgsqlDataAdapter GenreAdapter { get => genreAdapter; set => genreAdapter = value; }
        public NpgsqlDataAdapter BorrowingsAdapter { get => borrowingsAdapter; set => borrowingsAdapter = value; }
        public NpgsqlDataAdapter MemberAdapter { get => memberAdapter; set => memberAdapter = value; }
        public NpgsqlDataAdapter CardAdapter { get => cardAdapter; set => cardAdapter = value; }



        static Adapters() { }

        Adapters()
        {
            CreateAdapters();
        }

        NpgsqlConnection conn = Database.Instance.Conn;
        public void CreateAdapters()
        {
            //CREATING CONNECTION

            //COMMANDS FOR TABLE BOOK
            NpgsqlCommand s_cmd_book = new NpgsqlCommand("SELECT * FROM book", conn);

            NpgsqlCommand i_cmd_book = new NpgsqlCommand("INSERT INTO book VALUES (default, @ISBN, @book_title, @publish_date, @id_publisher, @id_language, @id_genre, @id_author, @availability)", conn);
            i_cmd_book.Parameters.Add(new NpgsqlParameter("@ISBN", DbType.String, 100, "ISBN"));
            i_cmd_book.Parameters.Add(new NpgsqlParameter("@book_title", DbType.String, 100, "book_title"));
            i_cmd_book.Parameters.Add(new NpgsqlParameter("@publish_date", DbType.Date, 100, "publish_date"));
            i_cmd_book.Parameters.Add(new NpgsqlParameter("@id_publisher", DbType.Int32, sizeof(int), "id_publisher"));
            i_cmd_book.Parameters.Add(new NpgsqlParameter("@id_language", DbType.Int32, sizeof(int), "id_language"));
            i_cmd_book.Parameters.Add(new NpgsqlParameter("@id_genre", DbType.Int32, sizeof(int), "id_genre"));
            i_cmd_book.Parameters.Add(new NpgsqlParameter("@id_author", DbType.Int32, sizeof(int), "id_author"));
            i_cmd_book.Parameters.Add(new NpgsqlParameter("@availability", DbType.String, 100, "availability"));

            NpgsqlCommand u_cmd_book = new NpgsqlCommand("UPDATE book SET ISBN = @ISBN, book_title = @book_title, id_publisher = @id_publisher, id_language = @id_language, id_genre = @id_genre, id_author = @id_author, availability = @availability WHERE id_book LIKE @id_book", conn);
            u_cmd_book.Parameters.Add(new NpgsqlParameter("@ISBN", DbType.String, 100, "ISBN"));
            u_cmd_book.Parameters.Add(new NpgsqlParameter("@book_title", DbType.String, 100, "book_title"));
            u_cmd_book.Parameters.Add(new NpgsqlParameter("@id_publisher", DbType.Int32, sizeof(int), "id_publisher"));
            u_cmd_book.Parameters.Add(new NpgsqlParameter("@id_language", DbType.Int32, sizeof(int), "id_language"));
            u_cmd_book.Parameters.Add(new NpgsqlParameter("@id_genre", DbType.Int32, sizeof(int), "id_genre"));
            u_cmd_book.Parameters.Add(new NpgsqlParameter("@id_author", DbType.Int32, sizeof(int), "id_author"));
            u_cmd_book.Parameters.Add(new NpgsqlParameter("@id_book", DbType.String, 100, "id_book"));
            u_cmd_book.Parameters.Add(new NpgsqlParameter("@availability", DbType.String, 100, "availability"));

            NpgsqlCommand d_cmd_book = new NpgsqlCommand("DELETE FROM book WHERE id_book LIKE @id_book", conn);
            d_cmd_book.Parameters.Add(new NpgsqlParameter("@id_book", DbType.String, 100, "id_book"));

            bookAdapter = new NpgsqlDataAdapter();
            bookAdapter.SelectCommand = s_cmd_book;
            bookAdapter.InsertCommand = i_cmd_book;
            bookAdapter.UpdateCommand = u_cmd_book;
            bookAdapter.DeleteCommand = d_cmd_book;

            //COMMANDS FOR TABLE LIBRARY_CARD
            NpgsqlCommand s_cmd_lc = new NpgsqlCommand("SELECT * FROM library_card", conn);

            NpgsqlCommand i_cmd_lc = new NpgsqlCommand("INSERT INTO library_card VALUES (default, @date_issued)", conn);
            i_cmd_lc.Parameters.Add(new NpgsqlParameter("@date_issued", DbType.Date, 100, "date_issued"));

            NpgsqlCommand u_cmd_lc = new NpgsqlCommand("UPDATE library_card SET date_issued = @date_issued WHERE card_number LIKE @card_number", conn);
            u_cmd_lc.Parameters.Add(new NpgsqlParameter("@date_issued", DbType.Date, 100, "date_issued"));
            u_cmd_lc.Parameters.Add(new NpgsqlParameter("@card_number", DbType.String, 100, "card_number"));

            NpgsqlCommand d_cmd_lc = new NpgsqlCommand("DELETE FROM library_card WHERE card_number LIKE @card_number", conn);
            d_cmd_lc.Parameters.Add(new NpgsqlParameter("@card_number", DbType.String, 100, "card_number"));

            cardAdapter = new NpgsqlDataAdapter();
            cardAdapter.SelectCommand = s_cmd_lc;
            cardAdapter.InsertCommand = i_cmd_lc;
            cardAdapter.UpdateCommand = u_cmd_lc;
            cardAdapter.DeleteCommand = d_cmd_lc;

            //COMMANDS FOR MEMBER
            NpgsqlCommand s_cmd_member = new NpgsqlCommand("SELECT * FROM member", conn);

            NpgsqlCommand i_cmd_member = new NpgsqlCommand("INSERT INTO member VALUES (default, @full_name, @phone_number, @email, @address, @card_number)", conn);
            i_cmd_member.Parameters.Add(new NpgsqlParameter("@full_name", DbType.String, 100, "full_name"));
            i_cmd_member.Parameters.Add(new NpgsqlParameter("@phone_number", DbType.String, 100, "phone_number"));
            i_cmd_member.Parameters.Add(new NpgsqlParameter("@email", DbType.String, 100, "email"));
            i_cmd_member.Parameters.Add(new NpgsqlParameter("@address", DbType.String, 100, "address"));
            i_cmd_member.Parameters.Add(new NpgsqlParameter("@card_number", DbType.String, 100, "card_number"));

            NpgsqlCommand u_cmd_member = new NpgsqlCommand("UPDATE member SET full_name = @full_name, phone_number = @phone_number, email = @email, address = @address, card_number = @card_number WHERE id_member LIKE @id_member", conn);
            u_cmd_member.Parameters.Add(new NpgsqlParameter("@full_name", DbType.String, 100, "full_name"));
            u_cmd_member.Parameters.Add(new NpgsqlParameter("@phone_number", DbType.String, 100, "phone_number"));
            u_cmd_member.Parameters.Add(new NpgsqlParameter("@email", DbType.String, 100, "email"));
            u_cmd_member.Parameters.Add(new NpgsqlParameter("@address", DbType.String, 100, "address"));
            u_cmd_member.Parameters.Add(new NpgsqlParameter("@card_number", DbType.String, 100, "card_number"));
            u_cmd_member.Parameters.Add(new NpgsqlParameter("@id_member", DbType.String, 100, "id_member"));

            NpgsqlCommand d_cmd_member = new NpgsqlCommand("DELETE FROM member WHERE id_member LIKE @id_member", conn);
            d_cmd_member.Parameters.Add(new NpgsqlParameter("@id_member", DbType.String, 100, "id_member"));

            memberAdapter = new NpgsqlDataAdapter();
            memberAdapter.SelectCommand = s_cmd_member;
            memberAdapter.InsertCommand = i_cmd_member;
            memberAdapter.UpdateCommand = u_cmd_member;
            memberAdapter.DeleteCommand = d_cmd_member;

            //COMMANDS FOR COUNTRY
            NpgsqlCommand s_cmd_country = new NpgsqlCommand("SELECT * FROM country", conn);

            NpgsqlCommand i_cmd_country = new NpgsqlCommand("INSERT INTO country VALUES (default, @country_name)", conn);
            i_cmd_country.Parameters.Add(new NpgsqlParameter("@country_name", DbType.String, 100, "country_name"));

            NpgsqlCommand u_cmd_country = new NpgsqlCommand("UPDATE country SET country_name = @country_name WHERE id_country = @id_country", conn);
            u_cmd_country.Parameters.Add(new NpgsqlParameter("@country_name", DbType.String, 100, "country_name"));
            u_cmd_country.Parameters.Add(new NpgsqlParameter("@id_country", DbType.Int32, sizeof(int), "id_country"));

            NpgsqlCommand d_cmd_country = new NpgsqlCommand("DELETE FROM country WHERE id_country = @id_country", conn);
            d_cmd_country.Parameters.Add(new NpgsqlParameter("@id_country", DbType.Int32, sizeof(int), "id_country"));

            countryAdapter = new NpgsqlDataAdapter();
            countryAdapter.SelectCommand = s_cmd_country;
            countryAdapter.InsertCommand = i_cmd_country;
            countryAdapter.UpdateCommand = u_cmd_country;
            countryAdapter.DeleteCommand = d_cmd_country;

            //COMMANDS FOR PUBLISHER
            NpgsqlCommand s_cmd_publisher = new NpgsqlCommand("SELECT * FROM publisher", conn);

            NpgsqlCommand i_cmd_publisher = new NpgsqlCommand("INSERT INTO publisher VALUES (default, @publisher_name, @id_country)", conn);
            i_cmd_publisher.Parameters.Add(new NpgsqlParameter("@publisher_name", DbType.String, 100, "publisher_name"));
            i_cmd_publisher.Parameters.Add(new NpgsqlParameter("@id_country", DbType.Int32, sizeof(int), "id_country"));

            NpgsqlCommand u_cmd_publisher = new NpgsqlCommand("UPDATE publisher SET publisher_name = @publisher_name, id_country = @id_country WHERE id_publisher = @id_publisher", conn);
            u_cmd_publisher.Parameters.Add(new NpgsqlParameter("@publisher_name", DbType.String, 100, "publisher_name"));
            u_cmd_publisher.Parameters.Add(new NpgsqlParameter("@id_country", DbType.Int32, sizeof(int), "id_country"));
            u_cmd_publisher.Parameters.Add(new NpgsqlParameter("@id_publisher", DbType.Int32, sizeof(int), "id_publisher"));

            NpgsqlCommand d_cmd_publisher = new NpgsqlCommand("DELETE FROM publisher WHERE id_publisher = @id_publisher", conn);
            d_cmd_publisher.Parameters.Add(new NpgsqlParameter("@id_publisher", DbType.Int32, sizeof(int), "id_publisher"));

            publisherAdapter = new NpgsqlDataAdapter();
            publisherAdapter.SelectCommand = s_cmd_publisher;
            publisherAdapter.InsertCommand = i_cmd_publisher;
            publisherAdapter.UpdateCommand = u_cmd_publisher;
            publisherAdapter.DeleteCommand = d_cmd_publisher;

            //COMMANDS FOR BORROWINGS
            NpgsqlCommand s_cmd_borrowings = new NpgsqlCommand("SELECT * FROM borrowings", conn);

            NpgsqlCommand i_cmd_borrowings = new NpgsqlCommand("INSERT INTO borrowings VALUES (default, @id_member, @id_book, @date_borrowed, @date_due, @is_returned)", conn);
            i_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@id_member", DbType.String, 100, "id_member"));
            i_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@id_book", DbType.String, 100, "id_book"));
            i_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@date_borrowed", DbType.Date, 100, "date_borrowed"));
            i_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@date_due", DbType.Date, 100, "date_due"));
            i_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@is_returned", DbType.Boolean, 100, "is_returned"));

            NpgsqlCommand u_cmd_borrowings = new NpgsqlCommand("UPDATE borrowings SET id_member = @id_member, id_book = @id_book, date_borrowed = @date_borrowed, date_due = @date_due, is_returned = @is_returned WHERE id_borrowing_info = @id_borrowing_info", conn);
            u_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@id_member", DbType.String, 100, "id_member"));
            u_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@id_book", DbType.String, 100, "id_book"));
            u_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@date_borrowed", DbType.Date, 100, "date_borrowed"));
            u_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@date_due", DbType.Date, 100, "date_due"));
            u_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@id_borrowing_info", DbType.Int32, sizeof(int), "id_borrowing_info"));
            u_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@is_returned", DbType.Boolean, 100, "is_returned"));

            NpgsqlCommand d_cmd_borrowings = new NpgsqlCommand("DELETE FROM borrowings WHERE id_borrowing_info = @id_borrowing_info", conn);
            d_cmd_borrowings.Parameters.Add(new NpgsqlParameter("@id_borrowing_info", DbType.Int32, sizeof(int), "id_borrowing_info"));

            borrowingsAdapter = new NpgsqlDataAdapter();
            borrowingsAdapter.SelectCommand = s_cmd_borrowings;
            borrowingsAdapter.InsertCommand = i_cmd_borrowings;
            borrowingsAdapter.UpdateCommand = u_cmd_borrowings;
            borrowingsAdapter.DeleteCommand = d_cmd_borrowings;

            //COMMANDS FOR TABLE GENRE
            NpgsqlCommand s_cmd_genre = new NpgsqlCommand("SELECT * FROM genre", conn);

            NpgsqlCommand i_cmd_genre = new NpgsqlCommand("INSERT INTO genre VALUES (default, @genre_name, @id_parent_genre)", conn);
            i_cmd_genre.Parameters.Add(new NpgsqlParameter("@genre_name", DbType.String, 100, "genre_name"));
            i_cmd_genre.Parameters.Add(new NpgsqlParameter("@id_parent_genre", DbType.Int32, sizeof(int), "id_parent_genre"));

            NpgsqlCommand u_cmd_genre = new NpgsqlCommand("UPDATE genre SET genre_name = @genre_name, id_parent_genre = @id_parent_genre WHERE id_genre = @id_genre", conn);
            u_cmd_genre.Parameters.Add(new NpgsqlParameter("@genre_name", DbType.String, 100, "genre_name"));
            u_cmd_genre.Parameters.Add(new NpgsqlParameter("@id_parent_genre", DbType.Int32, sizeof(int), "id_parent_genre"));
            u_cmd_genre.Parameters.Add(new NpgsqlParameter("@id_genre", DbType.Int32, sizeof(int), "id_genre"));

            NpgsqlCommand d_cmd_genre = new NpgsqlCommand("DELETE FROM genre WHERE id_genre = @id_genre", conn);
            d_cmd_genre.Parameters.Add(new NpgsqlParameter("@id_genre", DbType.Int32, sizeof(int), "id_genre"));

            genreAdapter = new NpgsqlDataAdapter();
            genreAdapter.SelectCommand = s_cmd_genre;
            genreAdapter.InsertCommand = i_cmd_genre;
            genreAdapter.UpdateCommand = u_cmd_genre;
            genreAdapter.DeleteCommand = d_cmd_genre;

            //COMMANDS FOR TABLE AUTHOR
            CreateAuthorAdapter();

            //COMMANDS  FOR TABLE LANGUAGE
            NpgsqlCommand s_cmd_language = new NpgsqlCommand("SELECT * FROM language", conn);

            NpgsqlCommand i_cmd_language = new NpgsqlCommand("INSERT INTO language VALUES (default, @language)", conn);
            i_cmd_language.Parameters.Add(new NpgsqlParameter("@language", DbType.String, 100, "language"));

            NpgsqlCommand u_cmd_language = new NpgsqlCommand("UPDATE language SET language = @language WHERE id_language = @id_language", conn);
            u_cmd_language.Parameters.Add(new NpgsqlParameter("@language", DbType.String, 100, "language"));
            u_cmd_language.Parameters.Add(new NpgsqlParameter("@id_language", DbType.Int32, sizeof(int), "id_language"));

            NpgsqlCommand d_cmd_language = new NpgsqlCommand("DELETE FROM language WHERE id_language = @id_language", conn);
            d_cmd_language.Parameters.Add(new NpgsqlParameter("@id_language", DbType.Int32, sizeof(int), "id_language"));

            languageAdapter = new NpgsqlDataAdapter();
            languageAdapter.SelectCommand = s_cmd_language;
            languageAdapter.InsertCommand = i_cmd_language;
            languageAdapter.UpdateCommand = u_cmd_language;
            languageAdapter.DeleteCommand = d_cmd_language;
        }

        public void CreateAuthorAdapter()
        {
            NpgsqlCommand s_cmd_author = new NpgsqlCommand("SELECT * FROM author", conn);

            NpgsqlCommand i_cmd_author = new NpgsqlCommand("INSERT INTO author VALUES (default, @full_name)", conn);
            i_cmd_author.Parameters.Add(new NpgsqlParameter("@full_name", DbType.String, 100, "full_name"));

            NpgsqlCommand u_cmd_author = new NpgsqlCommand("UPDATE author SET full_name = @full_name WHERE id_author = @id_author", conn);
            u_cmd_author.Parameters.Add(new NpgsqlParameter("@full_name", DbType.String, 100, "full_name"));
            u_cmd_author.Parameters.Add(new NpgsqlParameter("@id_author", DbType.Int32, sizeof(int), "id_author"));

            NpgsqlCommand d_cmd_author = new NpgsqlCommand("DELETE FROM author WHERE id_author = @id_author", conn);
            d_cmd_author.Parameters.Add(new NpgsqlParameter("@id_author", DbType.Int32, sizeof(int), "id_author"));

            authorAdapter = new NpgsqlDataAdapter();
            authorAdapter.SelectCommand = s_cmd_author;
            authorAdapter.InsertCommand = i_cmd_author;
            authorAdapter.UpdateCommand = u_cmd_author;
            authorAdapter.DeleteCommand = d_cmd_author;
        }
        
        public void HandleTreeAdapters(NodeLabelEditEventArgs e)
        {
            DataTable tempTable = new DataTable();
            if (e.Label != null)
                e.Node.Text = e.Label;

            NpgsqlCommand s_cmd_genre = new NpgsqlCommand("SELECT * FROM genre", Database.Instance.Conn);

            NpgsqlCommand i_cmd_genre = new NpgsqlCommand("INSERT INTO genre VALUES (default, @genre_name, @id_parent_genre)", Database.Instance.Conn);
            i_cmd_genre.Parameters.Add(new NpgsqlParameter("@genre_name", DbType.String, 100, "genre_name"));
            i_cmd_genre.Parameters.Add(new NpgsqlParameter("@id_parent_genre", DbType.Int32, sizeof(int), "id_parent_genre"));

            NpgsqlCommand u_cmd_genre = new NpgsqlCommand("UPDATE genre SET genre_name = @genre_name, id_parent_genre = @id_parent_genre WHERE id_genre = @id_genre", Database.Instance.Conn);
            u_cmd_genre.Parameters.Add(new NpgsqlParameter("@genre_name", DbType.String, 100, "genre_name"));
            u_cmd_genre.Parameters.Add(new NpgsqlParameter("@id_parent_genre", DbType.Int32, sizeof(int), "id_parent_genre"));
            u_cmd_genre.Parameters.Add(new NpgsqlParameter("@id_genre", DbType.Int32, sizeof(int), "id_genre"));

            NpgsqlCommand d_cmd_genre = new NpgsqlCommand("DELETE FROM genre WHERE id_genre = @id_genre", Database.Instance.Conn);
            d_cmd_genre.Parameters.Add(new NpgsqlParameter("@id_genre", DbType.Int32, sizeof(int), "id_genre"));

            NpgsqlDataAdapter genreAdapter = new NpgsqlDataAdapter();
            genreAdapter.SelectCommand = s_cmd_genre;
            genreAdapter.InsertCommand = i_cmd_genre;
            genreAdapter.UpdateCommand = u_cmd_genre;
            genreAdapter.DeleteCommand = d_cmd_genre;

            genreAdapter.Fill(tempTable);

            int i = 0;
            int t = -1;
            foreach (DataRow dr in tempTable.Rows)
            {
                if (dr[0].ToString() == e.Node.Name)
                {
                    t = i;
                }
                i++;
            }
            DataRow dr1 = tempTable.NewRow();
            dr1["id_genre"] = 0;
            dr1["genre_name"] = e.Node.Text.ToString();
            int temp = e.Node.Parent.Name == null ? 0 : int.Parse(e.Node.Parent.Name);
            dr1["id_parent_genre"] = temp;

            tempTable.Rows.Add(dr1);
            genreAdapter.Update(tempTable);           
        }
    }
}
