﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AWSQueryExceptionUnmarshaller : BaseResponseUnmarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 11 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Response U" +
                    "nmarshaller for ");
            
            #line 14 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" operation\r\n    /// </summary>  \r\n    public class ");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("Unmarshaller : IErrorResponseUnmarshaller<");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(", XmlUnmarshallerContext>\r\n    {\r\n        /// <summary>\r\n        /// Unmarshaller" +
                    " the response from the service to the response class.\r\n        /// </summary>  \r" +
                    "\n        /// <param name=\"context\"></param>\r\n        /// <returns></returns>\r\n  " +
                    "      public ");
            
            #line 23 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@" Unmarshall(XmlUnmarshallerContext context)
        {
            return this.Unmarshall(context, new ErrorResponse());
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name=""context""></param>
        /// <param name=""errorResponse""></param>
        /// <returns></returns>
        public ");
            
            #line 34 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)\r\n       " +
                    " {\r\n            ");
            
            #line 36 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" response = new ");
            
            #line 36 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@"(errorResponse.Message, errorResponse.InnerException, 
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
");
            
            #line 49 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"

    if(this.Structure != null)
    {
        foreach (var member in this.Structure.Members)
        {
            var testExpression = GeneratorHelpers.DetermineAWSQueryTestExpression(member);

            
            #line default
            #line hidden
            this.Write("                    if (context.TestExpression(\"");
            
            #line 56 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(testExpression));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n                    {\r\n");
            
            #line 58 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"

            if (member.IsMap || member.IsList)
            {

            
            #line default
            #line hidden
            this.Write("                        var item = ");
            
            #line 62 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(".Unmarshall(context);\r\n                        response.");
            
            #line 63 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MemberAccessorFor(member.PropertyName)));
            
            #line default
            #line hidden
            this.Write(".Add(item);\r\n");
            
            #line 64 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("                        response.");
            
            #line 69 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MemberAccessorFor(member.PropertyName)));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 69 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(".Unmarshall(context);\r\n");
            
            #line 70 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"

            }

            
            #line default
            #line hidden
            this.Write("                    }\r\n");
            
            #line 74 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("                }\r\n            }\r\n            return response;\r\n        }\r\n\r\n");
            
            #line 83 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"

    this.AddStructureSingletonMethod();

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 88 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryExceptionUnmarshaller.tt"

// if the result fields have been wrapped in a subordinate structure, wire the accessor
// to use it when addressing a member
string MemberAccessorFor(string memberName)
{
	if (string.IsNullOrEmpty(WrappedResultMember))
		return memberName;

	return string.Concat(WrappedResultMember, ".", memberName);
}	

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
