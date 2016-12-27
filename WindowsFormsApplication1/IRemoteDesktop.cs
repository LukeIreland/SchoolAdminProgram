using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WindowsFormsApplication1
{ 
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IRemoteDesktop
    {
        [OperationContract]
        byte[] UpdateScreenImage();

        [OperationContract]
        byte[] UpdateCursorImage();
    }
}
