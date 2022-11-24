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
    ///The K8OpenSalesOrder_PP recording.
    /// </summary>
    [TestModule("d33cb2ca-89a1-4b43-935b-1742ee20bef1", ModuleType.Recording, 1)]
    public partial class K8OpenSalesOrder_PP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the K8_UK_SOP_RegressionRepository repository.
        /// </summary>
        public static K8_UK_SOP_RegressionRepository repo = K8_UK_SOP_RegressionRepository.Instance;

        static K8OpenSalesOrder_PP instance = new K8OpenSalesOrder_PP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K8OpenSalesOrder_PP()
        {
            OrderNumber = "sl";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K8OpenSalesOrder_PP Instance
        {
            get { return instance; }
        }

#region Variables

        string _OrderNumber;

        /// <summary>
        /// Gets or sets the value of variable OrderNumber.
        /// </summary>
        [TestVariable("b762b899-5734-441a-8755-ef9dad6c1166")]
        public string OrderNumber
        {
            get { return _OrderNumber; }
            set { _OrderNumber = value; }
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
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$OrderNumber' with focus on 'Ql1054K8QA3SalesOrderProcessingD.OrderNumber'.", repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumberInfo, new RecordItemIndex(2));
            repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber.PressKeys(OrderNumber, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Ql1054K8QA3SalesOrderProcessingD.OrderNumber2'.", repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber2Info, new RecordItemIndex(3));
            Validate.Exists(repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber2Info);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Ql1054K8QA3SalesOrderProcessingD.OrderNumber2'.", repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber2Info, new RecordItemIndex(4));
            repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber2.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
