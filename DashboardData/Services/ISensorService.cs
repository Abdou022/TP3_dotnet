using DashboardData.Models;

namespace DashboardData.Services;

public interface ISensorService 
{
    Task<List<SensorData>> GetSensorsAsync();
    Task AddSensorAsync(SensorData sensor);
    Task<List<SensorData>> GetCriticalSensorsAsync(double threshold);
    Task<int> GetTotalCountAsync();
    Task<double> GetAverageValueAsync();
    Task<double> GetMaxValueAsync();
}