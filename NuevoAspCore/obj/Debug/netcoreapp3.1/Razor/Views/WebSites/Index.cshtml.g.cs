#pragma checksum "C:\Users\Hakan\source\repos\NuevoAspCore\NuevoAspCore\Views\WebSites\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a28ea44365822a19a1ea16235bf9b65944341ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebSites_Index), @"mvc.1.0.view", @"/Views/WebSites/Index.cshtml")]
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
#line 1 "C:\Users\Hakan\source\repos\NuevoAspCore\NuevoAspCore\Views\_ViewImports.cshtml"
using NuevoAspCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hakan\source\repos\NuevoAspCore\NuevoAspCore\Views\_ViewImports.cshtml"
using NuevoAspCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a28ea44365822a19a1ea16235bf9b65944341ad", @"/Views/WebSites/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b10dd43ecaab2653c50952f4bb58d1173a70575", @"/Views/_ViewImports.cshtml")]
    public class Views_WebSites_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NuevoAspCore.Models.DbModels.WebSites>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hakan\source\repos\NuevoAspCore\NuevoAspCore\Views\WebSites\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"" id=""app"">
    <div class=""row"">
        <div class=""col-md-12 my-2"">
            <div class=""row"">
                <div class=""col-md-8"">
                    <div class=""form-group"">
                        <div class=""input-group flex-nowrap"">
                            <input type=""text"" class=""form-control"" v-model=""search"" placeholder=""Search title.."" aria-label=""Search"" aria-describedby=""addon-wrapping"">
                        </div>
                    </div>
                </div>
                <div class=""col-md-2"">
                    <div class=""form-group"">
                        <button type=""button"" class=""btn btn-primary"" v-on:click=""formClear"" data-toggle=""modal"" data-target=""#exampleModal"">
                            <i class=""fas fa-plus""></i> Ekle
                        </button>
                    </div>
                </div>
                <div class=""col-md-2"">
                    <div class=""form-group"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a28ea44365822a19a1ea16235bf9b65944341ad6553", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-sign-out-alt\"></i> Çıkış\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        </div>
        <div class=""col-md-12"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""row"">

                        <table class=""table table-hover"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th scope=""col"">Site Name</th>
                                    <th scope=""col"">Last Control Time</th>
                                    <th scope=""col"">Last Status</th>
                                    <th scope=""col"">#</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr v-for=""WebSite in filteredList"">
                                    <td><a :href=""'/WebSites/Details/' + WebSite.webSitesId""> {{ WebSite.siteName }} </a></td>
                                    <td>{{ WebSit");
            WriteLiteral(@"e.lastSuccessCheck }}</td>
                                    <td>


                                        <div v-if=""WebSite.errorStatus == 2"">
                                            <span class=""badge badge-success"">Success</span>
                                        </div>
                                        <div v-else>
                                            <a href=""#"" class=""badge badge-danger"">Error</a>
                                        </div>
                                    </td>
                                    <th>
                                        <button data-toggle=""modal"" data-target=""#exampleModal"" class=""btn btn-primary"" v-on:click=""editItem(WebSite.webSitesId)""> Düzenle <i class=""far fa-edit""></i></button>
                                        <button class=""btn btn-danger"" v-on:click=""deleteItem(WebSite.webSitesId)""> Sil <i class=""far fa-trash-alt""></i></button>
                                    </th>
                                <");
            WriteLiteral(@"/tr>
                            </tbody>
                        </table>


                    </div>
                </div>
            </div>
        </div>
    </div>







    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel""> {{ postSite.siteName }} </h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a28ea44365822a19a1ea16235bf9b65944341ad11167", async() => {
                WriteLiteral(@"
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <label class=""control-label"">Site Name</label>
                            <input v-model=""postSite.siteName"" class=""form-control"" />
                            <span class=""text-danger""></span>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label"">Site Url</label>
                            <input v-model=""postSite.siteUrl"" class=""form-control"" pattern=""https://.*"" />
                            <span class=""text-danger""></span>
                        </div>
                        <div class=""form-group"">
                            <label for=""formControlRange"">Site Check Delay ( {{ postSite.sitesCheckDelay /  1000 }} s )</label>
                            <input type=""range"" class=""form-control-range"" v-model=""postSite.sitesCheckDelay"" step=""100000"" min=""100000"" max=""21474000"">
      ");
                WriteLiteral(@"                  </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" class=""btn btn-success"" href=""#"" v-on:click=""formSubmit"" data-dismiss=""modal"">Save</button>
                        <button type=""button"" class=""btn btn-secondary"" v-on:click=""formClear"" data-dismiss=""modal"">Kapat</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a28ea44365822a19a1ea16235bf9b65944341ad14001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/axios/0.19.2/axios.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@9""></script>




<script>


    new Vue({
        el: '#app',
        data() {
            return {
                search: '',
                WebSites: [],
                postSite: {
                    userId: 0,
                    sitesCheckDelay: 100000
                },
                editId: null
            }
        },
        methods: {
            servisistegi() {
                axios
                    .get('http://localhost:51728/api/WebSitesApi')
                    .then(response => (this.WebSites = response.data))
            },
            pollData() {
                this.polling = setInterval(() => {
                    this.servisistegi()
                }, 100000)
            },
            formSubmit: function (e) {
                e.preventDefault();
                this.postSite.sitesCheckDelay = parseFloat");
            WriteLiteral(@"(this.postSite.sitesCheckDelay);
                this.postSite.lastSuccessCheckDate = null;
                this.postSite.usersNavigation = null;
                this.postSite.webSiteError = null;


                if (this.postSite.webSitesId == undefined) {
                    axios.post('http://localhost:51728/api/WebSitesApi', this.postSite)
                        .then(function (response) {
                        })
                        .catch(function (error) {
                        });
                } else {
                    axios.put('http://localhost:51728/api/WebSitesApi/' + this.postSite.webSitesId, this.postSite)
                        .then(function (response) {
                        })
                        .catch(function (error) {
                        });
                }

                this.postSite = null;

                this.postSite = {
                    userId: 0,
                    sitesCheckDelay: 100000
                }
           ");
            WriteLiteral(@"     this.servisistegi();


                Swal.fire({
                    position: 'top-end',
                    icon: 'success',
                    title: 'Your work has been saved',
                    showConfirmButton: false,
                    timer: 1500
                })

            },
            editItem(selectId) {
                console.log(selectId);
                axios
                    .get('http://localhost:51728/api/WebSitesApi/' + selectId)
                    .then(response => (this.postSite = response.data));

            },
            formClear() {
                this.postSite = null;

                this.postSite = {
                    userId: 0,
                    sitesCheckDelay: 100000
                }
            },
            deleteItem(selectId) {
                Swal.fire({
                    title: 'Are you sure?',
                    text: ""You won't be able to revert this!"",
                    icon: 'warning',
               ");
            WriteLiteral(@"     showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes, delete it!'
                }).then((result) => {
                    if (result.value) {
                        axios.delete('http://localhost:51728/api/WebSitesApi/' + selectId).then();
                        this.servisistegi();

                       
                        Swal.fire(
                            'Deleted!',
                            'Your info has been deleted.',
                            'success'
                        )
                    }
                })
            }
        }
        ,
        mounted() {
            this.servisistegi()
            this.pollData()
        },
        computed: {
            filteredList() {
                return this.WebSites.filter(web => {
                    return web.siteName.toLowerCase().includes(this.search.toLowerCase())
         ");
            WriteLiteral("       })\r\n            }\r\n        }\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NuevoAspCore.Models.DbModels.WebSites> Html { get; private set; }
    }
}
#pragma warning restore 1591