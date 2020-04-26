using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Gecko;
using Gecko.DOM;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Text;
using Gecko.Events;
namespace phoenixtranslate
{
    public partial class Translator : Form
    {
        //remetre droit ctrl+K et D
        public int currentRow;
        public string ActivateTraslate = string.Empty;
        public string textesource;
        public string textescible = "";
        public string textescibleold="old";
        public GeckoWebBrowser wb1 => geckoWebBrowser1;
        public Translator()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize("Firefox");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          //Properties.Settings.Default.Name_Translator.Clear();
          // Properties.Settings.Default.Save();
            if (Properties.Settings.Default.Name_Translator.Cast<string>().ToArray().Length == 0)
            {
                Properties.Settings.Default.index = -1;
                Properties.Settings.Default.Save();
            }
            else
            {
                geckoWebBrowser1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
            }
            //buttonConfigTag.Visible = Properties.Settings.Default.ParameterTag;
            #region region text
            dataGridView1.Rows.Add("There lived a princess called Min-seo. ", "");
            dataGridView1.Rows.Add("She liked weapons. Everyone was terrified of her.", "");
            dataGridView1.Rows.Add("She'd threaten you with knives and steal and break your things.", "");
            dataGridView1.Rows.Add("She always got sent to the principal's office because she was bad.", "");
            dataGridView1.Rows.Add("Still,{w=0.35} she was a lovely princess. {w=0.35}And tragically, {w=0.35}she was cursed to prick her finger on a spindle and die.", "");
            dataGridView1.Rows.Add("Sure enough...One day, {w=0.2}like a total idiot,{w=0.2} she touched one.", "");
            dataGridView1.Rows.Add("And she fell into a deep, death-like slumber.", "");
            dataGridView1.Rows.Add("Or at least, she was supposed to.{w=0.35} \nInstead, the princess sat up abruptly and said:", "");
            dataGridView1.Rows.Add("{big=16}THIS IS THE WORST STORY IN HISTORY!{/big}", "");
            dataGridView1.Rows.Add("{big=20}I'M ESCAPING!{/big}", "");
            dataGridView1.Rows.Add("Wait!", "");
            dataGridView1.Rows.Add("Min, that's not how it goes!", "");
            dataGridView1.Rows.Add("I'm right here!{w=0.35} The evil dragon!", "");
            dataGridView1.Rows.Add("I killed you already!", "");
            dataGridView1.Rows.Add("Haaaah?{w=0.35} With what?", "");
            dataGridView1.Rows.Add("{big=+20}A GUN!{/big}", "");
            dataGridView1.Rows.Add("You don't have a gun!", "");
            dataGridView1.Rows.Add("{big=+20}I MADE ONE OUT OF ROCKS!{/big}", "");
            dataGridView1.Rows.Add("{cps=25}...... {/cps}", "");
            dataGridView1.Rows.Add("The hero has arrived!{w=0.35}\nAs Min-seo's twin, he's trying to reason with her!", "");
            dataGridView1.Rows.Add("{cps=35}Min... {w=0.35}that's impossible... {/cps}", "");
            dataGridView1.Rows.Add("Who cares!", "");
            dataGridView1.Rows.Add("If I have a gun,{w=0.35} I win!", "");
            dataGridView1.Rows.Add("{slower}...... {/slower}", "");
            dataGridView1.Rows.Add("{slower}...... {/slower}", "");
            dataGridView1.Rows.Add("{slower}...... {/slower}", "");
            dataGridView1.Rows.Add("It's difficult to argue against Min's brand of logic.", "");
            dataGridView1.Rows.Add("Okay, you win... {w=0.35}Let's just start over... ", "");
            dataGridView1.Rows.Add("This time someone else be the princess!{w=0.35} Not me!", "");
            dataGridView1.Rows.Add("I'm the only girl left, so I guess that's me...", "");
            dataGridView1.Rows.Add("Fine. Diya does seem more like the princess type anyway.", "");
            dataGridView1.Rows.Add("What's that supposed to mean.", "");
            dataGridView1.Rows.Add("You're really pretty.", "");
            dataGridView1.Rows.Add("And it's cute how your hair curls like that. {w=0.35} It makes you look like a princess.", "");
            dataGridView1.Rows.Add("Uh, {w=0.35} I just meant that she's less violent.", "");
            dataGridView1.Rows.Add("But whatever...", "");
            dataGridView1.Rows.Add("— 2nd Try —", "");
            dataGridView1.Rows.Add("Once upon a time... ", "");
            dataGridView1.Rows.Add("There lived a girl named Diya.", "");
            dataGridView1.Rows.Add("She was really quiet. ", "");
            dataGridView1.Rows.Add("It wasn't that she had nothing to say. {w=0.35}It was more like...", "");
            dataGridView1.Rows.Add("She was afraid if she opened her mouth,{w=0.35} something would come out that shouldn't.", "");
            dataGridView1.Rows.Add("She once held onto an apple core for 45 minutes because she didn't want people to see her walk across the classroom to the trash can.", "");
            dataGridView1.Rows.Add("It was that kind of quiet.", "");
            dataGridView1.Rows.Add("She was also insanely athletic.{w=0.35} There were rumors that under her shirt, she had a six-pack.", "");
            dataGridView1.Rows.Add("Tragically,{w=0.35} despite how buff she was, {w=0.35} this princess was also cursed to touch a spindle and die.", "");
            dataGridView1.Rows.Add("And one day, {w=0.2}like a total idiot,{w=0.2} she touched one.", "");
            dataGridView1.Rows.Add("And she fell into a deep, death-like slumber.", "");
            dataGridView1.Rows.Add("Nothing could break the spell but her true love's kiss.", "");
            dataGridView1.Rows.Add("For many years, she —", "");
            dataGridView1.Rows.Add("Diya,{w=0.2} get up! {w=0.35}I'm here to rescue you!", "");
            dataGridView1.Rows.Add("Hahah!!{w=0.35} Only the hero can wake her!", "");
            dataGridView1.Rows.Add("That's me! {w=0.35}I'm the hero!!", "");
            dataGridView1.Rows.Add("{cps=30}Wait,{w=0.35} no...?{/cps}{w=0.35}\nIt's supposed to be Jun-seo!", "");
            dataGridView1.Rows.Add("{big=+20}NO!{w=0.35} IT'S ME!!{/big}", "");
            dataGridView1.Rows.Add("Huh?{w=0.35} But if you're the hero, {w=0.35}then what am I?", "");
            dataGridView1.Rows.Add("A{cps=20}... {/cps}{w=0.35}{big=+20}GUN!{/big}", "");
            dataGridView1.Rows.Add("What?!", "");
            dataGridView1.Rows.Add("Min grabs Jun's arm and aims it at the dragon!", "");
            dataGridView1.Rows.Add("BANG!{w=0.35} You're dead!", "");
            dataGridView1.Rows.Add("Nice try! {w=0.35} But I deflected the bullet with my {i}own{/i} bullet!", "");
            dataGridView1.Rows.Add("I have a gun too!", "");
            dataGridView1.Rows.Add("{i}Why?!{/i}{w=0.35} You're a dragon!", "");
            dataGridView1.Rows.Add("This is America! {w=0.35}Everyone has a gun!", "");
            dataGridView1.Rows.Add("Diya rises to her feet.", "");
            dataGridView1.Rows.Add("I also have a gun.", "");
            dataGridView1.Rows.Add("Bang.", "");
            dataGridView1.Rows.Add("Dead.", "");
            dataGridView1.Rows.Add("Bang.", "");
            dataGridView1.Rows.Add("Min's dead.", "");
            dataGridView1.Rows.Add("Min looks very hurt...", "");
            dataGridView1.Rows.Add("Why? I'm here to rescue you.", "");
            dataGridView1.Rows.Add("Don't want to be rescued.", "");
            dataGridView1.Rows.Add("I can save myself.", "");
            dataGridView1.Rows.Add("But if we do it together, it'll be more fun.", "");
            dataGridView1.Rows.Add("We can ride off into the sunset on my horse.", "");
            dataGridView1.Rows.Add("What sunset...", "");
            dataGridView1.Rows.Add("What horse?", "");
            dataGridView1.Rows.Add("You.", "");
            dataGridView1.Rows.Add("Me?!", "");
            dataGridView1.Rows.Add("That does sound pretty cool...", "");
            dataGridView1.Rows.Add("Changed my mind.", "");
            dataGridView1.Rows.Add("Bang. Shot the dragon instead.", "");
            dataGridView1.Rows.Add("Bang.", "");
            dataGridView1.Rows.Add("Jun's dead.", "");
            dataGridView1.Rows.Add("But I'm a gun...", "");
            dataGridView1.Rows.Add("Then you broke in half.", "");
            dataGridView1.Rows.Add("In half?!", "");
            dataGridView1.Rows.Add("That's harsh, dude.", "");
            dataGridView1.Rows.Add("I used the last of Jun's energy to shoot you again!", "");
            dataGridView1.Rows.Add("DEAD.", "");
            dataGridView1.Rows.Add("Deflected the deflected bullet with my own bullet.", "");
            dataGridView1.Rows.Add("So Min's original bullet is going toward him again.", "");
            dataGridView1.Rows.Add("That's...{w=0.35} unnecessarily complicated.", "");
            dataGridView1.Rows.Add("Why didn't you just shoot him directly...?", "");
            dataGridView1.Rows.Add("This way is cooler!!!", "");
            dataGridView1.Rows.Add("Yeah.", "");
            dataGridView1.Rows.Add("{cps=20}Nice try... {/cps}{w=0.35}{i}but too bad!{/i} {w=0.35}The bullet bounces off me!", "");
            dataGridView1.Rows.Add("How is that possible.", "");
            dataGridView1.Rows.Add("My dragon scales are stronger than tank armor!", "");
            dataGridView1.Rows.Add("Take that!", "");
            dataGridView1.Rows.Add("Maybe we can resolve this without fighting, then... ", "");
            dataGridView1.Rows.Add("Let's talk it ov—", "");
            dataGridView1.Rows.Add("{big=+20}VIOLENCE SOLVES EVERYTHING!{/big}", "");
            dataGridView1.Rows.Add("{big=+20}I'M MAKING A NEW GUN WITH ROCKS!{/big}", "");
            dataGridView1.Rows.Add("Are you replacing me...?", "");
            dataGridView1.Rows.Add("Yeah! {w=0.35}Sorry!", "");
            dataGridView1.Rows.Add("BANG!{w=0.35} Dragon's dead!", "");
            dataGridView1.Rows.Add("Uh, did you forget?{w=0.35} I'm bulletproof.", "");
            dataGridView1.Rows.Add("But my gun didn't shoot a bullet!", "");
            dataGridView1.Rows.Add("My gun shot{cps=20}... {/cps}", "");
            dataGridView1.Rows.Add("A SMALLER GUN!", "");
            dataGridView1.Rows.Add("{big=+14}...WHICH SHOT A KNIFE!!{/big}", "");
            dataGridView1.Rows.Add("{big=+20}...WHICH EXPLODED!!!{/big}", "");
            dataGridView1.Rows.Add("{cps=25}...... {/cps}", "");
            dataGridView1.Rows.Add("{cps=25}...... {/cps}", "");
            dataGridView1.Rows.Add("{cps=25}...... {/cps}", "");
            dataGridView1.Rows.Add("What was the point of the smaller gun in the middle?", "");
            dataGridView1.Rows.Add("It's there to shoot the knife!", "");
            dataGridView1.Rows.Add("No, {w=0.2}but why couldn't the original gun shoot the knife?", "");
            dataGridView1.Rows.Add("Min gives Jun an incredulous look.", "");
            dataGridView1.Rows.Add("Because it was shooting out the smaller gun.", "");
            dataGridView1.Rows.Add("{cps=25}...never mind... {/cps}", "");
            dataGridView1.Rows.Add("Okay, so let's say my elbow is injured now.", "");
            dataGridView1.Rows.Add("So if you touch that, I lose.", "");
            dataGridView1.Rows.Add("RRRAUUGH!!!!", "");
            dataGridView1.Rows.Add("Min lunges at him!", "");
            dataGridView1.Rows.Add("He sidesteps and darts up the steps to the slide!", "");
            dataGridView1.Rows.Add("When Min catches up, he spins so his back is to the wall.", "");
            dataGridView1.Rows.Add("She looks like she's having trouble...", "");
            dataGridView1.Rows.Add("Do you need help?", "");
            dataGridView1.Rows.Add("What?!{w=0.2} No!", "");
            dataGridView1.Rows.Add("The evil dragon feints to the right.{w=0.2} Min falls for it and he rushes past her,{w=0.2} back the way he came.", "");
            dataGridView1.Rows.Add("!", "");
            dataGridView1.Rows.Add("Min trips and face plants on the bridge!", "");
            dataGridView1.Rows.Add("...!!!!!!!!", "");
            dataGridView1.Rows.Add("Before Min can see, Diya quickly picks the evil dragon up and hurls him off the playground structure like a sack of potatoes.", "");
            dataGridView1.Rows.Add("Waugh?!!", "");
            dataGridView1.Rows.Add("Wait, you're the princess! You can't just do that.", "");
            dataGridView1.Rows.Add("................", "");
            dataGridView1.Rows.Add("Diya throws him off the playground structure, too.", "");
            dataGridView1.Rows.Add("As he disappears over the edge, Min pulls herself back to her feet.", "");
            dataGridView1.Rows.Add("Where is everyone?", "");
            dataGridView1.Rows.Add("They.......balcony collapsed.", "");
            dataGridView1.Rows.Add("Castle is under construction.", "");
            dataGridView1.Rows.Add("Yeah!!!", "");
            dataGridView1.Rows.Add("Heheheh!!!{w=0.35} I rescued you!", "");
            dataGridView1.Rows.Add("My hero.", "");
            dataGridView1.Rows.Add("Yeah!{w=0.35} I'm your hero!!", "");
            dataGridView1.Rows.Add("Min is struggling to princess carry Diya down the slide with her.", "");
            dataGridView1.Rows.Add("Diya could destroy her in a single punch if she wanted to, but she's patiently going along with it.", "");
            dataGridView1.Rows.Add("I owe you my life. How can I repay you.", "");
            dataGridView1.Rows.Add("You can... {w=0.35}r-repay me with a ki—", "");
            dataGridView1.Rows.Add("*THUD*", "");
            dataGridView1.Rows.Add("................", "");
            dataGridView1.Rows.Add("................", "");
            dataGridView1.Rows.Add("My name is Diya.", "");
            dataGridView1.Rows.Add("...I don't really know what else to say about myself. I'm pretty boring.", "");
            dataGridView1.Rows.Add("The other girl is Min-seo. Everyone calls her Min.", "");
            dataGridView1.Rows.Add("She's so cool.", "");
            dataGridView1.Rows.Add("Do you see that thing on her arm? {w=0.35} She drew a giant dagger on it with Sharpie,{w=0.35} like a tattoo.", "");
            dataGridView1.Rows.Add("And in class, she makes ninja stars out of binder paper and throws them at people.", "");
            dataGridView1.Rows.Add("She stamps them with staples so they hurt more.", "");
            dataGridView1.Rows.Add("But she never throws them at me.", "");
            dataGridView1.Rows.Add("I think it's mainly because I'm the only other girl she knows who likes baseball.", "");
            dataGridView1.Rows.Add("We both used to think we were the only one in the world. So we were both really excited to meet each other.", "");
            dataGridView1.Rows.Add("I really like her.", "");
            dataGridView1.Rows.Add("Watching the pros play baseball always makes me so jealous.", "");
            dataGridView1.Rows.Add("It must be so fun, being on a real team like that.", "");
            dataGridView1.Rows.Add("The catcher's gone up to the mound for a conference with his pitcher.", "");
            dataGridView1.Rows.Add("For secrecy's sake,{w=0.10} they're talking with their gloves over their mouths.", "");
            dataGridView1.Rows.Add("Someday,{w=0.10} that's gonna be us.", "");
            #endregion
        }
        protected override void OnClosed(EventArgs e)
        {
            geckoWebBrowser1.Dispose();
            Xpcom.Shutdown();
            base.OnClosed(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    fill(wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]),(Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.CurrentCell.Value.ToString());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = Extract(wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");
                currentRow = dataGridView1.SelectedRows[0].Index;
                if (currentRow < dataGridView1.RowCount - 1)
                {
                    dataGridView1.Rows[++currentRow].Cells[0].Selected = true;
                }
                else
                {
                    MessageBox.Show("Fin.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            timer1.Enabled = true;
            button2.Enabled = false;
        }
        public string Extract(GeckoWebBrowser wb, string xpath, string type)
        {
            string result = string.Empty;
            GeckoHtmlElement Elm;
            if (wb != null)
            {
                Elm = (GeckoHtmlElement)wb.Document.EvaluateXPath(xpath).GetNodes().FirstOrDefault();
                if (Elm != null)
                {
                    switch (type)
                    {
                        case "html":
                            result = Elm.OuterHtml;
                            break;
                        case "text":
                            if (Elm.GetType().Name == "GeckoTextAreaElement")
                                result = ((GeckoTextAreaElement)Elm).Value;
                            else
                                result = Elm.TextContent.Trim();
                            break;
                        case "value":
                            result = ((GeckoInputElement)Elm).Value;
                            break;
                        default:
                            result = ExtractData(Elm, type);
                            break;
                    }
                }
            }
            return result;
        }
        private string ExtractData(GeckoHtmlElement ele, string attribute)
        {
            var result = string.Empty;
            if (ele != null)
            {
                var tmp = ele.GetAttribute(attribute);
                if (tmp != null)
                    result = tmp.Trim();
            }
            return result;
        }
        private string GetHtmlFromGeckoDocument(GeckoDocument doc)
        {
            var result = string.Empty;
            GeckoHtmlElement element;
            var geckoDomElement = doc.DocumentElement;
            if (geckoDomElement is GeckoHtmlElement)
            {
                element = (GeckoHtmlElement)geckoDomElement;
                result = element.InnerHtml;
            }
            return result;
        }
        public void fill(GeckoWebBrowser wb, string xpath, string Query, string value)
        {
            string str = System.Uri.EscapeDataString(value);
            string b = Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString() + "/" + Properties.Settings.Default.LangSource[Int32.Parse(Properties.Settings.Default.LangSource_index[Properties.Settings.Default.index])].ToString() + "/" + Properties.Settings.Default.LangTarget[Int32.Parse(Properties.Settings.Default.LangTarget_index[Properties.Settings.Default.index])].ToString() + "/" + str;
            string c = Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString() +"/"+ Properties.Settings.Default.LangSource[Int32.Parse(Properties.Settings.Default.LangSource_index[Properties.Settings.Default.index])].ToString() + "/" + Properties.Settings.Default.LangTarget[Int32.Parse(Properties.Settings.Default.LangTarget_index[Properties.Settings.Default.index])].ToString() + "/" + str;
            wb1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString() + "/" + Properties.Settings.Default.LangSource[Int32.Parse(Properties.Settings.Default.LangSource_index[Properties.Settings.Default.index])].ToString() + "/" + Properties.Settings.Default.LangTarget[Int32.Parse(Properties.Settings.Default.LangTarget_index[Properties.Settings.Default.index])].ToString() + "/" + str);
            //value = Remove_and_replace_Tag(value);
            //if (wb != null)
            //{
            //    GeckoHtmlElement elm = (GeckoHtmlElement)wb.Document.EvaluateXPath(xpath).GetNodes().FirstOrDefault();
            //    if (elm != null)
            //    {
            //        GeckoTextAreaElement input1 = (GeckoTextAreaElement)elm;
            //        if (Query != "#fakeArea")
            //        {
            //            input1.Value = value;
            //            var evt = wb.Document.CreateEvent("HTMLEvents");
            //            using (Gecko.AutoJSContext java = new Gecko.AutoJSContext(wb.Window))
            //            {
            //                var selector = Query;
            //                java.EvaluateScript($@"
            //            var xpathResult = document.querySelector('{selector}') 
            //            var evt = document.createEvent('HTMLEvents');
            //            evt.initEvent('change', false, true);
            //            xpathResult.dispatchEvent(evt);
            //            ", out string outString);
            //            }
            //        }
            //      else
            //        {
            //            input1.Value = "";
            //            wb.Focus();
                      
            //            if (value != "")
            //            {
            //                SendKeys.Send(value);
            //            }
            //        }
            //    }
            //}
        }
        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        private void buttontranslatorconfig_Click(object sender, EventArgs e)
        {
            Translator_config translator_config = new Translator_config(this);
            translator_config.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textescible = Extract(wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");
            if (textescible == string.Empty || textescible == textescibleold || button2.Enabled == true)
            {
               if (textescible == string.Empty || textescible == textescibleold)
                {
                    button2.Enabled = false;
                }
              
            }
            else
            {
                textescible = textescibleold;
              
                button2.Enabled = true;
                timer1.Enabled = false;
            }
        }
        private void Translator_FormClosing(object sender, FormClosingEventArgs e){timer1.Enabled = false;}
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    currentRow = dataGridView1.SelectedRows[0].Index;
                    fill(wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]),(Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.Rows[currentRow].Cells[0].Value.ToString());
                }
            }
        }
        private void geckoWebBrowser1_ShowContextMenu(object sender, GeckoContextMenuEventArgs e) { this.contextMenuwb1.Show(Control.MousePosition); }
        private void geckoWebBrowser1_Navigated(object sender, GeckoNavigatedEventArgs e)
        {
        }
        private void geckoWebBrowser1_DocumentCompleted(object sender, GeckoDocumentCompletedEventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    wait(1000);
                    fill(wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]),(Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.CurrentCell.Value.ToString());
                }
            }
        }
        private string Remove_and_replace_Tag(string input)
        {
            string pattern = @"\{.+\}";
            string replacement = "";
           
            string result = Regex.Replace(input, pattern, replacement);


            return result;
        }

        private void buttonConfigTag_Click(object sender, EventArgs e)
        {
            Config_Tag config_Tag = new Config_Tag(this);
            config_Tag.ShowDialog();
        }
    }
}
