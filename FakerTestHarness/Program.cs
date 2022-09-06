FakerTestHarness.Russian.Names.TestNames();
FakerTestHarness.Russian.Lorem.Test();

Console.WriteLine(Environment.NewLine);

FakerTestHarness.English.Names.TestNames();
FakerTestHarness.English.Lorem.Test();

//for (int i = 0; i < 10; i++)
//{
//    var text = $"<div class=\"most-recent\"><div class=\"hstack gap-2\"><div class=\"fw-bold\">{Name.FullName}</div><div class=\"text-muted ms-auto fw-light\">{ Location.City }, { Location.State}</div></div><div class=\"hstack gap-2\"><div class=\"fst-italic\">{Name.JobTitle}</div><div class=\"text-muted ms-auto fw-light\">Sept2020-Present</div></div><ul><li>{Lorem.GetText(15)}</li><li>{Lorem.GetText(15)}</li><li>{Lorem.GetText(15)}</li></ul></div>";
//    Console.WriteLine(text);
//}