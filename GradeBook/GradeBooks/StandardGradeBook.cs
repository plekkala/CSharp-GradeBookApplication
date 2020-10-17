using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        //public GradeBookType Type;
        public StandardGradeBook(string name) :base(name)
        {
            Name = name;
            Type = GradeBookType.Standard;
        }


        
    }
}
