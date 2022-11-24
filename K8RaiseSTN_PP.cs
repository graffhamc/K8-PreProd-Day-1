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
    ///The K8RaiseSTN_PP recording.
    /// </summary>
    [TestModule("2d16614f-982c-4643-a6ae-485d001c8415", ModuleType.Recording, 1)]
    public partial class K8RaiseSTN_PP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the K8_UK_SOP_RegressionRepository repository.
        /// </summary>
        public static K8_UK_SOP_RegressionRepository repo = K8_UK_SOP_RegressionRepository.Instance;

        static K8RaiseSTN_PP instance = new K8RaiseSTN_PP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K8RaiseSTN_PP()
        {
            ReceivingDepot = "IBDD02";
            Product = "RKC0070";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K8RaiseSTN_PP Instance
        {
            get { return instance; }
        }

#region Variables

        string _ReceivingDepot;

        /// <summary>
        /// Gets or sets the value of variable ReceivingDepot.
        /// </summary>
        [TestVariable("9fcd76f9-c289-4f23-ae9d-97e889b83bbd")]
        public string ReceivingDepot
        {
            get { return _ReceivingDepot; }
            set { _ReceivingDepot = value; }
        }

        string _Product;

        /// <summary>
        /// Gets or sets the value of variable Product.
        /// </summary>
        [TestVariable("e60682ad-20da-440f-a10a-ac5dab88ce71")]
        public string Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Row_1.
        /// </summary>
        [TestVariable("5f38ffb6-4ecf-4081-9716-91076fe85434")]
        public string Row_1
        {
            get { return repo.Row_1; }
            set { repo.Row_1 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3SalesOrderProcessingD.OrderNumber'.", repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumberInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumberInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Ql1054K8QA3SalesOrderProcessingD.OrderNumber' at 23;9.", repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumberInfo, new RecordItemIndex(1));
            repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber.DoubleClick("23;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'bt' with focus on 'Ql1054K8QA3SalesOrderProcessingD.OrderNumber'.", repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumberInfo, new RecordItemIndex(2));
            repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber.PressKeys("bt", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3SalesOrderProcessingD.OrderNumber2'.", repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber2Info, new RecordItemIndex(3));
            Validate.Exists(repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber2Info);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Ql1054K8QA3SalesOrderProcessingD.OrderNumber2'.", repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber2Info, new RecordItemIndex(4));
            repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber2.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3SalesOrderProcessingD.STNAccountNo'.", repo.Ql1054K8QA3SalesOrderProcessingD.STNAccountNoInfo, new RecordItemIndex(5));
            Validate.Exists(repo.Ql1054K8QA3SalesOrderProcessingD.STNAccountNoInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ql1054K8QA3SalesOrderProcessingD.STNAccountNo' at Center.", repo.Ql1054K8QA3SalesOrderProcessingD.STNAccountNoInfo, new RecordItemIndex(6));
            repo.Ql1054K8QA3SalesOrderProcessingD.STNAccountNo.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ReceivingDepot' with focus on 'Ql1054K8QA3SalesOrderProcessingD.STNAccountNo'.", repo.Ql1054K8QA3SalesOrderProcessingD.STNAccountNoInfo, new RecordItemIndex(7));
            repo.Ql1054K8QA3SalesOrderProcessingD.STNAccountNo.PressKeys(ReceivingDepot, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Ql1054K8QA3SalesOrderProcessingD.STNAccountNo'.", repo.Ql1054K8QA3SalesOrderProcessingD.STNAccountNoInfo, new RecordItemIndex(8));
            repo.Ql1054K8QA3SalesOrderProcessingD.STNAccountNo.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3SalesOrderProcessingD.RowRow.ProductCode'.", repo.Ql1054K8QA3SalesOrderProcessingD.RowRow.ProductCodeInfo, new RecordItemIndex(9));
            Validate.Exists(repo.Ql1054K8QA3SalesOrderProcessingD.RowRow.ProductCodeInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ql1054K8QA3SalesOrderProcessingD.RowRow.ProductCode' at Center.", repo.Ql1054K8QA3SalesOrderProcessingD.RowRow.ProductCodeInfo, new RecordItemIndex(10));
            repo.Ql1054K8QA3SalesOrderProcessingD.RowRow.ProductCode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3SalesOrderProcessingD.RowText'.", repo.Ql1054K8QA3SalesOrderProcessingD.RowTextInfo, new RecordItemIndex(11));
            Validate.Exists(repo.Ql1054K8QA3SalesOrderProcessingD.RowTextInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Product' with focus on 'Ql1054K8QA3SalesOrderProcessingD.RowText'.", repo.Ql1054K8QA3SalesOrderProcessingD.RowTextInfo, new RecordItemIndex(12));
            repo.Ql1054K8QA3SalesOrderProcessingD.RowText.PressKeys(Product, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Ql1054K8QA3SalesOrderProcessingD.RowText'.", repo.Ql1054K8QA3SalesOrderProcessingD.RowTextInfo, new RecordItemIndex(13));
            repo.Ql1054K8QA3SalesOrderProcessingD.RowText.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
