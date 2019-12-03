using SiparisTakip.Entittes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces
{
    public interface ICariService:IGenericService<Cari>
    {
        List<Cari> CariHesapEkstersi(int cariId);
    }
}
