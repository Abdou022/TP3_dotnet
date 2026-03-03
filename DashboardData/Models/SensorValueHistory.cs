using System.ComponentModel.DataAnnotations;

namespace DashboardData.Models;

public class SensorValueHistory
{
    [Key]
    public int Id { get; set; }

    public double Value { get; set; }

    public DateTime Timestamp { get; set; } = DateTime.Now;

    // FK vers SensorData (1-to-N) : chaque historique appartient à UN capteur
    public int SensorDataId { get; set; }
    public SensorData SensorData { get; set; }
}
