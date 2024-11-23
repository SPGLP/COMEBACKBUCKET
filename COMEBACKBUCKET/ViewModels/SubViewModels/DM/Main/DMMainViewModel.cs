using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMEBACKBUCKET.Models.MessagePack;
using COMEBACKBUCKET.Views.Components.DM;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

using ModelsManager;

namespace COMEBACKBUCKET.ViewModels.SubViewModels.DM.Main;

public partial class DMMainViewModel : ObservableRecipient
{
    private readonly WorkSpace workSpace = new();

    public ObservableCollection<ConnectionItem> ConnectionItems
    {
        get; set;
    }

    public DMMainViewModel()
    {
        IsActive = true;
        ConnectionItems = workSpace.ConnectionItems;
    }

    protected override void OnActivated()
    {
        WeakReferenceMessenger.Default.Register<NewConnetionMessage, string>(this, "AddConnection", (r, m) =>
        {
            if (ConnectionItems != null)
            {
                ConnectionItems.Add(m.ConnectionItem);
                Debug.Print("已添加链接");
            }
        });
    }

    protected override void OnDeactivated()
    {
        WeakReferenceMessenger.Default.Unregister<NewConnetionMessage>(this);
    }
}
