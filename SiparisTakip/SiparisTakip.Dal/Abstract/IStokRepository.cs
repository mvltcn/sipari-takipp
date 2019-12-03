using SiparisTakip.Entittes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract
{
    public interface IStokRepository : IGenericRepository<Stok>
    {
        List<Stok> StokListele(int stokGrubuId);
    }
}
