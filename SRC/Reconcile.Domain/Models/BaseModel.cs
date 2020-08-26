using Reconcile.Domain.Consts;
using Reconcile.Domain.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Reconcile.Domain.Models
{
    public abstract class BaseModel
    {
        #region Members

        protected IEnumerable<string> _chunkList;
        protected Action<string, string> _fillAction;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="tags">List of lines representing part of the OFX File</param>
        /// <param name="contFrom">Line to continue part of the OFXFile</param>
        public BaseModel(IEnumerable<string> tags, string tagName)
        {
            //_chunkList = tags.ChunkOn(text =>
            //                Regex.Match(text, RegexPatterns.initialTag)
            //                .Groups[1].Value.Contains(_tagName));

            _chunkList = tags.ChunkOn(text => text == "<" + tagName + ">",
                                text => text == "</" + tagName + ">").ToList();
        }

        #endregion

        #region Protected Methods

        protected void FillDTO()
        {
            Match tempTag, tempTagValue;

            _chunkList = _chunkList.Skip(ContFrom);

            foreach (var line in _chunkList)
            {
                tempTag = Regex.Match(line, RegexPatterns.initialTag);
                tempTagValue = Regex.Match(line, RegexPatterns.tagAndValue);

                _fillAction(tempTag.Groups[1].Value, tempTagValue.Groups[2].Value);

                ContFrom++;
            }
        }

        #endregion

        #region Properties

        public int ContFrom { get; set; }

        #endregion
    }
}