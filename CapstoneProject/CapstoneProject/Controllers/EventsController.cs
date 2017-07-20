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

        public ActionResult ViewEvents(EventModel.SearchParams paramsModel, EventModel.RootObject rootObjModel)
        {
            List<EventModel.Result> userInput = new List<EventModel.Result>();

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
                    EventModel.RootObject listEvents = JsonConvert.DeserializeObject<EventModel.RootObject>(result.Result);
                    foreach (EventModel.Result item in listEvents.results)
                    {
                        EventModel.Result events = new EventModel.Result();
                        events.assetName = item.assetName;
                        events.place.stateProvinceCode = item.place.stateProvinceCode;
                        events.place.addressLine1Txt = item.place.addressLine1Txt;
                        events.activityStartDate = item.activityStartDate;
                        events.salesEndDate = item.salesEndDate;
                        events.registrationUrlAdr = item.registrationUrlAdr;
                        events.place.latitude = item.place.latitude;
                        events.place.longitude = item.place.longitude;

                                           
                        userInput.Add(item);
                    }
                }
            }
            return View(userInput);
        }



    }
}
