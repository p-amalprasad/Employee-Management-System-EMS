﻿namespace LogGenerator.Models.ViewModels
{
    public class AddSubmission
    {
        public int LogNo { get; set; }
        public string TableAltered { get; set; }
        public string Action { get; set; }
        public string ColumnEdited { get; set; }
        public string RowEdited { get; set; }
        public string PreviousEntry { get; set; }
        public string LatestEntry { get; set; }
        public string IPAddress { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
