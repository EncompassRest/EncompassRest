using System.Threading.Tasks;

namespace EncompassApi.Utilities
{
    internal static class TaskHelper
    {
        public static Task CompletedTask { get; } = Task.FromResult(0);
    }
}