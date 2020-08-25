using Reconcile.Domain.Consts;
using Reconcile.Domain.ExtensionMethods;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Reconcile.Domain.Models
{
    public abstract class BaseModel
    {
        #region Members

        protected string _tagName;
        protected IEnumerable<IList<string>> _chunkList;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="tags">List of lines representing part of the OFX File</param>
        /// <param name="contFrom">Line to continue part of the OFXFile</param>
        protected BaseModel(IEnumerable<string> tags, ref int contFrom)
        {
            _chunkList = tags.ChunkOn(text => Regex.Match(text, RegexPatterns.initialTag)
                                            .Groups[1].Value.Contains(_tagName));
        }

        #endregion

        #region Abstract Methods

        protected abstract void FillModel();

        #endregion
    }
}