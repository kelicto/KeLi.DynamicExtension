using KeLi.DynamicExtension.DB;

namespace KeLi.DynamicExtension.Tool
{
    public abstract class BaseCommand: IExternalCommand
    {
        protected DocumentSet _documentSet;

        public void Execute(DocumentSet documentSet)
        {
            _documentSet = documentSet;

            try
            {
                Start();
            }
            finally
            {
                Close();
            }
        }

        public abstract void Start();

        public abstract void Close();
    }
}