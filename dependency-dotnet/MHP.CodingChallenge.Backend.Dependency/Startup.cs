using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MHP.CodingChallenge.Backend.Dependency.Inquiry;
using MHP.CodingChallenge.Backend.Dependency.Notifications;
using MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace MHP.CodingChallenge.Backend.Dependency
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        /// <summary>
        /// Dependency Injections registrieren. Z.B. benötigt die Klasse <see cref="InquiryService"/> im Konstruktor einen <see cref="IEmailHandler"/>
        /// und einen <see cref="IPushNotificationHandler"/>. Die wurden bereits davor mit 
        /// 
        /// <code>services.AddScoped<IEmailHandler, EmailHandler>();</code>
        /// 
        /// und 
        /// 
        /// <code>services.AddScoped<IPushNotificationHandler, PushNotificationHandler>();</code>
        /// 
        /// für die Dependency Injection konfiguriert, indem angegeben wurde, dass IEmailHandler mit einem Objekt der Klasse <see cref="EmailHandler"/>
        /// instanziiert werden soll.
        /// 
        /// Genauso benötigen die Konstruktoren von <see cref="EmailHandler"/> und <see cref="PushNotificationHandler"/> im Konstruktor einen Übergabeparameter vom Typ
        /// <see cref="IInquiry"/>, der davor in Zeile 49 für die Dependency Injection registiert wurde.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IInquiry, Inquiry.Inquiry>();
            services.AddScoped<IEmailHandler, EmailHandler>();
            services.AddScoped<IPushNotificationHandler, PushNotificationHandler>();
            services.AddTransient<InquiryService>();

            // Unterschied zwischen AddScoped, AddTransient und AddSingleton: https://stackoverflow.com/a/38138494
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
