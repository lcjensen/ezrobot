using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wizardControl
{
    public partial class Form1 : EZ_Builder.UCForms.FormPluginMaster
    {
        int intCount = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// 
        /// This method is called by EZ-Builder when it requests the configuration for your  plugin. 
        /// EZ-Builder will request the configuration when the control is created and when the project is saved.
        /// The data set in this configuration will be serialized and saved in the EZ-Builder user's project.
        /// Custom data may be stored in the STORAGE dictionary.
        /// 
        public override EZ_Builder.Config.Sub.PluginV1 GetConfiguration()
        {

            return base.GetConfiguration();
        }

        /// 
        /// This method is called by EZ-Builder when a project is loaded or when the control is added to a project.
        /// Set your default data in here!
        /// The configuration from the user's project file will be set using this method.
        /// *Note: The  plugin must call Base.SetConfiguration(cf) in your override. See the example!
        /// Also note that this is a good place to ensure all required configuration data exists.
        /// In the case of a newer version of your  plugin where different configuration data may be required outside of the users configuration file, set it here.
        /// 
        public override void SetConfiguration(EZ_Builder.Config.Sub.PluginV1 cf)
        {

            base.SetConfiguration(cf);
        }

        /// 
        /// This method is called by EZ-Builder when another control sends a command to this control using the EZ-Script  ControlCommand() function.
        /// The available  ControlCommand() functions for this control should be returned in the GetSupportedControlCommandsMethodsForSlave() override.
        /// 
        public override void SendCommand(string windowCommand, params string[] values)
        {
            if (windowCommand.Equals("Intervention", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetBackColor(btnInter, Color.Red);

            }

            else if (windowCommand.Equals("WaterIntake", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetBackColor(lblWatIn, Color.Red);
                EZ_Builder.Invokers.SetBackColor(waterIntake, Color.Red);
            }
            else if (windowCommand.Equals("WaterGlass", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetBackColor(lblGlas, Color.Red);
                EZ_Builder.Invokers.SetBackColor(ddGlas, Color.Red);
            }
            else if (windowCommand.Equals("yesno", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetBackColor(btnYes, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnNo, Color.Red);
            }
            else
            {
                base.SendCommand(windowCommand, values);
            }

        }

        /// 
        /// This method is called by EZ-Builder for the  Cheat Sheet to receive all available  ControlCommand() syntax for this control.
        /// When the  ControlCommand() is called for this function, see the SendCommand() override.
        /// 
        public override object[] GetSupportedControlCommands()
        {
            List<string> cmds = new List<string>();

            cmds.Add("Intervention");
            cmds.Add("WaterIntake");
            cmds.Add("WaterGlass");
            cmds.Add("yesno");

            //cmds.Add("Intervention");

            return cmds.ToArray();

            //return base.GetSupportedControlCommands();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if(txtPID.Text != "")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$PID", txtPID.Text);
            }
            else MessageBox.Show(string.Format("No PID supplied"));


        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            intCount++;
            EZ_Builder.Scripting.VariableManager.SetVariable("$intervention", intCount);
            EZ_Builder.Invokers.SetBackColor(btnInter, Color.LightGray);
        }


        private void ddCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddCondition.Text == "High")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$awareCond", "high");
            }

            if (ddCondition.Text == "Low")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$awareCond", "low");
            }
        }

        private void ddCondition2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddCondition2.Text == "Incremental")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$conditionInc", "Inc");
            }

            if (ddCondition2.Text == "Non-Incremental")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$conditionInc", "NoInc");
            }

        }


        private void waterIntake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(waterIntake.Text == "High")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$waterintake", "high");
            }

            else if(waterIntake.Text == "Low")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$waterintake", "low");
            }
            EZ_Builder.Invokers.SetBackColor(lblWatIn, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(waterIntake, Color.LightGray);

        }

        private void boxPre_Enter(object sender, EventArgs e)
        {

        }

        private void ddWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddWeather.Text == "Great")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$weather", "great");
            }

            if (ddWeather.Text == "Bad")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$weather", "bad");
            }
        }

        private void ddGlas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddGlas.Text == "Untouched")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$glasWater", "untouched");
            }

            else if (ddGlas.Text == "Full")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$glasWater", "full");
            }
            else if (ddGlas.Text == "Halfempty")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$glasWater", "halfempty");
            }
            else if (ddGlas.Text == "Empty")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$glasWater", "empty");
            }
            EZ_Builder.Invokers.SetBackColor(lblGlas, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(ddGlas, Color.LightGray);

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$yesno", 1);
                EZ_Builder.Invokers.SetBackColor(btnYes, Color.LightGray);
                EZ_Builder.Invokers.SetBackColor(btnNo, Color.LightGray);
            }
        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$yesno", 0);
                EZ_Builder.Invokers.SetBackColor(btnYes, Color.LightGray);
                EZ_Builder.Invokers.SetBackColor(btnNo, Color.LightGray);
            }

        }
    }
}