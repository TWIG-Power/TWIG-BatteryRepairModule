namespace BatteryRepairModule;

public static class dbInformation
{
    #region Ticket Creation 

    public static int? TWIGCaseNumber = 0;
    public static int? batterySerialNumber = 0;
    public static string? vehicleVINNumber = string.Empty;
    public static string? selectedBatteryType = string.Empty;
    public static List<string> batteryTypeOptions = new List<string>();
    public static List<string> staffOptions = new List<string>();
    public static string? staffCreatedReport = string.Empty;
    public static Dictionary<int, string> moduleReportedErrorsKeyPair = new Dictionary<int, string>();
    public static Dictionary<int, int> activeTwigCaseNumbers = new Dictionary<int, int>();

    #endregion

    #region Service Inspection
    public static List<string?> TWIGTicketOptions = new List<string?>();

    public static Dictionary<int, int> selectedTwigTicketKeyPair = new Dictionary<int, int>();  
    public static string? staffServiceInspection = string.Empty;
    public static string? verifyShippingChoice = string.Empty;
    public static string? nextAction = string.Empty;
    public static string? serviceInspectionNotes = string.Empty;
    public static string? diagnosticReportPath = string.Empty;
    public static bool? cleaningProcedures = false;
    public static bool? batteryLeadsProtected;
    public static List<int> tempReportKeys = new List<int>(); 
    public static Dictionary<int, string> reportTypeKeyPair = new Dictionary<int, string>();
    public static Dictionary<int, string> reportedIssuesList = new Dictionary<int, string>();
    public static Dictionary<int, string> repairActionOptions = new Dictionary<int, string>();
    public static Dictionary<int, string> proposedRepairsKeyPair = new Dictionary<int, string>(); 
    // Inspection Checkboxes
    public static bool? checkHousingScrape = false;
    public static bool? checkEvidenceOfTamp = false;
    public static bool? checkScrewsMissing = false;
    public static bool? checkHousingDentsHoles = false;
    public static bool? checkMissingWires = false;
    public static bool? checkCleanHousing = false;
    public static bool? checkThirtyMinuteDrying = false;
    public static bool? checkPluggedIntoDiagTool = false;
    public static bool? checkChargePort = false;
    public static bool? checkCableDamage = false;
    public static bool? checkGoveVent = false;
    public static bool? checkCommPort = false;

    #endregion

    #region Authorize Repairs 
    public static string? staffAuthorized = string.Empty; 
    public static Dictionary<int, string> clearedRepairsKeyValPair = new Dictionary<int, string>();

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
