﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        #region Properties
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        
        public UIMainWindowWindow1 UIMainWindowWindow1
        {
            get
            {
                if ((this.mUIMainWindowWindow1 == null))
                {
                    this.mUIMainWindowWindow1 = new UIMainWindowWindow1();
                }
                return this.mUIMainWindowWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIMainWindowWindow mUIMainWindowWindow;
        
        private UIMainWindowWindow1 mUIMainWindowWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfCheckBox UICheckBoxCheckBox
        {
            get
            {
                if ((this.mUICheckBoxCheckBox == null))
                {
                    this.mUICheckBoxCheckBox = new WpfCheckBox(this);
                    #region Search Criteria
                    this.mUICheckBoxCheckBox.SearchProperties[WpfCheckBox.PropertyNames.AutomationId] = "checkBox1";
                    this.mUICheckBoxCheckBox.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUICheckBoxCheckBox;
            }
        }
        
        public WpfButton UIStartButton
        {
            get
            {
                if ((this.mUIStartButton == null))
                {
                    this.mUIStartButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "button1";
                    this.mUIStartButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIStartButton;
            }
        }
        
        public WpfButton UIStartButton1
        {
            get
            {
                if ((this.mUIStartButton1 == null))
                {
                    this.mUIStartButton1 = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStartButton1.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
                    this.mUIStartButton1.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIStartButton1;
            }
        }
        #endregion
        
        #region Fields
        private WpfCheckBox mUICheckBoxCheckBox;
        
        private WpfButton mUIStartButton;
        
        private WpfButton mUIStartButton1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMainWindowWindow1 : WinWindow
    {
        
        public UIMainWindowWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
}
