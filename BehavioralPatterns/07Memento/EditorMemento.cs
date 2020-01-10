namespace _07Memento
{
    public class EditorMemento
    {
        private readonly string mContent;
        public EditorMemento(string content)
        {
            mContent = content;
        }

        public string Content
        {
            get
            {
                return mContent;
            }
        }
    }
}
