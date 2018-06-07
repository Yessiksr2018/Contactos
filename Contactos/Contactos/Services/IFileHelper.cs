using System;
using System.Collections.Generic;
using System.Text;

namespace Contactos.Services
{
    public interface IFileHelper
    {
        String GetLocalFilePath(String FileName);
    }
}
