namespace User.Shared
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    public class Book
    {
        public string Name;
        public string Title;

        public Genre property = Genre.Science;
        private string password;
        internal int copiesInStock = 5;
    }


}

