using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_admin_app
{
    public class RecommendationsSystem
    {
        public RecommendationsSystem(LinkedList<ScoreModuleInfo> modulesss)
        {
            ModulesInfo = modulesss;
        }

        public RecommendationsSystem()
        {
            ModulesInfo = new LinkedList<ScoreModuleInfo>();
        }

        public LinkedList<ScoreModuleInfo> ModulesInfo { get; private set; }
        public bool correct()
        {
           foreach(ScoreModuleInfo s in ModulesInfo)
            {
                if (s.MainMultiplicator <= 0 )
                {
                    return false;
                }
           }
            return true;
        }
    
    }
    public class ContainerScoreModuleInfo
    {
        public ScoreModuleInfo Module{ get; private set; }
        public ContainerScoreModuleInfo(ScoreModuleInfo s)
        {
            Module = s;
        }
        public override string ToString()
        {
            return Module.Name;
        }
    }
    


    public class SubMultiplicator
    {
        public string name;
        public int multiplicationValue;
        public override string ToString()
        {
            return name;
        }
    }


    public class ScoreModuleInfo
    {
        public bool Active { get; set; }
        public char charActive { get { if (Active == true) return 'y'; else return 'n'; } private set { } }
        public int MainMultiplicator { get; set; }
        public string Name { get; private set; }
        


        public ScoreModuleInfo(int mainMult, string name, LinkedList<string> names, LinkedList<int> values, bool state)
        {
            Active = state;
            Name = name;
            MainMultiplicator = mainMult;
            SubMultiplicators = new LinkedList<SubMultiplicator>();
            for (int i = 0; i < Math.Max(names.Count, values.Count); i++)
            {

                SubMultiplicator s = new SubMultiplicator();
                s.name = names.ElementAt(i);
                s.multiplicationValue = values.ElementAt(i);
                SubMultiplicators.AddLast(s);
            }
        }

        public LinkedList<SubMultiplicator> SubMultiplicators{ get; private set; }
        public int subMultiplicatorsSize { get { return SubMultiplicators.Count; } private set { } }
        public int getMultiplicatorAt(string argName)
        {
            foreach (SubMultiplicator smp in SubMultiplicators)
            {
                if (smp.name == argName)
                {
                    return smp.multiplicationValue;
                }
            }
            return 0;
        }
        public void setMultiplicatorAt(string argName, int newVal)
        {
            foreach(SubMultiplicator s in SubMultiplicators)
            {
                if(s.name == argName)
                {
                    s.multiplicationValue = newVal;
                    return;
                }
            }

        }

    }
}
