namespace PointToPoint.Extensions
{
    public static class WebHostExtension
    {
        public static void ConfiugreWebHost(this WebApplicationBuilder webApplicationBuilder )
        {
            webApplicationBuilder.WebHost.UseUrls("https://0.0.0.0:7020");
        }
    }
}
