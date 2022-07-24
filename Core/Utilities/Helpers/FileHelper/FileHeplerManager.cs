using Microsoft.AspNetCore.Http;
using Core.Utilities.Helpers.GuidHelperr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHeplerManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))  //adres kontrolü yapıyoruz
            {
                File.Delete(filePath);
            }
            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length>0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(file.FileName);//dosya uzantısını alırız
                string guid = GuidHelper.CreateGuid();
                string filePath = guid + extension;

                using (FileStream fileStream=File.Create(root+filePath))//oluşturulucak dosyanın yolu ve adı
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();//ara bellekten siler
                    return filePath; //burada dosyamızın tam adını geri gönderiyoruz sebebide sql servere dosya eklenirken adı ile eklenmesi için.
                    
                }
            }
            return null;
        }
    }
}
