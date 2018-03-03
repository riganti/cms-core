using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Riganti.CMS.BL
{
    public interface IDependencyInstaller
    {
        void Install(IServiceCollection collection);
    }
}
