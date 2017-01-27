using System;
using System.Threading.Tasks;
using Octopus.Client.Model;

namespace Octopus.Client.Repositories.Async
{
    public interface ICertificateRepository : IGet<CertificateResource>, IFindByName<CertificateResource>, ICreate<CertificateResource>, IModify<CertificateResource>, IDelete<CertificateResource>
    {
    }

    class CertificateRepository : BasicRepository<CertificateResource>, ICertificateRepository
    {
        public CertificateRepository(IOctopusAsyncClient client)
            : base(client, "Certificates")
        {
        }
    }
}
