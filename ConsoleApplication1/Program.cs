using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string readFile = File.ReadAllText(@"Y:\Mani\GitHub\ConsoleApplication1\ConsoleApplication1\Input\H80 - AE Review.txt");
            string file = "Y:\\Mani\\H80 - AE Review.txt";
            Input input = new Input();

            PropertyInfo[] properties = typeof(Input).GetProperties();
            //int count = typeof(Input).GetProperties().Count();
            foreach (PropertyInfo property in properties)
            {
                property.SetValue(input, Guid.NewGuid().ToString());
            }
            input.DisplayName = "";
            input.InstantiationConditionXml = "";
            input.Checklistxml = "";
            input.ValidationXml = "";
            ModifyFile(readFile, input);
        }

        private static void ModifyFile(string file, Input input)
        {
            Dictionary<string, string> myVal = new Dictionary<string, string>();
            myVal.Add("hdrdef", input.HeaderDefinitionId);
            myVal.Add("rvwdef", input.ReviewDefinitionId);
            myVal.Add("relrvwdefentity", input.RelReviewDefinitionEntityTypeId);
            myVal.Add("insCondid", input.InstantiationConditionId);
            myVal.Add("fd1", input.FieldDefinitionId1);
            myVal.Add("fd2", input.FieldDefinitionId2);
            myVal.Add("fd3", input.FieldDefinitionId3);
            myVal.Add("fd4", input.FieldDefinitionId4);
            myVal.Add("fd5", input.FieldDefinitionId5);
            myVal.Add("fd6", input.FieldDefinitionId6);
            myVal.Add("fd7", input.FieldDefinitionId7);
            myVal.Add("fd8", input.FieldDefinitionId8);
            myVal.Add("fd9", input.FieldDefinitionId9);
            myVal.Add("fd10", input.FieldDefinitionId10);
            myVal.Add("fd11", input.FieldDefinitionId11);
            myVal.Add("fd12", input.FieldDefinitionId12);
            myVal.Add("fd13", input.FieldDefinitionId13);
            myVal.Add("fd14", input.FieldDefinitionId14);
            myVal.Add("fd15", input.FieldDefinitionId15);
            myVal.Add("fd16", input.FieldDefinitionId16);
            myVal.Add("fd17", input.FieldDefinitionId17);
            myVal.Add("fd18", input.FieldDefinitionId18);
            myVal.Add("fd19", input.FieldDefinitionId19);
            myVal.Add("fd20", input.FieldDefinitionId20);
            myVal.Add("fd21", input.FieldDefinitionId21);
            myVal.Add("fd22", input.FieldDefinitionId22);
            myVal.Add("fd23", input.FieldDefinitionId23);
            myVal.Add("fd24", input.FieldDefinitionId24);
            myVal.Add("fd25", input.FieldDefinitionId25);
            myVal.Add("fd26", input.FieldDefinitionId26);
            myVal.Add("fd27", input.FieldDefinitionId27);
            myVal.Add("fd28", input.FieldDefinitionId28);
            myVal.Add("fd29", input.FieldDefinitionId29);
            myVal.Add("fd30", input.FieldDefinitionId30);
            myVal.Add("fd31", input.FieldDefinitionId31);
            myVal.Add("fd32", input.FieldDefinitionId32);
            myVal.Add("fd33", input.FieldDefinitionId33);
            myVal.Add("fd34", input.FieldDefinitionId34);
            myVal.Add("prmyobjfield", input.PrimaryObjectFieldId);
            myVal.Add("lnkdef1", input.LinkDefinitionId1);
            myVal.Add("lnkdef2", input.LinkDefinitionId2);
            myVal.Add("lnkdef3", input.LinkDefinitionId3);
            myVal.Add("lnkdef4", input.LinkDefinitionId4);
            myVal.Add("lnkdef5", input.LinkDefinitionId5);
            myVal.Add("lnkdef6", input.LinkDefinitionId6);
            myVal.Add("lnkdef7", input.LinkDefinitionId7);
            myVal.Add("lnkdef8", input.LinkDefinitionId8);
            myVal.Add("lnkdef9", input.LinkDefinitionId9);
            myVal.Add("lnkdef10", input.LinkDefinitionId10);
            myVal.Add("lnkdef11", input.LinkDefinitionId11);
            myVal.Add("lnkdef12", input.LinkDefinitionId12);
            myVal.Add("lnkdef13", input.LinkDefinitionId13);
            myVal.Add("lnkdef14", input.LinkDefinitionId14);
            myVal.Add("lnkdef15", input.LinkDefinitionId15);
            myVal.Add("lnkdef16", input.LinkDefinitionId16);
            myVal.Add("lnkdef17", input.LinkDefinitionId17);
            myVal.Add("lnkdef18", input.LinkDefinitionId18);
            myVal.Add("lnkdef19", input.LinkDefinitionId19);
            myVal.Add("lnkdef20", input.LinkDefinitionId20);
            myVal.Add("lnkgrp", input.LinkGroupId1);
            myVal.Add("lnkgrpdef1", input.LinkGroupId_DefinitionId1);
            myVal.Add("lnkgrpdef2", input.LinkGroupId_DefinitionId2);
            myVal.Add("lnkgrpdef3", input.LinkGroupId_DefinitionId3);
            myVal.Add("lnkgrpdef4", input.LinkGroupId_DefinitionId4);
            myVal.Add("lnkgrpdef5", input.LinkGroupId_DefinitionId5);
            myVal.Add("lnkgrpdef6", input.LinkGroupId_DefinitionId6);
            myVal.Add("lnkgrpdef7", input.LinkGroupId_DefinitionId7);
            myVal.Add("lnkgrpdef8", input.LinkGroupId_DefinitionId8);
            myVal.Add("lnkgrpdef9", input.LinkGroupId_DefinitionId9);
            myVal.Add("lnkgrpdef10", input.LinkGroupId_DefinitionId10);
            myVal.Add("lnkgrpdef11", input.LinkGroupId_DefinitionId11);
            myVal.Add("lnkgrpdef12", input.LinkGroupId_DefinitionId12);
            myVal.Add("lnkgrpdef13", input.LinkGroupId_DefinitionId13);
            myVal.Add("lnkgrpdef14", input.LinkGroupId_DefinitionId14);
            myVal.Add("lnkgrpdef15", input.LinkGroupId_DefinitionId15);
            myVal.Add("lnkgrpdef16", input.LinkGroupId_DefinitionId16);
            myVal.Add("lnkgrpdef17", input.LinkGroupId_DefinitionId17);
            myVal.Add("lnkgrpdef18", input.LinkGroupId_DefinitionId18);
            myVal.Add("lnkgrpdef19", input.LinkGroupId_DefinitionId19);
            myVal.Add("lnkgrpdef20", input.LinkGroupId_DefinitionId20);
            myVal.Add("chkListDef", input.ChecklistDefinitionId);
            myVal.Add("wfAPI", input.WorkflowAPIId);
            myVal.Add("stepAssign", input.StepDefinitionId1);
            myVal.Add("stepPDR", input.StepDefinitionId2);
            myVal.Add("stepCR", input.StepDefinitionId3);
            myVal.Add("stepPO", input.StepDefinitionId4);
            myVal.Add("displayname", input.DisplayName);
            myVal.Add("instantiationxml", input.InstantiationConditionXml);
            myVal.Add("checklistxml", input.Checklistxml);
            myVal.Add("validationXml", input.ValidationXml);

            myVal.Select(a => file = file.Replace(string.Concat("{", a.Key, "}"), a.Value)).ToList();
            File.WriteAllText(@"Y:\Mani\GitHub\ConsoleApplication1\ConsoleApplication1\Output\H80 - AE Review.txt", file);
        }
    }
}
