// The MIT License (MIT) 
// Copyright (c) 1994-2018 The Sage Group plc or its licensors.  All rights reserved.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in 
// the Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
// OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Services.Base;
using ValuedPartner.TU.Interfaces.BusinessRepository;
using ValuedPartner.TU.Interfaces.Services;
using ValuedPartner.TU.Models;

#endregion

namespace ValuedPartner.TU.Services
{
    /// <summary>
    /// Class for SourceCodeEntityService
    /// </summary>
    /// <typeparam name="T">Where T is type of <see cref="SourceCode"/></typeparam>
    public class SourceCodeEntityService<T> : FlatService<T, ISourceCodeEntity<T>>, ISourceCodeService<T>
        where T : SourceCode, new()
    {
        #region Constructor

        /// <summary>
        /// Constructor for SourceCode
        /// </summary>
        /// <param name="context">Request Context</param>
        public SourceCodeEntityService(Context context)
            : base(context)
        {
        }

        #endregion

        /// <summary>
        /// Get the source code based on primary key
        /// </summary>
        /// <param name="sourceLedger">Source Ledger</param>
        /// <param name="sourceType">Source Type</param>
        /// <returns>Source Code</returns>
        public T GetByIds(string sourceLedger, string sourceType)
        {
            using (var repository = Resolve<ISourceCodeEntity<T>>())
            {
                return repository.GetByIds(sourceLedger, sourceType);
            }
        }
    }
}