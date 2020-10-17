using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        //public GradeBookType Type;
        public StandardGradeBook(string name, bool isWeighted) :base(name,isWeighted)
        {
            Name = name;
            Type = GradeBookType.Standard;
        }


        
    }
}
