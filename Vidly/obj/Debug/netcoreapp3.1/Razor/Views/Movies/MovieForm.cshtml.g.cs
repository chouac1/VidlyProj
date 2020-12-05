#pragma checksum "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b67a6214d76f09e6c0decf97f774b5680e9a58a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_MovieForm), @"mvc.1.0.view", @"/Views/Movies/MovieForm.cshtml")]
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
#line 1 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67a6214d76f09e6c0decf97f774b5680e9a58a8", @"/Views/Movies/MovieForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_MovieForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.ViewModels.MovieFormModelWithGenre>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>New Movie</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
 using (Html.BeginForm("Save", "Movies"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 8 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 9 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.DropDownListFor(m => m.Movie.GenreId, new SelectList(Model.Genres, "Id", "TypeOfGenre"), "Select Genre", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.DateAdded, "{0:d MMM yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 23 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.ReleaseDate, "{0:d MMM yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 28 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.NumberInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.NumberInStock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"
Write(Html.HiddenFor(m => m.Movie.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 34 "C:\Users\Work and School\Desktop\DevCode\C#\Projects\Vidly\Vidly\Views\Movies\MovieForm.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.ViewModels.MovieFormModelWithGenre> Html { get; private set; }
    }
}
#pragma warning restore 1591
