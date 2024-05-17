using System;
using System.Collections.Generic;

namespace _4_4.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            News =
            [
                new ("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus ipsum purus, tempor vitae vehicula vitae,", DateTime.Now),
                new ("Vestibulum sagittis justo velit, a accumsan est auctor at. Aliquam erat volutpat. Pellentesque porttitor dolor enim, eget commodo nibh.", DateTime.Today)

                ];
            Blogs = [
                new ("Title", "amet, consectetur adipiscing elit. Vivamus ipsum purus, tempor vitae vehicula vitae, ornare sit amet lacus. Vivamus dolor mauris,",["tag 1, tag 2"]),
                new ("Title 2", "a accumsan est auctor at. Aliquam erat volutpat. Pellentesque porttitor dolor enim, eget commodo ", ["tag 3, tag 4"])
                ];
        }
        public List<News> News { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
