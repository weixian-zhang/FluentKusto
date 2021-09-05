using System.Linq.Expressions;

public interface IOperator
{
    public IOperator Where(Expression<Action<T>> expr);
}