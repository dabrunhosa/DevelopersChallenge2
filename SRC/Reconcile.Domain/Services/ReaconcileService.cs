
using Microsoft.Extensions.Logging;
using Reconcile.Domain.Interfaces;

namespace Reconcile.Domain.Services
{
    public class ReconcileService : IReconcileService
    {
        #region Members

        private readonly IOFXReaderService _oFXReader;

        #endregion

        public ReconcileService(IOFXReaderService ofxReader)
        {
            _oFXReader = ofxReader;
        }
    }
}