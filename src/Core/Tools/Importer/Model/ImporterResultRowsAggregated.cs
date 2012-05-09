using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Tools.Import
{
    public class ImporterResultRowsAggregated
    {
        public int SubId;
        public List<ImporterResultRow> Rows = new List<ImporterResultRow>();

        
        public bool IsCompany()
        {
            return Convert.ToInt32(Rows.First().FormId) == (int) EntryType.Unternehmen;
        }

        public bool IsClub()
        {
            return Convert.ToInt32(Rows.First().FormId) == (int)EntryType.Verein;
        }


        public string GetUrl()
        {
            var urlRow = Rows.Find(row => row.FieldName == "Webseite" ||
                                          row.FieldName == "Webseite/Blog" ||
                                          row.FieldName == "Webseite**");

            return urlRow.FieldValue;
        }

        public string GetName()
        {
            if(IsCompany())
                return Rows.Find(row => row.FieldName == "Firmenname").FieldValue;

            if(IsClub())
                return Rows.Find(row => row.FieldName == "Firmenname").FieldValue;

            return Rows.Find(row => row.FieldName == "Name des Vereins").FieldValue;
        }

        public string GetPoliticalFunction()
        {
            var rowPolitischeFuntion = Rows.Find(row => row.FieldName == "Funktion");
            if (rowPolitischeFuntion != null)
                return rowPolitischeFuntion.FieldValue;

            return "";
        }

        public string GetEmail()
        {
            return Rows.Find(row => row.FieldName == "Email*").FieldValue;
        }

        public string GetBranche()
        {
            return Rows.Find(row => row.FieldName == "Branche").FieldValue;
        }

        public string GetBeschaeftigte()
        {
            return Rows.Find(row => row.FieldName == "Beschaeftigte").FieldValue;
        }

        public string GetTaetigkeitsfeld()
        {
            return Rows.Find(row => row.FieldName == "Taetigkeitsfeld").FieldValue;
        }

        public bool IsBilanz2011()
        {
            return Rows.Where(row => row.FieldName == "GWB**" ||
                                   row.FieldName == "Bilanz**" || 
                                   row.FieldName == "Bilanz ab" ||
                                   row.FieldName == "Bilanz ab 2011**" ||
                                   row.FieldName == "Bilanz ab 2011").Any( row => row.FieldValue == "on");
        }

        public bool IsBilanz2012()
        {
            return Rows.Where(row => row.FieldName == "Bilanz ab 2012" ||
                                   row.FieldName == "Bilanz ab 2012 (geplant)").Any( row => row.FieldValue == "on");
        }

        public string GetLocation()
        {
            return Rows.Find(row => row.FieldName == "Staat-PLZ Ort").FieldValue;
        }
    }
}
