using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_admin_app
{
    public class Category
    {
        public Category() { }
        public Category(string name)
        {
            privCateg = name;
        }
        private string privCateg;
        public string categoryName { get { return privCateg.ToLower(); } set {  privCateg = value.ToLower(); } }
        public override string ToString()
        {
            return categoryName;
        }
        public Category clone()
        {
            string n = privCateg;
            return new Category(n);
        }

        internal bool correct()
        {
            return privCateg!=null && privCateg != "";
        }
    }
    public class Author
    {
        public Author(int id, string name, string lastname)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastname;

        }
        private string privName, privLastName;
        public int Id { get; private set; }
        public string Name { get { return privName; } set { privName = value.ToLower(); } }
        public string LastName { get { return privLastName; } set { privLastName = value.ToLower(); } }
        public override string ToString()
        {
            return Id.ToString() + ", " + Name + " " + LastName;
        }
        public Author clone()
        {
            int i = Id;
            string n = Name;
            string ln = LastName;
            return new Author(i, n, ln);
        }

        internal bool correct()
        {
            if(Name==null || Name == "" )
            {
                return false;
            }
            if(LastName==null || LastName=="")
            {
                return false;    
            } 
            if(Id<=0)
            {
                return false;
            }
            return true;
        }
    }

    public class Bonus
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int score { get; set; }
        public int id { get; set; }
        public Bonus clone()
        {
            Bonus copied = new Bonus();
            copied.startDate = startDate.AddSeconds(0.0);
            copied.endDate = endDate.AddSeconds(0.0);
            copied.score = score;
            copied.id = id;
            return copied;
        }
        //public static int NotYetInDB { get { return 0; } private set { } }
        public bool NotYetInDB { get { return id == 0; } private set { } }
        internal bool correct()
        {
            if(score == 0 || id < 0 || endDate.CompareTo(startDate)<=0)
            {
                return false;
            }
            return true;
        }
    }

    public class Book
    {
        internal static readonly int newBookId;
        static Book()
        {
            newBookId = 0;
        }

        public Book()
        {
            authors = new LinkedList<Author>();
            categories = new LinkedList<Category>();
            bonuses = new LinkedList<Bonus>();
            Id = 0;
            Title = "";
            Price = 0;
            priceMinusDiscountInProcent = 100;
            quantity = 0;
            startSellingDate = DateTime.Now;
            deleted = false;
        }
        private LinkedList<Author> privAuthors;
        private LinkedList<Category> privCategs;
        private LinkedList<Bonus> privBonuses;
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int priceMinusDiscountInProcent { get; set; }
        public int quantity { get; set; }
        public DateTime startSellingDate { get; set; }
        public bool deleted { get; set; }
        public LinkedList<Author> authors { get { return privAuthors; }
            set { if (value != null) { privAuthors = value; } else { privAuthors = new LinkedList<Author>(); } } }
        public LinkedList<Category> categories { get { return privCategs; } set { if (value != null) { privCategs = value; }
                else { privCategs = new LinkedList<Category>(); }
            } }
        public LinkedList<Bonus> bonuses { get { return privBonuses; } set { if (value != null) { privBonuses = value; } else { privBonuses = new LinkedList<Bonus>(); } } }
        public Book clone()
        {
            Book copiedBook = new Book();
            foreach(Author a in authors)
            {
                copiedBook.authors.AddLast(a.clone());
            }
            foreach(Category c in categories)
            {
                copiedBook.categories.AddLast(c);
            }
            foreach(Bonus b in bonuses)
            {
                copiedBook.bonuses.AddLast(b);
            }
            copiedBook.Id = Id;
            copiedBook.Title = Title;
            copiedBook.Price = Price;
            copiedBook.priceMinusDiscountInProcent = priceMinusDiscountInProcent;
            copiedBook.quantity = quantity;
            copiedBook.startSellingDate = startSellingDate.AddSeconds(0.0);
            copiedBook.deleted = deleted;
            return copiedBook;
        }

        public static int smallestIdPossible { get { return newBookId; } set { } }
        public string correct()
        {
            if (Id < Book.smallestIdPossible)
            {
                return "book has bad id";
            }
            if (Title == "")
            {
                return "new book has empty title";
            }
            if (Price.CompareTo(0.0m) <= 0)
            {
                return "new book has price lower than or equal to 0";
            }
            if (priceMinusDiscountInProcent < 0 || priceMinusDiscountInProcent > 100)
            {
                return "new book price minus discount in procent must range from 0 to 100";
            }
            if (quantity < 0)
            {
                return "new book quantity must be equal to or greater than 0";
            }
            if (startSellingDate == null)
            {
                return "enter start selling date";
            }
            
            foreach (Author a in authors)
            {
                if (!a.correct())
                {
                    return "one of authors is incorrect (empty name, lastname or id <= 0)";
                }
            }
            foreach (Category c in categories)
            {
                if (!c.correct())
                {
                    return "One of categories is incorrect (empty name)";
                }
            }
            foreach (Bonus b in bonuses)
            {
                if (!b.correct())
                {
                    return "One of bonuses is incorrect (start date >= end date or score is 0)";
                }
            }

            return "";
        }
        public static string BookCorrect { get { return ""; } private set { } } 
    }
}
