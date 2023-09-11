﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sra.P2rmis.Dal.Repository.ConsumerManagement
{
    public interface INomineeAffectedRepository : IGenericRepository<NomineeAffected>
    {

    }
    public class NomineeAffectedRepository : GenericRepository<NomineeAffected>, INomineeAffectedRepository
    {
        #region Construction & Setup & Disposal
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">P2RMIS database context</param>
        public NomineeAffectedRepository(P2RMISNETEntities context)
            : base(context)
        {
        }
        #endregion
    }
}
