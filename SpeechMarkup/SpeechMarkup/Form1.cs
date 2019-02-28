using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SpeechMarkup
{
    public partial class Form1 : EZ_Builder.UCForms.FormPluginMaster
    {
       // EZ_Builder.Scripting.Executor _executor;

        SpeechSynthesizer synth = new SpeechSynthesizer();
        int intCount = 0;

        public Form1()
        {
            InitializeComponent();
            // btnSpeak.Click += new EventHandler(btnSpeak_Click);

            // _executor = new EZ_Builder.Scripting.Executor();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // Intercept all unknown functions called from any ez-script globally.
            // If a function is called that doesn't exist in the ez-script library, this event will execute
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Disconnect from the function event
        }

        public override void SendCommand(string windowCommand, params string[] values)
        {
            if (windowCommand.Equals("Intervention", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetBackColor(bntInterv, Color.Red);
            }
            else if (windowCommand.Equals("Correct", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
            }
            else if (windowCommand.Equals("Incorrect", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetText(btnIncorrect, "Incorrect");
            }

            else if (windowCommand.Equals("Agreement", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Yes");
                EZ_Builder.Invokers.SetText(btnIncorrect, "No");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
            }

            else if (windowCommand.Equals("Social", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Social");
                EZ_Builder.Invokers.SetText(btnIncorrect, "Non-social");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
            }
            else if (windowCommand.Equals("Feedback1", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "sticks out");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect3, "other way");
                EZ_Builder.Invokers.SetText(btnIncorrect4, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.Red);
            }
            else if (windowCommand.Equals("Feedback2", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
            }
            else if (windowCommand.Equals("Feedback3", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "4 dots on one side");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect3, "say yes");
                EZ_Builder.Invokers.SetText(btnIncorrect4, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.Red);
            }
            else if (windowCommand.Equals("Feedback4", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "on edges");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect3, "say yes");
                EZ_Builder.Invokers.SetText(btnIncorrect4, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.Red);
            }
            else if (windowCommand.Equals("Feedback5", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "pieces not parallel");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "edges point inside");
                EZ_Builder.Invokers.SetText(btnIncorrect3, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect4, "other two parts");
                EZ_Builder.Invokers.SetText(btnIncorrect5, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.Red);
            }
            else if (windowCommand.Equals("Feedback6", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "asymmetrical slopes");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "wrong sides");
                EZ_Builder.Invokers.SetText(btnIncorrect3, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect4, "say yes");
                EZ_Builder.Invokers.SetText(btnIncorrect5, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.Red);
            }

            else if (windowCommand.Equals("Feedback7", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "wrong dots");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect3, "say yes");
                EZ_Builder.Invokers.SetText(btnIncorrect4, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.Red);
            }
            else if (windowCommand.Equals("Feedback8", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "piece sticks out");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "mouth wrong direction");
                EZ_Builder.Invokers.SetText(btnIncorrect3, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect4, "say yes");
                EZ_Builder.Invokers.SetText(btnIncorrect5, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.Red);
            }
            else if (windowCommand.Equals("Feedback9", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "Correct");
                EZ_Builder.Invokers.SetText(btnIncorrect, "more than 1 dot");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "feet wrong direction");
                EZ_Builder.Invokers.SetText(btnIncorrect3, "bricks on top");
                EZ_Builder.Invokers.SetText(btnIncorrect4, "repeat");
                EZ_Builder.Invokers.SetText(btnIncorrect5, "wrong undo");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.Red);
            }
            else if (windowCommand.Equals("Feedback9_1", StringComparison.InvariantCultureIgnoreCase))
            {
                EZ_Builder.Invokers.SetText(btnCorrect, "frog");
                EZ_Builder.Invokers.SetText(btnIncorrect, "other");
                EZ_Builder.Invokers.SetText(btnIncorrect2, "don't know");
                EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.Red);
                EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.Red);
            }
            


            else
            {
                base.SendCommand(windowCommand, values);
            }

        }

        public override object[] GetSupportedControlCommands()
        {
            List<string> cmds = new List<string>();

            cmds.Add("Intervention");
            cmds.Add("Correct");
            cmds.Add("Incorrect");
            cmds.Add("WaterIntake");
            cmds.Add("WaterGlas");
            cmds.Add("Agreement");
            cmds.Add("Social");
            cmds.Add("Feedback1");
            cmds.Add("Feedback2");
            cmds.Add("Feedback3");
            cmds.Add("Feedback4");
            cmds.Add("Feedback5");
            cmds.Add("Feedback6");
            cmds.Add("Feedback7");
            cmds.Add("Feedback8");
            cmds.Add("Feedback9");
            cmds.Add("Feedback9_1");

            return cmds.ToArray();

        }


        private void btnSpeak_Click(object sender, EventArgs e)
        {
            /*
             PromptBuilder pb = new PromptBuilder();
             pb.AppendText(textBox1.Text);
             synth.Speak(pb);*/
            
        }

        private void btnInterv_Click(object sender, EventArgs e)
        {
            intCount++;
            EZ_Builder.Scripting.VariableManager.SetVariable("$intervention", intCount);
            EZ_Builder.Invokers.SetBackColor(bntInterv, Color.LightGray);

        }

        private void ddWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddWeather.Text == "Great")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$weather", "weatherGood");
            }

            if (ddWeather.Text == "Bad")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$weather", "weatherBad");
            }
        }

        private void ddCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddCondition.Text == "Simple")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$condition", 1);
            }

            if (ddCondition.Text == "Metaphorical")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$condition", 2);
            }
        }


        private void AwareCondBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AwareCondBox.Text == "Aware")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$awareCond", 1);
            }

            if (AwareCondBox.Text == "NotAware")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$awareCond", 2);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtPID.Text != "")
            {
                EZ_Builder.Scripting.VariableManager.SetVariable("$PID", txtPID.Text);
            }
            else MessageBox.Show(string.Format("No PID supplied"));

            if (ddWeather.Text == "")
            {
                MessageBox.Show(string.Format("No weather supplied"));
            }

            if (ddCondition.Text == "")
            {
                MessageBox.Show(string.Format("No condition supplied"));
            }

                EZ_Builder.Scripting.VariableManager.SetVariable("$intervention", 1);
                EZ_Builder.Scripting.VariableManager.SetVariable("$correct", 1);
                EZ_Builder.Scripting.VariableManager.SetVariable("$incorrect", 1);
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            intCount++;
            EZ_Builder.Scripting.VariableManager.SetVariable("$cor", intCount);
            EZ_Builder.Scripting.VariableManager.SetVariable("$correct", 1);
            EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.LightGray);
            EZ_Builder.Invokers.SetText(btnCorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect2, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect3, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect4, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect5, " ");



        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            intCount++;
            EZ_Builder.Scripting.VariableManager.SetVariable("$cor", intCount);
            EZ_Builder.Scripting.VariableManager.SetVariable("$incorrect", 1);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.LightGray);
            EZ_Builder.Invokers.SetText(btnCorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect2, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect3, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect4, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect5, " ");

        }

        private void btnIncorrect2_Click(object sender, EventArgs e)
        {
            intCount++;
            EZ_Builder.Scripting.VariableManager.SetVariable("$cor", intCount);
            EZ_Builder.Scripting.VariableManager.SetVariable("$incorrect2", 1);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.LightGray);
            EZ_Builder.Invokers.SetText(btnCorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect2, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect3, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect4, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect5, " ");

        }

        private void btnIncorrect3_Click(object sender, EventArgs e)
        {
            intCount++;
            EZ_Builder.Scripting.VariableManager.SetVariable("$cor", intCount);
            EZ_Builder.Scripting.VariableManager.SetVariable("$incorrect3", 1);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.LightGray);
            EZ_Builder.Invokers.SetText(btnCorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect2, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect3, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect4, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect5, " ");
        }

        private void btnIncorrect4_Click(object sender, EventArgs e)
        {
            intCount++;
            EZ_Builder.Scripting.VariableManager.SetVariable("$cor", intCount);
            EZ_Builder.Scripting.VariableManager.SetVariable("$incorrect4", 1);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.LightGray);
            EZ_Builder.Invokers.SetText(btnCorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect2, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect3, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect4, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect5, " ");

        }

        private void btnIncorrect5_Click(object sender, EventArgs e)
        {
            intCount++;
            EZ_Builder.Scripting.VariableManager.SetVariable("$cor", intCount);
            EZ_Builder.Scripting.VariableManager.SetVariable("$incorrect5", 1);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnCorrect, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect2, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect3, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect4, Color.LightGray);
            EZ_Builder.Invokers.SetBackColor(btnIncorrect5, Color.LightGray);
            EZ_Builder.Invokers.SetText(btnCorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect2, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect3, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect4, " ");
            EZ_Builder.Invokers.SetText(btnIncorrect5, " ");

        }
    }


}
