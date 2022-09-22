using System.Collections.Generic;
using task1_asp.Entities;

namespace task1_asp.Models
{
    public class MealsViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<Burger> Burgers { get; set; }
        public List<Sandwich> Sandwiches { get; set; }
    }
}