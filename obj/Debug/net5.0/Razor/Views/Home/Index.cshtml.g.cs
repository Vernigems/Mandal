#pragma checksum "C:\Users\admin1\source\repos\Mandal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc9218de9f80beb3762488d359828713a728f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc9218de9f80beb3762488d359828713a728f85", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb6e2b8b66ef7f387814add17c911f3bfe27e62", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\admin1\source\repos\Mandal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""section dashboard"">
    <div class=""row"">

        <!-- Left side columns -->
        <div class=""col-lg-12"">
            <div class=""row"">

              
                  <!-- Sales Card -->
                    <div class=""col-md-3"">
                    <div class=""card info-card sales-card"">

                        <div class=""filter"">
                            <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                                <li class=""dropdown-header text-start"">
                                    <h6>Filter</h6>
                                </li>

                                <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
       ");
            WriteLiteral(@"                     </ul>
                        </div>

                        <div class=""card-body"">
                            <h5 class=""card-title"">Current Bal</h5>

                            <div class=""d-flex align-items-center"">
                                <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                                    ₹
                                </div>
                                <div class=""ps-3"">
                                    <h6>₹ 125000</h6>
                                    <span class=""text-success small pt-1 fw-bold"">12%</span> <span class=""text-muted small pt-2 ps-1"">increase</span>

                                </div>
                            </div>
                        </div>

                    </div>
                </div><!-- End Sales Card -->

                  <!-- Grand Total Card -->
                    <div class=""col-md-3"">
                    <div class=""card ");
            WriteLiteral(@"info-card sales-card"">

                        <div class=""filter"">
                            <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                                <li class=""dropdown-header text-start"">
                                    <h6>Filter</h6>
                                </li>

                                <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                            </ul>
                        </div>

                        <div class=""card-body"">
                            <h5 class=""card-title"">Grand Total</h5>

                            <div class=""d-flex align-items-center"">
                                <div class=""card-");
            WriteLiteral(@"icon rounded-circle d-flex align-items-center justify-content-center"">
                                    ₹
                                </div>
                                <div class=""ps-3"">
                                    <h6>₹ 125000</h6>
                                    <span class=""text-success small pt-1 fw-bold"">12%</span> <span class=""text-muted small pt-2 ps-1"">increase</span>

                                </div>
                            </div>
                        </div>

                    </div>
                </div><!-- End Sales Card -->

                  <!-- Total EMI Card -->
                    <div class=""col-md-3"">
                    <div class=""card info-card sales-card"">

                        <div class=""filter"">
                            <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                   ");
            WriteLiteral(@"             <li class=""dropdown-header text-start"">
                                    <h6>Filter</h6>
                                </li>

                                <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                            </ul>
                        </div>

                        <div class=""card-body"">
                            <h5 class=""card-title"">Total EMI</h5>

                            <div class=""d-flex align-items-center"">
                                <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                                    ₹
                                </div>
                                <div class=""ps-3"">
                                    <h6>₹ 250000</h6>
                                    <span clas");
            WriteLiteral(@"s=""text-success small pt-1 fw-bold"">12%</span> <span class=""text-muted small pt-2 ps-1"">increase</span>

                                </div>
                            </div>
                        </div>

                    </div>
                </div><!-- End Sales Card -->

                  <!-- Total Credit Card -->
                    <div class=""col-md-3"">
                    <div class=""card info-card sales-card"">

                        <div class=""filter"">
                            <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                                <li class=""dropdown-header text-start"">
                                    <h6>Filter</h6>
                                </li>

                                <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                                <li><a class=""dropdown-item"" href=""");
            WriteLiteral(@"#"">This Month</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                            </ul>
                        </div>

                        <div class=""card-body"">
                            <h5 class=""card-title"">Total Credit</h5>

                            <div class=""d-flex align-items-center"">
                                <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                                    ₹
                                </div>
                                <div class=""ps-3"">
                                    <h6>₹ 125000</h6>
                                    <span class=""text-success small pt-1 fw-bold"">12%</span> <span class=""text-muted small pt-2 ps-1"">increase</span>

                                </div>
                            </div>
                        </div>

                    </div>
                </div><!-- End Sales Card -->

    ");
            WriteLiteral(@"              <!-- Total Debit Card -->
                    <div class=""col-md-3"">
                    <div class=""card info-card sales-card"">

                        <div class=""filter"">
                            <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                                <li class=""dropdown-header text-start"">
                                    <h6>Filter</h6>
                                </li>

                                <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                            </ul>
                        </div>

                        <div class=""card-body"">
                            <h5 class=""card-title"">Total Debit</h5>");
            WriteLiteral(@"

                            <div class=""d-flex align-items-center"">
                                <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                                    ₹
                                </div>
                                <div class=""ps-3"">
                                    <h6>₹ 125000</h6>
                                    <span class=""text-success small pt-1 fw-bold"">12%</span> <span class=""text-muted small pt-2 ps-1"">increase</span>

                                </div>
                            </div>
                        </div>

                    </div>
                </div><!-- End Sales Card -->

                  <!-- Member Profit Card -->
                    <div class=""col-md-3"">
                    <div class=""card info-card sales-card"">

                        <div class=""filter"">
                            <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dot");
            WriteLiteral(@"s""></i></a>
                            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                                <li class=""dropdown-header text-start"">
                                    <h6>Filter</h6>
                                </li>

                                <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                            </ul>
                        </div>

                        <div class=""card-body"">
                            <h5 class=""card-title"">Member Profit </h5>

                            <div class=""d-flex align-items-center"">
                                <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                                    ₹
                                </div>
                      ");
            WriteLiteral(@"          <div class=""ps-3"">
                                    <h6>₹ 250</h6>
                                    <span class=""text-success small pt-1 fw-bold"">12%</span> <span class=""text-muted small pt-2 ps-1"">increase</span>

                                </div>
                            </div>
                        </div>

                    </div>
                </div><!-- End Sales Card -->

            </div>
        </div><!-- End Left side columns -->
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
