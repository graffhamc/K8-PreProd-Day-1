﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace K8_UK_PP_Regression
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The K8AccountPaymentReversal_PP recording.
    /// </summary>
    [TestModule("349d68ca-2f59-43d4-abb9-8fba03a49acc", ModuleType.Recording, 1)]
    public partial class K8AccountPaymentReversal_PP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the K8_UK_SOP_RegressionRepository repository.
        /// </summary>
        public static K8_UK_SOP_RegressionRepository repo = K8_UK_SOP_RegressionRepository.Instance;

        static K8AccountPaymentReversal_PP instance = new K8AccountPaymentReversal_PP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K8AccountPaymentReversal_PP()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K8AccountPaymentReversal_PP Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Tools') on item 'Ql1054K8QA3SalesOrderProcessingD.Tools'.", repo.Ql1054K8QA3SalesOrderProcessingD.ToolsInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Ql1054K8QA3SalesOrderProcessingD.ToolsInfo, "Text", "Tools");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ql1054K8QA3SalesOrderProcessingD.Tools' at 28;9.", repo.Ql1054K8QA3SalesOrderProcessingD.ToolsInfo, new RecordItemIndex(1));
            repo.Ql1054K8QA3SalesOrderProcessingD.Tools.Click("28;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Make Account Payment...\tSHIFT+F10') on item 'Kclient.MakeAccountPaymentSHIFTPlusF10'.", repo.Kclient.MakeAccountPaymentSHIFTPlusF10Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Kclient.MakeAccountPaymentSHIFTPlusF10Info, "Text", "Make Account Payment...\tSHIFT+F10");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Kclient.MakeAccountPaymentSHIFTPlusF10' at 83;10.", repo.Kclient.MakeAccountPaymentSHIFTPlusF10Info, new RecordItemIndex(3));
            repo.Kclient.MakeAccountPaymentSHIFTPlusF10.Click("83;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Description:') on item 'CashbookCustomerReceipts.Description'.", repo.CashbookCustomerReceipts.DescriptionInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.CashbookCustomerReceipts.DescriptionInfo, "Text", "Description:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Description' at 8;9.", repo.CashbookCustomerReceipts.DescriptionInfo, new RecordItemIndex(5));
            repo.CashbookCustomerReceipts.Description.Click("8;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SearchResults.RowRow'.", repo.SearchResults.RowRowInfo, new RecordItemIndex(6));
            Validate.Exists(repo.SearchResults.RowRowInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SearchResults.RowRow' at Center.", repo.SearchResults.RowRowInfo, new RecordItemIndex(7));
            repo.SearchResults.RowRow.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SearchResults.Finish'.", repo.SearchResults.FinishInfo, new RecordItemIndex(8));
            Validate.Exists(repo.SearchResults.FinishInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SearchResults.Finish' at 37;10.", repo.SearchResults.FinishInfo, new RecordItemIndex(9));
            repo.SearchResults.Finish.Click("37;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CashbookCustomerReceipts.ReceiptReversal'.", repo.CashbookCustomerReceipts.ReceiptReversalInfo, new RecordItemIndex(10));
            Validate.Exists(repo.CashbookCustomerReceipts.ReceiptReversalInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.ReceiptReversal' at 35;5.", repo.CashbookCustomerReceipts.ReceiptReversalInfo, new RecordItemIndex(11));
            repo.CashbookCustomerReceipts.ReceiptReversal.Click("35;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='&Yes') on item 'ReceiptReversal.ButtonYes'.", repo.ReceiptReversal.ButtonYesInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ReceiptReversal.ButtonYesInfo, "Text", "&Yes");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReceiptReversal.ButtonYes' at 43;11.", repo.ReceiptReversal.ButtonYesInfo, new RecordItemIndex(13));
            repo.ReceiptReversal.ButtonYes.Click("43;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Process') on item 'CashbookCustomerReceipts.Process'.", repo.CashbookCustomerReceipts.ProcessInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.CashbookCustomerReceipts.ProcessInfo, "Text", "Process");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Process' at 52;28.", repo.CashbookCustomerReceipts.ProcessInfo, new RecordItemIndex(15));
            repo.CashbookCustomerReceipts.Process.Click("52;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Exit') on item 'CashbookCustomerReceipts.Exit'.", repo.CashbookCustomerReceipts.ExitInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.CashbookCustomerReceipts.ExitInfo, "Text", "Exit");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Exit' at 35;17.", repo.CashbookCustomerReceipts.ExitInfo, new RecordItemIndex(17));
            repo.CashbookCustomerReceipts.Exit.Click("35;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Exit') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo, "Text", "Exit");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit' at 46;30.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo, new RecordItemIndex(19));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit.Click("46;30");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
