using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

using Fluid;
using Fluid.Ast;
using Fluid.Values;

namespace BatteryRepairModule
{
    public static class HTMLReportGenerator
    {
        #region MODULE REPORT
        public static void generateModuleReport(Module result)
        {
            try
            {
                string filePathFolder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "Battery-Repair-Module",
                    "Status-Review-Reports", 
                    $"Service_Report_{result.ticketId}"
                );

                if (!Directory.Exists(filePathFolder))
                {
                    Directory.CreateDirectory(filePathFolder);
                }

                string fileName = $"Service_Report_{result.ticketId}.html";
                string fullPath = Path.Combine(filePathFolder, fileName);

                var parser = new FluidParser();
                var context = generateContext(result);

                string templateString = Encoding.UTF8.GetString(Properties.Resources.ModuleInformationReport);
                var templateTest = parser.Parse(templateString);
                string outFile = templateTest.Render(context);

                if (File.Exists(fullPath))
                {
                    var option = MessageBox.Show("A file with the same name already exists. Do you wish to replace it?", "Warning: File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (option == DialogResult.No) { return;  }
                }
                File.WriteAllText(fullPath, outFile);

                MessageBox.Show($"Report generated successfully!\nSaved to: {fullPath}",
                                "Report Generated",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                Process.Start(new ProcessStartInfo
                {
                    FileName = fullPath,
                    UseShellExecute = true
                });

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}",
                                "Report Generation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }

        private static TemplateContext generateContext(Module result)
        {
            var context = new TemplateContext();

            context.SetValue("REPORT_GENERATED_DATE", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            context.SetValue("TICKET_ID", result.ticketId.ToString());
            context.SetValue("SERIAL_NUMBER", result.SerialNumber.ToString() ?? "Unknown");
            context.SetValue("OEM", result.Oem ?? "Unknown");
            context.SetValue("MODEL", result.model ?? "Unknown");
            context.SetValue("VEHICLE_VIN", result.vehicleVinNumber ?? "Unknown");            context.SetValue("ASSESSMENT_ID", result.initialAssesment.id.ToString() ?? "Unknown");
            context.SetValue("ASSESSMENT_COMPLETED_BY", result.initialAssesment.staff ?? "Unknown");
            context.SetValue("SHIPPING_CONDITION", result.initialAssesment.shipping ?? "Unknown");
            context.SetValue("HOUSING_SCRAPES", result.initialAssesment.housingScrapes.ToString() ?? "Unknown");
            context.SetValue("EVIDENCE_OF_TAMPERING", result.initialAssesment.evidenceOfTampering.ToString() ?? "Unknown");
            context.SetValue("SCREWS_MISSING", result.initialAssesment.screwsMissing.ToString() ?? "Unknown");
            context.SetValue("HOUSING_DENTS", result.initialAssesment.housingDents.ToString() ?? "Unknown");

            StringBuilder customerReportsHtml = new StringBuilder();
            int counter = 0; 
            foreach (var report in result.reportList)
            {
                customerReportsHtml.AppendLine($"<div class=\"param-name\"> ------------ Reported Issue {counter+=1} ------------ </div>");
                customerReportsHtml.AppendLine($"<div class=\"param-name\">Description:         {report.description ?? "Unknown"}</div>");
                customerReportsHtml.AppendLine($"<div class=\"param-name\">Status:              {report.status ?? "Unknown"}</div>");
            }

            context.SetValue("CUSTOMER_REPORTS", customerReportsHtml.ToString());

            context.SetValue("INSPECTION_ID", result.serviceInspection.id);
            context.SetValue("STAFF_SERVICE", result.serviceInspection.staff);
            context.SetValue("CLEANED", result.serviceInspection.cleaned);
            context.SetValue("DIAGNOSTIC_ATTACHED", result.serviceInspection.diagnosticFile);

            StringBuilder repairActionsHtml = new StringBuilder();
            counter = 0;
            foreach (var repairAction in result.repairList)
            {
                repairActionsHtml.AppendLine($"<div class=\"param-name\"> ------------ Repair Action {counter += 1} ------------ </div>");
                repairActionsHtml.AppendLine($"<div class=\"param-name\"> Repair ID: {repairAction.repairId}</div>");
                repairActionsHtml.AppendLine($"<div class=\"param-name\"> Description: {repairAction.description}</div>");
                repairActionsHtml.AppendLine($"<div class=\"param-name\"> Status: {repairAction.status}</div>");
                repairActionsHtml.AppendLine($"<div class=\"param-name\"> Note: {repairAction.note ?? "NULL"}</div>");
                repairActionsHtml.AppendLine($"<div class=\"param-name\"> Performed By: {repairAction.staff}</div>");
            }

            context.SetValue("REPAIR_ACTIONS", repairActionsHtml.ToString());

            StringBuilder testActionsHtml = new StringBuilder();
            counter = 0;
            foreach (var test in result.testList)
            {
                testActionsHtml.AppendLine($"<div class=\"param-name\"> ------------ Test Action {counter += 1} ------------ </div>");
                testActionsHtml.AppendLine($"<div class=\"param-name\"> Test ID: {test.id}</div>");
                testActionsHtml.AppendLine($"<div class=\"param-name\"> Description: {test.description}</div>");
                testActionsHtml.AppendLine($"<div class=\"param-name\"> Status: {test.status}</div>");
                testActionsHtml.AppendLine($"<div class=\"param-name\"> Result: {test.wattHour}Wh</div>");
                testActionsHtml.AppendLine($"<div class=\"param-name\"> State of Health: {test.stateOfHealth}</div>");
                testActionsHtml.AppendLine($"<div class=\"param-name\"> Note: {test.note ?? "NULL"}</div>");
                testActionsHtml.AppendLine($"<div class=\"param-name\"> Performed By: {test.staff}</div>");
            }

            context.SetValue("TESTING", testActionsHtml.ToString());


            return context;
        }

        #endregion
    }
}
