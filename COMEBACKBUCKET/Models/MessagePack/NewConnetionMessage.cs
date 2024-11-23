using CommunityToolkit.Mvvm.Messaging.Messages;
using ModelsManager;

namespace COMEBACKBUCKET.Models.MessagePack;

internal class NewConnetionMessage : RequestMessage<ConnectionItem>
{
    public ConnectionItem? ConnectionItem { get; set; }
}
