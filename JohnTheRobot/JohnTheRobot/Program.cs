using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnTheRobot
{
    class Program
    {
        private static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined

        }

        public interface ISkills
        {
            string ShowSkills();
        }
        public class Dancing : ISkills
        {
            public string ShowSkills()
            {
                return "dancing";
            }
        }
        public class Cooking : ISkills
        {
            public string ShowSkills()
            {
                return "cooking";
            }
        }
        public class Humanoid
        {
            private string SkillSet;
            public Humanoid()
            {
                SkillSet = "no skill is defined";
            }
            public Humanoid(ISkills Skills)
            {
                SkillSet = Skills.ShowSkills();
            }

            public virtual string ShowSkill()
            {
                return SkillSet;
            }
        }
    }
}
