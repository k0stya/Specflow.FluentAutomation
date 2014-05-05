param($installPath, $toolsPath, $package, $project) 

$destinationFolder = [System.IO.Path]::GetDirectoryName($project.FullName) + "\plugin"
$destinationFile = "$destinationFolder\FluentAutomation.Generator.SpecflowPlugin.dll"

if (-not(Test-Path $destinationFolder))
{
	mkdir $destinationFolder
}
copy "$toolsPath\plugin\FluentAutomation.Generator.SpecflowPlugin.dll" $destinationFile -recurse -force