using Microsoft.Extensions.Logging;
using Reconcile.Domain.Interfaces;
using Reconcile.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Reconcile.Test
{
    public class ReconcileTests
    {
        #region Members

        // We use sut to identify as a subject under test
        private readonly IReconcileService _sut;
        private readonly IOFXReaderService _ofxReader;

        #endregion

        #region Constructor

        public ReconcileTests()
        {
            _ofxReader = new OFXReaderService();

            _sut = new ReconcileService(_ofxReader);
        }

        #endregion

        #region Test Methods

        [Theory]
        [InlineData("D:\\Projetos\\02_JobChallenge\\Nibo\\DevelopersChallenge2\\OFX\\extrato1.ofx")]
        [InlineData("D:\\Projetos\\02_JobChallenge\\Nibo\\DevelopersChallenge2\\OFX\\extrato2.ofx")]
        public void ReadOFXFile_ShouldRecognizeOFXFile(string fileLocation)
        {
            _ofxReader.ReadFileToDTO(fileLocation);
        }

        #endregion
    }
}
