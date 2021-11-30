using System.Collections;
using ChristiansOeBackend.Models;
using Newtonsoft.Json;

namespace ChristiansOeBackend.Services
{
    public class MarkersService
    {

        public Marker[] GetMarkers()
        {
            var markers = new[]
            {
                new Marker("first", 55.31982f, 15.18783f, "This is a description"),
                new Marker("second", 55.31962f, 15.18733f, "This is a description")
            };
          
            return markers;
        }


    }
}