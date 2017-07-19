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

        


        public ActionResult SearchForEvents(EventModel model)
        {
            List<SearchParams> userInput = new List<SearchParams>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.seatgeek.com/2/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                string url = "https://api.seatgeek.com/2/performers?q=" + model.topic + "&client_id=ODExNjMyNnwxNDk5Nzg0NzQxLjEy";
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    EventRootObjectModel listEvents = JsonConvert.DeserializeObject<EventRootObjectModel>(result.Result);
                    foreach (EventModel item in listEvents)
                    {
                        EventModel events = new EventModel();
                        events.topic = item.topic;
                        events.state = item.state;                     
                        userInput.Add(item);

                    }
                }
            }
            return View(userInput);
        }
       

        public ActionResult ViewEvents(EventModel model)
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://api.amp.active.com");
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                //string url = "http://api.amp.active.com/v2/search?query=" + model.topic +"&category=event&country=United%20States&state=" + model.state + "&api_key=e7d3anxx2a923ryrdm6zcx68";
                //var response = client.GetAsync(url).Result;
                //if (response.IsSuccessStatusCode)
                //{
                //    var result = response.Content.ReadAsStringAsync();

                //}

            }
            return View();
        }

    }
}
