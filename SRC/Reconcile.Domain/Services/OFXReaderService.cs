using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;
using Reconcile.Domain.Interfaces;
using Reconcile.Domain.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace Reconcile.Domain.Services
{
    public class OFXReaderService : IOFXReaderService
    {
        #region Members 

        private OFXFile _ofxFile;

        #endregion

        public void ReadFileToDTO(string fileLocation)
        {
            if (File.Exists(fileLocation))
            {
                // This path is a file
                var fileRead = File.ReadLines(fileLocation);

                var internalOFXFile = fileRead.SkipWhile(text => !text.Contains("<OFX>"));

                foreach (var line in internalOFXFile)
                {
                    // match first tag, and name it 'tag' 
                    // match text content, name it 'text' 
                    // match last tag, denoted by 'tag'
                    var result = Regex.Match(line, RegexPatterns.initialTag);


                    switch (result.Groups[1].Value)
                    {
                        case OFXTags.OFX:
                            _ofxFile = new OFXFile();
                            break;
                        case OFXTags.SIGNONMSGSRSV1:
                            _ofxFile.SIGNONMSGSRSV1 = new SignonResponseMessage();
                            break;
                        case OFXTags.SONRS:
                            _ofxFile.SIGNONMSGSRSV1.SONRS = new SignonResponse();
                            break;
                            
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", fileLocation);
            }
        }
    }
}
