﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OpenNos.WCF.Interface
{
    public interface ICommunicationCallback
    {
        [OperationContract(IsOneWay = true)]
        void RegisterPlayerLoginCallback(string value);
    }
}
