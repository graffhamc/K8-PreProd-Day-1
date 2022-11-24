﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace K8_UK_PP_Regression
{
    public partial class K8BookInStock_PP
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void LoopForOrder()
        {
        	while (!repo.Ql1054K8QA3SalesOrderProcessingD.RowTextInfo.Exists(3000))
	         {
        	       	repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber.DoubleClick();
        	        Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
        	       	Keyboard.Press("Ctlr+A");
        	        repo.Ql1054K8QA3SalesOrderProcessingD.OrderNumber.PressKeys("BI", 100);
	    	 }
        }

    }
}
