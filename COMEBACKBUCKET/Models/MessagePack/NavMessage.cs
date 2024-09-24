namespace COMEBACKBUCKET.Models.MessagePack;
internal class NavMessage
{
    public Type TargetPage
    {
        get; set;
    }

    public NavMessage(Type targetPage)
    {
        TargetPage = targetPage;
    }

}
