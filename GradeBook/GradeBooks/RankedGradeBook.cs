using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
   public class RankedGradeBook : BaseGradeBook
    {

        //public GradeBookType Type { get; set; }
        public RankedGradeBook(string name) :base(name)
        {
            this.Type = GradeBookType.Ranked;
        }
       
    }
}
