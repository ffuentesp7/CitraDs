#pragma checksum "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b883eeb36ec9ebdc22ba04b161284e03374150cd"
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
#line 1 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore;

#line default
#line hidden
#line 2 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b883eeb36ec9ebdc22ba04b161284e03374150cd", @"/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685786d528591fe38a675b867e37c0bea3782889", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Roles\Edit.cshtml"
  
    ViewData["Title"] = "Modificac??on de roles de usuario";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 89, true);
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
            EndContext();
            BeginContext(202, 17, false);
#line 10 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Roles\Edit.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(219, 512, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <!-- general form elements -->
            <div class=""card shadow mb-4"">
                <div class=""card-header with-border"">
                    <h5 class=""m-0 font-weight-bold text-primary"">Editar informaci??n</h5>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                ");
            EndContext();
            BeginContext(731, 988, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b883eeb36ec9ebdc22ba04b161284e03374150cd5235", async() => {
                BeginContext(776, 260, true);
                WriteLiteral(@"
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">T??tulo</label>
                            <input type=""text"" class=""form-control"" id=""Title"" name=""Title""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1036, "\"", 1056, 1);
#line 29 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1044, Model.Title, 1044, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1057, 311, true);
                WriteLiteral(@" placeholder=""Ingresar nuevo t??tulo de rol"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Descripci??n</label>
                            <input type=""text"" class=""form-control"" id=""Description"" name=""Description""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1368, "\"", 1394, 1);
#line 33 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1376, Model.Description, 1376, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1395, 317, true);
                WriteLiteral(@" placeholder=""Ingresar nueva descripci??n"">
                        </div>
                    </div>
                    <!-- /.box-body -->
                    <div class=""card-footer"">
                        <button type=""submit"" class=""btn btn-success"">Guardar</button>
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
            BeginContext(1719, 1066, true);
            WriteLiteral(@"
            </div>
            <!-- /.box -->
        </div>
    </div>


    <div class=""card shadow mb-4"">
        <div class=""card-header with-border"">
            <h5 class=""m-0 font-weight-bold text-primary"">Editar permisos de usuario</h5>
        </div>
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""card-body"">
                    <h6 class=""box-title m-b-30"">Asignar permisos</h6>
                    <div class=""row"">
                        <div class=""col-lg-12 col-sm-12"">

                            <div style=""margin-left:28px; margin-top:20px;"">
                                <button type=""button"" class=""btn"">Collepsed</button>
                                <button type=""button"" class=""btn"">Expanded</button>
                                <button type=""button"" class=""btn"">Checked All</button>
                                <button type=""button"" class=""btn"">Unchek All</button>
                            </div>

                            <ul class=");
            WriteLiteral("\"mytree\">\n                                ");
            EndContext();
            BeginContext(2786, 22, false);
#line 66 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Roles\Edit.cshtml"
                           Write(Html.Raw(ViewBag.menu));

#line default
#line hidden
            EndContext();
            BeginContext(2808, 1784, true);
            WriteLiteral(@"
                            </ul>
                            <div style=""margin-left:28px"">
                                <button onclick=""Done()"" class=""btn btn-success"">Guardar</button>
                            </div>
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
          ");
            WriteLiteral(@"  case 'Expanded':
                $('.mytree ul').fadeIn();
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
            BeginContext(4593, 29, false);
#line 125 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Roles\Edit.cshtml"
             Write(Url.Action("Update", "Roles"));

#line default
#line hidden
            EndContext();
            BeginContext(4622, 43, true);
            WriteLiteral("\',\n            data: {\n                id: ");
            EndContext();
            BeginContext(4666, 8, false);
#line 127 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Roles\Edit.cshtml"
               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4674, 574, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
