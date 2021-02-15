using System.Collections.Generic;

namespace ASE_admin_app
{
    public class ContainerBonus
    {
        public Bonus StoredBonus { get; private set; }
        public ContainerBonus(Bonus toStore)
        {
            StoredBonus = toStore;
        }
        public override string ToString()
        {
            if(!StoredBonus.NotYetInDB)
            return "id: " + StoredBonus.id.ToString() +  ", from: " + StoredBonus.startDate + " to: " + StoredBonus.endDate + ", score: " + StoredBonus.score;
            else
                return "new bonus, from: " + StoredBonus.startDate + " to: " + StoredBonus.endDate + ", score: " + StoredBonus.score;
        }
    }

    public class ContainerCategories
    {
        public LinkedList<Category> Categories { get; private set; }
        public ContainerCategories(LinkedList<Category> categories)
        {
            this.Categories = categories;
        }
        public override string ToString()
        {
            string listboxLine = "categories: ";
            foreach (Category c in Categories)
            {
                listboxLine += c.ToString() + ", ";
            }
            char[] table = { ',', ' ' };
            return listboxLine.Trim(table);
        }
    }
    public class ContainerAuthors
    {
        public LinkedList<Author> Authors { get; private set; }
        public ContainerAuthors(LinkedList<Author> authors)
        {
            Authors = authors;
        }
        public override string ToString()
        {
            string listboxLine = "authors: ";
            foreach (Author a in Authors)
            {
                listboxLine += a.Name + " " + a.LastName + " (" + a.Id.ToString() + "), ";
            }
            char[] table = { ',', ' ' };
            return listboxLine.Trim(table);
        }
    }
    public class ContainerBook
    {
        public Book StoredBook { get; private set; }
        public ContainerBook(Book toStore)
        {
            StoredBook = toStore;
        }
        public override string ToString()
        {
            return StoredBook.Title + " (" + StoredBook.Id.ToString() + ")";
        }

    }

}
