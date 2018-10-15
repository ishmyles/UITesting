namespace CodedUITestProject1
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {
        public UIMap()
        {
            this.UIMainWindowWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }
        /// <summary>
        /// Blah blah blah
        /// </summary>
        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\Desktop\UITests\UITesting\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleAppTestParams.UIMainWindowWindowExePath, this.SimpleAppTestParams.UIMainWindowWindowAlternateExePath);

            // Click 'CheckBox' check box
            Mouse.Click(uICheckBoxCheckBox, new Point(9, 5));

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(57, 12));
            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(22, 8));
        }

        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }

        private SimpleAppTestParams mSimpleAppTestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleAppTestParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Desktop\UITests\UITesting\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\STUDENT\\Desktop\\UITests\\UITesting\\SimpleWPFApp\\bin\\Debug\\SimpleWPFApp.ex" +
            "e";

        /// <summary>
        /// Launch '%USERPROFILE%\Desktop\UITests\UITesting\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\Desktop\\UITests\\UITesting\\SimpleWPFApp\\bin\\Debug\\SimpleWPFApp.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
