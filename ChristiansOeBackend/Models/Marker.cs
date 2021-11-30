namespace ChristiansOeBackend.Models
{
    public class Marker
    {
        public string title { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public string description { get; set; }

        public Marker(string title, float lat, float lng, string description)
        {
            this.title = title;
            this.lat = lat;
            this.lng = lng;
            this.description = description;
        }
    }
}