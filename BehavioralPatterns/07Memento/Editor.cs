namespace _07Memento
{
    public class Editor
    {
        private string mContent;
        private EditorMemento memento;

        public Editor()
        {
            mContent = string.Empty;
            memento = new EditorMemento(string.Empty);
        }

        public void Type(string words)
        {
            mContent = string.Concat(mContent, " ", words);
        }

        public string Content
        {
            get
            {
                return mContent;
            }
        }

        public void Save()
        {
            memento = new EditorMemento(mContent);
        }

        public void Restore()
        {
            mContent = memento.Content;
        }
    }
}
