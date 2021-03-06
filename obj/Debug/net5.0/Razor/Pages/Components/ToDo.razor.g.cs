#pragma checksum "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f9fc28a4590341cf7befbd011c9059f9563940f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUG.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using BlazorUG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using BlazorUG.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Website Works\Blazor\BlazorUG\_Imports.razor"
using BlazorUG.Data.Modals;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 3 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
     headerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
                 task

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "form-inline");
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
                                                          addTask

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "class", "form-control mx-2");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
                        task.taskName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.taskName = __value, task.taskName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.AddMarkupContent(14, "<button class=\"btn btn-outline-success mx-2\">Add Task</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "progress-bar my-2 mx-2");
            __builder.AddAttribute(18, "role", "progressbar");
            __builder.AddAttribute(19, "style", "width:" + (
#nullable restore
#line 10 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
                                                                      percentageCompleted

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(20, "area-valuemax", "100");
            __builder.AddAttribute(21, "area-valuemin", "0");
            __builder.AddContent(22, 
#nullable restore
#line 11 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
      percentageCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "%\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "ul");
            __builder.AddAttribute(26, "class", "list-group my-2");
#nullable restore
#line 15 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
     foreach(var taskItem in taskList){
        if(taskItem.isCompleted){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "list-group-item list-group-item-success mx-1");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
                                                                                  (() => taskItem.isCompleted = !taskItem.isCompleted)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(30, "del");
            __builder.AddContent(31, 
#nullable restore
#line 17 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
                                                                                                                                              taskItem.taskName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
        }else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "list-group-item list-group-item-secondary mx-1");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
                                                                                 (() => taskItem.isCompleted = !taskItem.isCompleted)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, 
#nullable restore
#line 19 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
                                                                                                                                        taskItem.taskName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "F:\Website Works\Blazor\BlazorUG\Pages\Components\ToDo.razor"
      
    protected List<TaskList> taskList = new List<TaskList>();

    protected TaskList task = new TaskList();

    private void addTask(){
        taskList.Add(task);
        task = new TaskList();
    }

    protected override void OnInitialized(){
        if(headerName == ""){
            headerName = "To Do List";
        }
    }

    [Parameter]
    public string headerName {get; set;}

    public int percentageCompleted {
        get{
            return taskList.Count > 0 ? (taskList.Count(x => x.isCompleted)*100/taskList.Count) : 0; 
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
