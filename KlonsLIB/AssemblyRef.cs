using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib7
{
    internal static class MyFXAssembly
    {
        internal const string Version = "4.0.0.0";
    }

    internal static class MyAssemblyRef
    {
        internal const string MicrosoftPublicKey = "b03f5f7f11d50a3a";
        internal const string SystemDesign = "System.Design, Version=" + MyFXAssembly.Version + ", Culture=neutral, PublicKeyToken=" + MicrosoftPublicKey;
        internal const string SystemDrawingDesign = "System.Drawing.Design, Version=" + MyFXAssembly.Version + ", Culture=neutral, PublicKeyToken=" + MicrosoftPublicKey;
        internal const string SystemDrawing = "System.Drawing, Version=" + MyFXAssembly.Version + ", Culture=neutral, PublicKeyToken=" + MicrosoftPublicKey;
    }
}
