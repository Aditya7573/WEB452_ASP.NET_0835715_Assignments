using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Aditya_Tie.Models
{
    public class TieMaterialViewModel
    {
        public List<Tie> Ties { get; set; }  // Represents a list of ties
        public SelectList Materials { get; set; }  // Represents a list of materials for ties
        public string SelectedMaterial { get; set; }  // Represents the selected material
        public string SearchString { get; set; }  // Represents a search string for filtering ties
    }
}
