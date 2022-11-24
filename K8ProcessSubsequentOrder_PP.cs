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
    ///The K8ProcessSubsequentOrder_PP recording.
    /// </summary>
    [TestModule("8efb12e4-5242-4400-a72b-455f15424252", ModuleType.Recording, 1)]
    public partial class K8ProcessSubsequentOrder_PP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the K8_UK_SOP_RegressionRepository repository.
        /// </summary>
        public static K8_UK_SOP_RegressionRepository repo = K8_UK_SOP_RegressionRepository.Instance;

        static K8ProcessSubsequentOrder_PP instance = new K8ProcessSubsequentOrder_PP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K8ProcessSubsequentOrder_PP()
        {
            RequiredDate = "31122019";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K8ProcessSubsequentOrder_PP Instance
        {
            get { return instance; }
        }

#region Variables

        string _RequiredDate;

        /// <summary>
        /// Gets or sets the value of variable RequiredDate.
        /// </summary>
        [TestVariable("523e8d23-4724-4192-bbd6-6c93802dda64")]
        public string RequiredDate
        {
            get { return _RequiredDate; }
            set { _RequiredDate = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3SalesOrderProcessingD.Required'.", repo.Ql1054K8QA3SalesOrderProcessingD.RequiredInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Ql1054K8QA3SalesOrderProcessingD.RequiredInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ql1054K8QA3SalesOrderProcessingD.Required' at Center.", repo.Ql1054K8QA3SalesOrderProcessingD.RequiredInfo, new RecordItemIndex(1));
            repo.Ql1054K8QA3SalesOrderProcessingD.Required.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Ql1054K8QA3SalesOrderProcessingD.Required' at Center.", repo.Ql1054K8QA3SalesOrderProcessingD.RequiredInfo, new RecordItemIndex(2));
            repo.Ql1054K8QA3SalesOrderProcessingD.Required.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RequiredDate' with focus on 'Ql1054K8QA3SalesOrderProcessingD.Required'.", repo.Ql1054K8QA3SalesOrderProcessingD.RequiredInfo, new RecordItemIndex(3));
            repo.Ql1054K8QA3SalesOrderProcessingD.Required.PressKeys(RequiredDate, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Process') on item 'Ql1054K8QA3SalesOrderProcessingD.Process'.", repo.Ql1054K8QA3SalesOrderProcessingD.ProcessInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Ql1054K8QA3SalesOrderProcessingD.ProcessInfo, "Text", "Process");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ql1054K8QA3SalesOrderProcessingD.Process' at Center.", repo.Ql1054K8QA3SalesOrderProcessingD.ProcessInfo, new RecordItemIndex(5));
            repo.Ql1054K8QA3SalesOrderProcessingD.Process.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='&No') on item 'SalesOrder193931HJIlford.ButtonNo'.", repo.SalesOrder193931HJIlford.ButtonNoInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.SalesOrder193931HJIlford.ButtonNoInfo, "Text", "&No");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SalesOrder193931HJIlford.ButtonNo' at Center.", repo.SalesOrder193931HJIlford.ButtonNoInfo, new RecordItemIndex(8));
            repo.SalesOrder193931HJIlford.ButtonNo.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='OK') on item 'ActionSalesOrderSL17707.ButtonOK'.", repo.ActionSalesOrderSL17707.ButtonOKInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ActionSalesOrderSL17707.ButtonOKInfo, "Text", "OK");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ActionSalesOrderSL17707.ButtonOK' at Center.", repo.ActionSalesOrderSL17707.ButtonOKInfo, new RecordItemIndex(11));
            repo.ActionSalesOrderSL17707.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
