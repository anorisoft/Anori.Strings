#load ./Tools/GlobalSettings/Addins.cake

Environment.SetVariableNames();

BuildParameters.SetParameters(
	context: Context,
	buildSystem: BuildSystem,
	title: "Anori.Strings",
	shouldRunDupFinder: false
);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context);
