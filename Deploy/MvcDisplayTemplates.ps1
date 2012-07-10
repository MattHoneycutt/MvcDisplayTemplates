properties {
	$BaseDir = Resolve-Path "..\"
	$ProjectPath = "$BaseDir\Deploy\MvcDisplayTemplates.nuspec"	
	
	$NuGetPackageName = "MvcDisplayTemplates"
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

	exec { nuget pack "$ProjectPath" }
}

task Publish -depends Pack {
	$PackageName = gci "$NuGetPackageName.*.nupkg"
	exec { nuget push $PackageName }
}