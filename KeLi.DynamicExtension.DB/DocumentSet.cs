using System.Collections.Generic;

namespace KeLi.DynamicExtension.DB
{
    public class DocumentSet : List<Document>
    {
        public Document GetCurrentDocument()
        {
            return new Document();
        }
    }
}
