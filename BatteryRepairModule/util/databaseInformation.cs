namespace BatteryRepairModule;

public static class BRMinformation
{
    #region Ticket Creation 

    public static int? TWIGCaseNumber = 0;
    public static List<string> batteryTypeOptions = new List<string>();
    public static string? selectedBatteryType = string.Empty;
    public static int? batterySerialNumber = 0;
    public static string? vehicleVINNumber = string.Empty;
    public static List<string> staffOptions = new List<string>();
    public static string? staffCreatedReport = string.Empty;
    public static List<string> moduleReportedErrors = new List<string>(); 

    #endregion

    public static List<string> activeTwigCaseNumbers = new List<string>();

    #region Service Inspection

    public static string? verifyShippingChoice = string.Empty;
    public static bool? checkHousingScrape = false,
                        checkEvidenceOfTamp = false,
                        checkScrewsMissing = false,
                        checkHousingDentsHoles = false,
                        checkMissingWires = false;
    public static bool? batteryLeadsProtected;
    public static bool? checkCleanHousing = false;
    public static bool? checkThirtyMinuteDrying = false;
    public static bool? checkPluggedIntoDiagTool = false;
    public static List<string> errorCodesList = new List<string>();
    public static List<string> reportedIssuesList = new List<string>();
    public static bool? checkChargePort = false,
                        checkCableDamage = false,
                        checkGoveVent = false,
                        checkCommPort = false;
    public static string? nextAction = string.Empty;
    public static string? serviceInspectionNotes = string.Empty;
    public static bool? cleaningProcedures = false;
    public static string? diagnosticReportPath = string.Empty;
    public static List<string> repairActionOptions = new List<string>();
    public static List<string> proposedRepairsList = new List<string>();

    #endregion

    #region Authorize Repairs 

    public static List<string> clearedRepairsList = new List<string>();

    #endregion

    #region TESTING ONLY 

    public static void InitializeStaffOptions()
    {
        staffOptions.AddRange(new List<string>
        {
            "Alice Smith",
            "Bob Johnson",
            "Charlie Lee",
            "Dana White"
        });
    }

    #endregion
}
