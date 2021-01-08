﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AssemblyInfo : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle(""");
            
            #line 12 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.AssemblyTitle));
            
            #line default
            #line hidden
            this.Write("\")]\r\n#if BCL35\r\n[assembly: AssemblyDescription(\"The Amazon Web Services SDK for ." +
                    "NET (3.5) - ");
            
            #line 14 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.ServiceFullName));
            
            #line default
            #line hidden
            this.Write(". ");
            
            #line 14 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.AssemblyDescription));
            
            #line default
            #line hidden
            this.Write("\")]\r\n#elif BCL45\r\n[assembly: AssemblyDescription(\"The Amazon Web Services SDK for" +
                    " .NET (4.5) - ");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.ServiceFullName));
            
            #line default
            #line hidden
            this.Write(". ");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.AssemblyDescription));
            
            #line default
            #line hidden
            this.Write("\")]\r\n#elif NETSTANDARD13\r\n[assembly: AssemblyDescription(\"The Amazon Web Services" +
                    " SDK for .NET (NetStandard 1.3) - ");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.ServiceFullName));
            
            #line default
            #line hidden
            this.Write(". ");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.AssemblyDescription));
            
            #line default
            #line hidden
            this.Write("\")]\r\n#elif NETSTANDARD20\r\n[assembly: AssemblyDescription(\"The Amazon Web Services" +
                    " SDK for .NET (NetStandard 2.0) - ");
            
            #line 20 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.ServiceFullName));
            
            #line default
            #line hidden
            this.Write(". ");
            
            #line 20 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.AssemblyDescription));
            
            #line default
            #line hidden
            this.Write("\")]\r\n#elif NETCOREAPP3_1\r\n[assembly: AssemblyDescription(\"The Amazon Web Services" +
                    " SDK for .NET (.NET Core 3.1) - ");
            
            #line 22 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.ServiceFullName));
            
            #line default
            #line hidden
            this.Write(". ");
            
            #line 22 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.AssemblyDescription));
            
            #line default
            #line hidden
            this.Write(@""")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif

[assembly: AssemblyConfiguration("""")]
[assembly: AssemblyProduct(""Amazon Web Services SDK for .NET"")]
[assembly: AssemblyCompany(""Amazon.com, Inc"")]
[assembly: AssemblyCopyright(""Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved."")]
[assembly: AssemblyTrademark("""")]
[assembly: AssemblyCulture("""")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion(""1.0.*"")]
[assembly: AssemblyVersion(""");
            
            #line 49 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceVersion));
            
            #line default
            #line hidden
            this.Write("\")]\r\n[assembly: AssemblyFileVersion(\"");
            
            #line 50 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\AssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceFileVersion));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\r\n[assembly: System.CLSCompliant(true)]\r\n\r\n#if BCL\r\n[assembly: System.Securi" +
                    "ty.AllowPartiallyTrustedCallers]\r\n#endif");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
