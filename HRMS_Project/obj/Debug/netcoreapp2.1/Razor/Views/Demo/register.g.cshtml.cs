#pragma checksum "D:\Developer project\HRMS_Project\HRMS_Project\Views\Demo\register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e625074ad89c81fa7529aaf46f38a209c732cb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_register), @"mvc.1.0.view", @"/Views/Demo/register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Demo/register.cshtml", typeof(AspNetCore.Views_Demo_register))]
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
#line 1 "D:\Developer project\HRMS_Project\HRMS_Project\Views\_ViewImports.cshtml"
using HRMS_Project;

#line default
#line hidden
#line 2 "D:\Developer project\HRMS_Project\HRMS_Project\Views\_ViewImports.cshtml"
using HRMS_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e625074ad89c81fa7529aaf46f38a209c732cb8", @"/Views/Demo/register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90cd28ea7ae3be7cb71c23c2f3ed97e506f18060", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gradient-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Developer project\HRMS_Project\HRMS_Project\Views\Demo\register.cshtml"
  
    ViewData["Title"] = "register";

#line default
#line hidden
            BeginContext(46, 58, true);
            WriteLiteral("\r\n<h2>register</h2>\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(104, 701, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc20ad9acc994f60ba5f3fce7481186f", async() => {
                BeginContext(110, 688, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <title>SB Admin 2 - Register</title>
    <!-- Custom fonts for this template-->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"" rel=""stylesheet"">
    <!-- Custom styles for this template-->
    <link href=""css/sb-admin-2.min.css"" rel=""stylesheet"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(805, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(807, 3815, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fc9fe901d2e4cf6b72e8e9338f952ce", async() => {
                BeginContext(841, 605, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""card o-hidden border-0 shadow-lg my-5"">
            <div class=""card-body p-0"">
                <!-- Nested Row within Card Body -->
                <div class=""row"">
                    <div class=""col-lg-5 d-none d-lg-block bg-register-image""></div>
                    <div class=""col-lg-7"">
                        <div class=""p-5"">
                            <div class=""text-center"">
                                <h1 class=""h4 text-gray-900 mb-4"">Create an Account!</h1>
                            </div>
                            ");
                EndContext();
                BeginContext(1446, 2248, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76bfe01981b3478a9801bd9512c31cdb", async() => {
                    BeginContext(1465, 2222, true);
                    WriteLiteral(@"
                                <div class=""form-group row"">
                                    <div class=""col-sm-6 mb-3 mb-sm-0"">
                                        <input type=""text"" class=""form-control form-control-user"" id=""exampleFirstName"" placeholder=""First Name"">
                                    </div>
                                    <div class=""col-sm-6"">
                                        <input type=""text"" class=""form-control form-control-user"" id=""exampleLastName"" placeholder=""Last Name"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <input type=""email"" class=""form-control form-control-user"" id=""exampleInputEmail"" placeholder=""Email Address"">
                                </div>
                                <div class=""form-group row"">
                                    <div class=""col-sm-6 mb-3 mb-sm-0"">
                          ");
                    WriteLiteral(@"              <input type=""password"" class=""form-control form-control-user"" id=""exampleInputPassword"" placeholder=""Password"">
                                    </div>
                                    <div class=""col-sm-6"">
                                        <input type=""password"" class=""form-control form-control-user"" id=""exampleRepeatPassword"" placeholder=""Repeat Password"">
                                    </div>
                                </div>
                                <a href=""login.html"" class=""btn btn-primary btn-user btn-block"">
                                    Register Account
                                </a>
                                <hr>
                                <a href=""index.html"" class=""btn btn-google btn-user btn-block"">
                                    <i class=""fab fa-google fa-fw""></i> Register with Google
                                </a>
                                <a href=""index.html"" class=""btn btn-facebook btn-user btn-b");
                    WriteLiteral("lock\">\r\n                                    <i class=\"fab fa-facebook-f fa-fw\"></i> Register with Facebook\r\n                                </a>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3694, 921, true);
                WriteLiteral(@"
                            <hr>
                            <div class=""text-center"">
                                <a class=""small"" href=""forgot-password.html"">Forgot Password?</a>
                            </div>
                            <div class=""text-center"">
                                <a class=""small"" href=""login.html"">Already have an account? Login!</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Bootstrap core JavaScript-->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- Core plugin JavaScript-->
    <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>
    <!-- Custom scripts for all pages-->
    <script src=""js/sb-admin-2.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4622, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
