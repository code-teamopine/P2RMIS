using Sra.P2rmis.Dal.Repository.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sra.P2rmis.Dal
{
    public partial class UnitOfWork
    {
        #region Policy
        /// <summary>
        /// Provides database access for the Policy repository functions.
        /// </summary>
        private IPolicyRepository _PolicyRepository;
        public IPolicyRepository PolicyRepository { get { return LazyLoadPolicy(); } }
        /// <summary>
        /// Lazy load the Policy.
        /// </summary>
        /// <returns>WeekDayType</returns>
        private IPolicyRepository LazyLoadPolicy()
        {
            if (this._context == null)
            {
                _context = new P2RMISNETEntities();
            }

            if (this._PolicyRepository == null)
            {
                this._PolicyRepository = new PolicyRepository(_context);
            }
            return _PolicyRepository;
        }
        #endregion

        #region Policy Week
        /// <summary>
        /// Provides database access for the Policy week day repository functions.
        /// </summary>
        private IPolicyWeekDayRepository _PolicyWeekDayRepository;
        public IPolicyWeekDayRepository PolicyWeekDayRepository { get { return LazyLoadPPolicyWeekDayRepository(); } }
        /// <summary>
        /// Lazy load the Policy.
        /// </summary>
        /// <returns>WeekDayType</returns>
        private IPolicyWeekDayRepository LazyLoadPPolicyWeekDayRepository()
        {
            if (this._context == null)
            {
                _context = new P2RMISNETEntities();
            }

            if (this._PolicyWeekDayRepository == null)
            {
                this._PolicyWeekDayRepository = new PolicyWeekDayRepository(_context);
            }
            return _PolicyWeekDayRepository;
        }
        #endregion

        #region Policy Network Range
        /// <summary>
        /// Provides database access for the Policy network range repository functions.
        /// </summary>
        private IPolicyNetworkRangeRepository _PolicyNetworkRangeRepository;
        public IPolicyNetworkRangeRepository PolicyNetworkRangeRepository { get { return LazyLoadPPolicyNetworkRangeRepository(); } }
        /// <summary>
        /// Lazy load the Policy.
        /// </summary>
        /// <returns>NetworkRangeType</returns>
        private IPolicyNetworkRangeRepository LazyLoadPPolicyNetworkRangeRepository()
        {
            if (this._context == null)
            {
                _context = new P2RMISNETEntities();
            }

            if (this._PolicyNetworkRangeRepository == null)
            {
                this._PolicyNetworkRangeRepository = new PolicyNetworkRangeRepository(_context);
            }
            return _PolicyNetworkRangeRepository;
        }
        #endregion

    }

    public partial class UnitOfWork
    {
        #region Policy History
        /// <summary>
        /// Provides database access for the PolicyHistory repository functions.
        /// </summary>
        private IPolicyHistoryRepository _PolicyHistoryRepository;
        public IPolicyHistoryRepository PolicyHistoryRepository { get { return LazyLoadPolicyHistory(); } }
        /// <summary>
        /// Lazy load the PolicyHistory.
        /// </summary>
        /// <returns>WeekDayType</returns>
        private IPolicyHistoryRepository LazyLoadPolicyHistory()
        {
            if (this._context == null)
            {
                _context = new P2RMISNETEntities();
            }

            if (this._PolicyHistoryRepository == null)
            {
                this._PolicyHistoryRepository = new PolicyHistoryRepository(_context);
            }
            return _PolicyHistoryRepository;
        }
        //#region PolicyHistory Week
        ///// <summary>
        ///// Provides database access for the PolicyHistory week day repository functions.
        ///// </summary>
        //private IPolicyHistoryWeekDayRepository _PolicyHistoryWeekDayRepository;
        //public IPolicyHistoryWeekDayRepository PolicyHistoryWeekDayRepository { get { return LazyLoadPPolicyHistoryWeekDayRepository(); } }
        ///// <summary>
        ///// Lazy load the PolicyHistory.
        ///// </summary>
        ///// <returns>WeekDayType</returns>
        //private IPolicyHistoryWeekDayRepository LazyLoadPPolicyHistoryWeekDayRepository()
        //{
        //    if (this._context == null)
        //    {
        //        _context = new P2RMISNETEntities();
        //    }

        //    if (this._PolicyHistoryWeekDayRepository == null)
        //    {
        //        this._PolicyHistoryWeekDayRepository = new PolicyHistoryWeekDayRepository(_context);
        //    }
        //    return _PolicyHistoryWeekDayRepository;
        //}
        //#endregion

        //#region PolicyHistory Network Range
        ///// <summary>
        ///// Provides database access for the PolicyHistory network range repository functions.
        ///// </summary>
        //private IPolicyHistoryNetworkRangeRepository _PolicyHistoryNetworkRangeRepository;
        //public IPolicyHistoryNetworkRangeRepository PolicyHistoryNetworkRangeRepository { get { return LazyLoadPPolicyHistoryNetworkRangeRepository(); } }
        ///// <summary>
        ///// Lazy load the PolicyHistory.
        ///// </summary>
        ///// <returns>NetworkRangeType</returns>
        //private IPolicyHistoryNetworkRangeRepository LazyLoadPPolicyHistoryNetworkRangeRepository()
        //{
        //    if (this._context == null)
        //    {
        //        _context = new P2RMISNETEntities();
        //    }

        //    if (this._PolicyHistoryNetworkRangeRepository == null)
        //    {
        //        this._PolicyHistoryNetworkRangeRepository = new PolicyHistoryNetworkRangeRepository(_context);
        //    }
        //    return _PolicyHistoryNetworkRangeRepository;
        //}
        //#endregion
        #endregion

        #region Policy Week History
        /// <summary>
        /// Provides database access for the Policy week day repository functions.
        /// </summary>
        private IPolicyWeekDayHistoryRepository _PolicyWeekDayHistoryRepository;
        public IPolicyWeekDayHistoryRepository PolicyWeekDayHistoryRepository { get { return LazyLoadPPolicyWeekDayHistoryRepository(); } }
        /// <summary>
        /// Lazy load the Policy.
        /// </summary>
        /// <returns>WeekDayHistoryType</returns>
        private IPolicyWeekDayHistoryRepository LazyLoadPPolicyWeekDayHistoryRepository()
        {
            if (this._context == null)
            {
                _context = new P2RMISNETEntities();
            }

            if (this._PolicyWeekDayHistoryRepository == null)
            {
                this._PolicyWeekDayHistoryRepository = new PolicyWeekDayHistoryRepository(_context);
            }
            return _PolicyWeekDayHistoryRepository;
        }
        #endregion

        #region Policy Network Range History
        /// <summary>
        /// Provides database access for the Policy network range repository functions.
        /// </summary>
        private IPolicyNetworkRangeHistoryRepository _PolicyNetworkRangeHistoryRepository;
        public IPolicyNetworkRangeHistoryRepository PolicyNetworkRangeHistoryRepository { get { return LazyLoadPPolicyNetworkRangeHistoryRepository(); } }
        /// <summary>
        /// Lazy load the Policy.
        /// </summary>
        /// <returns>NetworkRangeHistoryType</returns>
        private IPolicyNetworkRangeHistoryRepository LazyLoadPPolicyNetworkRangeHistoryRepository()
        {
            if (this._context == null)
            {
                _context = new P2RMISNETEntities();
            }

            if (this._PolicyNetworkRangeHistoryRepository == null)
            {
                this._PolicyNetworkRangeHistoryRepository = new PolicyNetworkRangeHistoryRepository(_context);
            }
            return _PolicyNetworkRangeHistoryRepository;
        }
        #endregion
    }

    public partial class UnitOfWork
    {
        #region PolicyStatus
        /// <summary>
        /// Provides database access for the PolicyHistory repository functions.
        /// </summary>
        private IPolicyStatusRepository _PolicyStatusRepository;
        public IPolicyStatusRepository PolicyStatusRepository { get { return LazyLoadPolicyStatus(); } }
        /// <summary>
        /// Lazy load the PolicyStatus.
        /// </summary>
        /// <returns>WeekDayType</returns>
        private IPolicyStatusRepository LazyLoadPolicyStatus()
        {
            if (this._context == null)
            {
                _context = new P2RMISNETEntities();
            }

            if (this._PolicyStatusRepository == null)
            {
                this._PolicyStatusRepository = new PolicyStatusRepository(_context);
            }
            return _PolicyStatusRepository;
        }
        #endregion
    }
}
