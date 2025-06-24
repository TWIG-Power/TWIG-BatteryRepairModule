using System.Data;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static class DatabaseConnection
{
    public static string connectionPath = "Server=192.168.1.69;Port=5432;Username=postgres;Password=TestServer1;Database=BMA_Room";
    
}