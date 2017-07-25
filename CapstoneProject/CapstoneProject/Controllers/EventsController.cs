using CapstoneProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        public ActionResult ViewEvents(EventModel.SearchParams searchParams)
        {
            List<EventModel.Event> allEvents = new List<EventModel.Event>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.eventful.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                string url = "api.eventful.com/json/events/search?...&keywords=fitness&location=" + searchParams.state + "&app_key=f82xVFHpZXDFfbck";
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    EventModel.Events model = JsonConvert.DeserializeObject<EventModel.Events>(result.Result);
                    foreach (EventModel.Event item in model.@event)
                    {
                        EventModel.Event events = new EventModel.Event();
                        events.latitude = item.latitude;
                        events.longitude = item.longitude;
                        events.city_name = item.city_name;
                        events.venue_name = item.venue_name;
                        events.start_time = item.start_time;
                        events.stop_time = item.stop_time;
                                                
                        allEvents.Add(events);
                    }
                }
            }
            return View(allEvents);
        }
    }
}
