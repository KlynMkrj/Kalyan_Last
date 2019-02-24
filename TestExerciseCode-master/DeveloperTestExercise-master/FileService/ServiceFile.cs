using System;
using System.Collections.Generic;
using System.Text;

using FileRepository;

namespace FileService
{
    public class ServiceFile
    {
        private string _strFileInfo;
        private string _strFilePath;
        RepositoryFile _objRepositoryFile;

        public ServiceFile(string fileInfo, string filePath)
        {
            _strFileInfo = fileInfo;
            _strFilePath = filePath;
            _objRepositoryFile = new RepositoryFile(_strFilePath);
        }

        public string BringFileInformation()
        {
            string strResult;

            switch (_strFileInfo)
            {
                case "-v":
                case "--v":
                case "/v":
                case "--version":
                    strResult = "File Version : " + _objRepositoryFile.FetchVersionFromDB(_strFilePath);
                    break;

                case "-s":
                case "--s":
                case "/s":
                case "--size":
                    strResult = "File Size : " + Convert.ToString(_objRepositoryFile.FetchSizeFromDB(_strFilePath));
                    break;

                default:
                    strResult = "Wrong Input";
                    break;
            }

            return strResult;
        }
    }
}

