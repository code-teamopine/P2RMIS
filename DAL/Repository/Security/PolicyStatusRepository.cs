namespace Sra.P2rmis.Dal.Repository.Security
{
    public interface IPolicyStatusRepository : IGenericRepository<PolicyStatu>
    {        
    }
    public class PolicyStatusRepository : GenericRepository<PolicyStatu>,IPolicyStatusRepository
    {
        public PolicyStatusRepository(P2RMISNETEntities context) : base(context) { }        
    }
}
