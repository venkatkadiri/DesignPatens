using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_based_poc_s
{
    // this example illistrates saparation of conserns with don't example and then will show the right one.

    // this example we will build the music staff

    public class Lines
    {
        public int Nos { get; } = 6;
        private string[] notes;

        public string[]? Notes { get { return notes; } }

        public Lines(string type)
        {
            if (type == "trouble")
            {
                notes = new string[6]{
                "E","G","B","D","A","F"
            };
            }
            if (type == "Base")
            {
                notes = new string[6]{
                "G","B","D","F","A","C"
            };
            }
        }

    }

    public class Spaces
    {
        public int Nos { get; } = 4;

        private string[] notes;

        public string[]? Notes { get { return notes; } }
        public Spaces(string type)
        {
            if (type == "trouble")
            {
                notes = new string[4]{
                "F","A","C","E"
            };
            }
            if (type == "Base")
            {
                notes = new string[4]{
                "A","C","E","G"
            };
            }

        }
    }

    public abstract class Cleff
    {
        public Lines? Lines { get; set; }
        public Spaces? Spaces { get; set; }

        public string? Type { get; set; }

        public Cleff(string Type)
        {
            this.Type = Type;
        }

        public virtual void SetNotes()
        {
            this.Lines = new Lines(Type);
            this.Spaces = new Spaces(Type);
        }

        public virtual void Print()
        {
            foreach (var item in this.Lines?.Notes)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class TroubleCleff : Cleff
    {

        public TroubleCleff() : base("trouble")
        {

        }



    }

    public class BaseCleff : Cleff
    {

        public BaseCleff() : base("Base")
        {

        }

    }


}