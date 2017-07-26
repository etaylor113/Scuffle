using CapstoneProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace CapstoneProject.Controllers
{
    public class EventsController : Controller
    {


        public ActionResult SearchForEvents()
        {
            return View();
        }

        public async Task<ActionResult> ViewEvents(EventModel.SearchParams searchParams)
        {
            List<EventModel.Event> allEvents = new List<EventModel.Event>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.eventful.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                string url = "/json/events/search?...&keywords=fitness&location=" + searchParams.state + "&app_key=f82xVFHpZXDFfbck";
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    EventModel.RootObject model = JsonConvert.DeserializeObject<EventModel.RootObject>(result);
                    foreach (EventModel.Event item in model.events.@event)
                    {
                        EventModel.Event events = new EventModel.Event();
                        events.latitude = item.latitude;
                        events.longitude = item.longitude;
                        events.city_name = item.city_name;
                        events.title = item.title;
                        events.start_time = item.start_time;
                        events.stop_time = item.stop_time;
                        events.venue_address = item.venue_address;                  
                        allEvents.Add(events);
                    }
                }
            }
            return View(allEvents);
        }
    }
}
