﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProductService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        void DoWork();
    }
    [DataContract]
    public class Product
    {

    }
}
