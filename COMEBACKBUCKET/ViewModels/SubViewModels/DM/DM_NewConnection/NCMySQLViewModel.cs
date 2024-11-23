using System.Diagnostics;
using COMEBACKBUCKET.Models.MessagePack;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using ModelsManager;

namespace COMEBACKBUCKET.ViewModels.SubViewModels.DM.DM_NewConnection;

public partial class NCMySQLViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string? _server;

    [ObservableProperty]
    private string? _datebase;

    [ObservableProperty]
    private string? _username;

    [ObservableProperty]
    private string? _password;

    [ObservableProperty]
    private string? _port = "3306";

    [ObservableProperty]
    private string? _charset = "utf-8";

    [ObservableProperty]
    private bool _allowLoadLocalInfile = true;

    public NCMySQLViewModel()
    {
        IsActive = true;
    }

    public ConnectionItem CreateMySQLConnetion()
    {
        var dbConf = $"server={Server};" +
                     $"Datebase={Datebase};" +
                     $"Uid={Username};" +
                     $"Pwd={Password};" +
                     $"Port={Port};" +
                     $"Charset={Charset}" +
                     $"AllowLoadLocalInfile={(AllowLoadLocalInfile ? "ture" : "false")}";
        return new ConnectionItem() { DBConf = dbConf, DBType = SqlSugar.DbType.MySql };
    }
    protected override void OnActivated()
    {
        WeakReferenceMessenger.Default.Register<NewConnetionMessage, string>(this,"NewMySQL", (r, m) => m.Reply(CreateMySQLConnetion()));
    }

    protected override void OnDeactivated()
    {
        WeakReferenceMessenger.Default.Unregister<NewConnetionMessage>(this);
    }
}
