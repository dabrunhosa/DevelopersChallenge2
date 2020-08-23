using Reconcile.Domain.Interfaces;
using System;
using System.IO;

namespace Reconcile.Domain.Services
{
    public class OFXReaderService : IOFXReaderService
    {
        #region Members

        #endregion

        public void ReadFileToDTO(string fileLocation)
        {
            if (File.Exists(fileLocation))
            {
                // This path is a file
                FileStream fileStream = new FileStream(fileLocation, FileMode.Open);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string line = reader.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", fileLocation);
            }
        }
    }
}
