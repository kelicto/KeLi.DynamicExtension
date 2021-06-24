using KeLi.DynamicExtension.DB;

namespace KeLi.DynamicExtension.Tool
{
    public interface ICommand
    {
        void Execute(DocumentSet documentSet);
    }
}
