using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        interface Visitor
        {
            void visit(Zoo zoo);
        }

        interface Visitable
        {
            void accept(Visitor visitor);
        }

    
