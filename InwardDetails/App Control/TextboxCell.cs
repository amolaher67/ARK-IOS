using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace InwardDetails
{
    public class TextboxCell : DataGridViewTextBoxCell
    {
        public TextboxCell()
            : base()
        {
            // Use the short date format.
            // this.Style.Format = "d";
        }
        public override void InitializeEditingControl(int rowIndex, object
           initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            TextboxEditingControl ctl =
                DataGridView.EditingControl as TextboxEditingControl;
            if (dataGridViewCellStyle.Alignment == DataGridViewContentAlignment.MiddleCenter)
                ctl.TextAlign = HorizontalAlignment.Center;
            if (dataGridViewCellStyle.Alignment == DataGridViewContentAlignment.MiddleLeft)
                ctl.TextAlign = HorizontalAlignment.Left;
            if (dataGridViewCellStyle.Alignment == DataGridViewContentAlignment.MiddleRight)
                ctl.TextAlign = HorizontalAlignment.Right;

            // ctl.MaxLength = this.MaxInputLength;

            if (this.Value != null)
                ctl.Text = this.Value.ToString();
        }

        public override System.Type EditType
        {
            get
            {
                // Return the type of the editing contol that CalendarCell uses.
                return typeof(TextboxEditingControl);
            }
        }

        public override System.Type ValueType
        {
            get
            {
                // Return the type of the value that CalendarCell contains.
                return typeof(string);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                // Use the current date and time as the default value.
                return "";
            }
        }
    }
}
