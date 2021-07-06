using Proje.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business.Abstract
{
    public interface IWriterLoginService
    {
        Writer Login(string username, string password);
    }
}
