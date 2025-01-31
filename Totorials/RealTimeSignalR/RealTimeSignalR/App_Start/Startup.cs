﻿using Owin;
//using System;
//using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;

namespace RealTimeSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //// Map all hubs to "/signalr"
            app.MapSignalR();

            //// Map the Echo PersistentConnection to "/echo"
            //app.MapSignalR<EchoConnection>("/echo");

            //app.MapHubs();





            //// Branch the pipeline here for requests that start with "/signalr"
            //app.Map("/signalr", map =>
            //{
            //    // Setup the cors middleware to run before SignalR.
            //    // By default this will allow all origins. You can 
            //    // configure the set of origins and/or http verbs by
            //    // providing a cors options with a different policy.
            //    map.UseCors(CorsOptions.AllowAll);

            //    var hubConfiguration = new HubConfiguration
            //    {
            //        // You can enable JSONP by uncommenting line below.
            //        // JSONP requests are insecure but some older browsers (and some
            //        // versions of IE) require JSONP to work cross domain
            //        // EnableJSONP = true
            //    };

            //    // Run the SignalR pipeline. We're not using MapSignalR
            //    // since this branch is already runs under the "/signalr"
            //    // path.
            //    map.RunSignalR(hubConfiguration);
            //});
        }
    }
}