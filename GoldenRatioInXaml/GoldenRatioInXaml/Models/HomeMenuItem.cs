using System;
using System.Collections.Generic;
using System.Text;

namespace GoldenRatioInXaml.Models
{
    public enum MenuItemType
    {
        GoldenRatio2,
        GoldenRatio4,
        GoldenRatio6,
        GoldenRatio9
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
