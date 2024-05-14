using ReactiveUI;
using System.Diagnostics.Metrics;

namespace _4_4.ViewModels
{
    public class Blog
    {
        public string Text { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public string Imagepath { get; set; }

        public Blog(string title, string text, string[] tags, string image)
        {
            Title = title;
            Text = text;
            Tags = tags;
            Imagepath = image;
        }
    }
}
