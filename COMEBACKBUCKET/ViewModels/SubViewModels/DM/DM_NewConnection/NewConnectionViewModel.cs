using COMEBACKBUCKET.Models.MessagePack;
using COMEBACKBUCKET.Views.Components.DM;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace COMEBACKBUCKET.ViewModels.SubViewModels.DM.DM_NewConnection;

public partial class NewConnectionViewModel : ObservableRecipient
{
    [ObservableProperty]
    private Type _dbTypePage;

    [ObservableProperty]
    private string _dbTypeName;

    public NewConnectionViewModel()
    {
        DbTypeName = "MySQL";
        DbTypePage = typeof(DM_NC_MySQL); 
    }

    public void DBUTSelectMySQL()
    {
        DbTypeName = "MySQL";
        DbTypePage = typeof(DM_NC_MySQL);
    }

    public void DBUTSelectPostgresSQL()
    {
        DbTypeName = "PostgresSQL";
        DbTypePage = typeof(DM_NC_PostgresSQL);
    }

    public void DBUTSelectOracle()
    {
        DbTypeName = "Oracle";
        DbTypePage = typeof(DM_NC_Oracle);
    }

    public void DBUTSelectSQLServer()
    {
        DbTypeName = "SQL Server";
        DbTypePage = typeof(DM_NC_SQLServer);
    }

    public void DBUTSelectOpenGauss()
    {
        DbTypeName = "OpenGauss";
        DbTypePage = typeof(DM_NC_OpenGauss);
    }

    public void BUTCancelClick()
    {
        WeakReferenceMessenger.Default.Send(new NavMessage(typeof(DM_Main)));
    }

}