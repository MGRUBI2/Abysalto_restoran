using AbySalto.Junior.Application.Dto;
using AbySalto.Junior.Application.Interfaces;
using AbySalto.Junior.Application.Mapper;
using AbySalto.Junior.Application.Services;
using AbySalto.Junior.Domain.Entities;

namespace AbySalto.Junior.Application;

public static class DependencyInjection
{
   public static IServiceCollection AddApplication(this IServiceCollection services)
   {
      services/*.AddSingleton <IMapper<Order, BackendOrderCreationRequestDto>,OrderMapper>()*/ //M.G:depricated
         .AddSingleton<IMapper<Article,ArticleDtoBackend>,ArticleMapper>()
         .AddSingleton<IMapper<Order,OrderDtoBackend>,OrderResponseDtoMapper>()
         .AddScoped<IOrderService,OrderService>()
         .AddScoped<IArticleService,ArticleService>();
      
      return services;
   }
}