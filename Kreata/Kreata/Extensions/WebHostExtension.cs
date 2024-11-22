namespace Kreata.Extensions
{
    public static class WebHostExtension
    {
        public static void ConfiugreWebHost(this WebApplicationBuilder webApplicationBuilder )
        {
            webApplicationBuilder.WebHost.UseUrls("http://0.0.0.0:7020");
        }
    }
}
