#pragma checksum "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/Home/Wall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba0b046a12ee6125ac60fac56f2988e5c1aab11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wall), @"mvc.1.0.view", @"/Views/Home/Wall.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Wall.cshtml", typeof(AspNetCore.Views_Home_Wall))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/_ViewImports.cshtml"
using Wall_Assign;

#line default
#line hidden
#line 2 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/_ViewImports.cshtml"
using Wall_Assign.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba0b046a12ee6125ac60fac56f2988e5c1aab11", @"/Views/Home/Wall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a18ac6b5809c7998ba3fbef45da57dc98c02ac9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wall : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_WallPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 94, true);
            WriteLiteral("\n<a href=\"/\">Home</a>\n\n<a href=\"logout\">Log Out</a>\n<h2>Welcome to the Cool Kids Wall!</h2>\n\n\n");
            EndContext();
            BeginContext(115, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ba0b046a12ee6125ac60fac56f2988e5c1aab113862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 9 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/Home/Wall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new Message(){};

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(169, 12, true);
            WriteLiteral("</partial>\n\n");
            EndContext();
#line 11 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/Home/Wall.cshtml"
 foreach(var m in Model)
{

#line default
#line hidden
            BeginContext(208, 8, true);
            WriteLiteral("    <h5>");
            EndContext();
            BeginContext(217, 19, false);
#line 13 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/Home/Wall.cshtml"
   Write(m.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(236, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(238, 11, false);
#line 13 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/Home/Wall.cshtml"
                        Write(m.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(249, 13, true);
            WriteLiteral("</h5>\n    <p>");
            EndContext();
            BeginContext(263, 12, false);
#line 14 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/Home/Wall.cshtml"
  Write(m.MesContent);

#line default
#line hidden
            EndContext();
            BeginContext(275, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
            BeginContext(285, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(289, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ba0b046a12ee6125ac60fac56f2988e5c1aab116904", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 16 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/Home/Wall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new Comment(){MessageId = @m.MessageId};

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(367, 11, true);
            WriteLiteral("</partial>\n");
            EndContext();
#line 17 "/Users/kelseymiller/Desktop/Kelseys_Coding/C_Sharp_Stack/Wall_Assign/Views/Home/Wall.cshtml"

}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591