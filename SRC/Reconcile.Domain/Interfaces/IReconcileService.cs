using Reconcile.Domain.Models;
using System.Collections.Generic;

namespace Reconcile.Domain.Interfaces
{
    public interface IReconcileService
    {
        OFXFile ReadFileToDTO(string fileLocation);
        List<OFXFile> ReadFileToDTO(List<string> ofxFiles);
        List<Transaction> ReconcileTransactions(List<OFXFile> ofxFiles);
    }
}