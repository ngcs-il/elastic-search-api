using System.Diagnostics.CodeAnalysis;

namespace Ngcs.Data.Repository
{
	[SuppressMessage("ReSharper", "UnusedMember.Global")]
	public interface IRepository<TEntity> where TEntity : class
	{
    }
}
