using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpertiseSolution {
    public class Expertise {
        public List<Expertise> exp;
        public Int32 Code {get; set;}
        public String Name {get; set;}
        public DateTime Start {get; set;}
        public DateTime End {get; set;}
        public Int32? Duration {get; set;}
        public Expertise() {
            exp = new List<Expertise>(){
                new Expertise(1,"Experiencia 1", DateTime.Parse("03/12/2016"), DateTime.Parse("09/11/2018")),
                new Expertise(1,"Experiencia 1", DateTime.Parse("09/10/2015"), DateTime.Parse("09/10/2017")),
                new Expertise(1,"Experiencia 3", DateTime.Parse("03/10/2016"), DateTime.Parse("09/11/2018")),
                new Expertise(1,"Experiencia 1", DateTime.Parse("03/08/2017"), DateTime.Parse("09/11/2018")),
                new Expertise(1,"Experiencia 5", DateTime.Parse("03/12/2013"), DateTime.Parse("09/11/2015")),
                new Expertise(6,"Experiencia 6", DateTime.Parse("03/12/2014"), DateTime.Parse("09/11/2016")),
                new Expertise(7,"Experiencia 7", DateTime.Parse("03/12/2017"), DateTime.Parse("05/02/2018")),
                new Expertise(8,"Experiencia 8", DateTime.Parse("03/12/2016"), DateTime.Parse("19/01/2018")),
                new Expertise(9,"Experiencia 9", DateTime.Parse("15/12/2016"), DateTime.Parse("09/11/2018"))
            };
        }
        public Expertise(Int32 Code, String Name, DateTime Start, DateTime End) {
            this.Code = Code;
            this.Name = Name;
            this.Start = Start;
            this.End = End;
        }
        public void ListExpertise() {
           List<Expertise> Expertise =  this.exp.GroupBy(x => x.Code).Select(x => new Expertise(){
               Name = x.First().Name,
               Start = x.Min(z => z.Start),
               End = x.Max(z => z.End),
               Duration = x.Sum(y =>  y.Duration = (Convert.ToDateTime(y.End) - Convert.ToDateTime(y.Start)).Days),
           }
              
           ).ToList();
         foreach(var obj in Expertise) {

             Console.Write(obj.Name);
             Console.Write(" "+obj.Duration);
             Console.Write(" "+obj.Start);
             Console.WriteLine(" "+obj.End);
         }
        }
    }
}