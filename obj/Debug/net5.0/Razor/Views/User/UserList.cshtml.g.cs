#pragma checksum "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133ae91cfa7ee4c928788babd2ee82f9b8251238"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserList), @"mvc.1.0.view", @"/Views/User/UserList.cshtml")]
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
#nullable restore
#line 1 "C:\Users\admin1\source\repos\Mandal\Views\_ViewImports.cshtml"
using Mandal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin1\source\repos\Mandal\Views\_ViewImports.cshtml"
using Mandal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133ae91cfa7ee4c928788babd2ee82f9b8251238", @"/Views/User/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb6e2b8b66ef7f387814add17c911f3bfe27e62", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserDetailModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Recent Sales -->
<div class=""col-12"">
    <div class=""card recent-sales overflow-auto"">

        <div class=""card-body"">

            <div class=""row"">
                <div class=""col-sm-5"">
                    <h5 class=""card-title"">User List</h5>
                </div>
                <div class=""col-sm-7 mt-4"">
                    <div style=""float:right"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133ae91cfa7ee4c928788babd2ee82f9b82512384576", async() => {
                WriteLiteral("<i class=\"bi bi-plus-circle-fill\"></i> Add Member");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <table class=""table table-borderless datatable"">
                <thead>
                    <tr>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">EMI</th>
                        <th scope=""col"">Debit</th>
                        <th scope=""col"">Credit</th>
                        <th scope=""col"">Last EMI</th>
                        <th scope=""col"">Int</th>
                        <th scope=""col"">NextPay</th>
                        <th scope=""col"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 33 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                      
                        if (Model != null)
                        {


                            foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=d-none>\r\n                                        ");
#nullable restore
#line 42 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                                   Write(item.MemberId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133ae91cfa7ee4c928788babd2ee82f9b82512387300", async() => {
#nullable restore
#line 44 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                                                                                                                                          Write(item.NickName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 1648, "~/account/AccountDetail?NickName=", 1648, 33, true);
#nullable restore
#line 44 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
AddHtmlAttributeValue("", 1681, item.NickName, 1681, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1695, "&MemberId=", 1695, 10, true);
#nullable restore
#line 44 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
AddHtmlAttributeValue("", 1705, item.MemberId, 1705, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 45 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                                   Write(item.TotalEMI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 46 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                                   Write(item.TotalDebit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                                   Write(item.TotalCredit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                                   Write(item.LastMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                                   Write(item.Intrest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                                   Write(item.NextPay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a href=\"#\" class=\"text-primary\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2251, "\'", 2301, 5);
            WriteAttributeValue("", 2261, "AddEmi(", 2261, 7, true);
#nullable restore
#line 52 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
WriteAttributeValue("", 2268, item.MemberId, 2268, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2282, ",\"", 2282, 2, true);
#nullable restore
#line 52 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
WriteAttributeValue(" ", 2284, item.NickName, 2285, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2299, "\")", 2299, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-plus-circle-fill\"> </i> Emi</a> &nbsp;\r\n                                        <a href=\"/user\"><i class=\"bi bi-pencil-square\"></i></a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <td colspan=""5"">
                                    <p class=""text-center"">
                                        No Record Available
                                    </p>
                                </td>
                            </tr>
");
#nullable restore
#line 67 "C:\Users\admin1\source\repos\Mandal\Views\User\UserList.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div><!-- End Recent Sales -->
<!-- Script Section -->
<script>
    function AddEmi(id, NickName) {
        $(""#AddEmi"").modal('show');
        $(""#NickName"").val(NickName)
        $(""#MemberId"").val(id)
    }

</script>
<!-- Script Section -->
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserDetailModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
