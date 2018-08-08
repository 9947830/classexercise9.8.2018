using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{

    public class Book
    {
        string title;
        string authorlname;
        string authorfname;
        string category;
        string location;
        double isbn;
        static void Main(string[] args)
        {
        }

        public Book(string _title, string _authorlname, string _authorfname, string _category, string _location, double _isbn)
        {
            _title = title;
            _authorlname = authorlname;
            _authorfname = authorfname;
            _category = category;
            _location = location;
            _isbn = isbn;
        }
        
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string AuthorLName
        {
            get
            {
                return authorlname;
            }
            set
            {
                authorlname = value;
            }
        }

        public string AuthorFName
        {
            get
            {
                return authorfname;
            }
            set
            {
                authorfname = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public double ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }
    }
}

