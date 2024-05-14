using ReactiveUI;
using System;
using System.Diagnostics.Metrics;

namespace _4_4.ViewModels
{
    public class News
    {
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
        public News(string text, DateTime publishdate)
        {
            Text = text;
            PublishDate = publishdate;
        }
    }
}
