using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Client.Pages
{
    public partial class Error
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public void Accion()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
