using System.Collections.Generic;

namespace DOMBuilder
{
    public class Element
    {
        private ICollection<Element> children;
        private string type;
        public Element(string type, params Element[] children)
        {
            this.children = children;
            this.type = type;
        }

        public void Add(Element element)
        {
            if (element != null)
                this.children.Add(element);
        }

        public void Remove(Element element)
        {
            if (element != null)
                this.children.Remove(element);
        }

        public string Display()
        {
            var result = $"<{this.type}>\n";

            foreach (var child in children)
            {
                result += child.Display();
            }

            result += $"</{this.type}>\n";

            return result;
        }
    }
}
