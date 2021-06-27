using KeLi.DynamicExtension.DB;

namespace KeLi.DynamicExtension.Tool
{
    public interface IExternalCommand
    {
        void Execute(DocumentSet documentSet);
    }
}
