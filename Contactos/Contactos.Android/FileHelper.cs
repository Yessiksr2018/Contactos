Using System;
Using System.IO;
using Contactos.IOS.Services;
using Contactos.Services;
using Xamarin.Forms;
[assembly: Dependecy(typeof(FileHelper))]

namespace Contactos.iOS.service {

    public class Filehelper : IFileHelper {
    public FileHelper(){
    }
    
    public string GetLocalFilePath(string fileName)
    {
        string docFolder = Enviroment.GetFolderPath(Enviroment.SpecialFolder.Personal);
        string libFolder = Path.Combine(docFolder, "..","DataBases");
        if (Directory.Exist(libFolder)){
            return Path.Combine(libFolder, filename);
        }
        }
    }
    
}
