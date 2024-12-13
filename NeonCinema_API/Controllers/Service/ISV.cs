namespace NeonCinema_API.Controllers.Service
{
    public interface ISV
    {
        public Task<(int TotalPoints, decimal TotalSpent, string ranks)> GetUserStatsAsync(Guid userId);
    }
}
