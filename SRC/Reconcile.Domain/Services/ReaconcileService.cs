
using Microsoft.Extensions.Logging;
using Reconcile.Domain.Interfaces;
using Reconcile.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Reconcile.Domain.Services
{
    public class ReconcileService : IReconcileService
    {
        #region Members


        #endregion

        #region Constructor

        public ReconcileService()
        {
        }

        #endregion

        #region Public Methods

        #region Read OFX Files

        public OFXFile ReadFileToDTO(string fileLocation)
        {
            OFXFile ofxFile = null;

            if (File.Exists(fileLocation))
            {
                // This path is a file
                var fileRead = File.ReadLines(fileLocation);
                ofxFile = new OFXFile(fileRead);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", fileLocation);
            }

            return ofxFile;
        }

        public List<OFXFile> ReadFileToDTO(List<string> fileLocations)
        {
            List<OFXFile> ofxFiles = new List<OFXFile>();

            fileLocations.ForEach(file =>
                {
                    if (File.Exists(file))
                    {
                        // This path is a file
                        ofxFiles.Add(new OFXFile(File.ReadLines(file)));
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid file or directory.", file);
                    }
                });

            return ofxFiles;
        }

        #endregion Read OFX Files

        #region Reconcile Transactions

        public List<Transaction> ReconcileTransactions(List<OFXFile> ofxFiles)
        {
            return ofxFiles.Select(ofx => ofx.BANKMSGSRSV1.STMTTRNRS.STMTRS.BANKTRANLIST.STMTTRNS)
                .Aggregate((list1, list2) => list1.Union(list2).OrderBy(x => x.DTPOSTED).ToList());
        }

        #endregion Reconcile Transactions

        #endregion Public Methods
    }
}