using System.Collections.Generic;

namespace DemoProject.Models
{
    public class MarvelSearchResult
    {
        public string AttributionText { get; set; }
        public Datawrapper Data { get; set; }

        public class Datawrapper
        {
            public List<Result> Results { get; set; }
        }

        public class Result
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Image Thumbnail { get; set; }

            public class Image
            {
                public string Path { get; set; }
                public string Extension { get; set; }
            }
        }
    }
}