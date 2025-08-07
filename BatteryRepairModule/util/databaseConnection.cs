using System.Data;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static class dbConnection
{
    public static string connectionPath = "Server=192.168.1.35;Port=5432;Username=operator;Password=TWIGOperator;Database=BRM_Room";
    
}