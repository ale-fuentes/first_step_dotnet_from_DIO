using System;

namespace DIO.series.ale
{
    public class Serie : EntidadeBase
    {
        private Gender Gender { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Exclude { get; set; }


        public Serie(int id, Gender gender, string title, string description, int year)
        {
            this.Id = id;
            this.Gender = gender;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Exclude = false;
        }

        public override string ToString()
        {
            string toString = "";
            toString += $"Gender: {this.Gender}{Environment.NewLine}";
            toString += $"Title: {this.Title}{Environment.NewLine}";
            toString += $"Description: {this.Description}{Environment.NewLine}";
            toString += $"Year of start: {this.Year}{Environment.NewLine}";
            toString += $"Is exclude: {this.Exclude}{Environment.NewLine}";
            return toString;

        }

        public string getTitle() { return this.Title; }

        public int getId() { return this.Id; }

        public void Excluding() { this.Exclude = true; }

        public bool isExclude() { return this.Exclude; }
    }

}
