using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ThirdPartyTools;

namespace FileRepository
{
    public class RepositoryFile
    {
        private string _strFilePath;
        FileDetails _objFileDetails;

        public RepositoryFile(string filePath)
        {
            _strFilePath = filePath;
            _objFileDetails = new FileDetails();
        }

        public string FetchVersionFromDB(string filePath)
        {
            return _objFileDetails.Version(_strFilePath);
        }

        public int FetchSizeFromDB(string filePath)
        {
            return _objFileDetails.Size(_strFilePath);
        }
    }
}
