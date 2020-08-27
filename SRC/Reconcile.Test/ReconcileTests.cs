using FluentAssertions;
using Microsoft.Extensions.Logging;
using Reconcile.Domain.Interfaces;
using Reconcile.Domain.Models;
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

        #endregion

        #region Constructor

        public ReconcileTests()
        {
            _sut = new ReconcileService();
        }

        #endregion

        #region Test Methods

        [Theory]
        [InlineData("D:\\Projetos\\02_JobChallenge\\Nibo\\DevelopersChallenge2\\OFX\\extrato1.ofx")]
        [InlineData("D:\\Projetos\\02_JobChallenge\\Nibo\\DevelopersChallenge2\\OFX\\extrato2.ofx")]
        public void ReadOFXFile_ShouldRecognizeOFXFile(string fileLocation)
        {
            _sut.ReadFileToDTO(fileLocation)
                .Should()
                .NotBeNull();
        }

        [Fact]
        public void ReadOFXFile_ShouldReadMultipleFiles()
        {
            List<string> ofxFiles = new List<string>();

            ofxFiles.Add("D:\\Projetos\\02_JobChallenge\\Nibo\\DevelopersChallenge2\\OFX\\extrato1.ofx");
            ofxFiles.Add("D:\\Projetos\\02_JobChallenge\\Nibo\\DevelopersChallenge2\\OFX\\extrato2.ofx");

            _sut.ReadFileToDTO(ofxFiles)
                .Should()
                .NotBeSameAs(new List<OFXFile>());
        }

        [Fact]
        public void OFXFiles_ShouldReconcileTransactions()
        {
            List<string> ofxFiles = new List<string>();

            ofxFiles.Add("D:\\Projetos\\02_JobChallenge\\Nibo\\DevelopersChallenge2\\OFX\\extrato1.ofx");
            ofxFiles.Add("D:\\Projetos\\02_JobChallenge\\Nibo\\DevelopersChallenge2\\OFX\\extrato2.ofx");

            _sut.ReconcileTransactions(_sut.ReadFileToDTO(ofxFiles));
        }

        #endregion
    }
}
