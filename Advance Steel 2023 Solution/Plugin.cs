using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AdvanceSteel.Runtime;

namespace HelloWorld
{
    public sealed class Plugin : IExtensionApplication

    {
        void IExtensionApplication.Initialize()
        {
        }
        void IExtensionApplication.Terminate()
        {
        }
    }
}