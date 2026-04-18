namespace Blazor.Interfaces;

public interface ISort<T> where T : class
{
   IEnumerable<T> Sort(IEnumerable<T> lst);
}