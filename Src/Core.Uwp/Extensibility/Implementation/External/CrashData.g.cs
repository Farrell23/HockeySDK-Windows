
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 3.02
//   File : CrashData_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.HockeyApp.Extensibility.Implementation.External
{
    using System.Collections.Generic;

    
    [System.CodeDom.Compiler.GeneratedCode("gbc", "3.02")]
    internal partial class CrashData
    {
        
        public int ver { get; set; }

        
        public CrashDataHeaders headers { get; set; }
        

        public IList<CrashDataThread> threads { get; set; } 


        public IList<CrashDataBinary> binaries { get; set; } 

        public CrashData()
            : this("AI.CrashData", "CrashData")
        {}

        protected CrashData(string fullName, string name)
        {
            ver = 2;
            headers = new CrashDataHeaders();
            threads = new List<CrashDataThread>();
            binaries = new List<CrashDataBinary>();
        }
    }
} // AI










