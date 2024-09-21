using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace COMEBACKBUCKET.ViewModels.SubViewModels.DM.DM_NewConnection
{
    public class NewConnectionViewModel : ObservableRecipient
    {
        public NewConnectionViewModel() 
        { 
            IsActive =  true;
        }

        public void BUTCancelClick()
        {
            
        }
    }
}