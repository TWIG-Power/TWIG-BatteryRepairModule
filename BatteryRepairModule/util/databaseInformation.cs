namespace BatteryRepairModule;

public static class dbInformation
{
    #region Ticket Creation 

    public static int? TWIGCaseNumber = 0;
    public static List<string> batteryTypeOptions = new List<string>();
    public static string? selectedBatteryType = string.Empty;
    public static int? batterySerialNumber = 0;
    public static string? vehicleVINNumber = string.Empty;
    public static List<string> staffOptions = new List<string>();
    public static string? staffCreatedReport = string.Empty;
    public static Dictionary<int, string> moduleReportedErrorsKeyPair = new Dictionary<int, string>(); 

    #endregion

    public static Dictionary<int, int> activeTwigCaseNumbers = new Dictionary<int, int>();

    #region Service Inspection
    public static List<string?> TWIGTicketOptions = new List<string?>();

    public static Dictionary<int, int> selectedTwigTicketKeyPair = new Dictionary<int, int>();  
    public static string? staffServiceInspection = string.Empty;
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
    public static Dictionary<int, string> reportTypeKeyPair = new Dictionary<int, string>();
    public static List<int> tempReportKeys = new List<int>(); 
    public static Dictionary<int, string> reportedIssuesList = new Dictionary<int, string>();
    public static bool? checkChargePort = false,
                        checkCableDamage = false,
                        checkGoveVent = false,
                        checkCommPort = false;
    public static string? nextAction = string.Empty;
    public static string? serviceInspectionNotes = string.Empty;
    public static bool? cleaningProcedures = false;
    public static string? diagnosticReportPath = string.Empty;
    public static Dictionary<int, string> repairActionOptions = new Dictionary<int, string>();
    public static Dictionary<int, string> proposedRepairsList = new Dictionary<int, string>(); 

    #endregion

    #region Authorize Repairs 

    public static List<string> clearedRepairsList = new List<string>();

    #endregion

    #region TESTING ONLY 

    public static void ClearTicketCreation()
    {
        // Ticket Creation Form 1 variables
        TWIGCaseNumber = 0;
        batteryTypeOptions.Clear();
        selectedBatteryType = string.Empty;
        batterySerialNumber = 0;
        vehicleVINNumber = string.Empty;
        staffOptions.Clear();
        staffCreatedReport = string.Empty;
        moduleReportedErrorsKeyPair.Clear();
        
        // Ticket Creation Form 2 variables (Service Inspection section)
        verifyShippingChoice = string.Empty;
        batteryLeadsProtected = null;
        checkHousingScrape = false;
        checkEvidenceOfTamp = false;
        checkScrewsMissing = false;
        checkHousingDentsHoles = false;
        checkMissingWires = false;
        checkChargePort = false;
        checkCableDamage = false;
        checkGoveVent = false;
        checkCommPort = false;
    }
    #endregion
}
