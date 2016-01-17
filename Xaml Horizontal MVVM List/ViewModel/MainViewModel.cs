using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xaml_Horizontal_MVVM_List.Model;

namespace Xaml_Horizontal_MVVM_List.ViewModel
{
    public class MainViewModel
    {
        public List<Category> cat { get; set; }
        public MainViewModel() {

            cat = new List<Category>{

                new Category{ name="Element 1", desc="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec luctus purus lorem,", color= "#3F51B5"},
                new Category{ name="Element 2", desc="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec luctus purus lorem," , color= "#2196F3"},
                new Category{ name="Element 3", desc="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec luctus purus lorem,", color= "#03A9F4"},
                new Category{ name="Element 4", desc="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec luctus purus lorem,", color= "#00BCD4"}

                                     };
        }
    }
}
