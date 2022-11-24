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
    ///The K8DeleteSalesOrderLines_PP recording.
    /// </summary>
    [TestModule("e5d6f340-ae09-4413-8b7a-b701e2228acf", ModuleType.Recording, 1)]
    public partial class K8DeleteSalesOrderLines_PP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the K8_UK_SOP_RegressionRepository repository.
        /// </summary>
        public static K8_UK_SOP_RegressionRepository repo = K8_UK_SOP_RegressionRepository.Instance;

        static K8DeleteSalesOrderLines_PP instance = new K8DeleteSalesOrderLines_PP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K8DeleteSalesOrderLines_PP()
        {
            AccNumber = "CD961";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K8DeleteSalesOrderLines_PP Instance
        {
            get { return instance; }
        }

#region Variables

        string _AccNumber;

        /// <summary>
        /// Gets or sets the value of variable AccNumber.
        /// </summary>
        [TestVariable("9f4bd9f6-a27c-4baf-9c25-86422b99f325")]
        public string AccNumber
        {
            get { return _AccNumber; }
            set { _AccNumber = value; }
        }

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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Howdens History') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.HowdensHistory'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.HowdensHistoryInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.HowdensHistoryInfo, "Text", "Howdens History");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.HowdensHistory' at 53;21.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.HowdensHistoryInfo, new RecordItemIndex(1));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.HowdensHistory.Click("53;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3BackOfficeUserView2.PushButton'.", repo.Ql1054K8QA3BackOfficeUserView2.PushButtonInfo, new RecordItemIndex(2));
            Validate.Exists(repo.Ql1054K8QA3BackOfficeUserView2.PushButtonInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ql1054K8QA3BackOfficeUserView2.PushButton' at 15;10.", repo.Ql1054K8QA3BackOfficeUserView2.PushButtonInfo, new RecordItemIndex(3));
            repo.Ql1054K8QA3BackOfficeUserView2.PushButton.Click("15;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Filter.Between'.", repo.Filter.BetweenInfo, new RecordItemIndex(4));
            Validate.Exists(repo.Filter.BetweenInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Filter.Between' at 31;10.", repo.Filter.BetweenInfo, new RecordItemIndex(5));
            repo.Filter.Between.Click("31;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't' with focus on 'Filter.Between'.", repo.Filter.BetweenInfo, new RecordItemIndex(6));
            repo.Filter.Between.PressKeys("t", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Filter.And'.", repo.Filter.AndInfo, new RecordItemIndex(7));
            Validate.Exists(repo.Filter.AndInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Filter.And' at 30;12.", repo.Filter.AndInfo, new RecordItemIndex(8));
            repo.Filter.And.Click("30;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't' with focus on 'Filter.And'.", repo.Filter.AndInfo, new RecordItemIndex(9));
            repo.Filter.And.PressKeys("t", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Filter.Text'.", repo.Filter.TextInfo, new RecordItemIndex(10));
            Validate.Exists(repo.Filter.TextInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Filter.Text' at 57;10.", repo.Filter.TextInfo, new RecordItemIndex(11));
            repo.Filter.Text.Click("57;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AccNumber' with focus on 'Filter.Text'.", repo.Filter.TextInfo, new RecordItemIndex(12));
            repo.Filter.Text.PressKeys(AccNumber, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Filter.Text'.", repo.Filter.TextInfo, new RecordItemIndex(13));
            repo.Filter.Text.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='OK') on item 'Filter.ButtonOK'.", repo.Filter.ButtonOKInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.Filter.ButtonOKInfo, "Text", "OK");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Filter.ButtonOK' at 69;10.", repo.Filter.ButtonOKInfo, new RecordItemIndex(15));
            repo.Filter.ButtonOK.Click("69;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.RowRow'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.RowRowInfo, new RecordItemIndex(16));
            Validate.Exists(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.RowRowInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.RowRow' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.RowRowInfo, new RecordItemIndex(17));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.RowRow.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Open Sale...') on item 'Kclient.OpenSale'.", repo.Kclient.OpenSaleInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.Kclient.OpenSaleInfo, "Text", "Open Sale...");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Kclient.OpenSale' at 64;12.", repo.Kclient.OpenSaleInfo, new RecordItemIndex(19));
            repo.Kclient.OpenSale.Click("64;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(20));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Success, "User", "Sales Order Lines Before Deletion", repo.SalesOrderProcessingCreditNoteCR.Self, false, new RecordItemIndex(21));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Cancel') on item 'SalesOrderProcessingCreditNoteCR.Cancel'.", repo.SalesOrderProcessingCreditNoteCR.CancelInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.SalesOrderProcessingCreditNoteCR.CancelInfo, "Text", "Cancel");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SalesOrderProcessingCreditNoteCR.Cancel' at 25;16.", repo.SalesOrderProcessingCreditNoteCR.CancelInfo, new RecordItemIndex(23));
            repo.SalesOrderProcessingCreditNoteCR.Cancel.Click("25;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Delete lines') on item 'SalesOrder193892HJIlford.DeleteLines'.", repo.SalesOrder193892HJIlford.DeleteLinesInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.SalesOrder193892HJIlford.DeleteLinesInfo, "Text", "Delete lines");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SalesOrder193892HJIlford.DeleteLines' at 37;10.", repo.SalesOrder193892HJIlford.DeleteLinesInfo, new RecordItemIndex(25));
            repo.SalesOrder193892HJIlford.DeleteLines.Click("37;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='OK') on item 'ActionSalesOrderSL17707.ButtonOK'.", repo.ActionSalesOrderSL17707.ButtonOKInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.ActionSalesOrderSL17707.ButtonOKInfo, "Text", "OK");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ActionSalesOrderSL17707.ButtonOK' at 45;7.", repo.ActionSalesOrderSL17707.ButtonOKInfo, new RecordItemIndex(27));
            repo.ActionSalesOrderSL17707.ButtonOK.Click("45;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(28));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Exit') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo, "Text", "Exit");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo, new RecordItemIndex(30));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
