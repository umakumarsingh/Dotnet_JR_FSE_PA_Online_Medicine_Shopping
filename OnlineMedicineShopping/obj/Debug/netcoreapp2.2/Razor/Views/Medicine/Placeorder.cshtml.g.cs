#pragma checksum "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a358e433292f9a6222c60888e2a16570eca2b229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicine_Placeorder), @"mvc.1.0.view", @"/Views/Medicine/Placeorder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Medicine/Placeorder.cshtml", typeof(AspNetCore.Views_Medicine_Placeorder))]
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
#line 1 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\_ViewImports.cshtml"
using OnlineMedicineShopping;

#line default
#line hidden
#line 2 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\_ViewImports.cshtml"
using OnlineMedicineShopping.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a358e433292f9a6222c60888e2a16570eca2b229", @"/Views/Medicine/Placeorder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8ea490bea9bf6cc189a7368c6b4f0c2990b8945", @"/Views/_ViewImports.cshtml")]
    public class Views_Medicine_Placeorder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMedicineShopping.Entities.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
  
    ViewData["Title"] = "Placeorder";

#line default
#line hidden
            BeginContext(102, 183, true);
            WriteLiteral("\r\n<div class=\"card\" style=\"width:100%; margin:10px;\">\r\n    <div class=\"card-header bg-success text-white\">\r\n        <h5>Place Order now</h5>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
            EndContext();
#line 11 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(344, 23, false);
#line 13 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(382, 28, false);
#line 14 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(412, 141, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(554, 26, false);
#line 18 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(580, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(607, 61, false);
#line 19 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(668, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(694, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358e433292f9a6222c60888e2a16570eca2b2296185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 20 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(753, 164, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(918, 27, false);
#line 25 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(945, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(972, 62, false);
#line 26 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1060, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358e433292f9a6222c60888e2a16570eca2b2298997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 27 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1120, 215, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1336, 34, false);
#line 34 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.LabelFor(m => m.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1397, 69, false);
#line 35 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.TextBoxFor(m => m.MobileNumber, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1492, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358e433292f9a6222c60888e2a16570eca2b22911885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 36 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MobileNumber);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1559, 164, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1724, 29, false);
#line 41 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.LabelFor(m => m.PinCode));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1780, 64, false);
#line 42 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.TextBoxFor(m => m.PinCode, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1870, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358e433292f9a6222c60888e2a16570eca2b22914714", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 43 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PinCode);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1932, 215, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(2148, 43, false);
#line 50 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.LabelFor(m => m.HouseNo_Building_Name));

#line default
#line hidden
            EndContext();
            BeginContext(2191, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2218, 78, false);
#line 51 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.TextBoxFor(m => m.HouseNo_Building_Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2296, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2322, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358e433292f9a6222c60888e2a16570eca2b22917623", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 52 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HouseNo_Building_Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2398, 164, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(2563, 31, false);
#line 57 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.LabelFor(m => m.Road_area));

#line default
#line hidden
            EndContext();
            BeginContext(2594, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2621, 66, false);
#line 58 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.TextBoxFor(m => m.Road_area, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2687, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2713, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358e433292f9a6222c60888e2a16570eca2b22920465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 59 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Road_area);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2777, 215, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(2993, 26, false);
#line 66 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.LabelFor(m => m.City));

#line default
#line hidden
            EndContext();
            BeginContext(3019, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3046, 61, false);
#line 67 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.TextBoxFor(m => m.City, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3107, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3133, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358e433292f9a6222c60888e2a16570eca2b22923342", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 68 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.City);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3192, 164, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(3357, 27, false);
#line 73 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.LabelFor(m => m.State));

#line default
#line hidden
            EndContext();
            BeginContext(3384, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3411, 62, false);
#line 74 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
                   Write(Html.TextBoxFor(m => m.State, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3473, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3499, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358e433292f9a6222c60888e2a16570eca2b22926159", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 75 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.State);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3559, 254, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group text-center\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Place Order</button>\r\n                <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3813, "\"", 3885, 4);
            WriteAttributeValue("", 3823, "location.href=\'", 3823, 15, true);
#line 81 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
WriteAttributeValue("", 3838, Url.Action("Index", "Medicine"), 3838, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 3870, "\';return", 3870, 8, true);
            WriteAttributeValue(" ", 3878, "false;", 3879, 7, true);
            EndWriteAttribute();
            BeginContext(3886, 47, true);
            WriteLiteral(">Back To Product</button>\r\n            </div>\r\n");
            EndContext();
#line 83 "C:\Users\KUMARUMA\Documents\GitHub\Dotnet_JR_FSE_PA_Online_Medicine_Shopping\OnlineMedicineShopping\Views\Medicine\Placeorder.cshtml"
        }

#line default
#line hidden
            BeginContext(3944, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMedicineShopping.Entities.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
