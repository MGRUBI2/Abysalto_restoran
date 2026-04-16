namespace AbySalto.Junior.Application.Interfaces;

public interface IMapper<TSource,TDestination>
{
    TDestination ToDto(TSource source);
    
    TSource ToEntity(TDestination destination);
}