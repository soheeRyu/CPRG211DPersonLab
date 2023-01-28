﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Relation
    {
        private string person1Relation;
        private Person person1;
        
        private string person2Relation;
        private Person person2;

        public string Person1Relation { get { return person1Relation; } }
        public string Person2Relation { get { return person2Relation; } }

        public Person Person1 { get { return person1; } }
        public Person Person2 { get { return person2;} }

        public Relation(string person1Relation, Person person1, string person2Relation, Person person2) 
        {
            this.person1Relation = person1Relation;
            this.person1 = person1;
            this.person2Relation= person2Relation;
            this.person2 = person2;
        
        }

        public string ShowRelationship()
        {
            string formatted;

            formatted = "Relationship between " + Person1.FirstName+ " and " + Person2.FirstName + " is: " + Person1Relation;
            
            return formatted;
        }


    }
}
