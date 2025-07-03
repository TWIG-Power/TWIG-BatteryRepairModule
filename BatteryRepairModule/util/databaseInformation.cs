using System.Diagnostics;
using BatteryRepairModule.Forms.BRM;

namespace BatteryRepairModule;

public static class dbInformation
{
    #region Ticket Creation 

    public static int? TWIGCaseNumber = 0;
    public static int? batterySerialNumber = 0;
    public static string? vehicleVINNumber = string.Empty;
    public static string? selectedBatteryType = string.Empty;
    public static Dictionary<int, string> moduleReportedErrorsKeyPair = new Dictionary<int, string>();
    public static Dictionary<int, int> activeTwigCaseNumbers = new Dictionary<int, int>();
    public static Dictionary<int, string> staffKeyPairOptions = new Dictionary<int, string>(); 
    public static Dictionary<int, Dictionary<int, string>> moduleTypesByOEM = new Dictionary<int, Dictionary<int, string>>();
    public static Dictionary<int, Dictionary<int, string>> selectedModuleType = new Dictionary<int, Dictionary<int, string>>();
    public static Dictionary<int, string> selectedStaffKeyValue = new Dictionary<int, string>(); 


    #endregion

    #region Service Inspection
    public static List<string?> TWIGTicketOptions = new List<string?>();

    public static Dictionary<int, int> selectedTwigTicketKeyPair = new Dictionary<int, int>();  
    public static string? verifyShippingChoice = string.Empty;
    public static string? diagnosticReportPath = string.Empty;
    public static bool? cleaningProcedures = false;
    public static bool? batteryLeadsProtected;
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
    public static bool? checkPluggedIntoDiagTool = false;
    public static bool? checkChargePort = false;
    public static bool? checkCableDamage = false;
    public static bool? checkGoveVent = false;
    public static bool? checkCommPort = false;

    #endregion

    #region Authorize Repairs 
    public static string? staffAuthorized = string.Empty;
    public static Dictionary<int, string> clearedRepairsKeyValPair = new Dictionary<int, string>();
    public static Dictionary<int, string> clearedRepairsKeyStatusPair = new Dictionary<int, string>();
    public static Dictionary<string, string> clearedRepairsValueStatusPair = new Dictionary<string, string>();

    #endregion

    #region REPAIR ACTIONS
    public static string repairNotes = string.Empty;
    public static Dictionary<int, string> repairActionKeyStatus = new Dictionary<int, string>();
    public static Dictionary<int, string> newRepairActionInRepairFormKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> reportedIssueKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> reportedIssueKeyStatus = new Dictionary<int, string>();
    public static Dictionary<string, string> reportedIssuesValueStatus = new Dictionary<string, string>();
    public static Dictionary<int, string> issueStatusOptionsKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> repairStatusOptionKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> tempUpdateIssueIssueHolder = new Dictionary<int, string>();
    public static Dictionary<int, string> tempUpdateIssueStatusHolder = new Dictionary<int, string>();
    public static Dictionary<int, string> tempUpdateRepairRepairHolder = new Dictionary<int, string>();
    public static Dictionary<int, string> tempUpdateRepairStatusHolder = new Dictionary<int, string>();
    public static Dictionary<int, string> tempUpdateNotesRepairHolder = new Dictionary<int, string>();

    #endregion

    #region TESTING 

    public static string testNotes = string.Empty;
    public static Dictionary<int, string> testingOptionsKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> addedTestsKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> tempAddNewTest = new Dictionary<int, string>();
    public static Dictionary<int, string> addedTestsKeyStatus = new Dictionary<int, string>();
    public static Dictionary<string, string> addedTestValueStatus = new Dictionary<string, string>();
    public static Dictionary<int, string> tempTestNoteHolder = new Dictionary<int, string>();
    public static Dictionary<int, string> moduleTypeKeyValue = new Dictionary<int, string>(); 
    public static Dictionary<int, int> raceGradeHighLowKeyPair = new Dictionary<int, int>();
    public static Dictionary<int, int> trackGradeHighLowKeyPair = new Dictionary<int, int>();
    public static Dictionary<int, int> playGradeHighLowKeyPair = new Dictionary<int, int>();
    public static Dictionary<int, string> testStatusOptionsKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> tempTestStatusHolder = new Dictionary<int, string>();
    public static Dictionary<int, string> tempTestTestHolder = new Dictionary<int, string>(); 

    public static void ClearTicketCreation()
    {
        // Ticket Creation Form 1 variables
        TWIGCaseNumber = 0;
        selectedBatteryType = string.Empty;
        batterySerialNumber = 0;
        vehicleVINNumber = string.Empty;
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
