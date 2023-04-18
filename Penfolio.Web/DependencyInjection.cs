namespace Penfolio.Web;

internal static class DependencyInjection
{

        internal static IServiceCollection InjectControllers(this IServiceCollection services) =>
                services.AddControllers().Services;

        internal static IServiceCollection InjectAddEndpointsApiExplorer(this IServiceCollection services) =>
                services.AddEndpointsApiExplorer();

        internal static IServiceCollection InjectSwaggerGen(this IServiceCollection services) =>
                services.AddSwaggerGen();
}
