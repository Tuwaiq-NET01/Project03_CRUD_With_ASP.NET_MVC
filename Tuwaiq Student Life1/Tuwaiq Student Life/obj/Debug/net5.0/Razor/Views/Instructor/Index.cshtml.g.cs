#pragma checksum "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d74cf2314e6717ca5022b000dc3065ee0c950d74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_Index), @"mvc.1.0.view", @"/Views/Instructor/Index.cshtml")]
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
#line 1 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\_ViewImports.cshtml"
using Tuwaiq_Student_Life;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\_ViewImports.cshtml"
using Tuwaiq_Student_Life.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74cf2314e6717ca5022b000dc3065ee0c950d74", @"/Views/Instructor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d50ac0b9957e69b0a494d6132ae43f5ac4e006d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
  
    var Instructors = (List<InstructorModel>)ViewData["Instructors"];
    var Subjects = (List<SubjectModel>)ViewData["Subjects"];
    SubjectModel mySubject = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Our Exceptional Instructors</h1>

<div class=""div-background"">
    <table class=""table"">
        <tr>
            <th>Instructor's Name</th>
            <th>Email</th>
            <th>Subject</th>
            <th></th>
            <th></th>
        </tr>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
             foreach (var Instructor in Instructors)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
                   Write(Instructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 25 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
                                          Write(Instructor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
                   Write(Instructor.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
                      mySubject = Subjects.Find(S => S.Id == Instructor.SubjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
                   Write(mySubject.SubjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>\r\n");
            WriteLiteral("                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1483, "\"", 1527, 2);
            WriteAttributeValue("", 1490, "Instructor/Details/?id=", 1490, 23, true);
#nullable restore
#line 39 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
WriteAttributeValue("", 1513, Instructor.Id, 1513, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-info\">Details</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1639, "\"", 1703, 3);
            WriteAttributeValue("", 1646, "Session/Create/?instructor_id=", 1646, 30, true);
#nullable restore
#line 42 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
WriteAttributeValue("", 1676, Instructor.Id, 1676, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1690, "&student_id=1", 1690, 13, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-info\">Book a session</a>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project02_CRUD_EF_ASP.NET_MVC\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Instructor\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
