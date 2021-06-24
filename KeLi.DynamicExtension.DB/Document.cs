using KeLi.DynamicExtension.App;

namespace KeLi.DynamicExtension.DB
{
    public class Document
    {
        public Element CreateElement(int id)
        {
            return new Element(id);
        }
    }
}
