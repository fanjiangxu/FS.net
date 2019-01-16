using FS.API.Auth;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//来源：https://www.cnblogs.com/richieyang/p/4918819.html#!comments
//作为owin的启动入口
[assembly: OwinStartup(typeof(FS.API.Startup))]
namespace FS.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            //开启OAuth服务
            ConfigureOAuth(app);

            app.UseWebApi(config);
        }
        /// <summary>
        /// 开启OAuth服务
        /// </summary>
        /// <param name="app"></param>
        private void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                Provider = new SimpleAuthorizationServerProvider(),

                ////refresh token provider
                //RefreshTokenProvider = new SimpleRefreshTokenProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}