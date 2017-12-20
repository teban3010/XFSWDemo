using System.Collections.Generic;

namespace XFSWDemo.Model
{
    public class SearchResults<T>
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<T> Results { get; set; }
    }
}
