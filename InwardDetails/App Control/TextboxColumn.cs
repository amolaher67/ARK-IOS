﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace InwardDetails
{
    public class TextboxColumn : DataGridViewColumn
    {
        public TextboxColumn()
            : base(new TextboxCell())
        {

        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(TextboxCell)))
                    {  
                        throw new InvalidCastException("Must be a TextboxCell");
                   }
                base.CellTemplate = value;
            }
        }
    }
}
