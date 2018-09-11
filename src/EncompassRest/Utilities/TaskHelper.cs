using System.Threading.Tasks;

namespace EncompassRest.Utilities
{
    public static class TaskHelper
    {
        public static Task CompletedTask { get; } = Task.FromResult(0);
    }
}