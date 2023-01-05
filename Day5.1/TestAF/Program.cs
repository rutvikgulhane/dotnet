using Apprform;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

List<AppraisalForm> formList = new List<AppraisalForm>();
formList.Add(new AppraisalForm(1, "Rutvik"));
formList.Add(new AppraisalForm(2, "Piyush"));
formList.Add(new AppraisalForm(3, "Anvesh"));
formList.Add(new AppraisalForm(4, "Aman"));

foreach (var item in formList)
{
    System.Console.WriteLine(item);
}

try
{
    var options = new JsonSerializerOptions { IncludeFields = true };
    string jsonString = JsonSerializer.Serialize<List<AppraisalForm>>(formList, options);
    System.Console.WriteLine(jsonString);
    string path = @"D:\IACSD AKURDI\DOT_NET\DN_Assignments\Day5.1\TestAF\jsonString.json";
    using (File.WriteAllText(path, jsonString)) ;
}
catch (System.Exception)
{

    throw;
}





