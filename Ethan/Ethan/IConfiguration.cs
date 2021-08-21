using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace Ethan
{
    public interface IConfiguration
    {
        string directorio { get; }

        ISQLitePlatform plataforma { get; }
    }
}
