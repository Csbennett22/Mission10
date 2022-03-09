#pragma checksum "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47c2c662d85980f985a9c001d0f11f5bfc4bb58f"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\_Imports.razor"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<thead>\r\n        <tr class=\"table-dark\">\r\n            <th>Book ID</th>\r\n            <th>Title</th>\r\n            <th>Author</th>\r\n            <th colspan=\"3\">Actions</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 16 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
         if (BookData?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
             foreach (Book b in BookData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddAttribute(10, "class", "text-center");
            __builder.AddContent(11, 
#nullable restore
#line 21 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
                                             b.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
                         b.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 23 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
                         b.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(23, "href", 
#nullable restore
#line 26 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
                                                                    GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(25, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 29 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
                                                                       GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(34, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
                                                                          x => RemoveBook(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 35 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.AddMarkupContent(47, "<tr>\r\n                <td colspan=\"5\" class=\"text-center\">No Projects</td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddAttribute(53, "href", "/admin/books/create");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(55, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\chris\Documents\IS413\Mission10\BookStore\BookStore\Pages\Admin\Books.razor"
       
    public IBookstoreRepository repo => Service;

    public IEnumerable<Book> BookData { get; set; }
    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";
    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

    public async Task RemoveBook(Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
