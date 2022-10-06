using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace datumsformatierung
{
    public class FormattedDate
    {
        public Date Date { get; }
        public string Format { get; }
        public bool DateIsValid { get; private set; }
        public bool FormatIsValid { get; private set; }
        public string Message { get; private set; }

        public FormattedDate(Date date, string format)
        {
            this.Date = date;
            this.Format = format.ToLower();
            this.DateIsValid = true;
            this.FormatIsValid = true;
        }

        public void SetMessage()
        {
            CheckForIsValid();
            if (!DateIsValid && !FormatIsValid)
            {
                Message = "invalid date and format";
            }
            else if (!DateIsValid && FormatIsValid)
            {
                Message = "invalid date";
            }
            else if (DateIsValid && !FormatIsValid)
            {
                Message = "invalid format";
            }
            else
            {
                SetValidMessage();
            }
        }

        public void CheckForIsValid()
        {
            if (Date.Day > 31 || Date.Day < 1)
            {
                DateIsValid = false;
            }
            else if (Date.Month > 12 || Date.Month < 1)
            {
                DateIsValid = false;
            }
            else if (Date.Year < 0)
            {
                DateIsValid = false;
            }

            if (Format != "ch" && Format != "us" && Format != "iso")
            {
                FormatIsValid = false;
            }
        }

        private void SetValidMessage()
        {
            if (Format == "ch")
            {
                Message = $"CH: {Date.Day}.{Date.Month}.{Date.Year}";
            }
            else if (Format == "us")
            {
                Message = $"US: {Date.Month}/{Date.Day}/{Date.Year}";
            }
            else if (Format == "iso")
            {
                Message = $"ISO: {Date.Year}-{Date.Month}-{Date.Day}";
            }
        }
    }
}
