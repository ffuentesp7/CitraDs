#pragma checksum "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76262a333a8a1574d669d4f2924526783652e3d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Edit), @"mvc.1.0.view", @"/Views/Roles/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Edit.cshtml", typeof(AspNetCore.Views_Roles_Edit))]
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
#line 1 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore;

#line default
#line hidden
#line 2 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76262a333a8a1574d669d4f2924526783652e3d5", @"/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685786d528591fe38a675b867e37c0bea3782889", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CitraDataStore.Models.Roles>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "/Roles/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Roles\Edit.cshtml"
  
    ViewData["Title"] = "Edit Role & Permissions";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 89, true);
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
            EndContext();
            BeginContext(228, 17, false);
#line 11 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Roles\Edit.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(245, 483, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <!-- general form elements -->
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Edit Admin Info</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                ");
            EndContext();
            BeginContext(728, 958, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76262a333a8a1574d669d4f2924526783652e3d55213", async() => {
                BeginContext(773, 258, true);
                WriteLiteral(@"
                    <div class=""box-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Title</label>
                            <input type=""text"" class=""form-control"" id=""Title"" name=""Title""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1031, "\"", 1051, 1);
#line 30 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1039, Model.Title, 1039, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1052, 294, true);
                WriteLiteral(@" placeholder=""Enter Title"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Description</label>
                            <input type=""text"" class=""form-control"" id=""Description"" name=""Description""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1346, "\"", 1372, 1);
#line 34 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1354, Model.Description, 1354, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1373, 306, true);
                WriteLiteral(@" placeholder=""Enter Description"">
                        </div>
                    </div>
                    <!-- /.box-body -->
                    <div class=""box-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1686, 819, true);
            WriteLiteral(@"
            </div>
            <!-- /.box -->
        </div>
    </div>

    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""white-box"">
                <h3 class=""box-title m-b-30"">Assign Roles</h3>
                <div class=""row"">
                    <div class=""col-lg-12 col-sm-12"">

                        <div style=""margin-left:28px; margin-top:20px;"">
                            <button type=""button"" class=""btn"">Collepsed</button>
                            <button type=""button"" class=""btn"">Expanded</button>
                            <button type=""button"" class=""btn"">Checked All</button>
                            <button type=""button"" class=""btn"">Unchek All</button>
                        </div>

                        <ul class=""mytree"">
                            ");
            EndContext();
            BeginContext(2506, 22, false);
#line 62 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Roles\Edit.cshtml"
                       Write(Html.Raw(ViewBag.menu));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 1732, true);
            WriteLiteral(@"
                        </ul>
                        <div style=""margin-left:28px"">
                            <button onclick=""Done()"" class=""btn btn-primary"">Update</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<script>

    $(document).on('click', '.mytree label', function (e) {
        $(this).next('ul').fadeToggle();
        e.stopPropagation();
    });

    $(document).on('change', '.mytree input[type=checkbox]', function (e) {
        $(this).siblings('ul').find(""input[type='checkbox']"").prop('checked', this.checked);
        $(this).parentsUntil('.mytree').children(""input[type='checkbox']"").prop('checked', this.checked);
        e.stopPropagation();
    });

    $(document).on('click', 'button', function (e) {
        switch ($(this).text()) {
            case 'Collepsed':
                $('.mytree ul').fadeOut();
                break;
            case 'Expanded':
                $('.mytree ul').f");
            WriteLiteral(@"adeIn();
                break;
            case 'Checked All':
                $("".mytree input[type='checkbox']"").prop('checked', true);
                break;
            case 'Unchek All':
                $("".mytree input[type='checkbox']"").prop('checked', false);
                break;
            default:
        }
    });


    function Done() {

        var checkedValues = $('input:checkbox:checked').map(function () {
            return this.id;
        }).get();

        $body = $(""body"");
        $(document).on({
            ajaxStart: function () { $body.addClass(""loading""); },
            ajaxStop: function () { }
        });

        $.ajax({
            type: ""POST"",
            url: '");
            EndContext();
            BeginContext(4261, 29, false);
#line 120 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Roles\Edit.cshtml"
             Write(Url.Action("Update", "Roles"));

#line default
#line hidden
            EndContext();
            BeginContext(4290, 43, true);
            WriteLiteral("\',\n            data: {\n                id: ");
            EndContext();
            BeginContext(4334, 8, false);
#line 122 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Roles\Edit.cshtml"
               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4342, 574, true);
            WriteLiteral(@",
                roles: checkedValues
            },
            error: function (result) {
                alert(""error"");
            },
            success: function (result) {
                $body.removeClass(""loading"");
                if (result.status == true) {

                    alert(""Successfully Updated Role!"")
                    var baseUrl = ""/Roles"";
                    window.location.href = baseUrl;
                }
                else {
                    alert(""Failed:""+result);
                }
            }
        });
    }

</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CitraDataStore.Models.Roles> Html { get; private set; }
    }
}
#pragma warning restore 1591
