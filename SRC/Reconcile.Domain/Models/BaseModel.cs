using Reconcile.Domain.Consts;
using Reconcile.Domain.ExtensionMethods;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Reconcile.Domain.Models
{
    public abstract class BaseModel
    {
        #region Members

        protected string _tagName;
        protected IEnumerable<string> _chunkList;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="tags">List of lines representing part of the OFX File</param>
        /// <param name="contFrom">Line to continue part of the OFXFile</param>
        public BaseModel(IEnumerable<string> tags, string tagName)
        {
            _tagName = tagName;
            //_chunkList = tags.ChunkOn(text =>
            //                Regex.Match(text, RegexPatterns.initialTag)
            //                .Groups[1].Value.Contains(_tagName));

            _chunkList = tags.ChunkOn(text => text == "<" + _tagName + ">",
                                text => text == "</" + _tagName + ">");
        }

        #endregion

        #region Abstract Methods

        protected abstract void FillModel();

        #endregion
    }
}