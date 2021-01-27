using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigEditor
{
    class Variable {
        public Variable(string typ, string nam, string val)
        {
            type = typ;
            name = nam;
            value = val;
        }
        public string type
        {
            get;
        }
        public string name
        {
            get;
        }
        public string value
        {
            get;
        }
    }
    class ConfigFile
    {
        public List<Variable> variableList = new List<Variable>();
        public int variableCount {
            get { return variableList.Count; }
        }
        public void insertNewVariable(string type, string name, string value="")
        {
            variableList.Add(new Variable(type, name, value));
        }
        public void readFile(string fileName)
        {
            variableList.Clear();
            var lines = File.ReadAllLines(fileName);
            foreach(var l in lines)
            {
                if(l.Contains("="))
                {
                    var strlist = l.Split('=');
                    string left = strlist[0];
                    var leftlist = left.Split(' ');

                    string type = leftlist[0].Trim();
                    string name = leftlist[1].Trim();
                    string value = strlist[1].Trim();

                    insertNewVariable(type, name, value);
                }
            }
        }
        public void saveFile(string fileName)
        {
            StreamWriter sr = File.CreateText(fileName);
            foreach(var v in variableList)
            {
                string line = v.type + " " + v.name + "=" + v.value;
                sr.WriteLine(line);
            }
            sr.Close();
        }

        public void ClearList()
        {
            variableList.Clear();
        }
    }
}
