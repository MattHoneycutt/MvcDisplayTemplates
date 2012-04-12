properties {
	$BaseDir = Resolve-Path "..\"
	$ProjectPath = "$BaseDir\MvcDisplayTemplates.nuspec"	
	
	$NuGetPackageName = "MvcDisplayTemplates"
	
	$Version = "1.0.0-alpha"
}

$framework = '4.0'

task default -depends Pack,Archive

task Init {
	cls
}

task Clean -depends Init {
	ri *.nupkg
}

task Pack -depends Clean {

	exec { nuget pack "$ProjectPath" -version "$Version" }
}

task Publish -depends Pack {
	$PackageName = gci "$NuGetPackageName.*.nupkg"
	exec { nuget push $PackageName }
}