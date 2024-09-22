using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using COMEBACKBUCKET.Views.Components.DM;
using CommunityToolkit.Mvvm.ComponentModel;

namespace COMEBACKBUCKET.ViewModels.SubViewModels.DM.DM_NewConnection;

public partial class NewConnectionViewModel : ObservableRecipient
{
    [ObservableProperty]
    private Type dbTypePage;

    public NewConnectionViewModel() 
    { 
        IsActive =  true;
        dbTypePage = typeof(DM_NC_MySQL);
    }

    public void BUTCancelClick()
    {
        
    }
}