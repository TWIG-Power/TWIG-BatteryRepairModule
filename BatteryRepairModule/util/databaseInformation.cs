using System.Diagnostics;
using BatteryRepairModule.Forms.BRM;

namespace BatteryRepairModule;

public static class dbInformation
{
    // General
    public static bool recycled; 

    #region Ticket Creation 
    public static int? TWIGCaseNumber = 0;
    public static int? batterySerialNumber = 0;
    public static string? vehicleVINNumber = string.Empty;
    public static string? selectedBatteryType = string.Empty;
    public static Dictionary<int, string> moduleReportedErrorsKeyPair = new Dictionary<int, string>();
    public static Dictionary<int, string> staffKeyPairOptions = new Dictionary<int, string>();
    public static Dictionary<int, Dictionary<int, string>> moduleTypesByOEM = new Dictionary<int, Dictionary<int, string>>();
    public static Dictionary<int, Dictionary<int, string>> selectedModuleType = new Dictionary<int, Dictionary<int, string>>();
    public static Dictionary<int, string> selectedStaffKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> ticketStatusOptions = new Dictionary<int, string>();
    #endregion

    #region Service Inspection
    public static Dictionary<int, int> selectedTwigTicketKeyPair = new Dictionary<int, int>();
    public static string? verifyShippingChoice = string.Empty;
    public static string? diagnosticReportPath = string.Empty;
    public static bool? cleaningProcedures = false;
    public static bool? batteryLeadsProtected;
    public static Dictionary<int, string> reportTypeKeyPair = new Dictionary<int, string>();
    public static Dictionary<int, string> reportedIssuesList = new Dictionary<int, string>();
    public static Dictionary<int, string> repairActionOptions = new Dictionary<int, string>();
    public static Dictionary<int, string> proposedRepairsKeyPair = new Dictionary<int, string>();
    public static List<Module> activeModules = new List<Module>();
    public static List<repairOption> repairOptionsList = new List<repairOption>(); 

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
    public static Dictionary<int, string> clearedRepairsKeyValPair = new Dictionary<int, string>();
    public static Dictionary<int, string> clearedRepairsKeyStatusPair = new Dictionary<int, string>();
    public static Dictionary<string, string> clearedRepairsValueStatusPair = new Dictionary<string, string>();
    #endregion

    #region REPAIR ACTIONS
    public static string repairNotes = string.Empty;
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
    public static Dictionary<string, bool> repairHasNoteStringBool = new Dictionary<string, bool>();
    #endregion

    #region TESTING 
    public static string testNotes = string.Empty;
    public static Dictionary<int, string> testingOptionsKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, bool> testingOptionsRequiredKeyBoolean = new Dictionary<int, bool>(); 
    public static Dictionary<int, string> addedTestsKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> tempAddNewTest = new Dictionary<int, string>();
    public static Dictionary<int, string> addedTestsKeyStatus = new Dictionary<int, string>();
    public static Dictionary<int, string> tempTestNoteHolder = new Dictionary<int, string>();
    public static Dictionary<int, string> moduleTypeKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, int> raceGradeHighLowKeyPair = new Dictionary<int, int>();
    public static Dictionary<int, int> trackGradeHighLowKeyPair = new Dictionary<int, int>();
    public static Dictionary<int, int> playGradeHighLowKeyPair = new Dictionary<int, int>();
    public static Dictionary<int, string> testStatusOptionsKeyValue = new Dictionary<int, string>();
    public static Dictionary<int, string> tempTestStatusHolder = new Dictionary<int, string>();
    public static Dictionary<int, string> tempTestTestHolder = new Dictionary<int, string>();
    public static Dictionary<int, bool> doesTestHaveNote = new Dictionary<int, bool>();
    public static bool conditionalClosureFailure = false;

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

    #region QUALITY 
    public static string qualityFilePath = string.Empty;
    public static Dictionary<string, int> selectedOemModelKeyPair = new Dictionary<string, int>();
    public static string downloadedFileName = string.Empty;
    public static byte[] downloadedFileBytes = null;
    #endregion

    #region Shipping 
    public static List<Module> awaitingInvoiceModuleList = new List<Module>();
    public static List<Module> awaitingShippingModuleList = new List<Module>(); 
    #endregion

    // Example: Sorting activeModules by SerialNumber
    public static void SortActiveModulesBySerialNumber()
    {
        activeModules = activeModules.OrderBy(m => m.SerialNumber).ToList();
    }

    // Example: Sorting repairOptionsList by Id
    public static void SortRepairOptionsListById()
    {
        repairOptionsList = repairOptionsList.OrderBy(o => o.Id).ToList();
    }
}

public class Module
{
    public int ticketSurrogateKey { get; set; }
    public int ticketId { get; set; }
    public int SerialNumber { get; set; }
    public string model { get; set; } = string.Empty;
    public string Oem { get; set; } = string.Empty;
    public string stateOfHealth { get; set; } = string.Empty;
    public string ticketStatus { get; set; } = string.Empty; 

    public Module(int surroKey, int id, int serialNumber, string oem, string type, string stateOfHealth)
    {
        ticketSurrogateKey = surroKey;
        ticketId = id;
        SerialNumber = serialNumber;
        Oem = oem;
        model = type;
        this.stateOfHealth = stateOfHealth;
    }
    public Module(int surroKey, int id, int serialNumber, string oem, string type, string stateOfHealth, string status)
    {
        ticketSurrogateKey = surroKey;
        ticketId = id;
        SerialNumber = serialNumber;
        Oem = oem;
        model = type;
        this.stateOfHealth = stateOfHealth;
        ticketStatus = status; 
    }
}

public class repairOption
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool Enabled { get; set; }

    public repairOption(int refId, string refDescription, bool refEnabled)
    {
        Id = refId;
        Description = refDescription;
        Enabled = refEnabled; 
    }

    public static List<repairOption> SortById(List<repairOption> options)
    {
        return options.OrderBy(o => o.Id).ToList();
    }
}
