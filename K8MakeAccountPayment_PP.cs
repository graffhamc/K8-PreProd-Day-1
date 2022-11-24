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
    ///The K8MakeAccountPayment_PP recording.
    /// </summary>
    [TestModule("5c099714-4904-4a28-a1c1-c6ccf9a97b56", ModuleType.Recording, 1)]
    public partial class K8MakeAccountPayment_PP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the K8_UK_SOP_RegressionRepository repository.
        /// </summary>
        public static K8_UK_SOP_RegressionRepository repo = K8_UK_SOP_RegressionRepository.Instance;

        static K8MakeAccountPayment_PP instance = new K8MakeAccountPayment_PP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K8MakeAccountPayment_PP()
        {
            TillNumber = "1";
            CashType = "Q";
            Value = "1.50";
            AccountNumber = "1100000498";
            Reference = "Reference";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K8MakeAccountPayment_PP Instance
        {
            get { return instance; }
        }

#region Variables

        string _TillNumber;

        /// <summary>
        /// Gets or sets the value of variable TillNumber.
        /// </summary>
        [TestVariable("b70911f7-494f-404f-8d41-81a0d0e625ef")]
        public string TillNumber
        {
            get { return _TillNumber; }
            set { _TillNumber = value; }
        }

        string _CashType;

        /// <summary>
        /// Gets or sets the value of variable CashType.
        /// </summary>
        [TestVariable("eb094287-966d-4857-93aa-066e57e0ccb6")]
        public string CashType
        {
            get { return _CashType; }
            set { _CashType = value; }
        }

        string _Value;

        /// <summary>
        /// Gets or sets the value of variable Value.
        /// </summary>
        [TestVariable("fdc74412-2b31-406e-acfa-fe79310d8937")]
        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        string _AccountNumber;

        /// <summary>
        /// Gets or sets the value of variable AccountNumber.
        /// </summary>
        [TestVariable("7a6a512f-ebe3-4ee8-b5bc-fb8a3e1d1436")]
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Reference.
        /// </summary>
        [TestVariable("c570d60e-ec05-44e7-9683-d5940bff7054")]
        public string Reference
        {
            get { return repo.Reference; }
            set { repo.Reference = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3SalesOrderProcessingD.Tools'.", repo.Ql1054K8QA3SalesOrderProcessingD.ToolsInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Ql1054K8QA3SalesOrderProcessingD.ToolsInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ql1054K8QA3SalesOrderProcessingD.Tools' at Center.", repo.Ql1054K8QA3SalesOrderProcessingD.ToolsInfo, new RecordItemIndex(1));
            repo.Ql1054K8QA3SalesOrderProcessingD.Tools.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Kclient.MakeAccountPaymentSHIFTPlusF10' at 86;14.", repo.Kclient.MakeAccountPaymentSHIFTPlusF10Info, new RecordItemIndex(2));
            repo.Kclient.MakeAccountPaymentSHIFTPlusF10.Click("86;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CashbookCustomerReceipts.TillNumber'.", repo.CashbookCustomerReceipts.TillNumberInfo, new RecordItemIndex(3));
            Validate.Exists(repo.CashbookCustomerReceipts.TillNumberInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CashbookCustomerReceipts.TillNumber' at 55;9.", repo.CashbookCustomerReceipts.TillNumberInfo, new RecordItemIndex(4));
            repo.CashbookCustomerReceipts.TillNumber.DoubleClick("55;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TillNumber' with focus on 'CashbookCustomerReceipts.TillNumber'.", repo.CashbookCustomerReceipts.TillNumberInfo, new RecordItemIndex(5));
            repo.CashbookCustomerReceipts.TillNumber.PressKeys(TillNumber, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'CashbookCustomerReceipts.TillNumber'.", repo.CashbookCustomerReceipts.TillNumberInfo, new RecordItemIndex(6));
            repo.CashbookCustomerReceipts.TillNumber.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='&Yes') on item 'ChangeTill.ButtonYes'.", repo.ChangeTill.ButtonYesInfo, new RecordItemIndex(7));
            //Validate.AttributeEqual(repo.ChangeTill.ButtonYesInfo, "Text", "&Yes");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChangeTill.ButtonYes' at Center.", repo.ChangeTill.ButtonYesInfo, new RecordItemIndex(8));
            //repo.ChangeTill.ButtonYes.Click();
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CashbookCustomerReceipts.Text2'.", repo.CashbookCustomerReceipts.Text2Info, new RecordItemIndex(9));
            Validate.Exists(repo.CashbookCustomerReceipts.Text2Info);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Text2' at Center.", repo.CashbookCustomerReceipts.Text2Info, new RecordItemIndex(10));
            repo.CashbookCustomerReceipts.Text2.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AccountNumber' with focus on 'CashbookCustomerReceipts.Text2'.", repo.CashbookCustomerReceipts.Text2Info, new RecordItemIndex(11));
            repo.CashbookCustomerReceipts.Text2.PressKeys(AccountNumber, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'CashbookCustomerReceipts.Text2'.", repo.CashbookCustomerReceipts.Text2Info, new RecordItemIndex(12));
            repo.CashbookCustomerReceipts.Text2.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CashbookCustomerReceipts.Table.Type'.", repo.CashbookCustomerReceipts.Table.TypeInfo, new RecordItemIndex(13));
            Validate.Exists(repo.CashbookCustomerReceipts.Table.TypeInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Table.Type' at Center.", repo.CashbookCustomerReceipts.Table.TypeInfo, new RecordItemIndex(14));
            repo.CashbookCustomerReceipts.Table.Type.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CashType' with focus on 'CashbookCustomerReceipts.Text'.", repo.CashbookCustomerReceipts.TextInfo, new RecordItemIndex(15));
            repo.CashbookCustomerReceipts.Text.PressKeys(CashType, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CashbookCustomerReceipts.Table.Value'.", repo.CashbookCustomerReceipts.Table.ValueInfo, new RecordItemIndex(16));
            Validate.Exists(repo.CashbookCustomerReceipts.Table.ValueInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Table.Value' at Center.", repo.CashbookCustomerReceipts.Table.ValueInfo, new RecordItemIndex(17));
            repo.CashbookCustomerReceipts.Table.Value.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Value' with focus on 'CashbookCustomerReceipts.Text'.", repo.CashbookCustomerReceipts.TextInfo, new RecordItemIndex(18));
            repo.CashbookCustomerReceipts.Text.PressKeys(Value, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CashbookCustomerReceipts.Table.Reference'.", repo.CashbookCustomerReceipts.Table.ReferenceInfo, new RecordItemIndex(19));
            Validate.Exists(repo.CashbookCustomerReceipts.Table.ReferenceInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Table.Reference' at Center.", repo.CashbookCustomerReceipts.Table.ReferenceInfo, new RecordItemIndex(20));
            repo.CashbookCustomerReceipts.Table.Reference.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Reference' with focus on 'CashbookCustomerReceipts.Text'.", repo.CashbookCustomerReceipts.TextInfo, new RecordItemIndex(21));
            repo.CashbookCustomerReceipts.Text.PressKeys(Reference, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'CashbookCustomerReceipts.Text'.", repo.CashbookCustomerReceipts.TextInfo, new RecordItemIndex(22));
            repo.CashbookCustomerReceipts.Text.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CashbookCustomerReceipts.Submit'.", repo.CashbookCustomerReceipts.SubmitInfo, new RecordItemIndex(23));
            Validate.Exists(repo.CashbookCustomerReceipts.SubmitInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Submit' at Center.", repo.CashbookCustomerReceipts.SubmitInfo, new RecordItemIndex(24));
            repo.CashbookCustomerReceipts.Submit.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SalesOrderProcessing.ButtonOK'.", repo.SalesOrderProcessing.ButtonOKInfo, new RecordItemIndex(25));
            Validate.Exists(repo.SalesOrderProcessing.ButtonOKInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SalesOrderProcessing.ButtonOK' at Center.", repo.SalesOrderProcessing.ButtonOKInfo, new RecordItemIndex(26));
            repo.SalesOrderProcessing.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CashbookCustomerReceipts.Exit'.", repo.CashbookCustomerReceipts.ExitInfo, new RecordItemIndex(27));
            Validate.Exists(repo.CashbookCustomerReceipts.ExitInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CashbookCustomerReceipts.Exit' at Center.", repo.CashbookCustomerReceipts.ExitInfo, new RecordItemIndex(28));
            repo.CashbookCustomerReceipts.Exit.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(29));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
