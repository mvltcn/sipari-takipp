using SiparisTakip.Entittes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces
{
    public interface IStokService:IGenericService<Stok>
    {
        List<Stok> StokListele(int stokGrubuId);
    }
}
