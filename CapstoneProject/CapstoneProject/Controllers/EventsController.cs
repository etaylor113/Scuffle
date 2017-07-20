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

        public ActionResult ViewEvents(EventModel.SearchParams paramsModel)
        {
            List<EventModel.EventsModel> allEvents = new List<EventModel.EventsModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.amp.active.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                string url = "http://api.amp.active.com/v2/search?query=" + paramsModel.topic + "&category=event&isSearchable=true&country=United%20States&state=" + paramsModel.state + "&api_key=e7d3anxx2a923ryrdm6zcx68";
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    EventModel.EventsRootModel eventList = JsonConvert.DeserializeObject<EventModel.EventsRootModel>(result.Result);
                    foreach (EventModel.EventsModel item in eventList.results)
                    {
                        EventModel.EventsModel events = new EventModel.EventsModel();
                        events.assetName = item.assetName;                        
                        events.activityStartDate = item.activityStartDate;
                        events.salesEndDate = item.salesEndDate;
                        events.registrationUrlAdr = item.registrationUrlAdr;
                        //events.place = item.place;
                                                
                        allEvents.Add(events);
                    }
                }
            }
            return View(allEvents);
        }
    }
}
