param (
    [Parameter(Position = 0, Mandatory=$true)] [string] $Path,
    [Parameter(Position = 1, Mandatory=$true)] [string] $Output
)

$xmlDoc = New-Object xml

$rootNode = $xmldoc.CreateElement("testsuites")
$xmldoc.appendchild($rootNode)

$dec = $xmldoc.CreateXmlDeclaration("1.0", $null, $null)
$xmldoc.InsertBefore($dec, $rootNode)

$files = Get-ChildItem $Path -Filter "*.xml"
foreach ($file in $files) {
    try {
        $testSuites = Select-Xml -Path $file.FullName -XPath "/testsuites/testsuite"
        foreach ($testSuite in $testSuites) {
            $importedNode = $xmldoc.ImportNode($testSuite.Node, $true)
            $rootNode.AppendChild($importedNode)
        }
    } catch {
        Write-Host "Error parsing file: $file"
    }
}
$xmldoc.Save($Output)
