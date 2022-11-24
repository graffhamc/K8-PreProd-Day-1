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
    ///The K8DeleteSupersedeRecord_PP recording.
    /// </summary>
    [TestModule("19a3cb34-5174-4cb8-b581-0634bd3e217b", ModuleType.Recording, 1)]
    public partial class K8DeleteSupersedeRecord_PP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the K8_UK_SOP_RegressionRepository repository.
        /// </summary>
        public static K8_UK_SOP_RegressionRepository repo = K8_UK_SOP_RegressionRepository.Instance;

        static K8DeleteSupersedeRecord_PP instance = new K8DeleteSupersedeRecord_PP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K8DeleteSupersedeRecord_PP()
        {
            FromPart = "DCK5541";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K8DeleteSupersedeRecord_PP Instance
        {
            get { return instance; }
        }

#region Variables

        string _FromPart;

        /// <summary>
        /// Gets or sets the value of variable FromPart.
        /// </summary>
        [TestVariable("3dfbaf29-5275-4898-a746-1db1a68f82dd")]
        public string FromPart
        {
            get { return _FromPart; }
            set { _FromPart = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Central Master Files') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFiles'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFilesInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFilesInfo, "Text", "Central Master Files");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFiles' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFilesInfo, new RecordItemIndex(2));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFiles.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Product File') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFile'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFileInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFileInfo, "Text", "Product File");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFile' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFileInfo, new RecordItemIndex(4));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFile.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Supersede Products') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.SupersedeProducts'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.SupersedeProductsInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.SupersedeProductsInfo, "Text", "Supersede Products");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.SupersedeProducts' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.SupersedeProductsInfo, new RecordItemIndex(6));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.SupersedeProducts.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='One-To-One') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.OneToOne'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.OneToOneInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.OneToOneInfo, "Text", "One-To-One");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.OneToOne' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.OneToOneInfo, new RecordItemIndex(8));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.OneToOne.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductCode'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductCodeInfo, new RecordItemIndex(9));
            Validate.Exists(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductCodeInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductCode' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductCodeInfo, new RecordItemIndex(10));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductCode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2Info, new RecordItemIndex(11));
            Validate.Exists(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2Info, new RecordItemIndex(12));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FromPart' with focus on 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2Info, new RecordItemIndex(13));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2.PressKeys(FromPart, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2Info, new RecordItemIndex(14));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Text2.PressKeys("{Tab}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(15));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SupersedeProducts.ButtonYes'.", repo.SupersedeProducts.ButtonYesInfo, new RecordItemIndex(16));
            Validate.Exists(repo.SupersedeProducts.ButtonYesInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SupersedeProducts.ButtonYes' at Center.", repo.SupersedeProducts.ButtonYesInfo, new RecordItemIndex(17));
            repo.SupersedeProducts.ButtonYes.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(18));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Delete'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.DeleteInfo, new RecordItemIndex(19));
            Validate.Exists(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.DeleteInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Delete' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.DeleteInfo, new RecordItemIndex(20));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Delete.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(1000, false);
            
            Report.Screenshot(ReportLevel.Success, "User", "Delete Supersede Record", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Self, false, new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DeleteSupersession.ButtonYes'.", repo.DeleteSupersession.ButtonYesInfo, new RecordItemIndex(23));
            Validate.Exists(repo.DeleteSupersession.ButtonYesInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DeleteSupersession.ButtonYes' at Center.", repo.DeleteSupersession.ButtonYesInfo, new RecordItemIndex(24));
            repo.DeleteSupersession.ButtonYes.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(25));
            Delay.Duration(15000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo, new RecordItemIndex(26));
            Validate.Exists(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ExitInfo, new RecordItemIndex(27));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.Exit.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(28));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Product File') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFile'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFileInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFileInfo, "Text", "Product File");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFile' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFileInfo, new RecordItemIndex(30));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.ProductFile.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Central Master Files') on item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFiles'.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFilesInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFilesInfo, "Text", "Central Master Files");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFiles' at Center.", repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFilesInfo, new RecordItemIndex(32));
            repo.K8UKPPD1Sl1071K8UKPPDHowdensK8HJ0.CentralMasterFiles.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
