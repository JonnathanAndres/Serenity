﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serenity.CodeGenerator.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EntityCss : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden
 public dynamic Model { get; set; } 
        public override void Execute()
        {


WriteLiteral("\r\n");


WriteLiteral("\r\n\r\n.s-");


Write(Model.ClassName);

WriteLiteral("Dialog {\r\n    > .size { .widthAndMin(650px); }\r\n    .dialog-styles(");


WriteLiteral("@h: auto, ");


WriteLiteral("@l: 150px, ");


WriteLiteral("@e: 400px);\r\n    .s-PropertyGrid .categories { height: 260px; }\r\n}");


        }
    }
}
#pragma warning restore 1591
