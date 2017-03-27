using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace InwardDetails
{
    class AmountTextBox :TextBox
    {
            private Font oldFont = null;
            private Boolean waterMarkTextEnabled = false;

            #region Attributes
            private Color _waterMarkColor = Color.Gray;
           // public TextBox textBox_mark;
            private TextBox textBox1;

            public Color WaterMarkColor
            {
                get { return _waterMarkColor; }
                set
                {
                    _waterMarkColor = value; Invalidate();/*thanks to Bernhard Elbl
                                                              for Invalidate()*/
                }
            }

            private string _waterMarkText = "Water Mark";
            public string WaterMarkText
            {
                get { return _waterMarkText; }
                set { _waterMarkText = value; Invalidate(); }
            }
            #endregion

            //Default constructor
            public AmountTextBox()
            {
                JoinEvents(true);
                this.TextAlign = HorizontalAlignment.Right;
                
            }

            //Override OnCreateControl ... thanks to  "lpgray .. codeproject guy"
            protected override void OnCreateControl()
            {
                base.OnCreateControl();
                WaterMark_Toggel(null, null);
            }

            //Override OnPaint
            protected override void OnPaint(PaintEventArgs args)
            {
                // Use the same font that was defined in base class
                System.Drawing.Font drawFont = new System.Drawing.Font(Font.FontFamily,
                    Font.Size, Font.Style, Font.Unit);
                //Create new brush with gray color or 
                SolidBrush drawBrush = new SolidBrush(WaterMarkColor);//use Water mark color
                //Draw Text or WaterMark
                args.Graphics.DrawString((waterMarkTextEnabled ? WaterMarkText : Text),
                    drawFont, drawBrush, new PointF(0.0F, 0.0F));
                base.OnPaint(args);
            }

            private void JoinEvents(Boolean join)
            {
                if (join)
                {
                    this.Enter +=new EventHandler(AmountTextBox_Enter);
                    this.TextChanged += new System.EventHandler(this.WaterMark_Toggel);
                    this.LostFocus += new System.EventHandler(this.WaterMark_Toggel);
                    this.FontChanged += new System.EventHandler(this.WaterMark_FontChanged);
                    this.KeyPress += new KeyPressEventHandler(AmountTextBox_KeyPress);
                    this.Leave+=new EventHandler(AmountTextBox_Leave);
                   
                    //No one of the above events will start immeddiatlly 
                    //TextBox control still in constructing, so,
                    //Font object (for example) couldn't be catched from within
                    //WaterMark_Toggle
                    //So, call WaterMark_Toggel through OnCreateControl after TextBox
                    //is totally created
                    //No doupt, it will be only one time call

                    //Old solution uses Timer.Tick event to check Create property
                }
            }
            private void AmountTextBox_Enter(object sender, EventArgs e)
            {
                if (this.Text!=string.Empty && Convert.ToDouble(this.Text) <= 0)
                    this.Text = "";
            }


            private void AmountTextBox_Leave(object sender, EventArgs e)
            {
                if (this.Text == string.Empty || this.Text==".")
                    this.Text = "0.00";
                else
                {
                    this.Text = Convert.ToDouble(this.Text).ToString("F2");
                }
            }
            private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
            {
               
               
                if ((this.Text.Contains(".") == true && e.KeyChar.ToString() == ".")||(char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back && e.KeyChar.ToString() != "\r" && e.KeyChar.ToString() != "."))
                {
                    e.Handled = true;
                    //WPFMessageBox.Show(Program.strCompanyName, "चुकिचे अक्षर ! कृपया अक्षराचे स्वरुप ठिक द्यावे!", WPFMessageBoxButtons.OK, WPFMessageBoxImage.Alert);
                    return;
                }
            }
            private void WaterMark_Toggel(object sender, EventArgs args)
            {
                if (this.Text == "." || this.Text == "0.")
                {
                    this.Text = "0.";
                    this.Select(this.TextLength, 0);
                }
                if (this.Text.Length <= 0)
                    EnableWaterMark();
                else
                    DisbaleWaterMark();
            }

            private void EnableWaterMark()
            {
                //Save current font until returning the UserPaint style to false (NOTE:
                //It is a try and error advice)
                oldFont = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style,
                   Font.Unit);
                //Enable OnPaint event handler
                this.SetStyle(ControlStyles.UserPaint, true);
                this.waterMarkTextEnabled = true;
                //Triger OnPaint immediatly
                Refresh();
            }

            private void DisbaleWaterMark()
            {
                //Disbale OnPaint event handler
                this.waterMarkTextEnabled = false;
                this.SetStyle(ControlStyles.UserPaint, false);
                //Return back oldFont if existed
                if (oldFont != null)
                    this.Font = new System.Drawing.Font(oldFont.FontFamily, oldFont.Size,
                        oldFont.Style, oldFont.Unit);
            }

            private void WaterMark_FontChanged(object sender, EventArgs args)
            {
                if (waterMarkTextEnabled)
                {
                    oldFont = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style,
                        Font.Unit);
                    Refresh();
                }
            }

            private void InitializeComponent()
            {
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.SuspendLayout();
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(0, 0);
                this.textBox1.MaxLength = 12;
                this.textBox1.Name = "textBox1";
                this.textBox1.ShortcutsEnabled = false;
                this.textBox1.Size = new System.Drawing.Size(100, 20);
                this.textBox1.TabIndex = 0;
                this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                this.ResumeLayout(false);

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            
        }

}
