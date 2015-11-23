namespace _11.ImplementLinkedList
{
    public class ListItem<T>
    {
        public T Value { get; set; }
        public ListItem<T> NextItem { get; set; }

        public ListItem(T value) : this(value, null)
        {
            this.Value = value;
        }

        public ListItem(T value, ListItem<T> nextItem)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }  
    }
}